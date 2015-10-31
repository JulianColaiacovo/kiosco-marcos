using Data.Dtos;
using System;
using System.Collections.Generic;
using System.Data;

namespace Data
{
    public class DbValidation
    {
        private static DbValidation dbValidation = new DbValidation();

        private DbConnection dbConnection;

        private DbValidation()
        {
            this.dbConnection = new DbConnection();
        }

        public static DbValidation Instance
        {
            get { return DbValidation.dbValidation; }
        }

        //providers
        public List<ProviderDB> searchProvidersByName(string name)
        {
            List<ProviderDB> listReturn = new List<ProviderDB>();
            DataTable data = this.dbConnection.searchProvidersByName(name);
            foreach (DataRow row in data.Rows)
            {
                listReturn.Add(new ProviderDB((int)row["Id"], row["Name"].ToString(), row["Address"].ToString()));
            }
            return listReturn;
        }
        public void saveProvider(ProviderDB provider)
        {
            if (provider.IsNew())
            {
                int id = dbConnection.addProvider(provider.Name, provider.Address);
                provider.Id = id;
            }
            else
            {
                dbConnection.updateProvider((int)provider.Id, provider.Name, provider.Address);
            }
        }
        public void deleteProvider(ProviderDB provider)
        {
            dbConnection.deleteProviderPhones((int)provider.Id);
            dbConnection.deleteProvider((int)provider.Id);
        }

        //providers phones
        public List<ProviderPhoneDB> searchProviderPhonesByProviderId(int providerId)
        {
            List<ProviderPhoneDB> listReturn = new List<ProviderPhoneDB>();
            DataTable data = this.dbConnection.searchProviderPhonesByProviderId(providerId);
            foreach (DataRow row in data.Rows)
            {
                listReturn.Add(new ProviderPhoneDB((int)row["Id"], (int)row["ProviderId"], row["Phone"].ToString(), row["Description"].ToString()));
            }
            return listReturn;
        }
        public void saveProviderPhone(ProviderPhoneDB providerPhone)
        {
            if (providerPhone.IsNew())
            {
                int id = this.dbConnection.addProviderPhone((int)providerPhone.ProviderId, providerPhone.Phone, providerPhone.Description);
                providerPhone.Id = id;
            }
            else
            {
                this.dbConnection.updateProviderPhone((int)providerPhone.Id, (int)providerPhone.ProviderId, providerPhone.Phone, providerPhone.Description);
            }
        }
        public void deleteProviderPhone(ProviderPhoneDB providerPhone)
        {
            this.dbConnection.deleteProviderPhone((int)providerPhone.Id);
        }

        //products
        public List<ProductDB> searchProductsByName(string name)
        {
            List<ProductDB> listReturn = new List<ProductDB>();
            DataTable data = this.dbConnection.searchProductsByName(name);
            foreach (DataRow row in data.Rows)
            {
                listReturn.Add(new ProductDB((int)row["Id"], (long)row["Code"], row["Name"].ToString(), (bool)row["Stockable"], (decimal)row["Stock"], (decimal)row["Price"]));
            }
            return listReturn;
        }
        public ProductDB searchProductByCode(long code)
        {
            DataTable data = this.dbConnection.searchProductsByCode(code);
            if (data.Rows.Count == 0)
                return null;
            DataRow row = data.Rows[0];
            return new ProductDB((int)row["Id"], (long)row["Code"], row["Name"].ToString(), (bool)row["Stockable"], (decimal)row["Stock"], (decimal)row["Price"]);
        }
        public void saveProduct(ProductDB product)
        {
            if (product.IsNew())
            {
                int id = this.dbConnection.addProduct(product.Code, product.Name, product.Stockable, product.Stock, product.Price);
                product.Id = id;
            }
            else
            {
                this.dbConnection.updateProduct((int)product.Id, product.Code, product.Name, product.Stockable, product.Stock, product.Price);
            }
        }
        public void deleteProduct(ProductDB product)
        {
            this.dbConnection.deleteProduct((int)product.Id);
        }

        //purchases
        public void savePurchase(List<PurchaseItemDB> purchaseItems, decimal discount, decimal tax)
        {
            try
            {
                int purchaseId = this.dbConnection.addPurchase(discount, tax, DateTime.Now);
                List<int> idsItems = new List<int>();
                try
                {
                    foreach (PurchaseItemDB item in purchaseItems)
                    {
                        idsItems.Add(this.dbConnection.addPurchaseItem(purchaseId, item.ProductId, item.ProviderId, item.Quantity, item.UnitPrice));
                    }
                }
                catch (Exception)
                {
                    foreach (int id in idsItems)
                    {
                        this.dbConnection.deletePurchaseItem(id);
                    }
                    this.dbConnection.deletePurchase(purchaseId);
                    throw;
                }
            }
            catch (System.Exception)
            {
                throw new ArgumentException("Error al registrar la compra");
            }
        }

        //sales
        public void saveSale(List<SaleItemDB> saleItems, decimal discount, decimal surcharge)
        {
            int saleId = this.dbConnection.addSale(discount, surcharge, DateTime.Now);
            List<int> idsItems = new List<int>();
            try
            {
                foreach (SaleItemDB item in saleItems)
                {
                    decimal stock = this.dbConnection.availableStockOfProduct(item.ProductId);
                    if (stock >= item.Quantity)
                    {
                        decimal stockItem = item.Quantity;
                        while (stockItem > 0)
                        {
                            int purchaseItemId = this.dbConnection.purchaseItemWithStock(item.ProductId);
                            if (purchaseItemId == -1)
                                throw new Exception(String.Format("No hay stock suficiente para el producto"));
                            decimal purchaseItemStock = this.dbConnection.availableStockOfPurchaseItem(purchaseItemId);
                            if (purchaseItemStock - stockItem >= 0)
                            {
                                idsItems.Add(this.dbConnection.addSaleItem(saleId, purchaseItemId, stockItem, item.UnitPrice));
                            }
                            else
                            {
                                idsItems.Add(this.dbConnection.addSaleItem(saleId, purchaseItemId, purchaseItemStock, item.UnitPrice));
                            }
                            stockItem -= purchaseItemStock;
                        }
                    }
                    else
                    {
                        throw new ArgumentException("El producto no cuenta con stock");
                    }
                }
            }
            catch (Exception ex)
            {
                foreach (int id in idsItems)
                {
                    this.dbConnection.deletePurchaseItem(id);
                }
                this.dbConnection.deleteSale(saleId);
                throw;
            }
        }
    }
}
