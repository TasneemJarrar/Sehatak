using Sehatak.Domain.Enums;

namespace Sehatak.Domain.Entities.TenantEntities
{
    public class FollowUp
    {
        public int Id { get; set; }
        public int OriginalAppointmentId { get; set; }
        public int PatientId { get; set; }
        public int DoctorId { get; set; }
        public int? ReceptionistId { get; set; }
        public DateOnly? AllowFollowUpDate { get; set; }
        public FollowUpStatus Status { get; set; } = FollowUpStatus.Pending;
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public DateTime UpdatedAt { get; set; } 
        public int? ScheduledAppointmentId { get; set; }
        // Navigation Properties
        public Appointment OriginalAppointment { get; set; } = null!;
        public Appointment? ScheduledAppointment {  get; set; } = null!;
        public Patient Patient { get; set; } = null!;
        public Doctor Doctor { get; set; } = null!;
        public User? Receptionist { get; set; } = null!;
    }
}
