using KatmanliOrnek.Core.Enums;

namespace KatmanliOrnek.Models.DTOs.ArtistDtos
{
    public class ArtistCreateDto
    {
        public string ArtistName { get; set; }

        public string CreatedBy { get; set; }

        public State State => State.Created;

        public DateTime CreateDate => DateTime.Now;
    }
}
