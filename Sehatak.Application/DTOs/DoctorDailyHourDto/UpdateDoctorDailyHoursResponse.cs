

namespace Sehatak.Application.DTOs.AddDoctorDailyHour
{
    public class UpdateDoctorDailyHoursResponse
    {
        public int DoctorId { get; set; }
        public DayOfWeek DayOfWeek { get; set; }

        public TimeOnly StartTime { get; set; }

        public TimeOnly EndTime { get; set; }
        public int SlotDurationMinutes { get; set; }
    }
}
