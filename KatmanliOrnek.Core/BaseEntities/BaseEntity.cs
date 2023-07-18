using KatmanliOrnek.Core.Enums;

namespace KatmanliOrnek.Core.BaseEntities
{
    public abstract class BaseEntity
    {
        public int Id { get; set; }

        public DateTime CreatedDate { get; set; }

        public DateTime? UpdatedDate { get; set;}

        public State State { get; set; }
    }
}
