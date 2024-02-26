namespace Core.Models
{
    public class ShippingAddress: BaseEntity
    {
        public String Address { get; set; }

        public String City { get; set; }

        public String State { get; set; }

        public String Country { get; set; }

        public String ZipCode { get; set; }

        public ICollection<User> Users { get; set; }
    }
}