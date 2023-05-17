using Assgiment_CSharp5._1_DataProcessing.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Assgiment_CSharp5._1_DataProcessing.Configuration
{
    public class OrdelDetail_Configuration : IEntityTypeConfiguration<OrdelDetail>
    {
        public void Configure(EntityTypeBuilder<OrdelDetail> builder)
        {
            builder.HasKey(c => c.IDOrdeltDetail);        }
    }
}
