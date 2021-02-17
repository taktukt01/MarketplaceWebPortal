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
            this.Models = new HashSet<Model>();
        }
    
        public int ProductID { get; set; }
        public string ProductImgUrl { get; set; }
        public string ProductName { get; set; }
        public int ManufactureID { get; set; }
        public int SubCategoryID { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Model> Models { get; set; }
        public virtual Manufacture Manufacture { get; set; }
        public virtual SubCategory SubCategory { get; set; }
    }
}
