using KatmanliOrnek.Models.VMs.PlakVMs;

namespace KatmanliOrnek.Models.DTOs.ArtistDtos
{
    public class ArtistDetailDto
    {
        public int Id { get; set; }

        public string ArtistName { get; set; }

        public List<PlakBaseVm> Albums { get; set; }
    }
}
