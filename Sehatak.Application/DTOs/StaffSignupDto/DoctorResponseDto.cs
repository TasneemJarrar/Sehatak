

namespace Sehatak.Application.DTOs.StaffSignup
{
    public class DoctorResponseDto
    {
        public int UserId { get; set; }
        public string Email { get; set; } = string.Empty;
        public string Message { get; set; } = "تم التسجيل، يرجى الانتباه لكلمة المرور وتغيريها في أقرب وقت.";
    }
}
