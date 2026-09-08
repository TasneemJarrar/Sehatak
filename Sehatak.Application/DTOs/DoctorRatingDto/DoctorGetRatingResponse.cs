

namespace Sehatak.Application.DTOs.DoctorRatingDto
{
    public class DoctorGetRatingResponse
    {
        public double AvrageRating { get; set; } = 0;
        public List<PatientSummaryRating> PatientRatings { get; set; }
    }
}
