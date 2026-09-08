

namespace Sehatak.Application.DTOs.DashBoardDto
{
    public class AppointmentsSummaryDto
    {
        public DateOnly Date { get; set; }
        public int Total { get; set; }
        public int Confirmed { get; set; }
        public int Completed { get; set; }
        public int Cancelled { get; set; }
        public int NoShow { get; set; }
        public int WaitlistCount { get; set; }
    }
}
