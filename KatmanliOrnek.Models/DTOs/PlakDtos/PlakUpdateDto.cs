using KatmanliOrnek.Core.Enums;

namespace KatmanliOrnek.Models.DTOs.PlakDtos
{
    public class PlakUpdateDto : PlakBaseDto
    {
        public int Id { get; set; }

        public bool Discontinued { get; set; }

        public string UpdatedBy { get; set; }

        public State State => State.Updated;

        public DateTime UpdateDate => DateTime.Now;

    }
}
