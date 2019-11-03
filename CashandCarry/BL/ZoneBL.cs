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
    class ZoneBL
    {
        public int? ZoneId { get; set; }
        public string ZoneName { get; set; }
        
        public void Save()
        {
            using(var context=new CashCarryEntities3())
            {
                tbl_Zone obj = new tbl_Zone() 
                {
                  ZoneName=ZoneName
                };
                context.tbl_Zone.Add(obj);
                context.SaveChanges();
            }
        }

        public void Delete()
        {
            using (var context = new CashCarryEntities3())
            {
                var result = context.tbl_Zone.Where(a => a.ZoneID == ZoneId).SingleOrDefault();
                if (result != null)
                {
                    context.tbl_Zone.Remove(result);
                    context.SaveChanges();
                }
            }
        }

        public void Update()
        {
           using(var context=new CashCarryEntities3())
           {
               var result = context.tbl_Zone.Where(a => a.ZoneID == ZoneId).SingleOrDefault();
               if(result != null)
               {
                   result.ZoneName = ZoneName;
                   context.SaveChanges();
               }
           }
        }

        public DataTable Addnew()
        {
            string spName = "SP_Zone_AddNew";
            SqlParameter[] prm = new SqlParameter[1];
            prm[0] = new SqlParameter("@zoneID", ZoneId);
            return DB.SelectTableWithSP(spName, prm);
            //using (var context= new CashCarryEntities3())
            //{
            //    var result= context.SP_Zone_AddNew(ZoneId).ToList();
            //    return result;
            //}
        }

        public List<tbl_Zone> Search()
        {
            using(var context=new CashCarryEntities3())
            {
                return context.tbl_Zone.Where(a => a.ZoneID == ZoneId).ToList();
            }
        }

        public List<tbl_Zone> Select()
        {
            using(var context=new CashCarryEntities3())
            {
                return context.tbl_Zone.ToList();
            }
        }
    }
}
