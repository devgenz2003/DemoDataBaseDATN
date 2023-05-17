using Assgiment_CSharp5._1_DataProcessing.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Assgiment_CSharp5._1_DataProcessing.Configuration
{
    public class Review_Configuration : IEntityTypeConfiguration<Reviews>
    {
        public void Configure(EntityTypeBuilder<Reviews> builder)
        {
            builder.HasKey(c => c.IDReviews);        }
    }
}
