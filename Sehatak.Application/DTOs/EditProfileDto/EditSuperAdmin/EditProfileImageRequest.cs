using Microsoft.AspNetCore.Http;
namespace Sehatak.Application.DTOs.EditProfile.EditSuperAdmin
{
    public class EditProfileImageRequest
    {
        public IFormFile ImageFile { get; set; }
    }
}
