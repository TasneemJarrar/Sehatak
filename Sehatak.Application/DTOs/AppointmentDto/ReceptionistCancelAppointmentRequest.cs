
namespace Sehatak.Application.DTOs.AppointmentDto
{
    public class ReceptionistCancelAppointmentRequest
    {
        public int PatientId { get; set; }
        public TimeOnly timeSlot { get; set; }
        public DateOnly date { get; set; }
        public string Resone { get; set; }
        public int? SubPatientId { get; set; }

    }
}
