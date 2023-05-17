namespace Assgiment_CSharp5._1_DataProcessing.Models
{
    public class Bill //Hóa đơn
    {
        public Guid IDBill { get; set; }
        public string CodeBill { get; set; }
        public DateTime OrderDate { get; set; }
        public decimal TotalPrice { get; set; }
//___________________________________________________________________//
        public virtual Client Client { get; set; }
        public Guid IDClient { get; set; }
        public ICollection<BillDetail> BillDetail { get; set; }    
        public virtual Address Address { get; set; }
        public Guid IDAddress { get; set; }
    }
}
