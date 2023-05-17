namespace Assgiment_CSharp5._1_DataProcessing.Models
{
    public class Address //Địa chỉ
    {
        public Guid IDAddress { get; set; }
        public string NameAddress { get; set; }
        public DateTime Create_At { get; set; }
        public DateTime Update_At { get; set; }
        public int Status { get; set; }
        //___________________________________________________________________//
        public ICollection<Client> Client { get; set; }
        public ICollection<Bill> Bill { get; set; }
        public ICollection<Personnel> Personnels { get; set; }
    }
}
