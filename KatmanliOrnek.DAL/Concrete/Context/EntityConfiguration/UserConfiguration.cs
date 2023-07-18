using KatmanliOrnek.Core.Enums;
using KatmanliOrnek.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace KatmanliOrnek.DAL.Concrete.Context.EntityConfiguration
{
    public class UserConfiguration : BaseConfiguration<User>
    {
        public override void Configure(EntityTypeBuilder<User> builder)
        {
            builder.Property(x => x.UserName)
                .IsRequired();

            builder.HasIndex(x => x.UserName).IsUnique();

            builder.Property(x=>x.Password).IsRequired();

            builder.Property(x => x.Role).IsRequired().HasConversion(new EnumToStringConverter<Role>());

            base.Configure(builder);

            builder.HasData(new User { UserName = "admin", Password = "admin", Id = 1, CreatedDate = DateTime.Now, State = State.Created, Role = Role.Admin });
        }
    }
}
