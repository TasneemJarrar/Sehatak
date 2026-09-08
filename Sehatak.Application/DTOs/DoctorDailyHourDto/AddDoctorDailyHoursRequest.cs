

namespace Sehatak.Application.DTOs.AddDoctorDailyHour
{
    public class AddDoctorDailyHoursRequest
    {
        public DayOfWeek DayOfWeek { get; set; }

        public TimeOnly StartTime { get; set; }

        public TimeOnly EndTime { get; set; }
        public int SlotDurationMinutes { get; set; }
    }
}
