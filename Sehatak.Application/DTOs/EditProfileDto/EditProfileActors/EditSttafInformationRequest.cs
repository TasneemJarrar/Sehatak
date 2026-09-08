using Microsoft.AspNetCore.Http;

namespace Sehatak.Application.DTOs.EditProfile.EditProfileActors
{
    public class EditSttafInformationRequest
    {
        public string? firstNmae {  get; set; }
        public string? lastNmae { get; set; }
        public IFormFile? profileImage { get; set; }
        public bool RemoveProfileImage { get; set; } = false;
        public string? address { get; set; }
        public string? city {  get; set; }
        public string? phoneNumber { get; set; }
        public string? Specialization { get; set; }
        public string? Bio { get; set; }
        public bool? OnlineEnabled { get; set; }
    }
}
