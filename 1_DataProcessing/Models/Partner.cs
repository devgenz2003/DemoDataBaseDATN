namespace Assgiment_CSharp5._1_DataProcessing.Models
{
    public class Partner
    {
        public Guid IDPartner { get; set; }
        public string PartnerName { get; set;}
        public string PartnerDescription { get; set;}
//___________________________________________________________________//
        public virtual Coupons_Partner Coupons_Partner { get; set; }
        public Guid IDCoupons_Partner { get; set; }
    }
}
