namespace Assgiment_CSharp5._1_DataProcessing.Models
{
    public class CategoryDetail//danh mục chi tiết
    {
        public Guid IDCategoryDetail { get; set; }
//___________________________________________________________________//
        public ICollection<Product> Products { get; set; }
        public Guid IDProduct { get; set; }
        public virtual Category Categories { get; set; }
        public Guid IDCategory { get; set; }
    }
}
