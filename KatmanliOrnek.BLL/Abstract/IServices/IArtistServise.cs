using KatmanliOrnek.Models.DTOs.ArtistDtos;
using KatmanliOrnek.Models.VMs.ArtistVMs;
using KatmanliOrnek.Shared;

namespace KatmanliOrnek.BLL.Abstract.IServices
{
    public interface IArtistServise
    {
        ResultService<ArtistCreateDto> Create(ArtistCreateVm createVm);

        ResultService<ArtistDetailDto> FindArtistByName(string name);

        bool IsExistArtist(string name);
    }
}
