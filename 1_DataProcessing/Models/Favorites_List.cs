namespace Assgiment_CSharp5._1_DataProcessing.Models
{
    public class Favorites_List//danh sách yêu thích
    {
        public Guid IDFavorites_List { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        //___________________________________________________________________//
        public ICollection<Client> Clients { get; set; }
        public Guid IDClient { get; set; }
        public ICollection<Combo> Combos { get; set; }
        public Guid IDCombo { get; set; }
        public ICollection<Product> Products { get; set; }
        public Guid IDProduct { get; set; }
    }
}
