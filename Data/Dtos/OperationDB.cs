using System;

namespace Data.Dtos
{
    public abstract class OperationDB : DTO
    {
        public decimal Discount { get; set; }
        public DateTime DateTime { get; set; }
    }
}
