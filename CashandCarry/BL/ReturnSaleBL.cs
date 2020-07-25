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
    class ReturnSaleBL
    {
        public int CustomerID { get; set; }
        public int RInvoice {get;set;}
        public int ProductID {get;set;}
        public int Quantity{get;set;}
        public decimal Amount { get; set; }
        public decimal TotalAmount { get; set; }
        public int Invoiceno {get;set;}
        public decimal ReturnAmount{get;set;}
        public DateTime ReturnDate{get;set;}
        public decimal DuePayment{get;set;}
        public decimal Discount { get; set; }
        public decimal ReturnCash { get; set; }
        public decimal TotalBill { get; set; }
        public DateTime mindate { get; set; }
        public DateTime maxdate { get; set; }
        public decimal Ctn { get; set; }

        public void  SaveDetail()
        {
            using(var context=new CashCarryEntities3())
            {
                Tbl_ReturnSaleDetail objRet = new Tbl_ReturnSaleDetail() 
                {
                 RInvoice=RInvoice,
                   ProductID=ProductID,
                    Quantity=Quantity,
                    Ctn=Ctn,
                     Discount=Discount,
                     Amount=Amount
                };
                context.Tbl_ReturnSaleDetail.Add(objRet);
                context.SaveChanges();
            }
        }
        public void SaveMaster()
        {
            using(var context=new CashCarryEntities3())
            {
                Tbl_ReturnSaleMaster objMas = new Tbl_ReturnSaleMaster() 
                {
                 ReturnAmount=ReturnAmount,
                  ReturnDate=ReturnDate,
                   Invoice_=Invoiceno,
                    ReturnCash=ReturnCash,
                    TotalBill=TotalBill
                };
                context.Tbl_ReturnSaleMaster.Add(objMas);
                context.SaveChanges();
            }
        }
        public int Delete()
        {
            throw new NotImplementedException();
        }

        public int UpdateInvoice()
        {
            string spName = "SP_Update_BothSale";
            SqlParameter[] prm = new SqlParameter[5];
            prm[0] = new SqlParameter("@Quantity", Quantity);
            prm[1] = new SqlParameter("@InvoiceID", Invoiceno);
            prm[2] = new SqlParameter("@TotalAmount", TotalAmount);
            prm[3] = new SqlParameter("@GrandTotal", TotalBill);
            prm[4] = new SqlParameter("@ProductID", ProductID);
            return DB.ExecuteNonQueryWithSP(spName, prm);
        }
        public int UpdateProd()
        {
            string spName = "SP_Quantity_Update";
            SqlParameter[] prm = new SqlParameter[3];
            prm[0] = new SqlParameter("@Quantity", Quantity);
            prm[1] = new SqlParameter("@ProductID", ProductID);
            prm[2] = new SqlParameter("@Action", 2);
            return DB.ExecuteNonQueryWithSP(spName, prm);
        }

        public DataTable Addnew()
        {
            string spName = "SP_RInvoice_AddNew";
            SqlParameter[] prm = new SqlParameter[1];
            prm[0] = new SqlParameter("@RInvoice", RInvoice);
            return DB.SelectTableWithSP(spName, prm);
        }

        public DataTable Search()
        {
            string spName = "SP_SaleInvoice_Search";
            SqlParameter[] prm = new SqlParameter[1];
            prm[0] = new SqlParameter("@InvoiceNo", Invoiceno);
            return DB.SelectTableWithSP(spName, prm);
        }
       
        public DataTable Select()
        {
            string spName = "SP_Search_ReturnInvoice";
            SqlParameter[] prm = new SqlParameter[1];
            prm[0] = new SqlParameter("@RinvoiceNo", RInvoice);
            return DB.SelectTableWithSP(spName, prm);
        }

            public int UpdateDueSub()
            {
                string spName = "SP_Update_DuePayment";
            SqlParameter[] prm = new SqlParameter[3];
            prm[0] = new SqlParameter("@CustomerID", CustomerID);
            prm[1] = new SqlParameter("@DuePayment", DuePayment);
            prm[2] = new SqlParameter("@prmtype", 2);
            return DB.ExecuteNonQueryWithSP(spName, prm);
            }
        //public DataTable SelectByCus()
        //    {
        //        string spName = "SP_Return_ByCus";
        //        SqlParameter[] prm = new SqlParameter[1];
        //        prm[0] = new SqlParameter("@CusID", CustomerID);
        //        return DB.SelectTableWithSP(spName, prm);
        //    }
        //public DataTable SelectDateDiff()
        //{
        //    string spName = "SP_SaleReturn_DateDiff";
        //    SqlParameter[] prm = new SqlParameter[2];
        //    prm[0] = new SqlParameter("@MinDate", mindate);
        //    prm[1] = new SqlParameter("@MaxDate", maxdate);
        //    return DB.SelectTableWithSP(spName, prm);
        //}
    }
}
