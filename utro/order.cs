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
    
    public partial class order
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public order()
        {
            this.order_products = new HashSet<order_products>();
        }
    
        public int number { get; set; }
        public System.DateTime date { get; set; }
        public short stage { get; set; }
        public int customer { get; set; }
        public Nullable<int> manager { get; set; }
        public Nullable<decimal> cost { get; set; }
    
        public virtual stage stage1 { get; set; }
        public virtual user user { get; set; }
        public virtual user user1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<order_products> order_products { get; set; }
    }
}