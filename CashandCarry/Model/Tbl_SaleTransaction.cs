//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CashandCarry.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class Tbl_SaleTransaction
    {
        public int STId { get; set; }
        public Nullable<int> CustomerID { get; set; }
        public Nullable<int> Invoice_ { get; set; }
        public Nullable<int> SRecoveryID { get; set; }
        public Nullable<decimal> Credit { get; set; }
        public Nullable<decimal> Debit { get; set; }
        public Nullable<System.DateTime> Date { get; set; }
        public Nullable<decimal> Balance { get; set; }
        public string Description { get; set; }
        public Nullable<int> RInvoice { get; set; }
    }
}
