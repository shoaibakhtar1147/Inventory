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
        public DateTime mindate { get; set; }
        public DateTime maxdate { get; set; }
        public decimal GST { get; set; }
        public string CusName { get; set; }
        public decimal Discount { get; set; }
        public decimal TotalAmount { get; set; }
        public decimal GrandTotal { get; set; }
        public decimal BillDiscount { get; set; }
        public decimal TotalBill { get; set; }
        public decimal Payment { get; set; }
        public decimal DuePayment { get; set; }
        public decimal Ctn { get; set; }
        public string OrderBy { get; set; }

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
                    Ctn=Ctn,
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
                   
                  
                    SaleDate = SaleDate,
                     CustomerID=CustomerID,
                    TotalAmount = GrandTotal,
                     Payment=Payment,
                     DuePayment=DuePayment,
                     OrderBy=OrderBy
                     
                };
                context.tbl_SaleMAster.Add(objMas);
                context.SaveChanges();
            }
        }
        public int UpdateProd()
        {
            string spName = "SP_Quantity_Update";
            SqlParameter[] prm = new SqlParameter[3];
            prm[0] = new SqlParameter("@ProductID", ProductID);
            prm[1] = new SqlParameter("@Quantity", Quantity);
            prm[2] = new SqlParameter("@Action", 1);
            return DB.ExecuteNonQueryWithSP(spName, prm);
        }
      public DataTable Search()
        {
            string spName = "SP_SaleInvoice_Search";
            SqlParameter[] prm = new SqlParameter[1];
            prm[0] = new SqlParameter("@InvoiceNo", InvoiceNo);
            return DB.SelectTableWithSP(spName, prm);
        }
        //public DataTable SelectByCus()
        //{
        //    string spName = "SP_SaleMas_ByCus";
        //    SqlParameter[] prm = new SqlParameter[1];
        //    prm[0] = new SqlParameter("@CusID", CustomerID);
        //   return DB.SelectTableWithSP(spName, prm);
        //}
        public DataTable Addnew()
        {
            string spName = "SP_SaleMAster";
            SqlParameter[] prm = new SqlParameter[1];
            prm[0] = new SqlParameter("@Invoice#", InvoiceNo);
            return DB.SelectTableWithSP(spName, prm);
        }

       
        //public DataTable SelectByDate()
        //{
        //    String spName = "SP_SaleMas_DateDiff";
        //    SqlParameter[] prm = new SqlParameter[2];
        //    prm[0] = new SqlParameter("@MinDate", mindate);
        //    prm[1] = new SqlParameter("@MaxDate", maxdate);
        //    return DB.SelectTableWithSP(spName, prm);
        //}
        public int UpdateDueSum()
        {
            string spName = "[SP_Update_DuePayment]";
            SqlParameter[] prm = new SqlParameter[3];
            prm[0] = new SqlParameter("@CustomerID", CustomerID);
            prm[1] = new SqlParameter("@DuePayment", DuePayment);
            prm[2] = new SqlParameter("@prmtype", 1);
            return DB.ExecuteNonQueryWithSP(spName, prm);
        }
      
    }
}
