namespace Assgiment_CSharp5._1_DataProcessing.Models
{
    public class BillDetail //Hóa đơn chi tiết
    {
        public Guid IDBillDetail { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }

//___________________________________________________________________//
        public ICollection<Product> Products { get; set; }
        public Guid IDProduct { get; set; }
        public virtual Bill Bill { get; set; }
        public Guid IDBill { get; set; }
    }
}
