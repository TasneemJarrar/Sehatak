

namespace Sehatak.Application.DTOs.AddDoctorDailyHourDto
{
    public class GetDoctorDailyHoursResponse
    {
        public int Id { get; set; }

        public int DoctorId { get; set; }

        public DayOfWeek DayOfWeek { get; set; }

        public TimeOnly StartTime { get; set; }

        public TimeOnly EndTime { get; set; }
        public bool IsActive { get; set; } = true;
        public int? SlotDurationMinutes { get; set; }
    }
}
