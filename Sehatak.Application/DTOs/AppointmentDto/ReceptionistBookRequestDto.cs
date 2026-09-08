using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sehatak.Application.DTOs.AppointmentDto
{
    public class ReceptionistBookRequestDto
    {
        public int PatientId { get; set; }
        public TimeOnly timeSlot { get; set; }
        public DateOnly dateOnly { get; set; }
        public int? SubPatientId { get; set; }
        public int? FollowUpId { get; set; }
    }
}
