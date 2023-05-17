using Assgiment_CSharp5._1_DataProcessing.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Assgiment_CSharp5._1_DataProcessing.Configuration
{
    public class ComboDetail_Configuration : IEntityTypeConfiguration<ComboDetail>
    {
        public void Configure(EntityTypeBuilder<ComboDetail> builder)
        {
            builder.HasKey(c => c.IDComboDetail);        }
    }
}
