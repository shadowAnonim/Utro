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
    
    public partial class product_furnitures
    {
        public string furnitureArticle { get; set; }
        public string productArticle { get; set; }
        public int positionX { get; set; }
        public int positionY { get; set; }
        public Nullable<int> width { get; set; }
        public Nullable<int> length { get; set; }
        public Nullable<int> rotation { get; set; }
        public int count { get; set; }
    
        public virtual furniture furniture { get; set; }
        public virtual product product { get; set; }
    }
}