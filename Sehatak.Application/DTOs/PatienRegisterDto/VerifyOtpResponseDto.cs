

namespace Sehatak.Application.DTOs.PatienRegisterDto
{
    public class VerifyOtpResponseDto
    {
        public string AccessToken { get; set; } = string.Empty;
        public string RefreshToken { get; set; } = string.Empty;
    }
}
