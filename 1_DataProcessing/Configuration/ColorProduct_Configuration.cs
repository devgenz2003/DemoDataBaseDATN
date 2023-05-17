using Assgiment_CSharp5._1_DataProcessing.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Assgiment_CSharp5._1_DataProcessing.Configuration
{
    public class ColorProduct_Configuration : IEntityTypeConfiguration<Color_Product>
    {
        public void Configure(EntityTypeBuilder<Color_Product> builder)
        {
            builder.HasKey(c => c.IDColor_Product);
        }
    }
}
