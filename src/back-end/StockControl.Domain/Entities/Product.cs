namespace StockControl.Domain.Entities
{
    public class Product : EntityBase
    {
        public string Name { get; set; } = string.Empty;
        public decimal Price { get; set; }
        public string Flavor { get; set; } = string.Empty;
        public string Mark { get; set; } = string.Empty;
        public string Manufacturer { get; set; } = string.Empty;
        public DateOnly DueDate { get; set; }
        public int QuantityStock { get; set; }
    }
}
