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
    
    public partial class View_tbl_Product
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public string Category { get; set; }
        public string Company { get; set; }
        public string weight { get; set; }
        public decimal RetailPrice { get; set; }
        public decimal PurchasePrice { get; set; }
        public Nullable<int> PiecePerCtn { get; set; }
        public Nullable<decimal> Ctn { get; set; }
        public Nullable<int> Piece { get; set; }
    }
}
