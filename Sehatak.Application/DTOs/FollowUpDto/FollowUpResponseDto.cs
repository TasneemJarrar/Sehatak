using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sehatak.Application.DTOs.FollowUpDto
{
    public class FollowUpResponseDto
    {
        public int Id { get; set; }
        public int OriginalAppointmentId { get; set; }
        public int PatientId { get; set; }
        public string PatientName { get; set; } = null!;
        public int DoctorId { get; set; }
        public string DoctorName { get; set; } 
        public int? ReceptionistId { get; set; }
        public DateOnly? AllowFollowUpDate { get; set; }
        public string Status { get; set; } = null!;
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public DateTime UpdatedAt { get; set; } 
        public int? ScheduledAppointmentId { get; set; }
        
    }
}
