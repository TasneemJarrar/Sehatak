
using System.ComponentModel.DataAnnotations;

namespace Sehatak.Application.DTOs.DoctorRatingDto
{
    public class UpdateDoctorRatingRequest
    {
        public int RatingId { get; set; }

        [Range(1, 5)]
        public int? Rating { get; set; }

        [MaxLength(1000)]
        public string? Review { get; set; }
    }
}
