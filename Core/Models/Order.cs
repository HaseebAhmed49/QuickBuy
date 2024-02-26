namespace Core.Models
{
    public class Order: BaseEntity
	{
        public int? UserId { get; set; }

        public User? User { get; set; }

        public decimal TotalPrice { get; set; }

        public DateTime OrderDate { get; set; } = DateTime.Now;

        public Status Status { get; set; }

        public int? SellerId { get; set; }

        public Seller? Seller { get; set; }

        public ICollection<OrderItem> OrderItems { get; set; }

        public ICollection<Payment> Payments { get; set; }
    }

    public enum Status
    {
        Ready,
        Delievered,
        Processing,
    }
}