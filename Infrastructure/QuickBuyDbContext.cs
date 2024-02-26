using System;
using Microsoft.EntityFrameworkCore;
using Core.Models;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Net;
using System.Reflection;

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
            modelBuilder.Entity<User>()
            .HasMany(u => u.ShoppingCarts)
            .WithOne(sc => sc.User)
            .HasForeignKey(u => u.UserId)
            .IsRequired(false);

            modelBuilder.Entity<User>()
            .HasMany(u => u.Orders)
            .WithOne(o => o.User)
            .HasForeignKey(u => u.UserId)
            .IsRequired(false);

            modelBuilder.Entity<User>()
            .HasMany(u => u.Reviews)
            .WithOne(r => r.User)
            .HasForeignKey(u => u.UserId)
            .IsRequired(false);

             modelBuilder.Entity<User>()
            .HasMany(u => u.Notifications)
            .WithOne(n => n.User)
            .HasForeignKey(u => u.UserId)
            .IsRequired(false);

            modelBuilder.Entity<User>()
           .HasMany(u => u.WishLists)
           .WithOne(wl => wl.User)
           .HasForeignKey(u => u.UserId)
           .IsRequired(false);

             modelBuilder.Entity<Seller>()
            .HasMany(s => s.SellerPerformances)
            .WithOne(sp => sp.Seller)
            .HasForeignKey(sp => sp.SellerId)
            .IsRequired(false);

            modelBuilder.Entity<Seller>()
           .HasMany(s => s.Products)
           .WithOne(p => p.Seller)
           .HasForeignKey(p => p.SellerId)
           .IsRequired(false);

            modelBuilder.Entity<Seller>()
           .HasMany(s => s.Orders)
           .WithOne(o => o.Seller)
           .HasForeignKey(o => o.SellerId)
           .IsRequired(false);

            modelBuilder.Entity<Seller>()
           .HasMany(s => s.Notifications)
           .WithOne(n => n.Seller)
           .HasForeignKey(n => n.SellerId)
           .IsRequired(false);

            //*Product to Review
            //*Product to OrderItem
            //*Product to CartItem

            modelBuilder.Entity<Product>()
           .HasMany(p => p.Reviews)
           .WithOne(r => r.Product)
           .HasForeignKey(r => r.ProductId)
           .IsRequired(false);

            modelBuilder.Entity<Product>()
           .HasMany(p => p.OrderItems)
           .WithOne(oi => oi.Product)
           .HasForeignKey(oi => oi.ProductId)
           .IsRequired(false);

            modelBuilder.Entity<Product>()
            .HasMany(p => p.CartItems)
            .WithOne(ci => ci.Product)
            .HasForeignKey(ci => ci.ProductId)
            .IsRequired(false);

            //*Category to Product

            modelBuilder.Entity<Category>()
            .HasMany(c => c.Products)
            .WithOne(p => p.Category)
            .HasForeignKey(p => p.CategoryId)
            .IsRequired(false);

            //*ShoppingCart to CartItem

            modelBuilder.Entity<ShoppingCart>()
            .HasMany(sc => sc.CartItems)
            .WithOne(ci => ci.ShoppingCart)
            .HasForeignKey(ci => ci.ShoppingCartId)
            .IsRequired(false);

            //*Order to OrderItem
            //*Order to Payment

            modelBuilder.Entity<Order>()
            .HasMany(o => o.OrderItems)
            .WithOne(oi => oi.Order)
            .HasForeignKey(oi => oi.OrderId)
            .IsRequired(false);

            modelBuilder.Entity<Order>()
            .HasMany(o => o.Payments)
            .WithOne(p => p.Order)
            .HasForeignKey(p => p.OrderId)
            .IsRequired(false);

            //*Wishlist to WishlistItem

            modelBuilder.Entity<WishList>()
            .HasMany(o => o.WishListItems)
            .WithOne(wl => wl.WishList)
            .HasForeignKey(wl => wl.WishListId)
            .IsRequired(false);

            //*Address to User
            modelBuilder.Entity<ShippingAddress>()
            .HasMany(o => o.Users)
            .WithOne(sa => sa.ShippingAddress)
            .HasForeignKey(sa => sa.AddressId)
            .IsRequired(false);


            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

            //        *Many - to - Many relationships:
            //        *User to Product(through Wishlist)
            //*User to Product(through CartItem)
            //*User to Order(through ShoppingCart)
            //*Product to Seller(representing multiple sellers for a product)


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