

namespace Sehatak.Application.DTOs.ServicePriceDto
{
    public class UpdateServicePrice
    {
        public int ServicePriceId { get; set; }
        public string? ServiceName { get; set; } = string.Empty;
        public decimal? Price { get; set; }

    }
}
