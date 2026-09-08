

namespace Sehatak.Application.DTOs.ShiftDto
{
    public class GetStaffsShitfResponseDto
    {
        public int userId { get; set; }
        public string role { get; set; }
        public string email { get; set; }
        public string? phoneNumber { get; set; }
        public string name { get; set; }
        public bool userIsActive {  get; set; }
        public List<DailyAttendanceDto> Days { get; set; } = new();

    }
}
