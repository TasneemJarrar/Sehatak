

using Sehatak.Domain.Enums;

namespace Sehatak.Application.DTOs.AppointmentDto
{
    public class GetPatientWaitList
    {
        public int WaitLisId {  get; set; }
        public int PatientId { get; set; }
        public string PatientName { get; set; }
        public string Email {  get; set; }
        public string? PhoneNumber { get; set; }
        public WaitlistStatus status { get; set; }
        public DateOnly date { get; set; }
    }
}
