using Assgiment_CSharp5._1_DataProcessing.Models;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace Assgiment_CSharp5._1_DataProcessing.Context
{
    public class Assgiment_Csharp5_Context : DbContext
    {
        public Assgiment_Csharp5_Context()
        {
            
        }
        public Assgiment_Csharp5_Context(DbContextOptions options) : base(options)
        {
            
        }

        public DbSet<Address> Address { get; set; }
        public DbSet<Bill> Bill { get; set; }
        public DbSet<BillDetail> BillDetail { get; set; }
        public DbSet<Category> Category { get; set; }
        public DbSet<CategoryDetail> CategoryDetail { get; set; }
        public DbSet<Client> Client { get; set; }
        public DbSet<Color_Product> Color_Product { get; set; }
        public DbSet<Combo> Combo { get; set; }
        public DbSet<ComboDetail> ComboDetail { get; set; }
        public DbSet<Coupons> Coupons { get; set; }
        public DbSet<Coupons_Partner> Coupons_Partner { get; set; }
        public DbSet<Express_Delivery> Express_Delivery { get; set; }
        public DbSet<Favorites_List> Favorites_List { get; set; }
        public DbSet<Images> Images { get; set; }
        public DbSet<Material_Product> Material_Product { get; set; }
        public DbSet<Membership_Card> Membership_Card { get; set; }
        public DbSet<Membership_Level> Membership_Level { get; set; }
        public DbSet<Ordel> Ordel { get; set; }
        public DbSet<OrdelDetail> OrdelDetail { get; set; }
        public DbSet<Partner> Partner { get; set; }
        public DbSet<Payments> Payments { get; set; }
        public DbSet<Personnel> Personnel { get; set; }
        public DbSet<Producer_Product> Producer_Product { get; set; }
        public DbSet<Product> Product { get; set; }
        public DbSet<Reviews> Reviews { get; set; }
        public DbSet<Role> Role { get; set; }
        public DbSet<Size_Product> Size_Product { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=DATNT;Initial Catalog=Assignment_C5;Integrated Security=True");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}
