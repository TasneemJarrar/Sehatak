using Microsoft.AspNetCore.Http;

namespace Sehatak.Application.DTOs.RecordPaymentRequestDto
{
   public class PaymentRequestExist
    {
        public int? centerId {  get; set; }
        public int? SubscriptionId {  get; set; }
        public string PaymentMethod { get; set; } = string.Empty;
        public string? ReferenceNumber { get; set; }
        public IFormFile? ReceiptImage { get; set; }
        public string? Notes { get; set; }
    }
}
