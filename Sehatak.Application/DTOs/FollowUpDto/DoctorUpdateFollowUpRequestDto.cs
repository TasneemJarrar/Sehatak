using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sehatak.Application.DTOs.FollowUpDto
{
    public class DoctorUpdateFollowUpRequestDto
    {
        public int FollowUpId { get; set; }
        public int PatientId { get; set; }
        public DateOnly? AllowFollowUpDate { get; set; }
    }
}
