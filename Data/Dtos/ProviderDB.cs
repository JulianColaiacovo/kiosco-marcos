using System.Collections.Generic;

namespace Data.Dtos
{
    public class ProviderDB : DTO
    {
        public string Name { get; set; }
        public string Address { get; set; }

        public ProviderDB(string name, string address)
        {
            this.Id = null;
            this.Name = name;
            this.Address = address;
        }
        public ProviderDB(int id, string name, string address)
        {
            this.Id = id;
            this.Name = name;
            this.Address = address;
        }
    }
}
