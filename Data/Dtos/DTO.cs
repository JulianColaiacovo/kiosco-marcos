
namespace Data.Dtos
{
    public abstract class DTO
    {
        public int? Id { get; set; }

        public bool IsNew()
        {
            return this.Id == null;
        }
    }
}
