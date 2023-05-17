using Assgiment_CSharp5._1_DataProcessing.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Assgiment_CSharp5._1_DataProcessing.Configuration
{
    public class CategoryDetail_Configuation : IEntityTypeConfiguration<CategoryDetail>
    {
        public void Configure(EntityTypeBuilder<CategoryDetail> builder)
        {
            builder.HasKey(c => c.IDCategoryDetail);
            builder.HasOne(c=>c.Categories).WithMany(c=>c.CategoryDetail).HasForeignKey(c=>c.IDCategoryDetail);
        }
    }
}
