using Domain.DTO.Auth;
using Domain.Entity.Auth;
using Domain.Interface.Repository.Common;

namespace Domain.Interface.Repository.Auth
{
    public interface IUserRepository : IBaseRepository<UserEntity>
    {
        Task<UserEntity> GetUserAsync(AuthRequest request);

        Task<UserEntity> GetFullUserInfo(string username);
    }
}
