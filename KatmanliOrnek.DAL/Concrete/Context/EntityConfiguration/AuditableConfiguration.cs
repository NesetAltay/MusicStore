using KatmanliOrnek.Core.BaseEntities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace KatmanliOrnek.DAL.Concrete.Context.EntityConfiguration
{
    public abstract class AuditableConfiguration<TEntity> : BaseConfiguration<TEntity>
        where TEntity : AuditableEntity
    {
        public override void Configure(EntityTypeBuilder<TEntity> builder)
        {
            builder.Property(x => x.DeletedDate).IsRequired(false);

            base.Configure(builder);
        }
    }
}
