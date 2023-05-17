namespace Assgiment_CSharp5._1_DataProcessing.Models
{
    public class Reviews//đánh giá sản phẩm đã mua
    {
        public Guid IDReviews { get; set; }
        public string Content { get; set; }
        public string Rating { get; set; }
        public DateTime Created_At { get; set; }
        public DateTime Updated_At { get; set; }
        //___________________________________________________________________//
        public ICollection<Client> Client { get; set; }
        public Guid IDClient { get; set; }
        public ICollection<Product> Products { get; set; }
        public Guid IDProduct { get; set; }
    }
}
