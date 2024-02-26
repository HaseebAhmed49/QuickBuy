namespace Core.Models
{
    public class ShoppingCart: BaseEntity
	{
        public decimal TotalPrice { get; set; }

        public int? UserId { get; set; }

        public User? User { get; set; }

        public ICollection<CartItem> CartItems { get; set; }
    }
}

