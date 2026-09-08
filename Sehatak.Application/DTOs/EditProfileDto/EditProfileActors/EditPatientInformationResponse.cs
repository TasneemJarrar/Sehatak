

namespace Sehatak.Application.DTOs.EditProfile.EditProfileActors
{
    public class EditPatientInformationResponse
    {
        public int PatientId { get; set; }
        public string FullName { get; set; } = string.Empty;
        public string? ProfileImageUrl { get; set; }
        public string Address { get; set; } = string.Empty;
        public string City { get; set; } = string.Empty;
        public string? PhoneNumber { get; set; }
        public string Message { get; set; } = "تم تحديث البيانات بنجاح";
    }
}
