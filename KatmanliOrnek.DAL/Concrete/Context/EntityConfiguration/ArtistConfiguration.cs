using KatmanliOrnek.Core.BaseEntities;
using KatmanliOrnek.Core.Enums;
using KatmanliOrnek.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace KatmanliOrnek.DAL.Concrete.Context.EntityConfiguration
{
    public class ArtistConfiguration : AppEntityConfiguration<Artist>
    {
        public override void Configure(EntityTypeBuilder<Artist> builder)
        {
            builder.Property(x => x.ArtistName)
                .HasMaxLength(50)
                .IsRequired();

            base.Configure(builder);

            builder.HasData(
                new Artist { ArtistName = "Tarkan", CreatedDate = DateTime.Now, Id = 1, State = State.Created }
                );
        }
    }
}
