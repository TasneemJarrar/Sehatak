using Sehatak.Application.DTOs.FinancialReport;

namespace Sehatak.Application.Interfaces.IFinancialReports
{
    public interface IFinancialReportAdmin
    {
        Task<byte[]> GenerateReportAsync(int centerId , int userId , FinancialReportRequestDto request);
    }
}
