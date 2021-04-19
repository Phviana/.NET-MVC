using Dev.Business.Models.Suppliers;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dev.Infra.Data.Mappings
{
    public class AddressConfig : EntityTypeConfiguration<Address>
    {
        public AddressConfig()
        {
            HasKey(a => a.Id);

            Property(a => a.AddressLineOne)
                .IsRequired()
                .HasMaxLength(200);

            Property(a => a.Country)
                .IsRequired()
                .HasMaxLength(100);

            Property(a => a.Number)
                .IsRequired()
                .HasMaxLength(50);

            Property(a => a.ZipCode)
                .IsRequired()
                .HasMaxLength(200);

            Property(a => a.City)
                .IsRequired()
                .HasMaxLength(100);

            Property(a => a.State)
                .IsRequired()
                .HasMaxLength(100);

            ToTable("Addresses");


        }
    }
}
