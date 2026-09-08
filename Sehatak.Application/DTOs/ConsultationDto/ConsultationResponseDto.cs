

namespace Sehatak.Application.DTOs.ConsultationDto
{
    public class ConsultationResponseDto
    {
        public int patientId { get; set; }
        public string? VideoLink { get; set; }
        public int ConsultationId { get; set; }
        public string patientName { get; set; }
        public DateTime? SchedualeDate { get; set; }


    }
}