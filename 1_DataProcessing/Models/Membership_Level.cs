namespace Assgiment_CSharp5._1_DataProcessing.Models
{
    public class Membership_Level//hạng thành viên
    {
        public Guid IDMembership_Level { get; set; }
        public string LevelName { get; set; }// Các thuộc tính khác của cấp độ thành viên
        
 //___________________________________________________________________//
        public virtual ICollection<Membership_Card> MembershipCards { get; set; }
    }
}

