using Sehatak.Application.DTOs.StaffAttendance;

namespace Sehatak.Application.Interfaces.IStaffAttendance
{
    public interface IStaffAttendance
    {
        Task<string> CheckInTimeAsync(int centerId, int userId, StaffAttendanceCheckInRequestDto request);
        Task<string> CheckOutTimeAsync(int centerId, int userId, StaffAttendanceCheckInRequestDto request);
        Task<string> OnLeaveAsync(int centerId, int userId, StaffOnLeaveRequestDto request);
        Task<string> AbsentStaffAsync(int centerId, StaffAbsentRequestDto request);


    }
}
