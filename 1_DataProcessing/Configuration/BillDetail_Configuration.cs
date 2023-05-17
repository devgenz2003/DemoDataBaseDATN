using Assgiment_CSharp5._1_DataProcessing.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Assgiment_CSharp5._1_DataProcessing.Configuration
{
    public class BillDetail_Configuration : IEntityTypeConfiguration<BillDetail>
    {
        public void Configure(EntityTypeBuilder<BillDetail> builder)
        {
            builder.HasKey(c => c.IDBillDetail);
            builder.HasOne(c => c.Bill).WithMany(c => c.BillDetail).HasForeignKey(c => c.IDBillDetail);
            builder.HasMany(c => c.Products).WithMany(c => c.BillDetails);
        }
    }
}
