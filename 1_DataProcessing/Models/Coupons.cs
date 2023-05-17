namespace Assgiment_CSharp5._1_DataProcessing.Models
{
    public class Coupons//Phiếu giảm giá
    {
        public Guid IDCoupons { get; set; }
        public string Coupon_Code { get; set; } //mã giảm giá
        public string Discount_Type { get; set; } //loại giảm giá
        public string Discount_Amount { get; set; }//số tiền hoặc phần trăm
        public decimal Minimum_Spend { get; set; }//giá trị tối thiêu để sử dụng
        public decimal Maximum_Discount_Amount { get; set; }//Giới hạn giá trị giảm giá tối đa mà mã giảm giá có thể cung cấp.
        public DateTime Expiration_Date { get; set; }//ngày hết hạn
        public DateTime Create_At { get; set; }
        public DateTime Update_At { get; set; }
//___________________________________________________________________//
        public ICollection<Product> Products { get; set; }
        public Guid IDProduct { get; set; }
        public ICollection<Combo> Combos { get; set; }
        public Guid IDCombo { get; set; }
        public virtual Membership_Card MembershipCard { get; set; }
        public Guid? IDMembership_Card { get; set; }
    }
}
