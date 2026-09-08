using Sehatak.Domain.Enums;

namespace Sehatak.Application.DTOs.ShiftDto
{
    public class ShiftScheduleResponse
    {
        public int Id { get; set; }
        public ShiftGroup ShiftName { get; set; }
        public TimeOnly StartTime { get; set; }
        public TimeOnly EndTime { get; set; }
    }
}
