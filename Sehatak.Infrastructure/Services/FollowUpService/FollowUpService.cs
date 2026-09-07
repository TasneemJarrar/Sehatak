using Microsoft.EntityFrameworkCore;
using Sehatak.Application.Common;
using Sehatak.Application.DTOs.Exceptions;
using Sehatak.Application.DTOs.FollowUpDto;
using Sehatak.Application.Interfaces.ApointmentInterface;
using Sehatak.Application.Interfaces.IFollowUp;
using Sehatak.Domain.Entities.TenantEntities;
using Sehatak.Domain.Enums;
using Sehatak.Domain.Enums.SharedEnums;
using Sehatak.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sehatak.Infrastructure.Services.FollowUpService
{
    public class FollowUpService : IFollowUp
    {
        private readonly SharedDbContext sharedDbContext;
        private readonly TenantDbContextFactory contextFactory;
        public FollowUpService(SharedDbContext sharedDbContext, TenantDbContextFactory contextFactory)
        {
            this.sharedDbContext = sharedDbContext;
            this.contextFactory = contextFactory;
        }
        public async Task<FollowUpResponseDto> DoctorAddFollowUpAsync(int centerId , int userId ,DoctorAddFollowUpRequestDto request)
        {
            var center = await sharedDbContext.MedicalCenters
                .FirstOrDefaultAsync(c => c.Id == centerId
                                     && c.CenterStatus == CenterStatus.Active);

            if (center == null)
                throw new BusinessException("Center.NoFound");

            using var db = contextFactory.CreateForCenter(centerId);

            var doctor = await db.Doctors
                .Include(u=>u.user)
                .FirstOrDefaultAsync(d=>d.userId == userId
                                     && d.user.isActive);

            if(doctor == null)
                throw new BusinessException("Doctor.NoFound");

            var appointment = await db.Appointments
                .Include(a => a.Patient)
                .Include(a => a.Doctor)
                .FirstOrDefaultAsync(a => a.Id == request.OriginalAppointmentId
                                     && a.doctorId == doctor.Id
                                     && a.appointmentStatus == AppointmentStatus.Confirmed
                                     && a.patientId == request.PatientId);

            if(appointment == null)
                throw new BusinessException("Appointment.NoFound");

            var followUp = new FollowUp
            {
                OriginalAppointmentId = request.OriginalAppointmentId,
                PatientId = request.PatientId,
                DoctorId = doctor.Id,
                AllowFollowUpDate = request.AllowFollowUpDate,
                Status = FollowUpStatus.Pending,
                CreatedAt = DateTime.UtcNow,
            };
            await db.FollowUps.AddAsync(followUp);

            await db.Notifications.AddAsync(new Notification
            {
                UserId = appointment.Patient.NotifiableUserId,
                Message = $"تم تحديد موعد للمتابعة" +
                $"{request.AllowFollowUpDate} .",
                CreatedAt = DateTime.UtcNow,
            });

            await db.SaveChangesAsync();
            return new FollowUpResponseDto
            {
                Id = followUp.Id,
                OriginalAppointmentId = followUp.OriginalAppointmentId,
                PatientId = followUp.PatientId,
                PatientName = appointment.Patient.userId != null
                ? appointment.Patient.user.firstName + " " + appointment.Patient.user.lastName
                : appointment.Patient.FirstName + " " + appointment.Patient.LastName,
                DoctorId = followUp.DoctorId,
                AllowFollowUpDate = followUp.AllowFollowUpDate,
                Status = followUp.Status.ToString(),
                CreatedAt = followUp.CreatedAt,
            };

        }

        public async Task<PagedResult<DoctorGetAllFollowUpResponse>> DoctorGetAllFollowUpAsync(int centerId, int userId, PagedRequest request)
        {
            var center = await sharedDbContext.MedicalCenters
                .FirstOrDefaultAsync(c => c.Id == centerId
                                     && c.CenterStatus == CenterStatus.Active);

            if (center == null)
                throw new BusinessException("Center.NoFound");

            using var db = contextFactory.CreateForCenter(centerId);

            var doctor = await db.Doctors
                .Include(u => u.user)
                .FirstOrDefaultAsync(d => d.userId == userId
                                     && d.user.isActive);

            if (doctor == null)
                throw new BusinessException("Doctor.NoFound");

            var query=  db.FollowUps
                .Where(f=>f.DoctorId == doctor.Id)
                .OrderByDescending(f=>f.CreatedAt)
                .Select(f=> new DoctorGetAllFollowUpResponse
                {
                    FollowUpId = f.Id,
                    PatientId = f.PatientId,
                    PatientName = f.Patient.userId != null
                    ? f.Patient.user.firstName + " " + f.Patient.user.lastName
                    : f.Patient.FirstName + " " + f.Patient.LastName,
                    AllowFollowUpDate = f.AllowFollowUpDate,
                    followUpStatus = f.Status,
                    CreatedAt = f.CreatedAt,
                    UpdatedAt = f.UpdatedAt,
                });
            return await query.ToPagedResultAsync(request.PageNumber, request.PageSize);
        }

        public async Task<FollowUpResponseDto> DoctorUpdateFollowUpAsync(int centerId, int userId, DoctorUpdateFollowUpRequestDto request)
        {
            var center = await sharedDbContext.MedicalCenters
                .FirstOrDefaultAsync(c => c.Id == centerId
                                     && c.CenterStatus == CenterStatus.Active);

            if (center == null)
                throw new BusinessException("Center.NoFound");

            using var db = contextFactory.CreateForCenter(centerId);

            var doctor = await db.Doctors
                .Include(u => u.user)
                .FirstOrDefaultAsync(d => d.userId == userId
                                     && d.user.isActive);

            if (doctor == null)
                throw new BusinessException("Doctor.NoFound");

            var followUp = await db.FollowUps
                .FirstOrDefaultAsync(f => f.Id == request.FollowUpId
                                     && f.DoctorId == doctor.Id
                                     && f.PatientId == request.PatientId);

            if (followUp == null)
                throw new BusinessException("FollowUp.NoFound");

            followUp.AllowFollowUpDate = request.AllowFollowUpDate;
            followUp.UpdatedAt = DateTime.UtcNow;

            await db.Notifications.AddAsync(new Notification
            {
                UserId = followUp.Patient.NotifiableUserId,
                Message = $"تم نعديل موعد للمتابعة" +
                $"{request.AllowFollowUpDate} .",
                CreatedAt = DateTime.UtcNow,
            });

            await db.SaveChangesAsync();

            return new FollowUpResponseDto
            {
                Id = followUp.Id,
                OriginalAppointmentId = followUp.OriginalAppointmentId,
                PatientId = followUp.PatientId,
                PatientName = followUp.Patient.userId != null
                ? followUp.Patient.user.firstName + " " + followUp.Patient.user.lastName
                : followUp.Patient.FirstName + " " + followUp.Patient.LastName,
                DoctorId = followUp.DoctorId,
                AllowFollowUpDate = followUp.AllowFollowUpDate,
                Status = followUp.Status.ToString(),
                CreatedAt = followUp.CreatedAt,
                UpdatedAt = followUp.UpdatedAt,
            };
        }
    }
}
