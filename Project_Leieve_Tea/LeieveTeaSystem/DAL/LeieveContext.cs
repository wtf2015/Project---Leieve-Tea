namespace LeieveTeaSystem.DAL
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;
    using LeieveTea.Data.Entities;

    public partial class LeieveContext : DbContext
    {
        public LeieveContext()
            : base("name=LeieveDB")
        {
        }

        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Coupon> Coupons { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<MenuItem> MenuItems { get; set; }
        public virtual DbSet<OrderDetail> OrderDetails { get; set; }
        public virtual DbSet<PaymentType> PaymentTypes { get; set; }
        public virtual DbSet<position> positions { get; set; }
        public virtual DbSet<ReceiveOrder> ReceiveOrders { get; set; }
        public virtual DbSet<Schedule> Schedules { get; set; }
        public virtual DbSet<ShoppingCart> ShoppingCarts { get; set; }
        public virtual DbSet<ShoppingCartItem> ShoppingCartItems { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<Coupon>()
                .Property(e => e.CouponName)
                .IsUnicode(false);

            modelBuilder.Entity<Customer>()
                .Property(e => e.FirstName)
                .IsUnicode(false);

            modelBuilder.Entity<Customer>()
                .Property(e => e.LastName)
                .IsUnicode(false);

            modelBuilder.Entity<Customer>()
                .Property(e => e.Address)
                .IsUnicode(false);

            modelBuilder.Entity<Customer>()
                .Property(e => e.City)
                .IsUnicode(false);

            modelBuilder.Entity<Customer>()
                .Property(e => e.Province)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Customer>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<Customer>()
                .Property(e => e.PostalCode)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Customer>()
                .Property(e => e.Phone)
                .IsUnicode(false);

            modelBuilder.Entity<Employee>()
                .Property(e => e.FirstName)
                .IsUnicode(false);

            modelBuilder.Entity<Employee>()
                .Property(e => e.LastName)
                .IsUnicode(false);

            modelBuilder.Entity<Employee>()
                .Property(e => e.Phone)
                .IsUnicode(false);

            modelBuilder.Entity<MenuItem>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<MenuItem>()
                .Property(e => e.SellingPrice)
                .HasPrecision(19, 4);

            modelBuilder.Entity<OrderDetail>()
                .Property(e => e.SellingPrice)
                .HasPrecision(19, 4);

            modelBuilder.Entity<PaymentType>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<position>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<ReceiveOrder>()
                .Property(e => e.FirstName)
                .IsUnicode(false);

            modelBuilder.Entity<ReceiveOrder>()
                .Property(e => e.Address)
                .IsUnicode(false);

            modelBuilder.Entity<ReceiveOrder>()
                .Property(e => e.City)
                .IsUnicode(false);

            modelBuilder.Entity<ReceiveOrder>()
                .Property(e => e.Province)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ReceiveOrder>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<ReceiveOrder>()
                .Property(e => e.PostalCode)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ReceiveOrder>()
                .Property(e => e.Phone)
                .IsUnicode(false);

            modelBuilder.Entity<ReceiveOrder>()
                .Property(e => e.DeliveryType)
                .IsUnicode(false);

            modelBuilder.Entity<ReceiveOrder>()
                .Property(e => e.GST)
                .HasPrecision(19, 4);

            modelBuilder.Entity<ReceiveOrder>()
                .Property(e => e.DeliveryFee)
                .HasPrecision(19, 4);

            modelBuilder.Entity<ReceiveOrder>()
                .Property(e => e.PaymentType)
                .HasPrecision(19, 4);
        }
    }
}
