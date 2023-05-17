using Assgiment_CSharp5._1_DataProcessing.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Assgiment_CSharp5._1_DataProcessing.Configuration
{
    public class MaterialProduct_Configurationcs : IEntityTypeConfiguration<Material_Product>
    {
        public void Configure(EntityTypeBuilder<Material_Product> builder)
        {
            builder.HasKey(c => c.IDMaterial_Product);        }
    }
}
