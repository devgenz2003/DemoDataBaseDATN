namespace Assgiment_CSharp5._1_DataProcessing.Models
{
    public class Category //Danh mục
    {
        public Guid IDCategory { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

//___________________________________________________________________//
        //public ICollection<Product> Products { get; set; }
        //public Guid IDProduct { get; set; }
        public ICollection<CategoryDetail> CategoryDetail { get; set; }
        public ICollection<Combo> Combos { get; set; }
        public Guid IDCombo { get; set; }
    }
}
