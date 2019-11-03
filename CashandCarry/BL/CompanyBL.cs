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
    class CompanyBL
    {
        public int CompanyID { get; set; }
        public string CompanyName { get; set; }
        public string Contact { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }

        public void Save()
        {
            using(var context=new CashCarryEntities3())
            {
                tbl_Company obj = new tbl_Company() 
                {
                 CompanyName=CompanyName,
                  Contact=Contact,
                   Email=Email,
                   Address=Address
                };
                context.tbl_Company.Add(obj);
                context.SaveChanges();
            }
        }

        public void Delete()
        {
           using(var context=new CashCarryEntities3())
           {
               var result = context.tbl_Company.Where(a => a.CompanyID == CompanyID).SingleOrDefault();
               context.tbl_Company.Remove(result);
               context.SaveChanges();
           }
        }

        public void Update()
        {
            using(var context=new CashCarryEntities3())
            {
                var result = context.tbl_Company.Where(a => a.CompanyID == CompanyID).SingleOrDefault();
                if(result != null)
                {
                    result.CompanyName = CompanyName;
                    result.Contact = Contact;
                    result.Email = Email;
                    result.Address = Address;
                    context.SaveChanges();
  
                }
            }

        }

        public DataTable Addnew()
        {
            string spName = "SPAddNewCom";
            SqlParameter[] prm = new SqlParameter[1];
            prm[0] = new SqlParameter("@CompanyID", CompanyID);
            return DB.SelectTableWithSP(spName, prm);
        }

        public List<tbl_Company> Search()
        {
            using(var context=new CashCarryEntities3())
            {
                return context.tbl_Company.Where(a => a.CompanyID == CompanyID).ToList();
            }
        }

        public List<tbl_Company> Select()
        {
            using(var context= new CashCarryEntities3())
            {
                return context.tbl_Company.ToList();
            }
        }
    }
}
