using Assgiment_CSharp5._1_DataProcessing.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Assgiment_CSharp5._1_DataProcessing.Configuration
{
    public class FavoritesList_Configuration : IEntityTypeConfiguration<Favorites_List>
    {
        public void Configure(EntityTypeBuilder<Favorites_List> builder)
        {
            builder.HasKey(c => c.IDFavorites_List);        }
    }
}
