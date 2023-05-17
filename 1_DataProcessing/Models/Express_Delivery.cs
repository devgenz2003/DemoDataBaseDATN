namespace Assgiment_CSharp5._1_DataProcessing.Models
{
    public class Express_Delivery//giao hàng nhanh
    {
        public Guid IDExpress_Delivery { get; set; }
        public string Sender_Name { get; set; }
        public string Sender_Address { get; set; }
        public string Receiver_Name { get; set; }
        public string Receiver_Address { get; set; }
        public DateTime Delivery_Date { get; set; }//ngày giao dự kiến
        public DateTime Actual_Delivery_Date { get; set; } // ngày giao thực tế nếu có
        public int Delivery_Status { get; set; }//trạng thái giao hàng
        public decimal Shipping_Cost { get; set; }//phí vận chuyển
        public int Payment_Status { get; set; }//trạng thái thanh toán
//___________________________________________________________________//
        public virtual Bill Bill { get; set; }
        public Guid IDBill { get; set; }
        public ICollection<Client> Client { get; set; }
        public Guid IDClient { get; set; }

    }
}
