using Sehatak.Domain.Enums;
using Sehatak.Domain.Enums.PaymentEnums;
namespace Sehatak.Application.DTOs.ConsultationDto
{
    public class ConsultationResponse
    {
        public int Id { get; set; }
        public ConsultationStatus Status {  get; set; }
        public PaymentStatus? PaymentStatus { get; set; }
        public int patientId { get; set; }
        public string? VideoLink { get; set; }
        public DateTime? ScheduledAt { get; set; }
    }
}
