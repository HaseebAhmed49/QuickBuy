namespace Core.Models
{
    public class Payment: BaseEntity
    {
        public int? OrderId { get; set; }

        public Order? Order { get; set; }

        public decimal Amount { get; set; }

        public PaymentMethod PaymentMethod { get; set; }

        public DateTime TransactionDate { get; set; } = DateTime.Now;
    }

    public enum PaymentMethod
    {
        Cash,
        Card
    }
}
