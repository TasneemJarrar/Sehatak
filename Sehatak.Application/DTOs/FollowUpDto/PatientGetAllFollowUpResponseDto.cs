using Sehatak.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sehatak.Application.DTOs.FollowUpDto
{
    public class PatientGetAllFollowUpResponseDto
    {
        public int Id { get; set; }
        public int OriginalAppointmentId { get; set; }
        public int DoctorId { get; set; }
        public string DoctorName { get; set; }
        public DateOnly? AllowFollowUpDate { get; set; }
        public FollowUpStatus Status { get; set; }  
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public DateTime UpdatedAt { get; set; }
        public int? ScheduledAppointmentId { get; set; }

    }
}
