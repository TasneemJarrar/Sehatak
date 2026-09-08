using Microsoft.AspNetCore.Http;

namespace Sehatak.Application.DTOs.DepartmentDto
{
    public class DepartmentUpdateRequestDto
    {
        public int departmentId { get; set; }
        public string? departmentName {  get; set; }
        public string? departmentdiscription { get; set; }
        public IFormFile? logo {  get; set; }

    }
}
