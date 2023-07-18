namespace KatmanliOrnek.Core.BaseEntities
{
    public abstract class AuditableEntity : BaseEntity
    {
        public DateTime? DeletedDate { get; set; }
    }
}
