using AutoMapper;
using Domain.DTO.Auth;
using Domain.DTO.Common;
using Domain.Entity.Auth;

namespace Mapper
{
    public static class EntityMapper
    {
        public static IMapper Configure()
        {
            var mapperConfig = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<UserEntity, UserResponse>();
                cfg.CreateMap<UserRequest, UserEntity>();

                cfg.CreateMap<UserProfileEntity, UserProfileResponse>();
                cfg.CreateMap<UserProfileRequest, UserProfileEntity>();

                cfg.CreateMap<UserProfileResponse, OptionItemResponse>()
                .ForMember(x => x.Label, opt => opt.MapFrom(o => o.Name))
                .ForMember(x => x.Value, opt => opt.MapFrom(o => o.Uuid));

            });

            IMapper mapper = mapperConfig.CreateMapper();
            return mapper;
        }
    }
}
