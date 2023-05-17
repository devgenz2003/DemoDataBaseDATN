namespace Assgiment_CSharp5._1_DataProcessing.Models
{
    public class ComboDetail
    {
        public Guid IDComboDetail { get; set; }
//___________________________________________________________________//

        public ICollection<Product> Product { get; set; }
        public Guid IDProduct { get; set; }
        public virtual Combo Combo { get; set; }
        public Guid IDCombo { get; set; }
    }
}
