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
    class CustomerBL
    {
        public int CustomerID { get; set; }
        public string Name{get;set;}
        public int CusTypeID{get;set;}
        public string Address{get;set;}
        public string Contact{get;set;}
        public string Email	{get;set;}
        public int ZoneID { get; set; }
        public int SubZoneId { get; set; }
        public decimal Duepayment { get; set; }

      
     
        public void Save()
        {
           using(var context=new CashCarryEntities3())
           {
               tbl_Customer objCus = new tbl_Customer(); 

                if(objCus.DuePayment !=0)
                {
                    objCus.Name = Name;
                 objCus.CusTypeID=CusTypeID;
                  objCus.Address=Address;
                   objCus.Contact=Contact;
                    objCus.Email=Email;
                     objCus.ZoneID=ZoneID;
                     objCus.DuePayment=Duepayment;
                     objCus.SubRouteId=SubZoneId;
                     

                }


               else
                {
                    objCus.Name = Name;
                    objCus.CusTypeID = CusTypeID;
                    objCus.Address = Address;
                    objCus.Contact = Contact;
                    objCus.Email = Email;
                    objCus.ZoneID = ZoneID;
                    objCus.DuePayment = 0;
                    objCus.SubRouteId = SubZoneId;
                   
                }
                context.tbl_Customer.Add(objCus);
                context.SaveChanges();
                         }
        }

        public void Delete()
        {
           using(var context=new CashCarryEntities3())
           {
               var result = context.tbl_Customer.Where(a => a.CustomerID == CustomerID).SingleOrDefault();
               if(result!=null)
               {
                   context.tbl_Customer.Remove(result);
                   context.SaveChanges();
               }
           }
        }

        public void Update()
        {
           using(var context=new CashCarryEntities3())
           {
               var result = context.tbl_Customer.Where(a => a.CustomerID == CustomerID).SingleOrDefault();
               if(result != null)
               {
                    result.Name=Name;
                    result.CusTypeID = CusTypeID;
                    result.Address = Address;
                    result.Contact = Contact;
                    result.Email = Email;
                   // result.ZoneID = ZoneID;
                     context.SaveChanges();
               }
           }
        }

        public DataTable Addnew()
        {
            string spName = "SP_Cus_AddNew";
            SqlParameter[] prm = new SqlParameter[1];
            prm[0] = new SqlParameter("@CustomerID", CustomerID);
            return DB.SelectTableWithSP(spName, prm);
        }


        public List<tbl_Customer> Search()
        {
            using (var context = new CashCarryEntities3())
            {
                return context.tbl_Customer.Where(a => a.CustomerID == CustomerID).ToList();

            }
        }
            public List<tbl_Customer> SearchByName()
        {
           using(var context=new CashCarryEntities3())
           {
               return context.tbl_Customer.Where(a => a.Name == Name).ToList();
                
           }
        }
            public DataTable SelectByCus()
            {
                string spName = "SP_Cus_Search";
                SqlParameter[] prm = new SqlParameter[1];
                prm[0] = new SqlParameter("@CustomerID", CustomerID);

                return DB.SelectTableWithSP(spName, prm);
            }

            public DataTable SelectAllCus()
            {
                string spName = "SP_Cus_Search";               
                return DB.SelectTableWithSP(spName, null);
            }

        public DataTable Select15days()
            {
                string spName = "SP_CustomerCheck15Days";
                return DB.SelectTableWithSP(spName, null);
            }

        public List<View_tbl_Customer> Select()
        {
            using(var context=new CashCarryEntities3())
            {
               return context.View_tbl_Customer.ToList(); 
            }
        }

        public List<View_tbl_Customer> SearchByCusName()
        {
            using (var context = new CashCarryEntities3())
            {
                return context.View_tbl_Customer.Where(a => a.Name.Contains(Name.ToLower())).ToList();
            }
        }
    }
}
