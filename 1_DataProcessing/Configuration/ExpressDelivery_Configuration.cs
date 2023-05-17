using Assgiment_CSharp5._1_DataProcessing.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Assgiment_CSharp5._1_DataProcessing.Configuration
{
    public class ExpressDelivery_Configuration : IEntityTypeConfiguration<Express_Delivery>
    {
        public void Configure(EntityTypeBuilder<Express_Delivery> builder)
        {
            builder.HasKey(c => c.IDExpress_Delivery);        }
    }
}
