using System;
using System.Collections.Generic;

namespace Data.Dtos
{
    public class PurchaseDB : OperationDB
    {
        public decimal Tax { get; set; }
        public List<PurchaseItemDB> Items { get; set; }

        public PurchaseDB(int id, decimal discount, decimal tax, DateTime dateTime, List<PurchaseItemDB> items)
        {
            this.Id = id;
            this.Discount = discount;
            this.Tax = tax;
            this.DateTime = dateTime;
            this.Items = items;
        }
    }
}
