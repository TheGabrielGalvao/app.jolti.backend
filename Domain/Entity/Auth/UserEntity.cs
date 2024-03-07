using Domain.Entity.Common;
using Util.CustomAttributes;
using Util.Enumerator;

namespace Domain.Entity.Auth
{
    [TableInfo("Users", "auth")]
    public class UserEntity : DefaultEntity
    {
        public string UserName { get; set; }
        public string UserPass { get; set; }
        public string UserEmail { get; set; }

        public EGenericStatus? Status { get; set; } = EGenericStatus.ACTIVE;

        public Int64 UserProfileId { get; set; }
    }
}
