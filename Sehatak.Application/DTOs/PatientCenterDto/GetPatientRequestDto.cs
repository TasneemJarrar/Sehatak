using Sehatak.Domain.Enums;
namespace Sehatak.Application.DTOs.PatientCenter
{
    public class GetPatientRequestDto
    {
        public int patientId { get; set; }
        public AppointmentStatus status { get; set; }
    }
}
