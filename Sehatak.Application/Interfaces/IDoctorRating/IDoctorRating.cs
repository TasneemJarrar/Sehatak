using Sehatak.Application.Common;
using Sehatak.Application.DTOs.DoctorRatingDto;


namespace Sehatak.Application.Interfaces.IDoctorRating
{
    public interface IDoctorRating
    {
        Task<DoctorRatingResponse> AddDoctorRatingAsync(int centerId, int userId, AddDoctorRatingRequest request,int? subPatientId);
        Task<DoctorRatingResponse> UpdateDoctorRatingAsync(int centerId, int userId, UpdateDoctorRatingRequest request,int? subPatientId);
        Task<string> RemoveDoctorRatingAsync(int centerId, int userId , int ratingId, int? subPatientId);
        Task<PagedResult<GetMyRatingsResponse>> PatientGetRatingsAsync(int centerId , int userId, PagedRequest request,int? subPatientId);
        Task<DoctorGetRatingResponse> DoctorGetRatingsAsync(int centerId, int userId);
    }
}
