

namespace Sehatak.Application.DTOs.GetStaffDto
{
    public class GetDoctorResponseDto
    {
        public int DepartmentId { get; set; }
        public string DepartmentName { get; set; } = string.Empty;
        public string? DepartmentDescription { get; set; }
        public string? DepartmentImageUrl { get; set; }
        public List<DoctorSummaryDto> Doctors { get; set; } = new();


    }
}
