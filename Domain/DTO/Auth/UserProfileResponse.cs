using Util.Enumerator;

namespace Domain.DTO.Auth
{
    public class UserProfileResponse
    {
        public Guid Uuid { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public EGenericStatus Status { get; set; }
        public bool? DefaultData { get; set; }
    }
}
