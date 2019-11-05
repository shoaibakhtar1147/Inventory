using CashandCarry.Interface;
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
        public int Invoiceno {get;set;}
        public decimal ReturnAmount{get;set;}
        public DateTime ReturnDate{get;set;}

        public void  SaveDetail()
        {
            
        }
        public void SaveMaster()
        {

        }
        public int Delete()
        {
            throw new NotImplementedException();
        }

        public int Update()
        {
            throw new NotImplementedException();
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
        public string GetDuePayment()
        {
            string spName = "SP_DuePayment_Sum";
            SqlParameter[] prm = new SqlParameter[1];
            prm[0] = new SqlParameter("@CustomerID", CustomerID);
            string value = DB.SelectScalerWithSP(spName, prm);
            return value;
        }
        public System.Data.DataTable Select()
        {
            throw new NotImplementedException();
        }
    }
}
