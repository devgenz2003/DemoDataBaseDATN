namespace Assgiment_CSharp5._1_DataProcessing.Models
{
    public class Images
    {
        public Guid IDImages { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime Create_At { get; set; }
        public DateTime Update_At { get; set; }
        public int Status { get; set; }

//___________________________________________________________________//
        public ICollection<Client> Client { get; set; }
        public Guid IDClient { get; set; }
        public ICollection<Product> Products { get; set; }
        public Guid IDProduct { get; set; }
        public ICollection<Personnel> Personnel { get; set; }
        public Guid IDPersonnel { get; set; }
    }
}
