using KatmanliOrnek.Core.BaseEntities;
using KatmanliOrnek.Core.Enums;

namespace KatmanliOrnek.Entities
{
    public class User : BaseEntity
    {
        public string UserName { get; set; }

        public string Password { get; set; }

        public Role Role { get; set; }
    }
}
