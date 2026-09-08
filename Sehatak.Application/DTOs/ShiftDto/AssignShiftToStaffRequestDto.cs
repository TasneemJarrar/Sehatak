
using Sehatak.Domain.Enums;

namespace Sehatak.Application.DTOs.ShiftDto
{
    public class AssignShiftToStaffRequestDto
    {
        public int UserId { get; set; }
        public ShiftGroup ShiftName { get; set; }
        public DateOnly ShiftDate { get; set; }
    }
}
