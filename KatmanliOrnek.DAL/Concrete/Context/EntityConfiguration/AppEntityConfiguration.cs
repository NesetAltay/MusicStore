using KatmanliOrnek.Core.BaseEntities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace KatmanliOrnek.DAL.Concrete.Context.EntityConfiguration
{
    public abstract class AppEntityConfiguration<TEntity> : BaseConfiguration<TEntity>
        where TEntity : AppEntity
    {
        public override void Configure(EntityTypeBuilder<TEntity> builder)
        {
            builder.Property(x => x.CreatedBy).IsRequired(false);

            builder.Property(x => x.UpdatedBy).IsRequired(false);

            base.Configure(builder);
        }
    }
}
