using KatmanliOrnek.DAL.Abstract;
using KatmanliOrnek.DAL.Base.EntityFramework;
using KatmanliOrnek.DAL.Concrete.Context;
using KatmanliOrnek.Entities;

namespace KatmanliOrnek.DAL.Concrete.Repositories
{
    public class PlakRepo : BaseRepository<Plak, PlakDbContext>, IPlakRepo
    {
        public PlakRepo(PlakDbContext contex) : base(contex)
        {
        }
    }
}
