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
    class PurRemainBL
    {
        public int PRemainID { get; set; }
        public int CompanyID { get; set; }
        public decimal ReturnCash { get; set; }
        public int PReturnID { get; set; }
        public DateTime Date { get; set; }


        public void Save()
        {
         using(var context=new CashCarryEntities3())
         {
             if(PReturnID!=0)
             {
                 tbl_PurchaseRemain objPur = new tbl_PurchaseRemain() 
                 {
                  CompanyID=CompanyID,
                   PReturnID=PReturnID,
                    Date=Date,
                    ReturnCash=ReturnCash
                 };
                 context.tbl_PurchaseRemain.Add(objPur);
                 context.SaveChanges();
             }
             else
             {
                 tbl_PurchaseRemain obj = new tbl_PurchaseRemain() 
                 {
                  CompanyID=CompanyID,
                   Date=Date,
                    ReturnCash=ReturnCash
                 };
                 context.tbl_PurchaseRemain.Add(obj);
                 context.SaveChanges();
             }
         }
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
            string spName = "SP_PurRemain_AddNew";
            SqlParameter[]prm=new SqlParameter[1];
            prm[0]=new SqlParameter("@PRemainID",PRemainID);
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
