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
    
    public partial class Tbl_PurchaseReturn_Master
    {
        public int PReturnID { get; set; }
        public Nullable<int> CompanyID { get; set; }
        public Nullable<System.DateTime> ReturnDate { get; set; }
        public Nullable<decimal> ReturnCash { get; set; }
        public Nullable<decimal> TotalAmount { get; set; }
        public Nullable<decimal> ReturnDue { get; set; }
        public Nullable<decimal> Discount { get; set; }
        public Nullable<int> PInvoice { get; set; }
        public Nullable<decimal> GrandTotal { get; set; }
        public Nullable<decimal> FurDiscount { get; set; }
    }
}
