

namespace Sehatak.Application.DTOs.ShiftDto
{
    public class StaffDirectoryResponseDto
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string? PhoneNumber { get; set; } = string.Empty;
        public string role {  get; set; } 
        public bool isActive { get; set; }

    }
}
