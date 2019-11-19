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
    class SaleRecoveryBL
    {
        public int CustomerID { get; set; }
        public int SRecoveryID { get; set; }
        public Decimal ReturnCash {  get; set; }
        public DateTime RecoveryDate { get; set; }
        public int RInvoice { get; set; } 


        public void Save()
        {
            using(var context=new CashCarryEntities3())
            {
                
                
                   
                
                    if(RInvoice !=0)
                {

                    Tbl_SaleRecovery objRec2 = new Tbl_SaleRecovery()
                    {
                        CustomerID = CustomerID,
                        RecoveryDate = RecoveryDate,
                        ReturnCash = ReturnCash,
                        RInvoice=RInvoice
                    };
                    context.Tbl_SaleRecovery.Add(objRec2);
                    context.SaveChanges();
                }
                    else
                    {
                        Tbl_SaleRecovery objRec = new Tbl_SaleRecovery()
                        {
                            CustomerID = CustomerID,
                            RecoveryDate = RecoveryDate,
                            ReturnCash = ReturnCash

                        };
                        context.Tbl_SaleRecovery.Add(objRec);
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
            string SpName = "SP_SaleRecovery_AddNew";
            SqlParameter[] prm = new SqlParameter[1];
            prm[0] = new SqlParameter("@SRecoveryID", SRecoveryID);
            return DB.SelectTableWithSP(SpName, prm);
        }

        public List<View_tbl_Customer> Search()
        {
            using (var context = new CashCarryEntities3())
            {
                return context.View_tbl_Customer.Where(a=> a.CustomerID==CustomerID).ToList();
            }
        }

        public System.Data.DataTable Select()
        {
            throw new NotImplementedException();
        }
    }
}
