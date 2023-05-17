using Assgiment_CSharp5._1_DataProcessing.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Assgiment_CSharp5._1_DataProcessing.Configuration
{
    public class Address_Configuration : IEntityTypeConfiguration<Address>
    {
        public void Configure(EntityTypeBuilder<Address> builder)
        {
            builder.HasKey(c => c.IDAddress);
            //builder.HasOne(c => c.Bill).WithOne(c => c.).HasForeignKey<Bill>(c => c.IDAddress);
            builder.HasMany(c => c.Client).WithMany(c => c.Addresse);
        }
    }
}
