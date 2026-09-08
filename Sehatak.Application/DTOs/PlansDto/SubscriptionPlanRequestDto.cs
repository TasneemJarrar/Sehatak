
using System.ComponentModel.DataAnnotations;

namespace Sehatak.Application.DTOs.Plans
{
    public class SubscriptionPlanRequestDto
    {
        [Required]
        public string Name { get; set; } = string.Empty;
        [Required]
        public decimal Price { get; set; }
        [Required]
        public int DurationDays { get; set; }

        
    }
}
