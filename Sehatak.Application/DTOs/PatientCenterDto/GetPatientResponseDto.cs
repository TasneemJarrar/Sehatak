

namespace Sehatak.Application.DTOs.PatientCenter
{
    public class GetPatientResponseDto
    {
        public int Id { get; set; }
        public string pateintName { get; set; }
        public List<PatientSummaryDto> appointments { get; set; } 
    }
}
