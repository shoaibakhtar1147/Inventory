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
    class PurchaseInvoiceBL:IGeneric
    {
        public int PInvoice { get; set; }
        public DateTime PurchaseDate { get; set; }
        public int companyID { get; set; }
        public int ProductID { get; set; }
        public decimal Amount { get; set; }
        public int Quantity { get; set; }
        public string CompanyName { get; set; }
        public DateTime mindate { get; set; }
        public DateTime maxdate { get; set; }
        public decimal Discount { get; set; }
        public decimal TotalAmount { get; set; }
        //public decimal SubTotal { get; set; }
        public decimal TotalBill { get; set; }
        public decimal Payment { get; set; }
        public decimal DuePayment { get; set; }
        public decimal Ctn { get; set; }
        public decimal frieght { get; set; }
        public decimal furDiscount { get; set; }
        public decimal GrandTotal { get; set; }
        public decimal TP { get; set; }

        public void SaveDetail()
        {
            using(var context=new CashCarryEntities3())
            {
                if(frieght != 0)
                {
                    Tbl_PurchaseDetail objpur = new Tbl_PurchaseDetail()
                    {
                        PInvoice = PInvoice,
                        ProductID = ProductID,
                        Quantity = Quantity,
                        TotalAmount = Amount,
                        Ctn = Ctn,
                        frieght=frieght,
                        PurchasePrice=TP
                    };
                    context.Tbl_PurchaseDetail.Add(objpur);
                    context.SaveChanges();
                }
                else
                {
                    Tbl_PurchaseDetail objpur = new Tbl_PurchaseDetail()
                    {
                        PInvoice = PInvoice,
                        ProductID = ProductID,
                        Quantity = Quantity,
                        TotalAmount = Amount,
                        Ctn = Ctn,
                        frieght = 0
                    };
                    context.Tbl_PurchaseDetail.Add(objpur);
                    context.SaveChanges();
                }
            }
        }
        public  void SaveMaster()
        {
            using(var context=new CashCarryEntities3())
            {
                Tbl_PurchaseMaster objMas = new Tbl_PurchaseMaster() 
                {
                    PInvoice=PInvoice,
                 CompanyID=companyID,
                  Discount=Discount,
                   PurchaseDate=PurchaseDate,
                    TotalAmount=TotalAmount,
                    Payment=Payment,
                    DuePayment=DuePayment,
                    FurDiscount=furDiscount,
                    GrandTotal=GrandTotal
                };
                context.Tbl_PurchaseMaster.Add(objMas);
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
            prm[2] = new SqlParameter("@Action", 2);
            return DB.ExecuteNonQueryWithSP(SpName, prm);
        }

        public int CtnUpdate()
        {
            string spName = "SP_Ctn_Update";
            SqlParameter[] prm = new SqlParameter[3];
            prm[0] = new SqlParameter("@ProductID", ProductID);
            prm[1] = new SqlParameter("@Ctn", Ctn);
            prm[2] = new SqlParameter("@Action", 2);
            return DB.ExecuteNonQueryWithSP(spName, prm);
        }
        public int Update()
        {
            throw new NotImplementedException();
        }

        public DataTable Addnew()
        {
            string spName = "SP_PInvoice_AddNew";
            SqlParameter[] prm = new SqlParameter[1];
            prm[0] = new SqlParameter("@PInvoice", PInvoice);
            return DB.SelectTableWithSP(spName, null);
            
        }

        public List<View_DetailPurchase> search()
        {
            using(var context=new CashCarryEntities3())
            {
                return context.View_DetailPurchase.Where(m => m.InvoiceNo == PInvoice).ToList();
            }
        }

        public DataTable Search()
        {
            string spName = "SP_PurchaseInvoice_Search";
            SqlParameter[] prm = new SqlParameter[1];
            prm[0] = new SqlParameter("@PInvoice", PInvoice);
            return DB.SelectTableWithSP(spName,prm);
        }
        public DataTable SelectByDate()
        {
            string spName = "SP_Purchase_DateDiff";
            SqlParameter[] prm = new SqlParameter[2];
            prm[0] = new SqlParameter("@mindate", mindate);
            prm[1] = new SqlParameter("@maxdate", maxdate);
            return DB.SelectTableWithSP(spName, prm);
        }
        public DataTable SelectByCompany()
        {
            string spName = "SP_Purchase_ByCom";
            SqlParameter[] prm = new SqlParameter[1];
            prm[0] = new SqlParameter("@CompanyID", companyID);
            return DB.SelectTableWithSP(spName, prm);
        }
        public DataTable Select()
        {
            throw new NotImplementedException();
        }
        public int UpdateDuePayment()
        {
            string spName = "SP_Update_PReturn_DuePayment";
            SqlParameter[] prm = new SqlParameter[3];
            prm[0] = new SqlParameter("@CompanyID", companyID);
            prm[1] = new SqlParameter("@DuePayment", DuePayment);
            prm[2] = new SqlParameter("@Action", 1);
            return DB.ExecuteNonQueryWithSP(spName, prm);

        }
    }
}
