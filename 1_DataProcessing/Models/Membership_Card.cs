namespace Assgiment_CSharp5._1_DataProcessing.Models
{
    public class Membership_Card//thẻ thành viên
    {
        public Guid IDMembership_Card { get; set; }
        public string CardNumber { get; set; }
        // Các thuộc tính khác của thẻ thành viên
//___________________________________________________________________//

        public virtual ICollection<Coupons> Coupons { get; set; }
        public virtual Membership_Level MembershipLevel { get; set; }
        public Guid? IDMembership_Level { get; set; }
    }
}
