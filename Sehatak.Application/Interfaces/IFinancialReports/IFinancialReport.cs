using Sehatak.Application.DTOs.FinancialReport;

namespace Sehatak.Application.Interfaces.IFinancialReports
{
    public interface IFinancialReport
    {
        Task<byte[]> GenerateReportAsync(FinancialReportRequestDto request);

    }
}
