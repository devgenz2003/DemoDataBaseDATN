namespace Assgiment_CSharp5._1_DataProcessing.Models
{
    public class Ordel //Giỏ hàng
    {
        public Guid IDOrdel { get; set; }
        public DateTime OrderDate { get; set; }
        public decimal TotalPrice { get; set; }
        public int Status { get; set; }
//___________________________________________________________________//
        public ICollection<OrdelDetail> OrdelDetails { get; set; }
        public virtual Client Client { get; set; }
        public Guid IDClient { get; set; }
    }
}
