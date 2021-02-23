using Data_Service.Models;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration;

namespace Data_Service.Database
{
    public partial class ContextGrabber : DbContext
    {
        public ContextGrabber()
            : base("name=ContextGrabber")
        {
            this.Configuration.LazyLoadingEnabled = true;
            this.Configuration.ProxyCreationEnabled = false;
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new OrderMap());
            
            base.OnModelCreating(modelBuilder);
        }
    }

    public class ProductMap: EntityTypeConfiguration<Product>
    {
        public ProductMap()
        {
            ToTable("Products");


            HasKey(x => x.ProductID);
            Property(x => x.ProductID).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            //HasRequired(x => x.OrderDetails).WithMany(x => x.).HasForeignKey(x => x.CustomerID);

        }
    }

    public class OrderMap : EntityTypeConfiguration<Order> { 
        public OrderMap()
        {
            ToTable("Orders");

            
            HasKey(x => x.OrderID);
            Property(x => x.OrderID).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            
            HasRequired(x => x.Customer).WithMany(x => x.Orders).HasForeignKey(x => x.CustomerID);

            
        }
    }

    public class OrderDetailMap: EntityTypeConfiguration<OrderDetail>
    {
        public OrderDetailMap()
        {
            ToTable("OrderDetails");

            HasKey(x => x.OrderDetailID);
            Property(x => x.OrderDetailID).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            HasRequired(x => x.Order).WithMany(x => x.Details).HasForeignKey(x => x.OrderID);
        }
    }

    public class CustomerMap : EntityTypeConfiguration<Customer>
    {
        public CustomerMap()
        {
            ToTable("Customers");
            HasKey(x => x.CustomerID);
            Property(x => x.CustomerID).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
        }
    }
}
