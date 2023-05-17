namespace Assgiment_CSharp5._1_DataProcessing.Models
{
    public class Coupons_Partner
    {
        public Guid IDCoupons_Partner { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string KOD { get; set; } // loại giảm giá
        public int Status { get; set; }
//___________________________________________________________________//
        public virtual Partner Partner { get; set; }
    }
}
