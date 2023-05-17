using Assgiment_CSharp5._1_DataProcessing.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Assgiment_CSharp5._1_DataProcessing.Configuration
{
    public class Partner_Configuration : IEntityTypeConfiguration<Partner>
    {
        public void Configure(EntityTypeBuilder<Partner> builder)
        {
            builder.HasKey(c => c.IDPartner);
            builder.HasOne(c=>c.Coupons_Partner).WithOne(c => c.Partner).HasForeignKey<Partner>(c => c.IDPartner);
        }
    }
}
