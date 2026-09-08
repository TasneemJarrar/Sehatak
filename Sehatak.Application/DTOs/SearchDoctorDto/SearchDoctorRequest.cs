using Sehatak.Application.Common;


namespace Sehatak.Application.DTOs.SearchDoctorDto
{
    public class SearchDoctorRequest : PagedRequest
    {
        public string? doctorName { get; set; }
        public int? departmentId { get; set; }
        public string? Specialization {  get; set; }
    }
}
