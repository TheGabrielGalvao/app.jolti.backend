using Domain.DTO.Settings;
using Domain.Interface.Repository.Auth;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using Repository.Auth;

namespace Mapper
{
    public static class RepositoryMapper
    {
        public static void Map(IServiceCollection services, IConfiguration configuration, IOptions<JwtSettingsDTO> jwtSettings)
        {
            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<IUserProfileRepository, UserProfileRepository>();
            services.AddScoped<IAuthRepository>(provider =>
            {
                return new AuthRepository(configuration, jwtSettings);
            });
           
        }
    }
}
