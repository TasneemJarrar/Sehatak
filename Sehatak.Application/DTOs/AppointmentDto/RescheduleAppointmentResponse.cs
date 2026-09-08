

namespace Sehatak.Application.DTOs.AppointmentDto
{
    public class RescheduleAppointmentResponse
    {
        public int appointmentId {  get; set; }
        public TimeOnly timeSlot {get; set; }
        public DateOnly date {  get; set; }
    }
}
