
namespace Core.Models
{
    public class Notification: BaseEntity
    {
        public int UserId { get; set; }

        public User User { get; set; }

        public String Content { get; set; }

        public bool IsRead { get; set; }

        public DateTime TimeStamp { get; set; } = DateTime.Now;

        public int SellerId { get; set; }

        public Seller Seller { get; set; }
    }
}