
using System.ComponentModel.DataAnnotations;

namespace Sehatak.Application.DTOs.DoctorRatingDto
{
    public class AddDoctorRatingRequest
    {
        [Required]
        public int AppointmentId { get; set; }

        [Range(1, 5)]
        public int Rating { get; set; }

        [MaxLength(1000)]
        public string? Review { get; set; }
    }
}
