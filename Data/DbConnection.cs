using System;
using System.Data;
using System.Data.SqlClient;

namespace Data
{
    class DbConnection
    {
        private static string connectionString = String.Format(@"Data Source=(LocalDB)\v11.0;AttachDbFilename={0}\DB.mdf;Integrated Security=True", Environment.CurrentDirectory);

        private SqlConnection connection;

        public DbConnection()
        {
            this.connection = new SqlConnection(DbConnection.connectionString);
        }

        //providers
        public DataTable searchProvidersByName(string name)
        {
            string commandText = "SET @name = (@name Collate SQL_Latin1_General_CP1_CI_AI); ";
            commandText += "SELECT Id, Name, Address FROM Providers ";
            commandText += "WHERE @name = '' OR CHARINDEX(@name, Name Collate SQL_Latin1_General_CP1_CI_AI) > 0;";

            SqlCommand command = new SqlCommand(commandText, this.connection);
            command.Parameters.AddWithValue("name", name);

            try
            {
                this.connection.Open();
                command.ExecuteNonQuery();
                DataTable dataReturn = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(dataReturn);
                return dataReturn;
            }
            catch (Exception ex)
            {
                throw new ArgumentException("Error al buscar un proveedor", ex);
            }
            finally
            {
                if (this.connection.State == ConnectionState.Open)
                    this.connection.Close();
            }
        }
        public int addProvider(string name, string address)
        {
            string commandText = "INSERT INTO Providers(Name, Address) OUTPUT INSERTED.ID VALUES(@name, @address)";

            SqlCommand command = new SqlCommand(commandText, this.connection);
            command.Parameters.AddWithValue("name", name);
            command.Parameters.AddWithValue("address", address);

            try
            {
                this.connection.Open();
                return (int)command.ExecuteScalar();
            }
            catch (Exception ex)
            {
                throw new ArgumentException("Error al crear un proveedor", ex);
            }
            finally
            {
                if (this.connection.State == ConnectionState.Open)
                    this.connection.Close();
            }
        }
        public void updateProvider(int id, string name, string address)
        {
            string commandText = "UPDATE Providers SET Name = @name, Address = @address WHERE Id = @id";

            SqlCommand command = new SqlCommand(commandText, this.connection);
            command.Parameters.AddWithValue("id", id);
            command.Parameters.AddWithValue("name", name);
            command.Parameters.AddWithValue("address", address);

            try
            {
                this.connection.Open();
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new ArgumentException("Error al modificar un proveedor", ex);
            }
            finally
            {
                if (this.connection.State == ConnectionState.Open)
                    this.connection.Close();
            }
        }
        public void deleteProvider(int id)
        {
            string commandText = "DELETE FROM Providers WHERE Id = @id";

            SqlCommand command = new SqlCommand(commandText, this.connection);
            command.Parameters.AddWithValue("id", id);

            try
            {
                this.connection.Open();
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new ArgumentException("Error al eliminar un proveedor", ex);
            }
            finally
            {
                if (this.connection.State == ConnectionState.Open)
                    this.connection.Close();
            }
        }

        //providers phones
        public DataTable searchProviderPhonesByProviderId(int providerId)
        {
            string commandText = "SELECT Id, ProviderId, Phone, Description FROM ProviderPhones ";
            commandText += "WHERE ProviderId = @providerId;";

            SqlCommand command = new SqlCommand(commandText, this.connection);
            command.Parameters.AddWithValue("providerId", providerId);

            try
            {
                this.connection.Open();
                command.ExecuteNonQuery();
                DataTable dataReturn = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(dataReturn);
                return dataReturn;
            }
            catch (Exception ex)
            {
                throw new ArgumentException("Error al buscar los teléfonos de un proveedor", ex);
            }
            finally
            {
                if (this.connection.State == ConnectionState.Open)
                    this.connection.Close();
            }
        }
        public int addProviderPhone(int providerId, string phone, string description)
        {
            string commandText = "INSERT INTO ProviderPhones(ProviderId, Phone, Description) OUTPUT INSERTED.ID VALUES(@providerId, @phone, @description)";

            SqlCommand command = new SqlCommand(commandText, this.connection);
            command.Parameters.AddWithValue("providerId", providerId);
            command.Parameters.AddWithValue("phone", phone);
            command.Parameters.AddWithValue("description", description);

            try
            {
                this.connection.Open();
                return (int)command.ExecuteScalar();
            }
            catch (Exception ex)
            {
                throw new ArgumentException("Error al crear un teléfono de un proveedor", ex);
            }
            finally
            {
                if (this.connection.State == ConnectionState.Open)
                    this.connection.Close();
            }
        }
        public void updateProviderPhone(int id, int providerId, string phone, string description)
        {
            string commandText = "UPDATE ProviderPhones SET ProviderId = @providerId, Phone = @phone, Description = @description WHERE Id = @id";

            SqlCommand command = new SqlCommand(commandText, this.connection);
            command.Parameters.AddWithValue("id", id);
            command.Parameters.AddWithValue("providerId", providerId);
            command.Parameters.AddWithValue("phone", phone);
            command.Parameters.AddWithValue("description", description);

            try
            {
                this.connection.Open();
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new ArgumentException("Error al modificar un teléfono de un proveedor", ex);
            }
            finally
            {
                if (this.connection.State == ConnectionState.Open)
                    this.connection.Close();
            }
        }
        public void deleteProviderPhone(int id)
        {
            string commandText = "DELETE FROM ProviderPhones WHERE Id = @id";

            SqlCommand command = new SqlCommand(commandText, this.connection);
            command.Parameters.AddWithValue("id", id);

            try
            {
                this.connection.Open();
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new ArgumentException("Error al eliminar un teléfono de un proveedor", ex);
            }
            finally
            {
                if (this.connection.State == ConnectionState.Open)
                    this.connection.Close();
            }
        }
        public void deleteProviderPhones(int providerId)
        {
            string commandText = "DELETE FROM ProviderPhones WHERE ProviderId = @providerId";

            SqlCommand command = new SqlCommand(commandText, this.connection);
            command.Parameters.AddWithValue("providerId", providerId);

            try
            {
                this.connection.Open();
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new ArgumentException("Error al eliminar los teléfonos de un proveedor", ex);
            }
            finally
            {
                if (this.connection.State == ConnectionState.Open)
                    this.connection.Close();
            }
        }

        //products
        public DataTable searchProductsByName(string name)
        {
            string commandText = "SET @name = (@name Collate SQL_Latin1_General_CP1_CI_AI); ";
            commandText += "SELECT Id, Code, Stockable, Stock, Price, Name FROM Products ";
            commandText += "WHERE @name = '' OR CHARINDEX(@name, Name Collate SQL_Latin1_General_CP1_CI_AI) > 0;";

            SqlCommand command = new SqlCommand(commandText, this.connection);
            command.Parameters.AddWithValue("name", name);

            try
            {
                this.connection.Open();
                command.ExecuteNonQuery();
                DataTable dataReturn = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(dataReturn);
                return dataReturn;
            }
            catch (Exception ex)
            {
                throw new ArgumentException("Error al buscar los productos por texto", ex);
            }
            finally
            {
                if (this.connection.State == ConnectionState.Open)
                    this.connection.Close();
            }
        }
        public DataTable searchProductsByCode(long code)
        {
            string commandText = "SELECT Id, Code, Stockable, Stock, Price, Name FROM Products ";
            commandText += "WHERE Code = @code;";

            SqlCommand command = new SqlCommand(commandText, this.connection);
            command.Parameters.AddWithValue("code", code);

            try
            {
                this.connection.Open();
                command.ExecuteNonQuery();
                DataTable dataReturn = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(dataReturn);
                return dataReturn;
            }
            catch (Exception ex)
            {
                throw new ArgumentException("Error al buscar los productos por código", ex);
            }
            finally
            {
                if (this.connection.State == ConnectionState.Open)
                    this.connection.Close();
            }
        }
        public int addProduct(long code, string name, bool stockable, decimal stock, decimal price)
        {
            string commandText = "INSERT INTO Products(Code, Name, Stockable, Stock, Price) OUTPUT INSERTED.ID VALUES(@code, @name, @stockable, @stock, @price)";

            SqlCommand command = new SqlCommand(commandText, this.connection);
            command.Parameters.AddWithValue("code", code);
            command.Parameters.AddWithValue("name", name);
            command.Parameters.AddWithValue("stockable", stockable);
            command.Parameters.AddWithValue("stock", stock);
            command.Parameters.AddWithValue("price", price);

            try
            {
                this.connection.Open();
                return (int)command.ExecuteScalar();
            }
            catch (Exception ex)
            {
                throw new ArgumentException("Error al crear un producto", ex);
            }
            finally
            {
                if (this.connection.State == ConnectionState.Open)
                    this.connection.Close();
            }
        }
        public void updateProduct(int id, long code, string name, bool stockable, decimal stock, decimal price)
        {
            string commandText = "UPDATE Products SET Code = @code, Name = @name, Stockable = @stockable, Stock = @stock, Price = @price WHERE Id = @id";

            SqlCommand command = new SqlCommand(commandText, this.connection);
            command.Parameters.AddWithValue("id", id);
            command.Parameters.AddWithValue("code", code);
            command.Parameters.AddWithValue("name", name);
            command.Parameters.AddWithValue("stockable", stockable);
            command.Parameters.AddWithValue("stock", stock);
            command.Parameters.AddWithValue("price", price);

            try
            {
                this.connection.Open();
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new ArgumentException("Error al modificar un producto", ex);
            }
            finally
            {
                if (this.connection.State == ConnectionState.Open)
                    this.connection.Close();
            }
        }
        public void deleteProduct(int id)
        {
            string commandText = "DELETE FROM Products WHERE Id = @id";

            SqlCommand command = new SqlCommand(commandText, this.connection);
            command.Parameters.AddWithValue("id", id);

            try
            {
                this.connection.Open();
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new ArgumentException("Error al eliminar un producto", ex);
            }
            finally
            {
                if (this.connection.State == ConnectionState.Open)
                    this.connection.Close();
            }
        }

        //purchases
        /// <summary>
        /// Busca un item de compra del producto elegido que tenga stock
        /// </summary>
        /// <param name="productId"></param>
        /// <returns>Id del item de compra. -1 si no encontró ninguno</returns>
        public int purchaseItemWithStock(int productId)
        {
            string commandText = "SELECT PIs.Id FROM PurchaseItems PIs ";
            commandText += "LEFT JOIN SaleItems SIs ON PIs.Id = SIs.PurchaseItemId ";
            commandText += "WHERE PIs.ProductId = @productId ";
            commandText += "GROUP BY PIs.Id, PIs.Quantity ";
            commandText += "HAVING IsNull(SUM(SIs.Quantity), 0) < PIs.Quantity;";

            SqlCommand command = new SqlCommand(commandText, this.connection);
            command.Parameters.AddWithValue("productId", productId);

            try
            {
                this.connection.Open();
                object id = command.ExecuteScalar();
                return id == null ? -1 : (int)id;
            }
            catch (Exception ex)
            {
                throw new ArgumentException("Error al buscar los item de compra con stock", ex);
            }
            finally
            {
                if (this.connection.State == ConnectionState.Open)
                    this.connection.Close();
            }
        }
        public decimal availableStockOfProduct(int productId)
        {
            string commandText = "SELECT (IsNull((SELECT SUM(Quantity) FROM PurchaseItems WHERE ProductId = @productId), 0) - ";
            commandText += "IsNull((SELECT SUM(IsNull(SIs.Quantity, 0)) FROM PurchaseItems PIs LEFT JOIN SaleItems SIs ON PIs.Id = SIs.PurchaseItemId WHERE ProductId = @productId), 0)) Stock";

            SqlCommand command = new SqlCommand(commandText, this.connection);
            command.Parameters.AddWithValue("productId", productId);

            try
            {
                this.connection.Open();
                return (decimal)command.ExecuteScalar();
            }
            catch (Exception ex)
            {
                throw new ArgumentException("Error al obtener el stock de un producto", ex);
            }
            finally
            {
                if (this.connection.State == ConnectionState.Open)
                    this.connection.Close();
            }
        }
        public decimal availableStockOfPurchaseItem(int purchaseItemId)
        {
            string commandText = "SELECT (PIs.Quantity - IsNull(SUM(SIs.Quantity), 0)) Stock FROM PurchaseItems PIs ";
            commandText += "LEFT JOIN SaleItems SIs ON PIs.Id = SIs.PurchaseItemId ";
            commandText += "WHERE PIs.Id = @purchaseItemId ";
            commandText += "GROUP BY PIs.Id, PIs.Quantity;";

            SqlCommand command = new SqlCommand(commandText, this.connection);
            command.Parameters.AddWithValue("purchaseItemId", purchaseItemId);

            try
            {
                this.connection.Open();
                object id = command.ExecuteScalar();
                return id == null ? 0 : (decimal)id;
            }
            catch (Exception ex)
            {
                throw new ArgumentException("Error al obtener el stock de un item de compra", ex);
            }
            finally
            {
                if (this.connection.State == ConnectionState.Open)
                    this.connection.Close();
            }
        }
        public int addPurchase(decimal discount, decimal tax, DateTime date)
        {
            string commandText = "INSERT INTO Purchases(Discount, Tax, DateTime) OUTPUT INSERTED.ID VALUES(@discount, @tax, @date)";

            SqlCommand command = new SqlCommand(commandText, this.connection);
            command.Parameters.AddWithValue("discount", discount);
            command.Parameters.AddWithValue("tax", tax);
            command.Parameters.AddWithValue("date", date);

            try
            {
                this.connection.Open();
                return (int)command.ExecuteScalar();
            }
            catch (Exception ex)
            {
                throw new ArgumentException("Error al crear una compra", ex);
            }
            finally
            {
                if (this.connection.State == ConnectionState.Open)
                    this.connection.Close();
            }
        }
        public void deletePurchase(int id)
        {
            string commandText = "DELETE FROM Purchases WHERE Id = @id";

            SqlCommand command = new SqlCommand(commandText, this.connection);
            command.Parameters.AddWithValue("id", id);

            try
            {
                this.connection.Open();
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new ArgumentException("Error al eliminar una compra", ex);
            }
            finally
            {
                if (this.connection.State == ConnectionState.Open)
                    this.connection.Close();
            }
        }
        public int addPurchaseItem(int purchaseId, int productId, int providerId, decimal quantity, decimal unitPrice)
        {
            string commandText = "INSERT INTO PurchaseItems(PurchaseId, ProductId, ProviderId, Quantity, UnitPrice) OUTPUT INSERTED.ID ";
            commandText += "VALUES(@purchaseId, @productId, @providerId, @quantity, @unitPrice)";

            SqlCommand command = new SqlCommand(commandText, this.connection);
            command.Parameters.AddWithValue("purchaseId", purchaseId);
            command.Parameters.AddWithValue("productId", productId);
            command.Parameters.AddWithValue("providerId", providerId);
            command.Parameters.AddWithValue("quantity", quantity);
            command.Parameters.AddWithValue("unitPrice", unitPrice);

            try
            {
                this.connection.Open();
                return (int)command.ExecuteScalar();
            }
            catch (Exception ex)
            {
                throw new ArgumentException("Error al crear un item de compra", ex);
            }
            finally
            {
                if (this.connection.State == ConnectionState.Open)
                    this.connection.Close();
            }
        }
        public void deletePurchaseItem(int id)
        {
            string commandText = "DELETE FROM PurchaseItems WHERE Id = @id";

            SqlCommand command = new SqlCommand(commandText, this.connection);
            command.Parameters.AddWithValue("id", id);

            try
            {
                this.connection.Open();
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new ArgumentException("Error al eliminar un item de compra", ex);
            }
            finally
            {
                if (this.connection.State == ConnectionState.Open)
                    this.connection.Close();
            }
        }

        //sales
        public int addSale(decimal discount, decimal surcharge, DateTime date)
        {
            string commandText = "INSERT INTO Sales(Discount, Surcharge, DateTime) OUTPUT INSERTED.ID VALUES(@discount, @surcharge, @date)";

            SqlCommand command = new SqlCommand(commandText, this.connection);
            command.Parameters.AddWithValue("discount", discount);
            command.Parameters.AddWithValue("surcharge", surcharge);
            command.Parameters.AddWithValue("date", date);

            try
            {
                this.connection.Open();
                return (int)command.ExecuteScalar();
            }
            catch (Exception ex)
            {
                throw new ArgumentException("Error al crear una venta", ex);
            }
            finally
            {
                if (this.connection.State == ConnectionState.Open)
                    this.connection.Close();
            }
        }
        public void deleteSale(int id)
        {
            string commandText = "DELETE FROM Sales WHERE Id = @id";

            SqlCommand command = new SqlCommand(commandText, this.connection);
            command.Parameters.AddWithValue("id", id);

            try
            {
                this.connection.Open();
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new ArgumentException("Error al eliminar una venta", ex);
            }
            finally
            {
                if (this.connection.State == ConnectionState.Open)
                    this.connection.Close();
            }
        }
        public int addSaleItem(int saleId, int purchaseItemId, decimal quantity, decimal unitPrice)
        {
            string commandText = "INSERT INTO SaleItems(SaleId, PurchaseItemId, Quantity, UnitPrice) OUTPUT INSERTED.ID ";
            commandText += "VALUES(@saleId, @purchaseItemId, @quantity, @unitPrice)";

            SqlCommand command = new SqlCommand(commandText, this.connection);
            command.Parameters.AddWithValue("saleId", saleId);
            command.Parameters.AddWithValue("purchaseItemId", purchaseItemId);
            command.Parameters.AddWithValue("quantity", quantity);
            command.Parameters.AddWithValue("unitPrice", unitPrice);

            try
            {
                this.connection.Open();
                return (int)command.ExecuteScalar();
            }
            catch (Exception ex)
            {
                throw new ArgumentException("Error al crear un item de venta", ex);
            }
            finally
            {
                if (this.connection.State == ConnectionState.Open)
                    this.connection.Close();
            }
        }
        public void deleteSaleItem(int id)
        {
            string commandText = "DELETE FROM SaleItems WHERE Id = @id";

            SqlCommand command = new SqlCommand(commandText, this.connection);
            command.Parameters.AddWithValue("id", id);

            try
            {
                this.connection.Open();
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new ArgumentException("Error al eliminar un item de venta", ex);
            }
            finally
            {
                if (this.connection.State == ConnectionState.Open)
                    this.connection.Close();
            }
        }
    }
}
