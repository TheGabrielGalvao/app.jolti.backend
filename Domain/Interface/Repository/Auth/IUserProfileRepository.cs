using Domain.Entity.Auth;
using Domain.Interface.Repository.Common;

namespace Domain.Interface.Repository.Auth
{
    public interface IUserProfileRepository : IBaseRepository<UserProfileEntity>
    {
    }
}
