using Sehatak.Domain.Entities.TenantEntities;

namespace Sehatak.Domain.Entities.General
{
    public class AuditLog
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string Action { get; set; } = string.Empty;     // "DeleteAppointment", "UpdatePrice"
        public string EntityType { get; set; } = string.Empty; // "Appointment", "ServicePrice"
        public int? EntityId { get; set; }
        public string? OldValue { get; set; }   // JSON snapshot قبل التعديل
        public string? NewValue { get; set; }   // JSON snapshot بعد التعديل
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        // Navigation property
        public User User { get; set; } = null!;
    }
}
