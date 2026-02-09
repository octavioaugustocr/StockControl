using StockControl.Domain.Enums;

namespace StockControl.Domain.Entities
{
    public class StockMovement : EntityBase
    {
        public int Quantity { get; set; }
        public TypeMovement TypeMovement { get; set; }
        public long ProductId { get; set; }
    }
}
