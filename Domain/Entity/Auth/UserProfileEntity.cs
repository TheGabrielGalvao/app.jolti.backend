using Domain.Entity.Common;
using Util.CustomAttributes;
using Util.Enumerator;

namespace Domain.Entity.Auth
{
    [TableInfo("UserProfile", "auth")]
    public class UserProfileEntity : DefaultEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public EGenericStatus Status { get; set; }
        public int? DefaultData { get; set; } = 0;
    }
}
