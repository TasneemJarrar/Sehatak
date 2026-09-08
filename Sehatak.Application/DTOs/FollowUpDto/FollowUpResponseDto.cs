using Sehatak.Domain.Enums;

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
        public FollowUpStatus Status { get; set; } 
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public DateTime UpdatedAt { get; set; } 
        public int? ScheduledAppointmentId { get; set; }
        
    }
}
