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
    class SaleLedgerBL
    {
        public int STId { get; set; }
      public int  CustomerID{get;set;}
      public int  Invoiceno {get;set;}
      public int SRecoveryID{get;set;}
      public decimal  Credit {get;set;}
      public decimal Debit{get;set;}
      public DateTime  Date{get;set;}
      public decimal Balance{get;set;}
     public string Description{get;set;}
     public int RInvoice { get; set;}
     public int ZoneId { get; set; }
        public void Save()
        {
            using(var context = new CashCarryEntities3())
            {
                if (Invoiceno != 0)
                {
                    Tbl_SaleTransaction obj1 = new Tbl_SaleTransaction()
                    {

                        Invoice_ = Invoiceno,
                        CustomerID = CustomerID,
                        
                        Credit = Credit,
                        Debit = Debit,
                        Date = Date,
                        Balance = Balance,
                        Description = Description
                    };
                    context.Tbl_SaleTransaction.Add(obj1);
                    context.SaveChanges();
                }

                else if(SRecoveryID !=0)
                {
                    Tbl_SaleTransaction obj =new Tbl_SaleTransaction()
                {

                SRecoveryID=SRecoveryID,
                CustomerID=CustomerID,
                Credit=Credit,
                Debit=Debit,
                Date=Date,
                Balance=Balance,
                Description=Description
                };
                context.Tbl_SaleTransaction.Add(obj);
                context.SaveChanges();
            }
                else if(RInvoice !=0)
                {
                    Tbl_SaleTransaction obj2 = new Tbl_SaleTransaction()
                    {

                        RInvoice=RInvoice,
                        CustomerID=CustomerID,
                        Credit = Credit,
                        Debit = Debit,
                        Date = Date,
                        Balance = Balance,
                        Description = Description
                    };
                    context.Tbl_SaleTransaction.Add(obj2);
                    context.SaveChanges();
                }
                else if(Invoiceno ==0 && RInvoice==0 && SRecoveryID==0)
                {
                    Tbl_SaleTransaction obj3 = new Tbl_SaleTransaction() 
                    {
                        CustomerID=CustomerID,
                        Credit=Credit,
                        Debit=Debit,
                        Date=Date,
                        Balance=Balance,
                        Description=Description

                    };
                    context.Tbl_SaleTransaction.Add(obj3);
                    context.SaveChanges();
                }
                }
                }
                
        

        public List<View_SaleLedger> search()
        {
            using(var context=new CashCarryEntities3())
            {
                return context.View_SaleLedger.Where(m => m.CustomerID == CustomerID ).ToList();
            }
        }

        public bool UpdateBalance(decimal amount, int CustomerID)
        {
            using (var context = new CashCarryEntities3())
            {
                var customer = context.tbl_Customer.Where(m => m.CustomerID == CustomerID).FirstOrDefault();
                if (customer != null)
                {
                    customer.DuePayment = amount;
                }
                context.SaveChanges();
                return true;
            }
        }

        public DataTable Search()
        {
            string spName = "SP_SaleLedger";
            SqlParameter[] prm = new SqlParameter[1];
            prm[0] = new SqlParameter("@CustomerID", CustomerID);
            return DB.SelectTableWithSP(spName, prm);
        }

        public DataTable SearchByRoute()
        {
            string SpName = "SP_SaleLedger_Route";
            SqlParameter[] prm = new SqlParameter[1];
            prm[0] = new SqlParameter("@ZoneId", ZoneId);
            return DB.SelectTableWithSP(SpName, prm);
        }
    }
}
