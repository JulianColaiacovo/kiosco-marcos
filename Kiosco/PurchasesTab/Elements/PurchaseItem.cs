using Data.Dtos;

namespace Kiosco.PurchasesTab.Elements
{
    public class PurchaseItem
    {
        public decimal Quantity { get; set; }
        public decimal UnitPrice { get; set; }
        public ProductDB Product { get; set; }
        public ProviderDB Provider { get; set; }

        public PurchaseItem(decimal quantity, decimal unitPrice, ProductDB product)
        {
            this.Quantity = quantity;
            this.UnitPrice = unitPrice;
            this.Product = product;
            this.Provider = null;
        }
        public PurchaseItem(decimal quantity, decimal unitPrice, ProductDB product, ProviderDB provider)
        {
            this.Quantity = quantity;
            this.UnitPrice = unitPrice;
            this.Product = product;
            this.Provider = provider;
        }

        static public explicit operator PurchaseItemDB(PurchaseItem pi)
        {
            return new PurchaseItemDB(0, (int)pi.Product.Id, (int)pi.Provider.Id, pi.Quantity, pi.UnitPrice);
        }
    }
}
