
namespace Data.Dtos
{
    public class SaleItemDB : ItemDB
    {
        public int SaleId { get; set; }
        public int ProductId { get; set; }
        public int PurchaseItemId { get; set; }

        public SaleItemDB(int id, int saleId, int productId, int purchaseItemId, decimal quantity, decimal unitPrice)
        {
            this.Id = id;
            this.SaleId = saleId;
            this.ProductId = productId;
            this.PurchaseItemId = purchaseItemId;
            this.Quantity = quantity;
            this.UnitPrice = unitPrice;
        }
        public SaleItemDB(int saleId, int productId, int purchaseItemId, decimal quantity, decimal unitPrice)
        {
            this.Id = null;
            this.SaleId = saleId;
            this.ProductId = productId;
            this.PurchaseItemId = purchaseItemId;
            this.Quantity = quantity;
            this.UnitPrice = unitPrice;
        }
    }
}
