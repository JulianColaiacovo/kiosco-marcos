using Data.Dtos;

namespace Kiosco.SalesTab.Elements
{
    public class SaleItem
    {
        public decimal Quantity { get; set; }
        public ProductDB Product { get; set; }

        public SaleItem(decimal quantity, ProductDB product)
        {
            this.Quantity = quantity;
            this.Product = product;
        }

        static public explicit operator SaleItemDB(SaleItem si)
        {
            return new SaleItemDB(0, (int)si.Product.Id, 0, si.Quantity, si.Product.Price);
        }
    }
}