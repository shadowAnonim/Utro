//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace utro
{
    using System;
    using System.Collections.Generic;
    
    public partial class furniture
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public furniture()
        {
            this.furnitureStorage = new HashSet<furnitureStorage>();
            this.product_furnitures = new HashSet<product_furnitures>();
        }
    
        public string article { get; set; }
        public string name { get; set; }
        public string type { get; set; }
        public int width { get; set; }
        public Nullable<int> length { get; set; }
        public Nullable<int> weight { get; set; }
        public byte[] image { get; set; }
        public decimal cost { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<furnitureStorage> furnitureStorage { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<product_furnitures> product_furnitures { get; set; }
    }
}
