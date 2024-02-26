namespace Core.Models
{
    public class User: BaseEntity
    {
        public String Username { get; set; }

        public String Password { get; set; }

        public String Email { get; set; }

        public UserType UserType { get; set; }

        public int? AddressId { get; set; }

        public ShippingAddress? ShippingAddress { get; set; }

        public String VerificationStatus { get; set; }

        public ICollection<ShoppingCart> ShoppingCarts { get; set; }

        public ICollection<Order> Orders { get; set; }

        public ICollection<Review> Reviews { get; set; }

        public ICollection<Notification> Notifications { get; set; }

        public ICollection<WishList> WishLists { get; set; }
    }

    public enum UserType
    {
        Admin,
        Seller,
        Buyer
    }
}