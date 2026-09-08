

namespace Sehatak.Application.DTOs.AppointmentDto
{
    public class ReceptionistRescheduleAppointmentRequest
    {
        public int PatientId { get; set; }
        public int appointmentId { get; set; }
        public TimeOnly timeSlot { get; set; }
        public DateOnly date { get; set; }
        public int? SubPatientId { get; set; }
    }
}
