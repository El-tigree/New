//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CiroService.EFDatabase
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.Serialization;

    
    public partial class invoice
    {
        
        public int invoice_id { get; set; }
        public string invoice_description { get; set; }
        public Nullable<decimal> invoice_total { get; set; }
        public Nullable<int> user_id_invoice { get; set; }
    
        public virtual user user { get; set; }
    }
}
