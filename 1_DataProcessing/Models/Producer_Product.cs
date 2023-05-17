namespace Assgiment_CSharp5._1_DataProcessing.Models
{
    public class Producer_Product//nhà sản xuất
    {
        public Guid IDProducer_Product { get; set; }
        public string Producer_ProductName { get; set;}
        public string Producer_ProductDescription { get; set;}
        public string Producer_ProductStatus { get; set;}
        public string Producer_ProductType { get; set;}
//___________________________________________________________________//
        public ICollection<Product> Products { get; set;}
    }
}
