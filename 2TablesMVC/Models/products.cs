//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace _2TablesMVC.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class products
    {
        public int pid { get; set; }
        public string name { get; set; }
        public string description1 { get; set; }
        public string type1 { get; set; }
        public Nullable<double> price { get; set; }
        public Nullable<int> quantity { get; set; }
        public Nullable<int> sid { get; set; }
    
        public virtual suppliers suppliers { get; set; }
    }
}
