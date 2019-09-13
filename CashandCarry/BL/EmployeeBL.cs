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
    class EmployeeBL
    {

     public int EmployeeID{get;set;}
     public string Name{get;set;}
     public string  Fname{get;set;}
     public string Username{get;set;}
      public string Password{get;set;}
      public string Qualifiction{get;set;}
      public string DOB{get;set;}
     public string Cnic{get;set;}
     public string Contact{get;set;}
     public string Designation{get;set;}
     public bool Gender{get;set;}
     public string Address { get; set;}

        public void Save()
        {
           using(var context= new CashCarryEntities3())
           {
               tbl_employee objemp = new tbl_employee() 
               {
                Name=Name,
                  Fname=Fname,
                   Gender=Gender,
                    Password=Password,
                     Qualifiction=Qualifiction,
                      Username=Username,
                       DOB=DOB,
                        Designation=Designation,
                         Contact=Contact,
                          Cnic=Cnic,
                           Address=Address
               };
               context.tbl_employee.Add(objemp);
               context.SaveChanges();
           }

        }

        public void Delete()
        {
            using(var context=new CashCarryEntities3())
            {
                var result = context.tbl_employee.Where(a => a.EmployeeID == EmployeeID).SingleOrDefault();
                if(result != null)
                {
                    context.tbl_employee.Remove(result);
                    context.SaveChanges();
                }
            }
        }

        public void Update()
        {
           using(var context=new CashCarryEntities3())
           {
               var result = context.tbl_employee.Where(a => a.EmployeeID == EmployeeID).SingleOrDefault();
               if(result != null)
               {
                   result.Name = Name;
                   result.Fname=Fname;
                    result.Gender=Gender;
                    result.Password=Password;
                     result.Qualifiction=Qualifiction;
                      result.Username=Username;
                       result.DOB=DOB;
                        result.Designation=Designation;
                         result.Contact=Contact;
                          result.Cnic=Cnic;
                           result.Address=Address;
                           context.SaveChanges();
              
               };
              
           }
        }


        public DataTable Addnew()
        {
            string spName = "SPAddNewEmp";
            SqlParameter[] prm = new SqlParameter[1];
            prm[0] = new SqlParameter("@EmployeeID", EmployeeID);
            return DB.SelectTableWithSP(spName, prm);
        }


        public tbl_employee Search()
        {
            using(var context=new CashCarryEntities3())
            {
                return context.tbl_employee.Where(a => a.EmployeeID == EmployeeID).FirstOrDefault();
            }
        }

        public List<tbl_employee> Select()
        {
           using(var context=new CashCarryEntities3())
            {
                return context.tbl_employee.ToList();
            }
        }
    }
}
