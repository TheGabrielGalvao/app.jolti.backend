using Domain.Interface.Service.Auth;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Service.Auth;

namespace Mapper
{
    public static class ServiceMapper
    {
        public static void Map(IServiceCollection services, IConfiguration configuration)
        {
            services.AddTransient<IUserService, UserService>();
            services.AddTransient<IUserProfileService, UserProfileService>();
            services.AddTransient<IAuthService, AuthService>();
        }
    }
}
