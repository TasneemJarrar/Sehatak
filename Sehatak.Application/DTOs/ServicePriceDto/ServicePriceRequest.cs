using Sehatak.Domain.Enums;


namespace Sehatak.Application.DTOs.ServicePriceDto
{
    public class ServicePriceRequest
    {
        public ServiceType Type { get; set; }
        public List<ServicePriceItemDto> Items { get; set; } = new();
    }
}
