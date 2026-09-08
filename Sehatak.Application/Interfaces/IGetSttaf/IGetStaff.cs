using Sehatak.Application.Common;
using Sehatak.Application.DTOs.GetStaffDto;

namespace Sehatak.Application.Interfaces.GetSttafInterFace
{
    public interface IGetStaff
    {
        Task<PagedResult<GetDoctorsResponseDto>> GetDoctorsAsync(int centerId, PagedRequest request);
        Task<DoctorSummaryDto> GetDoctorAsync(int centerId, int doctorId,int? year = null, int? month = null);
        
        
    }
}
