namespace Core.Models
{
    public class Review: BaseEntity
    {
        public int? ProductId { get; set; }

        public Product? Product { get; set; }

        public int? UserId { get; set; }

        public User? User { get; set; }

        public int Rating { get; set; }

        public String Comment { get; set; }

        public DateTime Date { get; set; } = DateTime.Now;
    }
}

