using System;
using System.Collections.Generic;

namespace Data.Dtos
{
    public class SaleDB : OperationDB
    {
        public decimal Surcharge { get; set; }
        public List<SaleItemDB> Items { get; set; }

        public SaleDB(int id, decimal discount, decimal surcharge, DateTime dateTime, List<SaleItemDB> items)
        {
            this.Id = id;
            this.Discount = discount;
            this.Surcharge = surcharge;
            this.DateTime = dateTime;
            this.Items = items;
        }
    }
}
