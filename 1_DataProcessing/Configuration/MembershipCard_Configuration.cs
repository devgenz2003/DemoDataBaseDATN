using Assgiment_CSharp5._1_DataProcessing.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Assgiment_CSharp5._1_DataProcessing.Configuration
{
    public class MembershipCard_Configuration : IEntityTypeConfiguration<Membership_Card>
    {
        public void Configure(EntityTypeBuilder<Membership_Card> builder)
        {
            builder.HasKey(c => c.IDMembership_Card);        }
    }
}
