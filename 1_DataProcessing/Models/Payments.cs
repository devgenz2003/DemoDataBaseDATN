namespace Assgiment_CSharp5._1_DataProcessing.Models
{
    public class Payments//hình thức thanh toán
    {
        public Guid IDPayments { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        //public string Type { get; set; }

//___________________________________________________________________//
        public virtual ICollection<Bill> Bills { get; set; }
        public Guid IDBill { get; set; }
        public virtual Partner Partner { get; set; }
        public Guid IDPartner { get; set; }
    }
}
