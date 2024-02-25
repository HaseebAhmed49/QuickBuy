﻿namespace Core.Models
{
    public class WishListItem: BaseEntity
	{
        public int WishListId { get; set; }

        public WishList WishList { get; set; }

        public int ProductId { get; set; }

        public Product Product { get; set; }
    }
}


