using Database;
using Domain.Entity.Auth;
using Domain.Interface.Repository.Auth;
using Repository.Common;

namespace Repository.Auth
{
    public class UserProfileRepository : BaseRepository<UserProfileEntity>, IUserProfileRepository
    {
        public UserProfileRepository(AppDbContext context) : base(context)
        {

        }
    }
}
