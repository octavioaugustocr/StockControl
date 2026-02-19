using StockControl.Domain.Enums;

namespace StockControl.Domain.Entities
{
    public class StockMovement : EntityBase
    {
        public int Quantity { get; set; }
        public TypeMovement TypeMovement { get; set; }
        public long ProductId { get; set; }

        public bool CanDecreaseStock(int quantity) => Quantity > quantity ? true : false;
        public void DecreaseStock(int quantity) => Quantity -= quantity;
        public void IncreaseStock(int quantity) => Quantity += quantity;
    }
}
