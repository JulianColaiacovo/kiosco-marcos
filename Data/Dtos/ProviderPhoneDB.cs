
namespace Data.Dtos
{
    public class ProviderPhoneDB : DTO
    {
        public int? ProviderId { get; set; }
        public string Phone { get; set; }
        public string Description { get; set; }

        public ProviderPhoneDB(string phone, string description)
        {
            this.Id = null;
            this.ProviderId = null;
            this.Phone = phone;
            this.Description = description;
        }
        public ProviderPhoneDB(int? providerId, string phone, string description)
        {
            this.Id = null;
            this.ProviderId = providerId;
            this.Phone = phone;
            this.Description = description;
        }
        public ProviderPhoneDB(int id, int? providerId, string phone, string description)
        {
            this.Id = id;
            this.ProviderId = providerId;
            this.Phone = phone;
            this.Description = description;
        }

        public override string ToString()
        {
            return string.Format("{0} - {1}", this.Phone, this.Description);
        }

        public override bool Equals(object obj)
        {
            if (obj != null && obj.GetType() == typeof(ProviderPhoneDB))
            {
                ProviderPhoneDB phoneObj = (ProviderPhoneDB)obj;
                return (phoneObj.Id == this.Id && phoneObj.ProviderId == this.ProviderId && phoneObj.Phone == this.Phone && phoneObj.Description == this.Description);
            }
            return false;
        }
    }
}
