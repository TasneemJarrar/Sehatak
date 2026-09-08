using Sehatak.Domain.Enums;
namespace Sehatak.Application.DTOs.PatientCenter
{
    public class GetPatientRequestDto
    {
        public int userId { get; set; }
        public AppointmentStatus status { get; set; }
    }
}
