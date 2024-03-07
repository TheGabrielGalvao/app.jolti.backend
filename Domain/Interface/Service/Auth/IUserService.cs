using Domain.DTO.Auth;
using Domain.Entity.Auth;
using Domain.Interface.Service.Common;

namespace Domain.Interface.Service.Auth
{
    public interface IUserService : IBaseService<UserEntity, UserRequest, UserResponse>
    {
        Task<UserResponse> GetFullUserInfo(string username);
    }
}
