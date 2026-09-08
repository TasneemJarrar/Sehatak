

namespace Sehatak.Application.DTOs.FollowUpDto
{
    public class UpdateFollowUpRequestDto
    {
        public int FollowUpId { get; set; }
        public int PatientId { get; set; }
        public DateOnly? AllowFollowUpDate { get; set; }
    }
}
