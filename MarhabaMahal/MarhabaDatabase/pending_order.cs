//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MarhabaDatabase
{
    using System;
    using System.Collections.Generic;
    
    public partial class pending_order
    {
        public long id { get; set; }
        public string item_code { get; set; }
        public double qty { get; set; }
        public double item_total { get; set; }
        public string username { get; set; }
        public string table_number { get; set; }
    }
}
