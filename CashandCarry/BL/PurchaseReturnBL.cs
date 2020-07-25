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
    class PurchaseReturnBL
    {
        public int PReturnID { get; set; }
        public int ProductID{get;set;}
        public int  Quantity{get;set;}
        public decimal Amount { get; set; }
         public int CompanyID{get;set;}
         public DateTime ReturnDate{get;set;}
         public decimal ReturnCash{get;set;}
         public decimal TotalAmount{get;set;}
          public decimal ReturnDue{get;set;}
          public decimal Discount { get; set; }
          public decimal DuePayment { get; set; }
          public int PInvoice { get; set; }
          public decimal GrandTotal { get; set; }
          public decimal Ctn { get; set; }

        public void SaveDetail()
          {
            using(var context= new CashCarryEntities3())
            {
                Tbl_PurchaseReturn_Detail objDetail = new Tbl_PurchaseReturn_Detail() 
                {
                 PReturnID=PReturnID,
                 ProductID=ProductID,
                 Quantity=Quantity,
                  Amount=Amount,
                  Ctn=Ctn
                
                };
                context.Tbl_PurchaseReturn_Detail.Add(objDetail);
                context.SaveChanges();
            }
          }
        public void SaveMaster()
        {
            using(var context=new CashCarryEntities3())
            {
                Tbl_PurchaseReturn_Master objMaster = new Tbl_PurchaseReturn_Master()
                { 
                    PInvoice=PInvoice,
                     CompanyID=CompanyID,
                      Discount=Discount,
                       ReturnCash=ReturnCash,
                        ReturnDate=ReturnDate, 
                         ReturnDue=ReturnDue,
                          TotalAmount=TotalAmount
                };
                context.Tbl_PurchaseReturn_Master.Add(objMaster);
                context.SaveChanges();
            }
        }
        public int Save()
        {
            throw new NotImplementedException();
        }

        public int Delete()
        {
            throw new NotImplementedException();
        }

        
            public int ProdUpdate()
        {

            string SpName = "SP_Quantity_Update";
            SqlParameter[] prm = new SqlParameter[3];
            prm[0] = new SqlParameter("@ProductID", ProductID);
            prm[1] = new SqlParameter("@Quantity", Quantity);
            prm[2] = new SqlParameter("@Action", 1);
            return DB.ExecuteNonQueryWithSP(SpName, prm);
        }

            public int CtnUpdate()
            {
                string spName = "SP_Ctn_Update";
                SqlParameter[] prm = new SqlParameter[3];
                prm[0] = new SqlParameter("@ProductID", ProductID);
                prm[1] = new SqlParameter("@Ctn", Ctn);
                prm[2] = new SqlParameter("@Action", 1);
                return DB.ExecuteNonQueryWithSP(spName, prm);
            }
        public DataTable Addnew()
        {
            string spName = "SP_PReturn_AddNew";
            SqlParameter[] prm = new SqlParameter[1];
            prm[0] = new SqlParameter("@PReturnID", PReturnID);
            return DB.SelectTableWithSP(spName, prm);
        }
        public int UpdateDuePayment()
        {
            string spName = "SP_Update_PReturn_DuePayment";
            SqlParameter[] prm = new SqlParameter[3];
            prm[0] = new SqlParameter("@CompanyID", CompanyID);
            prm[1] = new SqlParameter("@DuePayment", DuePayment);
            prm[2] = new SqlParameter("@Action", 2);
            return DB.ExecuteNonQueryWithSP(spName,prm);
        }
        public int UpdatePInvoice()
        {
            string SpName = "SP_Update_BothPurchase";
            SqlParameter[] prm = new SqlParameter[5];
            prm[0] = new SqlParameter("@Quantity", Quantity);
            prm[1] = new SqlParameter("@Amount", Amount);
            prm[2] = new SqlParameter("@PInvoice", PInvoice);
            prm[3] = new SqlParameter("@ProductID", ProductID);
            prm[4] = new SqlParameter("@Grandtotal", GrandTotal);
            return DB.ExecuteNonQueryWithSP(SpName, prm);
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
