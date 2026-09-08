
namespace Sehatak.Application.DTOs.AppointmentDto
{
    public class AvailableDoctorSlot
    {
        public int doctorId {  get; set; }
        public string doctorName { get; set; }
        public List<TimeOnly> dateAvailable { get; set; }
        public DayOfWeek DayOfWeek { get; set; }
        public DateOnly date {  get; set; }
        
    }
}
