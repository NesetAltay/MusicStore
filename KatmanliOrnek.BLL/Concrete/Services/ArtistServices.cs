using KatmanliOrnek.BLL.Abstract.IServices;
using KatmanliOrnek.Models.DTOs.ArtistDtos;
using KatmanliOrnek.Models.VMs.ArtistVMs;
using KatmanliOrnek.Shared;

namespace KatmanliOrnek.BLL.Concrete.Services
{
    public class ArtistServices : IArtistServise
    {
        public ResultService<ArtistCreateDto> Create(ArtistCreateVm createVm)
        {
            throw new NotImplementedException();
        }

        public ResultService<ArtistDetailDto> FindArtistByName(string name)
        {
            throw new NotImplementedException();
        }

        public bool IsExistArtist(string name)
        {
            throw new NotImplementedException();
        }
    }
}
