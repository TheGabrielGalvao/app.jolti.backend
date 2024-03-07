using Azure.Core;
using Dapper;
using Database;
using Domain.DTO.Auth;
using Domain.Entity.Auth;
using Domain.Interface.Repository.Auth;
using Repository.Common;

namespace Repository.Auth
{
    public class UserRepository : BaseRepository<UserEntity>, IUserRepository
    {
        public UserRepository(AppDbContext context) : base(context)
        {

        }

        public async Task<UserEntity> GetFullUserInfo(string username)
        {
            try
            {
                using var connection = _context.CreateConnection();
                var response = await connection.QuerySingleOrDefaultAsync<UserEntity>($"SELECT * FROM auth.Users WHERE UserName = @UserName", new { UserName = username });
                return response;
            }
            catch (Exception ex) { return null; }
        }

        public override async Task<IEnumerable<UserEntity>> GetAllAsync()
        {
            try
            {
                using var connection = _context.CreateConnection();
                var response = await connection.QueryAsync<UserEntity>($"SELECT * FROM auth.Users");
                return response;
            }
            catch (Exception ex) { return null; }
        }

        public async Task<UserEntity> GetUserAsync(AuthRequest request)
        {
            try
            {
                using var connection = _context.CreateConnection();
                var response = await connection.QuerySingleOrDefaultAsync<UserEntity>($"SELECT * FROM auth.Users WHERE UserName = @UserName", new { UserName = request.Username });
                return response;
            }
            catch (Exception ex) { return null; }
        }
    }
}
