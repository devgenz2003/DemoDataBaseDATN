namespace Assgiment_CSharp5._1_DataProcessing.Models
{
    public class Personnel
    {
        public Guid IDPersonnel { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Gmail { get;set; }
        public string PhoneNumber { get; set; }
        public string City { get; set; }
        public string Region { get; set; }
        public string? PostalCode { get; set; }
        public string Country { get; set; }
        //___________________________________________________________________//
        public virtual Role Role { get; set; }
        public Guid IDRole { get; set; }
        public ICollection<Images> Images { get; set; }
        public Guid IDImages { get; set; }
        public virtual Address Address { get; set; }
        public Guid IDAddress { get; set; }

    }
}
