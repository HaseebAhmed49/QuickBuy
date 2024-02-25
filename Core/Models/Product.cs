namespace Core.Models
{
    public class Product: BaseEntity
    {
        public String Name { get; set; }

        public String Description { get; set; }

        public decimal Price { get; set; }

        public int StockQuantity { get; set; }

        public int CategoryId { get; set; }

        public Category Category { get; set; }

        public int SellerId { get; set; }

        public Seller Seller { get; set; }

        public ICollection<Review> Reviews { get; set; }

        public ICollection<OrderItem> OrderItems { get; set; }

        public ICollection<CartItem> CartItems { get; set; }

        public ICollection<WishList> WishLists { get; set; }
    }
}