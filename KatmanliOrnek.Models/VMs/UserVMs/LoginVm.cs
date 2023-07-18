using KatmanliOrnek.Core.Enums;

namespace KatmanliOrnek.Models.VMs.UserVMs
{
    public class LoginVm
    {
        public string UserName { get; set; }

        public string Password { get; set; }

        public Role Role { get; set; }
    }
}
