using Sehatak.Application.DTOs.Email;

namespace Sehatak.Application.Interfaces.IEmail
{
    public interface IAdminBulkEmailService
    {
        Task<int> SendAsync(SendEmailDto request);
    }
}
