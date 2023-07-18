using KatmanliOrnek.Core.Enums;

namespace KatmanliOrnek.Models.DTOs.PlakDtos
{
    public class PlakCreateDto : PlakBaseDto
    {
        public string CreatedBy { get; set; }

        public bool Discontinued => false;

        public State State => State.Created;

        public DateTime CreateDate => DateTime.Now;
    }
}
