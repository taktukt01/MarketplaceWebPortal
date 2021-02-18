//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MarketplaceWebPortal.EntityLayer.Entities
{
    using System;
    using System.Collections.Generic;
    
    public partial class Product
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Product()
        {
            this.Properties = new HashSet<Property>();
        }
    
        public int ProductID { get; set; }
        public Nullable<int> ModelID { get; set; }
        public Nullable<int> ManufactureID { get; set; }
        public string ProductImgUrl { get; set; }
        public Nullable<int> SubCategoryID { get; set; }
        public string ProductName { get; set; }
    
        public virtual Manufacture Manufacture { get; set; }
        public virtual Model Model { get; set; }
        public virtual SubCategory SubCategory { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Property> Properties { get; set; }
    }
}
