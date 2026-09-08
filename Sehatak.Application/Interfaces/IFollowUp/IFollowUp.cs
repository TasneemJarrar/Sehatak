using Sehatak.Application.Common;
using Sehatak.Application.DTOs.FollowUpDto;

namespace Sehatak.Application.Interfaces.IFollowUp
{
    public interface IFollowUp
    {
        Task<FollowUpResponseDto> DoctorAddFollowUpAsync(int centerId , int userId ,DoctorAddFollowUpRequestDto request);
        Task<FollowUpResponseDto> DoctorUpdateFollowUpAsync(int centerId , int userId , UpdateFollowUpRequestDto request);
        Task<PagedResult<DoctorGetAllFollowUpResponse>> DoctorGetAllFollowUpAsync(int centerId , int userId,PagedRequest request);
        Task<FollowUpResponseDto> ReceptionistAddFollowUpAsync(int centerId , int userId , ReceptionistAddFollowUpRequestDto request);
        Task<FollowUpResponseDto> ReceptionistUpdateFollowUpAsync(int centerId , int userId , UpdateFollowUpRequestDto request);
        Task<PagedResult<ReceptionistGetAllFollowUpResponseDto>> ReceptionistGetAllFollowUpAsync(int centerId , int userId,PagedRequest request);
        Task<PagedResult<PatientGetAllFollowUpResponseDto>> PatientGetAllFollowUpAsync(int centerId , int userId,PagedRequest request,int? subPatientId);
    }
}
