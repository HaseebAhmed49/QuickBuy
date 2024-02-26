
namespace Core.Models
{
    public class SellerPerformance: BaseEntity
    {
        public int? SellerId { get; set; }

        public Seller? Seller { get; set; }

        public int Rating { get; set; }

        public int TotalSales { get; set; }

        public int TotalFeedbacks { get; set; }
    }
}
