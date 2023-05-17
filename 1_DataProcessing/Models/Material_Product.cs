namespace Assgiment_CSharp5._1_DataProcessing.Models
{
    public class Material_Product
    {
        public Guid IDMaterial_Product { get; set; }
        public string MaterialName { get; set; }
        public string MaterialDescription { get; set; }
        public int Status { get; set; }
        // Các thuộc tính khác của vật liệu sản phẩm

        public virtual ICollection<Product> Products { get; set; }
    }
}
