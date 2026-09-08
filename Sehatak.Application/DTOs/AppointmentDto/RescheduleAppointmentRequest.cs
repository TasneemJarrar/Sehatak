

namespace Sehatak.Application.DTOs.AppointmentDto
{
    public class RescheduleAppointmentRequest
    {
        public int appointmentId {  get; set; }
        public TimeOnly timeSlot { get; set; }
        public DateOnly date {  get; set; }
        public int? SubPatientId { get; set; }
    }
}
