using Domain.DTO;
using Domain.Entity.Auth;

namespace Domain.Interface.Repository.Auth
{
    public interface IAuthRepository
    {
        public Task<string> GenerateToken(UserEntity customer);
    }
}
