using Dev.Business.Models.Suppliers;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Infrastructure.Annotations;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dev.Infra.Data.Mappings
{
    public class SupplierConfig : EntityTypeConfiguration<Supplier>
    {
        public SupplierConfig()
        {
            HasKey(s => s.Id);

            Property(s => s.Name)
                .IsRequired()
                .HasMaxLength(200);

            Property(s => s.Document)
                .IsRequired()
                .HasMaxLength(14)
                .HasColumnAnnotation("IX_Document",
                    new IndexAnnotation(new IndexAttribute { IsUnique = true }));

            HasRequired(s => s.Address)
                .WithRequiredPrincipal(a => a.Supplier);

            ToTable("Suppliers");
        }
    }
}
