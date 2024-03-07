using Domain.Entity.Common;
using System.ComponentModel.DataAnnotations.Schema;
using Util.CustomAttributes;
using Util.Enumerator;

namespace Domain.Entity.Auth
{
    [TableInfo("UserGroup", "auth")]
    public class UserGroupEntity : DefaultEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public EGenericStatus Status { get; set; }

        public Int64 UserProfileId { get; set; }

        
    }
}
