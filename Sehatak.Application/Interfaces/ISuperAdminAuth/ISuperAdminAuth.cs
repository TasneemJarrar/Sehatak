using Sehatak.Application.DTOs.SuperAdminDto;

namespace Sehatak.Application.Interfaces.SuperAdminInterface
{
    public interface ISuperAdminAuth
    {
        Task<RegisterSuperAdminResponseDto> RegisterAsync(RegisterSuperAdminRequestDto request);
        Task<SuperAdminLoginResponseDto?> LoginAsync(SuperAdminLoginRequestDto request);
    }
}
