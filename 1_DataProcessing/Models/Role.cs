namespace Assgiment_CSharp5._1_DataProcessing.Models
{
    public class Role //Chức vụ
    {
        public Guid IDRole { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Status { get; set; }
        //___________________________________________________________________//
        public Guid IDPersonnel { get; set; }
        public ICollection<Personnel> Personnel { get; set; }
    }
}
