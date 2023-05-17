using Assgiment_CSharp5._1_DataProcessing.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Assgiment_CSharp5._1_DataProcessing.Configuration
{
    public class Product_Configuration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasKey(c => c.IDProduct);
            builder.Property(c => c.Name).HasMaxLength(255).IsRequired();
            builder.Property(c => c.Description).HasMaxLength(255).IsRequired();
            builder.Property(C => C.Quantity).IsRequired();
            builder.Property(c => c.Price).IsRequired();
            builder.Property(c => c.PriceCeiling).IsRequired();
            builder.Property(c => c.Status).IsRequired();
            //_________________________________________________________________________________________//
            builder.HasMany(c => c.Color_Product).WithMany(c => c.Product);
            builder.HasMany(c => c.ComboDetail).WithMany(c => c.Product);
            builder.HasOne(c => c.Size_Product).WithMany(c => c.Products).HasForeignKey(c => c.IDProduct);
            builder.HasMany(c => c.Material_Product).WithMany(c => c.Products);
            builder.HasMany(c => c.Producer_Product).WithMany(c => c.Products);
            builder.HasMany(c => c.CategoryDetail).WithMany(c => c.Products);
            builder.HasMany(c => c.OrdelDetail).WithMany(c => c.Products);
            builder.HasMany(c => c.BillDetails).WithMany(c => c.Products);
            builder.HasMany(c => c.Coupons).WithMany(c => c.Products);
            builder.HasMany(c => c.Images).WithMany(c => c.Products);
        }
    }
}
