namespace KatmanliOrnek.Core.BaseEntities
{
    public abstract class AppEntity : BaseEntity
    {
        public string CreatedBy { get; set; }

        public string UpdatedBy { get; set; }
    }
}
