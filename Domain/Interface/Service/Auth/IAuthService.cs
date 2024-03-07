using Domain.DTO.Auth;

namespace Domain.Interface.Service.Auth
{
    public interface IAuthService
    {
        Task<AuthResponse> ExecuteAuth(AuthRequest request);

        Task<bool> CheckToken(string token);
    }
}
