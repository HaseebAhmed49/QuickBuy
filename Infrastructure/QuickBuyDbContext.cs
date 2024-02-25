using System;
using Microsoft.EntityFrameworkCore;
using Core.Models;

namespace Infrastructure
{
	public class QuickBuyDbContext: DbContext
	{
        public QuickBuyDbContext(DbContextOptions<QuickBuyDbContext> options): base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Configure one-to-many relationship between Author and Book
            modelBuilder.Entity<ShoppingCart>()
                .HasOne(s => s.User)
                .WithMany(u => u.ShoppingCarts)
                .HasForeignKey(s => s.UserId);

            modelBuilder.Entity<Order>()
                .HasOne(o => o.User)
                .WithMany(u => u.Orders)
                .HasForeignKey(o => o.UserId);

            modelBuilder.Entity<Review>()
                .HasOne(r => r.User)
                .WithMany(u => u.Reviews)
                .HasForeignKey(r => r.UserId);

            modelBuilder.Entity<Notification>()
                .HasOne(n => n.User)
                .WithMany(u => u.Notifications)
                .HasForeignKey(n => n.UserId);

            modelBuilder.Entity<WishList>()
                .HasOne(wl => wl.User)
                .WithMany(u => u.WishLists)
                .HasForeignKey(wl => wl.UserId);

            modelBuilder.Entity<SellerPerformance>()
                .HasOne(sp => sp.Seller)
                .WithMany(s => s.SellerPerformances)
                .HasForeignKey(sp => sp.SellerId);

            modelBuilder.Entity<Product>()
                .HasOne(p => p.Seller)
                .WithMany(s => s.Products)
                .HasForeignKey(p => p.SellerId);

            modelBuilder.Entity<Order>()
                .HasOne(o => o.Seller)
                .WithMany(s => s.Orders)
                .HasForeignKey(o => o.SellerId);

            modelBuilder.Entity<Notification>()
                .HasOne(n => n.Seller)
                .WithMany(s => s.Notifications)
                .HasForeignKey(n => n.SellerId);

            modelBuilder.Entity<Review>()
                .HasOne(r => r.Product)
                .WithMany(p => p.Reviews)
                .HasForeignKey(r => r.ProductId);

            modelBuilder.Entity<OrderItem>()
                .HasOne(oi => oi.Product)
                .WithMany(p => p.OrderItems)
                .HasForeignKey(oi => oi.ProductId);

            modelBuilder.Entity<CartItem>()
                .HasOne(ci => ci.Product)
                .WithMany(p => p.CartItems)
                .HasForeignKey(oi => oi.ProductId);

            modelBuilder.Entity<Product>()
                .HasOne(p => p.Category)
                .WithMany(p => p.Products)
                .HasForeignKey(p => p.CategoryId);

            modelBuilder.Entity<CartItem>()
                .HasOne(ci => ci.ShoppingCart)
                .WithMany(sc => sc.CartItems)
                .HasForeignKey(ci => ci.ShoppingCartId);

            modelBuilder.Entity<OrderItem>()
                .HasOne(oi => oi.Order)
                .WithMany(o => o.OrderItems)
                .HasForeignKey(oi => oi.OrderId);

            modelBuilder.Entity<Payment>()
                .HasOne(p => p.Order)
                .WithMany(o => o.Payments)
                .HasForeignKey(p => p.OrderId);

            modelBuilder.Entity<WishListItem>()
                .HasOne(wl => wl.WishList)
                .WithMany(w => w.WishListItems)
                .HasForeignKey(wl => wl.WishListId);

            modelBuilder.Entity<WishList>()
                .HasKey(wl => new { wl.UserId, wl.ProductId });

            modelBuilder.Entity<WishList>()
                .HasOne(wl => wl.User)
                .WithMany(u => u.WishLists)
                .HasForeignKey(wl => wl.UserId);

            modelBuilder.Entity<WishList>()
                .HasOne(wl => wl.Product)
                .WithMany(p => p.WishLists)
                .HasForeignKey(wl => wl.ProductId);

            //// Configure many-to-many relationship between Student and Course
            //modelBuilder.Entity<StudentCourse>()
            //    .HasKey(sc => new { sc.StudentId, sc.CourseId });

            //modelBuilder.Entity<StudentCourse>()
            //    .HasOne(sc => sc.Student)
            //    .WithMany(s => s.StudentCourses)
            //    .HasForeignKey(sc => sc.StudentId);

            //modelBuilder.Entity<StudentCourse>()
            //    .HasOne(sc => sc.Course)
            //    .WithMany(c => c.StudentCourses)
            //    .HasForeignKey(sc => sc.CourseId);
        }

        public DbSet<CartItem> CartItems { get; set; }

        public DbSet<Category> Categories { get; set; }

        public DbSet<Notification> Notifications { get; set; }

        public DbSet<Order> Orders { get; set; }

        public DbSet<OrderItem> OrderItems { get; set; }

        public DbSet<Payment> Payments { get; set; }

        public DbSet<Product> Products { get; set; }

        public DbSet<Review> Reviews { get; set; }

        public DbSet<Seller> Sellers { get; set; }

        public DbSet<SellerPerformance> SellerPerformances { get; set; }

        public DbSet<ShippingAddress> ShippingAddresses { get; set; }

        public DbSet<ShoppingCart> ShoppingCarts { get; set; }

        public DbSet<User> Users { get; set; }

        public DbSet<WishList> WishLists { get; set; }

        public DbSet<WishListItem> WishListItems { get; set; }
    }
}