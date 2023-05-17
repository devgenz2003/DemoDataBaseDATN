using System.ComponentModel.DataAnnotations;

namespace Assgiment_CSharp5._1_DataProcessing.Models
{
    public class Client//Khách hàng
    {
        public Guid IDClient { get; set; }
        public string CodeClient { get; set; }//mã đăng nhập
        public string PassWord { get; set; }
        public string ClientName { get; set; }
        public DateTime Birthday { get; set; }//năm sinh
        public string Description { get; set; }//mô tả
        public string Identity_Card { get; set; } // chứng minh nhân dân
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public int Status { get; set; }
//___________________________________________________________________//
        public ICollection<Bill> Bill { get; set; }
        public Guid IDBill { get; set; }
        public ICollection<Ordel> Cart { get; set; }
        public Guid IDCart { get; set; }
        public ICollection<Reviews> Reviews { get; set; }
        public Guid IDReviews { get; set; }
        public ICollection<Membership_Card> Membership_Card { get; set; }
        public Guid IDMembership_Card { get; set; }
        public virtual Membership_Level Membership_Level { get; set; }
        public Guid IDMembership_Level { get; set; }
        public ICollection<Favorites_List> Favorites { get; set; }
        public Guid IDFavorites_List { get; set; }
        public ICollection<Images> Images { get; set; }
        public Guid IDImages { get; set; } 
        public ICollection<Address> Addresse { get; set; }
        public Guid IDAddress { get; set; }
    }
}
