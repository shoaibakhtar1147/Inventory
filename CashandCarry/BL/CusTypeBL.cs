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
    class CusTypeBL
    {
        public int CusTypeID { get; set; }
        public string CusType { get; set; }


        public void Save()
        {
            using(var context=new CashCarryEntities3())
            {
                tbl_CustomerTypes objCus = new tbl_CustomerTypes() 
                {
                     CusType=CusType

                };
                context.tbl_CustomerTypes.Add(objCus);
                context.SaveChanges();
            }
        }

        public void Delete()
        {
            using(var context=new CashCarryEntities3())
            {
                var result = context.tbl_CustomerTypes.Where(a => a.CusTypeID == CusTypeID).SingleOrDefault();
                if(result != null)
                {
                    context.tbl_CustomerTypes.Remove(result);
                    context.SaveChanges();
                }

            }
        }

        public void Update()
        {
          using (var context=new CashCarryEntities3())
          {
              var result = context.tbl_CustomerTypes.Where(a => a.CusTypeID == CusTypeID).SingleOrDefault();
              if(result != null)
              {
                  result.CusType = CusType;
                  context.SaveChanges();

              }
          }
        }

        public DataTable Addnew()
        {
            String SpName = "SP_CusType_AddNew";
            SqlParameter[] prm = new SqlParameter[1];
            prm[0] = new SqlParameter("@CusTypeID", CusTypeID);
            return DB.SelectTableWithSP(SpName, prm);
        }

        public List<tbl_CustomerTypes> Search()
        {
           using(var context=new CashCarryEntities3())
           {
               return context.tbl_CustomerTypes.Where(a => a.CusTypeID == CusTypeID).ToList();
           }
        }

        public List<tbl_CustomerTypes> Select()
        {
            using (var context = new CashCarryEntities3())
            {
                return context.tbl_CustomerTypes.ToList();
            }
        }

        public List<tbl_CustomerTypes> SearchByName()
        {
            using (var context = new CashCarryEntities3())
            {
                return context.tbl_CustomerTypes.Where(a => a.CusType.Contains(CusType.ToLower())).ToList();
            }
        }
       
    }
}
