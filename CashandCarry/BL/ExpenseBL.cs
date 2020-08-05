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
    class ExpenseBL
    {
        
          public string  ExType {get;set;}
          public string ExName{get;set;}
          public string  Description{get;set;}
          public DateTime  Date{get;set;}
          public decimal Amount { get; set; }
          public DateTime mindate{get;set;}
          public DateTime maxdate { get; set; }
        public void Save()
          {
            using(var context=new CashCarryEntities3())
            {
                tbl_Expense objExp = new tbl_Expense()
                {
                    ExType=ExType,
                    ExName=ExName,
                    Description=Description,
                    Date=Date,
                    Amount=Amount
                };
                context.tbl_Expense.Add(objExp);
                context.SaveChanges();
            }
          }

        public DataTable SelectByDateDiff()
        {
            string spName = "Sp_Expense";
            SqlParameter[] prm = new SqlParameter[2];
            prm[0]=new SqlParameter("@MinDate",mindate);
            prm[1]=new SqlParameter("@MaxDate",maxdate);
            return DB.SelectTableWithSP(spName, prm);

        }

    }
}
