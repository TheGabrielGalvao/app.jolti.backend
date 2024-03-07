using Util.Enumerator;

namespace Domain.DTO.Auth
{
    public class UserProfileRequest
    {
        public Guid? Uuid { get; set; }
        public string Name { get; set; }
        public string? Description { get; set; }
        public EGenericStatus Status { get; set; }
    }
}
