using KatmanliOrnek.Core.Enums;
using KatmanliOrnek.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace KatmanliOrnek.DAL.Concrete.Context.EntityConfiguration
{
    public class PlakConfiguration : AppEntityConfiguration<Plak>
    {
        public override void Configure(EntityTypeBuilder<Plak> builder)
        {
            builder.Property(x => x.PlakName).IsRequired();

            builder.Property(x => x.RecordDate)
                .HasColumnType("smalldatetime")
                .IsRequired();

            builder.Property(x => x.UnitPrice).IsRequired();

            builder.Property(x => x.Discount).IsRequired(false);

            builder.Property(x => x.Discontinued).IsRequired();

            builder.HasOne(x => x.Artist)
                .WithMany(x => x.Plaks)
                .HasForeignKey(x => x.ArtistId)
                .OnDelete(DeleteBehavior.Restrict);

            base.Configure(builder);

            builder.HasData(
             new Plak { Id = 1, PlakName = "Şımarık", RecordDate = DateTime.Parse("01/01/1995"), Discontinued = false, ArtistId = 1, CreatedDate = DateTime.Now, State = State.Created, Discount = 0.15, UnitPrice = 10 },
             new Plak { Id = 2, PlakName = "Plak2", RecordDate = DateTime.Parse("01/01/1997"), Discontinued = false, ArtistId = 1, CreatedDate = DateTime.Now, State = Core.Enums.State.Created, Discount = 0.15, UnitPrice = 10 },
             new Plak { Id = 3, PlakName = "Palk3", RecordDate = DateTime.Parse("01/01/1998"), Discontinued = true, ArtistId = 1, CreatedDate = DateTime.Now, State = Core.Enums.State.Created, Discount = 0.15, UnitPrice = 10 },
             new Plak { Id = 4, PlakName = "plak4", RecordDate = DateTime.Parse("01/01/1998"), Discontinued = false, ArtistId = 1, CreatedDate = DateTime.Now, State = Core.Enums.State.Created, Discount = 0.15, UnitPrice = 10 },
             new Plak { Id = 5, PlakName = "Palk4", RecordDate = DateTime.Parse("01/01/2000"), Discontinued = true, ArtistId = 1, CreatedDate = DateTime.Now, State = Core.Enums.State.Created, Discount = 0.15, UnitPrice = 10 },
             new Plak { Id = 6, PlakName = "Plak5", RecordDate = DateTime.Parse("01/01/2020"), Discontinued = false, ArtistId = 1, CreatedDate = DateTime.Now, State = Core.Enums.State.Created, Discount = 0.15, UnitPrice = 10 },
             new Plak { Id = 7, PlakName = "Palk6", RecordDate = DateTime.Parse("01/01/1991"), Discontinued = false, ArtistId = 1, CreatedDate = DateTime.Now, State = Core.Enums.State.Created, Discount = 0.15, UnitPrice = 10 },
             new Plak { Id = 8, PlakName = "Plak7", RecordDate = DateTime.Parse("01/01/1993"), Discontinued = false, ArtistId = 1, CreatedDate = DateTime.Now, State = Core.Enums.State.Created, Discount = 0.15, UnitPrice = 10 },
             new Plak { Id = 9, PlakName = "Plak8", RecordDate = DateTime.Parse("01/01/1998"), Discontinued = false, ArtistId = 1, CreatedDate = DateTime.Now, State = Core.Enums.State.Created, Discount = 0.15, UnitPrice = 10 },
             new Plak { Id = 10, PlakName = "Plak9", RecordDate = DateTime.Parse("01/01/1998"), Discontinued = false, ArtistId = 1, CreatedDate = DateTime.Now, State = Core.Enums.State.Created, Discount = 0.15, UnitPrice = 10 },
             new Plak { Id = 11, PlakName = "Palk10", RecordDate = DateTime.Parse("01/01/1997"), Discontinued = true, ArtistId = 1, CreatedDate = DateTime.Now, State = Core.Enums.State.Created, Discount = 0.15, UnitPrice = 10 },
             new Plak { Id = 12, PlakName = "Plak11", RecordDate = DateTime.Parse("01/01/1993"), Discontinued = false, ArtistId = 1, CreatedDate = DateTime.Now, State = Core.Enums.State.Created, Discount = 0.15, UnitPrice = 10 },
             new Plak { Id = 13, PlakName = "Plak12", RecordDate = DateTime.Parse("01/01/1991"), Discontinued = false, ArtistId = 1, CreatedDate = DateTime.Now, State = Core.Enums.State.Created, Discount = 0.15, UnitPrice = 10 },
             new Plak { Id = 14, PlakName = "Plak13", RecordDate = DateTime.Parse("01/01/1995"), Discontinued = true, ArtistId = 1, CreatedDate = DateTime.Now, State = Core.Enums.State.Created, Discount = 0.15, UnitPrice = 10 }
             );
        }
    }
}
