namespace KatmanliOrnek.Models.VMs.PlakVMs
{
    public class PlakDetailVm : PlakBaseVm
    {
        public DateTime RecorDate { get; set; }

        public decimal UnitPrice { get; set; }

        public double? Discount { get; set; }

        public bool Discontinued { get; set; }
    }
}
