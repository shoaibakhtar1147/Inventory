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
    class PurchaseLedgerBL
    {
      public int  PTId{get;set;}
      public int CompanyID{get;set;}
      public int PInvoice{get;set;}
      public int PRemainID{get;set;}
      public decimal Credit{get;set;}
      public decimal Debit{get;set;}
      public DateTime Date{get;set;}
      public decimal Balance{get;set;}
      public string Description { get;set;}
      public int PReturnID { get; set; }

      public void save()
      { 
      using(var context=new CashCarryEntities3())
      {
          if(PInvoice !=0)
          {
              Tbl_PurTransaction obj1 = new Tbl_PurTransaction()
          {
              PInvoice=PInvoice,
              CompanyID=CompanyID,
              Credit=Credit,
              Debit=Debit,
              Date=Date,
              Balance=Balance,
              Description=Description
          };
              context.Tbl_PurTransaction.Add(obj1);
              context.SaveChanges();
          }

          else if(PRemainID !=0)
          {
              Tbl_PurTransaction obj = new Tbl_PurTransaction() 
              {
                  PRemainID=PRemainID,
                  CompanyID=CompanyID,
                  Credit=Credit,
                  Debit=Debit,
                  Date=Date,
                  Balance=Balance,
                  Description=Description
              };
              context.Tbl_PurTransaction.Add(obj);
              context.SaveChanges();
          }
          else if(PReturnID != 0)
          {
              Tbl_PurTransaction obj2 = new Tbl_PurTransaction()
              {
                  PReturnID=PReturnID,
                  CompanyID = CompanyID,
                  Credit = Credit,
                  Debit = Debit,
                  Date = Date,
                  Balance = Balance,
                  Description = Description
              };
              context.Tbl_PurTransaction.Add(obj2);
              context.SaveChanges();
          }
      }
      }

        public List<View_PurLedger> search()
      {
            using(var context=new CashCarryEntities3())
            {
                return context.View_PurLedger.Where(m => m.CompanyID == CompanyID).ToList();
            }
      }
      public bool UpdateBalance(decimal amount, int CompanyID)
      {
          using (var context = new CashCarryEntities3())
          {
              var customer = context.tbl_Company.Where(m => m.CompanyID == CompanyID).FirstOrDefault();
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
          string spName = "SP_PurLedger";
          SqlParameter[] prm = new SqlParameter[1];
          prm[0] = new SqlParameter("@CompanyID", CompanyID);
          return DB.SelectTableWithSP(spName, prm);
      }

    }
}
