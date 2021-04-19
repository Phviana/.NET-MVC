using Dev.Business.Models.Products;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dev.Infra.Data.Mappings
{
    public class ProductConfig : EntityTypeConfiguration<Product>
    {
        public ProductConfig()
        {
            HasKey(p => p.Id);

            Property(a => a.Name)
               .IsRequired()
               .HasMaxLength(100);

            Property(a => a.Description)
               .IsRequired()
               .HasMaxLength(100);

            Property(a => a.Image)
               .IsRequired()
               .HasMaxLength(100);

            HasRequired(p => p.Supplier)
               .WithMany(s => s.Products)
               .HasForeignKey(p => p.SupplierId);

            ToTable("Products");
        }
    }
}
