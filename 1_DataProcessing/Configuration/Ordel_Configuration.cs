using Assgiment_CSharp5._1_DataProcessing.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Assgiment_CSharp5._1_DataProcessing.Configuration
{
    public class Ordel_Configuration : IEntityTypeConfiguration<Ordel>
    {
        public void Configure(EntityTypeBuilder<Ordel> builder)
        {
            builder.HasKey(c => c.IDOrdel);        }
    }
}
