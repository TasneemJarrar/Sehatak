

namespace Sehatak.Application.DTOs.PatienRegisterDto
{
    public class RegisterResponseDto
    {
        public int UserId { get; set; }
        public string Email { get; set; } = string.Empty;
        public string Message { get; set; } = "تم التسجيل، يرجى إدخال كود التحقق المرسل على إيميلك.";

    }
}
