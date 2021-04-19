using Dev.Business.Models.Products;
using Dev.Business.Models.Suppliers;
using Dev.Infra.Data.Mappings;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dev.Infra.Data.Context
{
    public class MyDBContext : DbContext
    {
        public MyDBContext() : base("DefaultConnection")
        {
            Configuration.ProxyCreationEnabled = false;
            Configuration.LazyLoadingEnabled = false;
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<Supplier> Supplies { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();

            modelBuilder.Properties<string>()
                .Configure(p => p.HasColumnType("varchar")
                .HasMaxLength(100));

            modelBuilder.Configurations.Add(new SupplierConfig());
            modelBuilder.Configurations.Add(new AddressConfig());
            modelBuilder.Configurations.Add(new ProductConfig());

            base.OnModelCreating(modelBuilder);
        }

    }
}
