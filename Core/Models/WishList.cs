namespace Core.Models
{
    public class WishList: BaseEntity
    {
        public int? UserId { get; set; }

        public User? User { get; set; }

        public int ProductId { get; set; }

        public Product Product { get; set; }

        public ICollection<WishListItem> WishListItems { get; set; }
    }
}