using KatmanliOrnek.Core.BaseEntities;
using KatmanliOrnek.Core.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace KatmanliOrnek.DAL.Concrete.Context.EntityConfiguration
{
    public abstract class BaseConfiguration<TEntity> : IEntityTypeConfiguration<TEntity> 
        where TEntity : BaseEntity
    {
        public virtual void Configure(EntityTypeBuilder<TEntity> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn(1,1);
            builder.Property(x => x.CreatedDate).IsRequired();
            builder.Property(x => x.UpdatedDate).IsRequired(false);
            builder.Property(x => x.State).HasConversion(new EnumToStringConverter<State>());
        }
    }
}
