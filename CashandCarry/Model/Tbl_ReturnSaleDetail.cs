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
    
    public partial class Tbl_ReturnSaleDetail
    {
        public int RDetailID { get; set; }
        public Nullable<int> RInvoice { get; set; }
        public Nullable<int> ProductID { get; set; }
        public Nullable<int> Quantity { get; set; }
        public Nullable<decimal> Discount { get; set; }
        public Nullable<decimal> Amount { get; set; }
        public Nullable<decimal> Ctn { get; set; }
    }
}
