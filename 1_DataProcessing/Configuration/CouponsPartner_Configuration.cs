using Assgiment_CSharp5._1_DataProcessing.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Assgiment_CSharp5._1_DataProcessing.Configuration
{
    public class CouponsPartner_Configuration : IEntityTypeConfiguration<Coupons_Partner>
    {
        public void Configure(EntityTypeBuilder<Coupons_Partner> builder)
        {
            builder.HasKey(c => c.IDCoupons_Partner);
        }
    }
}
