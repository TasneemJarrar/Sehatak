using Sehatak.Domain.Enums;

namespace Sehatak.Application.DTOs.FollowUpDto
{
    public class DoctorGetAllFollowUpResponse
    {
        public int FollowUpId { get; set; }
        public int PatientId { get; set; }
        public string PatientName { get; set; } = null!;
        public DateOnly? AllowFollowUpDate { get; set; }
        public FollowUpStatus followUpStatus { get; set; }
        public DateTime CreatedAt { get; set; } 
        public DateTime UpdatedAt { get; set; }
    }
}
