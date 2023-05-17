namespace Assgiment_CSharp5._1_DataProcessing.Models
{
    public class Size_Product
    {
        public Guid IDSize_Product { get; set; }
        public string NameSize { get; set; }
        public string DescriptionSize { get; set; }
        public int Status { get; set; }
        //___________________________________________________________________//
        public virtual ICollection<Product> Products { get; set; }
    }
}
