using Sehatak.Domain.Enums;

namespace Sehatak.Domain.Entities.TenantEntities
{
    public class StaffAttendance
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int StaffShiftId { get; set; }

        public DateOnly AttendanceDate { get; set; }

        public DateTime? CheckInTime { get; set; }

        public DateTime? CheckOutTime { get; set; }

        public AttendanceStatus attendanceStatus { get; set; } = AttendanceStatus.Absent;

        // Navigation Properties :
        public User Staff { get; set; } = null!;
        public StaffShift Shift { get; set; } = null!;
    }
}
