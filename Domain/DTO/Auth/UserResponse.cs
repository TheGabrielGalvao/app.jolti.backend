using Util.Enumerator;

namespace Domain.DTO.Auth
{
    public class UserResponse
    {
        public Guid Uuid { get; set; }
        public string UserName { get; set; }
        public string? UserPass { get; set; }
        public string? UserEmail { get; set;}
        public Guid UserProfileUuid { get; set; }
        public EGenericStatus Status { get; set; }
    }
}
