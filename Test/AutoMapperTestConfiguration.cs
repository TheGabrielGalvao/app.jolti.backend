using AutoMapper;
using Domain.DTO.Auth;
using Domain.Entity.Auth;
using Mapper;

namespace Test
{
    public class AutoMapperTestConfiguration
    {
        public static IMapper Configure()
        {
            var mapperConfiguration = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<UserEntity, UserResponse>();
                cfg.CreateMap<UserRequest, UserEntity>();
            });

            return mapperConfiguration.CreateMapper();
        }
    }
}
