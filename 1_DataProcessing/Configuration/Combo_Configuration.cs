using Assgiment_CSharp5._1_DataProcessing.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Assgiment_CSharp5._1_DataProcessing.Configuration
{
    public class Combo_Configuration : IEntityTypeConfiguration<Combo>
    {
        public void Configure(EntityTypeBuilder<Combo> builder)
        {
            builder.HasKey(c => c.IDCombo);        }
    }
}
