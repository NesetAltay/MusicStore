using KatmanliOrnek.Core.BaseEntities;

namespace KatmanliOrnek.Entities
{
    public class Plak : AppEntity
    {
        public string PlakName { get; set; }

        public DateTime RecordDate { get; set; }

        public decimal UnitPrice { get; set; }

        public double? Discount { get; set; }

        public bool Discontinued { get; set; }

        public int ArtistId { get; set; }
        public virtual Artist? Artist { get; set; }
    }
}
