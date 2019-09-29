using CashandCarry.Interface;
using CashandCarry.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashandCarry.BL
{
    class SaleInvoiceBL
    {
        public int InvoiceNo { get; set; }
        public DateTime SaleDate { get; set; }
        public int ProductID { get; set; }
        public int CustomerID { get; set; }
        public decimal Amount { get; set; }
        public int Quantity { get; set; }
        
        public decimal GST { get; set; }
        public decimal Discount { get; set; }
        public decimal TotalAmount { get; set; }
        public decimal GrandTotal { get; set; }
        public decimal BillDiscount { get; set; }
        public decimal TotalBill { get; set; }

        public void SaveDetail()
        {
            using (var context = new CashCarryEntities3())
            {
                tbl_Saledetail objsale = new tbl_Saledetail()
                {
                    Invoice_ = InvoiceNo,
                    ProductID = ProductID,
                    Discount = Discount,
                    Quantity = Quantity,
                    TotalAmount = TotalAmount
                };
                context.tbl_Saledetail.Add(objsale);
                context.SaveChanges();
            }
        }
        
        public void SaveMaster()
        {
            using (var context = new CashCarryEntities3())
            {
                tbl_SaleMAster objMas = new tbl_SaleMAster()
                {
                    Amount = TotalBill,
                    Discount = BillDiscount,
                    SaleDate = SaleDate,
                     CustomerID=CustomerID,
                    TotalAmount = GrandTotal,
                     
                };
                context.tbl_SaleMAster.Add(objMas);
                context.SaveChanges();
            }
        }
        public int UpdateProd()
        {
            string spName = "SP_Quantity_Update";
            SqlParameter[] prm = new SqlParameter[2];
            prm[0] = new SqlParameter("@ProductID", ProductID);
            prm[1] = new SqlParameter("@Quantity", Quantity);
            return DB.ExecuteNonQueryWithSP(spName, prm);
        }
      
        public int Delete()
        {
            throw new NotImplementedException();
        }
        public DataTable sumSalesDetail()
        {
            string spName = "SP_SaleDetail_Sum";
            SqlParameter[] prm = new SqlParameter[1];
            prm[0] = new SqlParameter("@InvoiceNo", InvoiceNo);
            return DB.SelectTableWithSP(spName, prm);
        }

        public int Update()
        {
            throw new NotImplementedException();
        }
        public DataTable Addnew()
        {
            string spName = "SP_SaleMAster";
            SqlParameter[] prm = new SqlParameter[1];
            prm[0] = new SqlParameter("@Invoice#", InvoiceNo);
            return DB.SelectTableWithSP(spName, prm);
        }

        public System.Data.DataTable Search()
        {
            throw new NotImplementedException();
        }

        public System.Data.DataTable Select()
        {

            throw new NotImplementedException();
        }
    }
}
