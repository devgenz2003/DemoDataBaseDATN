namespace Assgiment_CSharp5._1_DataProcessing.Models
{
    public class OrdelDetail//Giỏ hafg chi tiết
    {
        public Guid IDOrdeltDetail { get; set; }
        public int Quantity { get; set; }
//___________________________________________________________________//
        public virtual Ordel Ordel { get; set; }
        public ICollection<Product> Products { get; set; }
        public Guid IDProduct { get; set; }
        public ICollection<Combo> Combos { get; set; }
        public Guid? IDCombo { get; set; }
    }
}
