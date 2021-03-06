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
    
    public partial class Property
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Property()
        {
            this.TechSpecFilters = new HashSet<TechSpecFilter>();
        }
    
        public int PropertyID { get; set; }
        public Nullable<int> ApplicationID { get; set; }
        public int air_flow { get; set; }
        public decimal power_min { get; set; }
        public decimal power_max { get; set; }
        public int operating_voltage_min { get; set; }
        public int operating_voltage_max { get; set; }
        public int fan_speed_min { get; set; }
        public int fan_speed_max { get; set; }
        public int number_of_fan_speed { get; set; }
        public int sound_at_max_speed { get; set; }
        public decimal height_min { get; set; }
        public decimal height_max { get; set; }
        public decimal weight { get; set; }
        public Nullable<int> Accessories { get; set; }
        public int ProductID { get; set; }
        public int SubCategoryID { get; set; }
    
        public virtual Application Application { get; set; }
        public virtual Product Product { get; set; }
        public virtual SubCategory SubCategory { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TechSpecFilter> TechSpecFilters { get; set; }
    }
}
