using Microsoft.AspNetCore.Http;

namespace Sehatak.Application.DTOs.DepartmentDto
{
    public class DepartmentRequestDto
    {
        public string departmentName {  get; set; }
        public string? departmentDescription { get; set; }
        public IFormFile? logo {  get; set; }
    }
}
