using KatmanliOrnek.DAL.Abstract;
using KatmanliOrnek.DAL.Base.EntityFramework;
using KatmanliOrnek.DAL.Concrete.Context;
using KatmanliOrnek.Entities;

namespace KatmanliOrnek.DAL.Concrete.Repositories
{
    public class UserRepo : BaseRepository<User, PlakDbContext>, IUserRepo
    {
        public UserRepo(PlakDbContext contex) : base(contex)
        {
        }
    }
}
