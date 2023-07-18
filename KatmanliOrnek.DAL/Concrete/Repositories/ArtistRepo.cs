using KatmanliOrnek.DAL.Abstract;
using KatmanliOrnek.DAL.Base.EntityFramework;
using KatmanliOrnek.DAL.Concrete.Context;
using KatmanliOrnek.Entities;

namespace KatmanliOrnek.DAL.Concrete.Repositories
{
    public class ArtistRepo : BaseRepository<Artist, PlakDbContext>, IArtistRepo
    {
        public ArtistRepo(PlakDbContext contex) : base(contex)
        {
        }
    }
}
