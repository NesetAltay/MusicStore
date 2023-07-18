namespace KatmanliOrnek.Models.DTOs.PlakDtos
{
    public class PlakBaseDto
    {
        public int ArtistId { get; set; }

        public string ArtistName { get; set; }

        public string PlakName { get; set; }

        public DateTime RecordDate { get; set; }

        public decimal UnitPrice { get; set; }

        public double? Discount { get; set; }

    }
}
