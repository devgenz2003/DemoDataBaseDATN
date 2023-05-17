using Assgiment_CSharp5._1_DataProcessing.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace Assgiment_CSharp5._1_DataProcessing.Configuration
{
    public class Images_Configuration : IEntityTypeConfiguration<Images>
    {
        public void Configure(EntityTypeBuilder<Images> builder)
        {
            builder.HasKey(c => c.IDImages);
            {
            }
        }
    }
}
