using Sehatak.Application.Common;
using Sehatak.Application.DTOs.FollowUpDto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sehatak.Application.Interfaces.IFollowUp
{
    public interface IFollowUp
    {
        Task<FollowUpResponseDto> DoctorAddFollowUpAsync(int centerId , int userId ,DoctorAddFollowUpRequestDto request);
        Task<FollowUpResponseDto> DoctorUpdateFollowUpAsync(int centerId , int userId , DoctorUpdateFollowUpRequestDto request);
        Task<PagedResult<DoctorGetAllFollowUpResponse>> DoctorGetAllFollowUpAsync(int centerId , int userId,PagedRequest request);
    }
}
