using AutoMapper;
using Domain.DTO.Auth;
using Domain.Entity.Auth;
using Domain.Interface.Repository.Auth;
using Domain.Interface.Service.Auth;
using Service.Common;
using Util.Helpers;

namespace Service.Auth
{
    public class UserService : BaseService<UserEntity, UserRequest, UserResponse>, IUserService
    {
        private readonly IUserRepository _repository;
        private readonly IUserProfileRepository _profileRepository;
        private readonly IMapper _mapper;
        public UserService(IUserRepository repository, IUserProfileRepository profileRepository, IMapper mapper)
            : base(repository, mapper)
        {
            _repository = repository;
            _profileRepository = profileRepository;
            _mapper = mapper;
        }

        public override async Task<UserResponse> AddAsync(UserRequest request)
        {
            var user = request;
            var profile = await _profileRepository.GetByUuidAsync(user.UserProfileUuid);
            user.UserPass = EncryptionHelper.HashPassword(user.UserPass);

            var userEntity = new UserEntity
            {
                UserName = user.UserName,
                UserPass = user.UserPass,
                UserEmail = user.UserEmail,
                UserProfileId = profile.Id,
                Status = request.Status
            };

            var addedUser = await _repository.AddAsync(userEntity);

            var response = _mapper.Map<UserResponse>(addedUser);
            response.UserProfileUuid = profile.Uuid;

            return response;
        }

        public async Task<UserProfileResponse> GetProfileById(Int64 id)
        {
            var profile = await _profileRepository.GetByIdAsync(id);

            var response = _mapper.Map<UserProfileResponse>(profile);

            return response;
        }

        public override async Task<IEnumerable<UserResponse>> GetAllAsync()
        {
            var users = _repository.GetAllAsync();
            var response = users.Result.Select(x => new UserResponse
            {
                Uuid = x.Uuid,
                UserEmail = x.UserEmail,
                UserName = x.UserName,
                UserPass = x.UserPass,
                Status = x.Status!.Value,
                UserProfileUuid = GetProfileById(x.UserProfileId).Result.Uuid
            }).ToList<UserResponse>(); 

            return response;
        }

        public async Task<UserResponse> GetFullUserInfo(string username)
        {
            var userInfo = await _repository.GetFullUserInfo(username);
            var teste = _mapper.Map<UserResponse>(userInfo);
            return _mapper.Map<UserResponse>(userInfo);
        }

    }
}
