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
    
    public partial class fabric
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public fabric()
        {
            this.fabricStorage = new HashSet<fabricStorage>();
            this.product = new HashSet<product>();
        }
    
        public string article { get; set; }
        public string name { get; set; }
        public string color { get; set; }
        public string paint { get; set; }
        public byte[] image { get; set; }
        public string composition { get; set; }
        public int width { get; set; }
        public int length { get; set; }
        public decimal cost { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<fabricStorage> fabricStorage { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<product> product { get; set; }
    }
}
