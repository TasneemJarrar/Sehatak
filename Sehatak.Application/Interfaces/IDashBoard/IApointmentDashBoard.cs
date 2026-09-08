using Sehatak.Application.DTOs.DashBoardDto;

namespace Sehatak.Application.Interfaces.IDashBoard
{
    public interface IApointmentDashBoard
    {
        Task<AppointmentsSummaryDto> GetCenterAppointmentsSummaryAsync(int centerId, DateOnly? date = null);
    }
}
