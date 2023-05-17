using Assgiment_CSharp5._1_DataProcessing.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Assgiment_CSharp5._1_DataProcessing.Configuration
{
    public class Role_Configuration : IEntityTypeConfiguration<Role>
    {
        public void Configure(EntityTypeBuilder<Role> builder)
        {
            builder.HasKey(c => c.IDRole);        }
    }
}
