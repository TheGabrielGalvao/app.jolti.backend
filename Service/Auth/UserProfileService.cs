using AutoMapper;
using Domain.DTO.Auth;
using Domain.Entity.Auth;
using Domain.Interface.Repository.Auth;
using Domain.Interface.Service.Auth;
using Service.Common;

namespace Service.Auth
{
    public class UserProfileService : BaseService<UserProfileEntity, UserProfileRequest, UserProfileResponse>, IUserProfileService
    {
        public UserProfileService(IUserProfileRepository repository, IMapper mapper)
            : base(repository, mapper)
        {
            
        }
    }
}
