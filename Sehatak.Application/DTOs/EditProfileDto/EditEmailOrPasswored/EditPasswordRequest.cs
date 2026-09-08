

namespace Sehatak.Application.DTOs.EditProfile.EditEmailOrPasswored
{
    public class EditPasswordRequest
    {
        public string PasswordHash { get; set; }
        public string ConfirmPassword { get; set; }
    }
}
