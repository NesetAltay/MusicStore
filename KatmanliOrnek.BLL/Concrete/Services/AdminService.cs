using AutoMapper;
using KatmanliOrnek.BLL.Abstract.IServices;
using KatmanliOrnek.DAL.Abstract;
using KatmanliOrnek.Models.VMs.UserVMs;
using KatmanliOrnek.Shared;

namespace KatmanliOrnek.BLL.Concrete.Services
{
    public class AdminService : IAdminService
    {
        private readonly IUserRepo _userRepo;
        private readonly IMapper _mapper;

        public AdminService(IUserRepo userRepo, IMapper mapper)
        {
            _mapper = mapper;
            _userRepo = userRepo;
        }

        public ResultService<LoginVm> Login(string username, string password)
        {
            ResultService<LoginVm> result = new ResultService<LoginVm>();

            var admin = _userRepo.GetFirstOrDefault(filter: x => x.UserName.Equals(username) && x.Password.Equals(password));

            if (admin != null)
            {
                var logged = new LoginVm { UserName = username, Password = password, Role = admin.Role };
                result.Data = logged;
            }
            else
            {
                result.AddError(ErrorType.NotFound, "Kullanıcı Bulunamadı");
            }

            return result;
        }
    }
}
