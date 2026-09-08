

namespace Sehatak.Application.DTOs.FollowUpDto
{
    public class ReceptionistAddFollowUpRequestDto
    {
        public int OriginalAppointmentId { get; set; }
        public int PatientId { get; set; }
        public int DoctorId { get; set; }
        public DateOnly? AllowFollowUpDate { get; set; }
    }
}
