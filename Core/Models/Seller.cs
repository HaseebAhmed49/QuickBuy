using System;

namespace Core.Models
{
    public class Seller: BaseEntity
    {
        public int UserId { get; set; }

        public User User { get; set; }

        public String BusinessName { get; set; }

        public String BusinessDescription { get; set; }

        public ICollection<SellerPerformance> SellerPerformances { get; set; }

        public ICollection<Product> Products { get; set; }

        public ICollection<Order> Orders { get; set; }

        public ICollection<Notification> Notifications { get; set; }
    }
}