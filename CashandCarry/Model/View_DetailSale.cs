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
    
    public partial class View_DetailSale
    {
        public int InvoiceNo { get; set; }
        public string ProductName { get; set; }
        public Nullable<decimal> RetailPrice { get; set; }
        public Nullable<int> Quantity { get; set; }
        public Nullable<decimal> Discount { get; set; }
        public Nullable<System.DateTime> Date { get; set; }
        public Nullable<decimal> GrandTotal { get; set; }
        public Nullable<decimal> Amount { get; set; }
        public string CustomerName { get; set; }
        public Nullable<decimal> Payment { get; set; }
        public Nullable<decimal> DuePayment { get; set; }
        public Nullable<decimal> TotalDue { get; set; }
    }
}
