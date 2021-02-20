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
            this.Configuration.LazyLoadingEnabled = false;
            this.Configuration.ProxyCreationEnabled = false;
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Order> Orders { get; set; }


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

        }
    }

    public class OrderMap : EntityTypeConfiguration<Order> { 
        public OrderMap()
        {
            ToTable("Orders");

            /*
            HasKey(x => x.OrderID);
            Property(x => x.OrderID).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            */
            HasRequired(x => x.Customer).WithMany(x => x.Orders).HasForeignKey(x => x.CustomerID);
            
        }
    }

    public class CustomerMap : EntityTypeConfiguration<Customer>
    {
        public CustomerMap()
        {

        }
    }
}
