namespace Assgiment_CSharp5._1_DataProcessing.Models
{
    public class Product//sản phẩm
    {
        public Guid IDProduct { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public decimal PriceCeiling { get; set; }
        public int Status { get; set; }

        //___________________________________________________________________//
        public ICollection<Color_Product> Color_Product { get; set; }
        public Guid IDColor { get; set; }
        public ICollection<Producer_Product> Producer_Product { get; set; }
        public Guid IDProducer_Product { get; set; }
        public virtual Size_Product Size_Product { get; set; }
        public Guid IDSize { get; set; }
        public ICollection<Material_Product> Material_Product { get; set; }
        public Guid IDMaterial_Product { get; set; }
        public ICollection<ComboDetail> ComboDetail { get; set; }
        public Guid IDComboDetail { get; set; }
        public ICollection<CategoryDetail> CategoryDetail { get; set; }
        public Guid IDCategoryDetail { get; set; }
        public ICollection<OrdelDetail> OrdelDetail { get; set; }
        public Guid IDOrdelDetail { get; set; }
        public ICollection<BillDetail> BillDetails { get; set; }
        public Guid IDBillDetails { get; set; }
        public ICollection<Coupons> Coupons { get; set; }
        public Guid IDCoupons { get; set; }
        public ICollection<Images> Images { get; set; }
        public Guid IDImages { get; set; }
        public ICollection<Favorites_List> Favorites_List { get; set; }
    }
}
