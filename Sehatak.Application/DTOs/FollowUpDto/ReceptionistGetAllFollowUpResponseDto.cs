

namespace Sehatak.Application.DTOs.FollowUpDto
{
    public class ReceptionistGetAllFollowUpResponseDto
    {
        public int DoctorId { get; set; }
        public string DoctorName { get; set; }
        public List<DoctorGetAllFollowUpResponse> FollowUps { get; set; } 
    }
}
