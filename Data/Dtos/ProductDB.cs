
namespace Data.Dtos
{
    public class ProductDB : DTO
    {
        public long Code { get; set; }
        public string Name { get; set; }
        public bool Stockable { get; set; }
        public decimal Stock { get; set; }
        public decimal Price { get; set; }

        public ProductDB(int id, long code, string name, bool stockable = true, decimal stock = 0, decimal price = 0)
        {
            this.Id = id;
            this.Code = code;
            this.Name = name;
            this.Stockable = stockable;
            this.Stock = stock;
            this.Price = price;
        }
        public ProductDB(long code, string name, bool stockable = true, decimal stock = 0, decimal price = 0)
        {
            this.Id = null;
            this.Code = code;
            this.Name = name;
            this.Stockable = stockable;
            this.Stock = stock;
            this.Price = price;
        }
    }
}
