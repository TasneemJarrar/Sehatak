

namespace Sehatak.Application.DTOs.StaffAttendance
{
    public class StaffAttendanceCheckInRequestDto
    {
        public DateOnly AttendanceDate { get; set; }

        public DateTime CheckTime { get; set; }

    }
}
