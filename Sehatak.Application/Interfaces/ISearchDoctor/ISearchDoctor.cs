using Sehatak.Application.Common;
using Sehatak.Application.DTOs.GetStaffDto;
using Sehatak.Application.DTOs.SearchDoctorDto;

namespace Sehatak.Application.Interfaces.SearchDoctor
{
    public interface ISearchDoctor
    {
        Task<PagedResult<DoctorSummaryDto>> SearchDoctorAsync(int centerId, SearchDoctorRequest request);
    }
}
