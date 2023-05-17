namespace Assgiment_CSharp5._1_DataProcessing.Models
{
    public class Combo//Combo sản phẩm
    {
        public Guid IDCombo { get; set; }
        public string ComboName { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
        public int Status { get; set; }
        //___________________________________________________________________//
        public ICollection<ComboDetail> ComboDetail { get; set; }
        public ICollection<Coupons> Coupons { get; set; }
        public Guid IDCoupons { get; set; }
    }
}
