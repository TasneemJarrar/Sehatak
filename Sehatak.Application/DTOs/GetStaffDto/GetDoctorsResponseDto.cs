using Sehatak.Application.Common;

namespace Sehatak.Application.DTOs.GetStaffDto
{
    public class GetDoctorsResponseDto : PagedRequest
    {
        public int DepartmentId { get; set; }
        public string DepartmentName { get; set; }
        public string? DepartmentDescription { get; set; }
        public string? DepartmentImageUrl { get; set; }
        public List<DoctorsSummaryDto> Doctors {  get; set; }
    }
}
