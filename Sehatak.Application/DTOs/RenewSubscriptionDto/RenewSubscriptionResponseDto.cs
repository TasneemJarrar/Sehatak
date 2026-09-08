using Sehatak.Domain.Enums.SharedEnums;


namespace Sehatak.Application.DTOs.RenewSubscription
{
    public class RenewSubscriptionResponseDto
    {
        public int SubscriptionId {  get; set; }
        public int CenterId { get; set; }
        public string PlanName { get; set; }
        public decimal Amount {  get; set; }
        public DateOnly StartDate { get; set; } 
        public DateOnly EndDate {  get; set; }
        public SubscriptionStatus Status {  get; set; }
        public string Message { get; set; }
    }
}
