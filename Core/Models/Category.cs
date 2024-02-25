namespace Core.Models
{
    public class Category: BaseEntity
    {
        public String Name { get; set; }

        public ICollection<Product> Products { get; set; }
    }
}