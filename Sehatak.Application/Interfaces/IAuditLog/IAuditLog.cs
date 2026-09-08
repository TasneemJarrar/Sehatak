

namespace Sehatak.Application.Interfaces.AuditLog
{
    public interface IAuditLog
    {
        Task LogAsync(string action, string entityType, int? entityId, object? oldValue = null, object? newValue = null);
    }
}
