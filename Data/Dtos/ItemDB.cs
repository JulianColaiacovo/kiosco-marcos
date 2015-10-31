
namespace Data.Dtos
{
    public abstract class ItemDB : DTO
    {
        public decimal Quantity { get; set; }
        public decimal UnitPrice { get; set; }
    }
}
