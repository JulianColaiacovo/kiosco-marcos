
namespace Kiosco.PurchaseItemCart
{
    public class QuantityUnitPrice
    {
        public decimal Quantity { get; set; }
        public decimal UnitPrice { get; set; }

        public QuantityUnitPrice(decimal quantity, decimal unitPrice)
        {
            this.Quantity = quantity;
            this.UnitPrice = unitPrice;
        }
    }
}
