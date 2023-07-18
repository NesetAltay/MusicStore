using KatmanliOrnek.Core.BaseEntities;

namespace KatmanliOrnek.Entities
{
    public class Artist : AppEntity
    {
        public string ArtistName { get; set; }

        public virtual ICollection<Plak> Plaks { get; set; }

        public Artist()
        {
            Plaks = new HashSet<Plak>();
        }
    }
}
