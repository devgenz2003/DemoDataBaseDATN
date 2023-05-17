using Assgiment_CSharp5._1_DataProcessing.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Assgiment_CSharp5._1_DataProcessing.Configuration
{
    public class MembershipLevel_Configuration : IEntityTypeConfiguration<Membership_Level>
    {
        public void Configure(EntityTypeBuilder<Membership_Level> builder)
        {
            builder.HasKey(c => c.IDMembership_Level);        }
    }
}
