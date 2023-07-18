using KatmanliOrnek.Models.VMs.UserVMs;
using KatmanliOrnek.Shared;

namespace KatmanliOrnek.BLL.Abstract.IServices
{
    public interface IAdminService
    {
        ResultService<LoginVm> Login(string username, string password);
    }
}
