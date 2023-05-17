namespace Assgiment_CSharp5._1_DataProcessing.Models
{
    public class Color_Product
    {
        public Guid IDColor_Product { get; set; }
        public string NameColor { get; set; }
        public string Description { get; set; }
        public int Status { get; set; }
        //___________________________________________________________________//
        public virtual ICollection<Product> Product { get; set; }
    }
}
