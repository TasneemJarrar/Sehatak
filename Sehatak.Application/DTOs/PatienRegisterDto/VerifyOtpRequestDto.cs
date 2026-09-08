

namespace Sehatak.Application.DTOs.PatienRegisterDto
{
    public class VerifyOtpRequestDto
    {

        public int UserId { get; set; }
        public string code { get; set; } = string.Empty;
    }
}
