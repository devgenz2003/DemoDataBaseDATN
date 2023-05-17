using Assgiment_CSharp5._1_DataProcessing.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Assgiment_CSharp5._1_DataProcessing.Configuration
{
    public class ProducerProduct_Configuration : IEntityTypeConfiguration<Producer_Product>
    {
        public void Configure(EntityTypeBuilder<Producer_Product> builder)
        {
            builder.HasKey(c => c.IDProducer_Product);
        }
    }
}
