
namespace Data.Dtos
{
    public class PurchaseItemDB : ItemDB
    {
        public int PurchaseId { get; set; }
        public int ProductId { get; set; }
        public int ProviderId { get; set; }

        public PurchaseItemDB(int id, int purchaseId, int productId, int providerId, decimal quantity, decimal unitPrice)
        {
            this.Id = id;
            this.PurchaseId = purchaseId;
            this.ProductId = productId;
            this.ProviderId = providerId;
            this.Quantity = quantity;
            this.UnitPrice = unitPrice;
        }
        public PurchaseItemDB(int purchaseId, int productId, int providerId, decimal quantity, decimal unitPrice)
        {
            this.Id = null;
            this.PurchaseId = purchaseId;
            this.ProductId = productId;
            this.ProviderId = providerId;
            this.Quantity = quantity;
            this.UnitPrice = unitPrice;
        }
    }
}
