using Assgiment_CSharp5._1_DataProcessing.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Assgiment_CSharp5._1_DataProcessing.Configuration
{
    public class SizeProduct_Configuration : IEntityTypeConfiguration<Size_Product>
    {
        public void Configure(EntityTypeBuilder<Size_Product> builder)
        {
            builder.HasKey(c => c.IDSize_Product);        }
    }
}
