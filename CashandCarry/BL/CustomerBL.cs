﻿using CashandCarry.Interface;
using CashandCarry.Model;
using System;
using System.Collections.Generic;
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

        public void Save()
        {
           using(var context=new CashCarryEntities3())
           {
               tbl_Customer objCus = new tbl_Customer() 
               { 
                Name=Name,
                 CusTypeID=CusTypeID,
                  Address=Address,
                   Contact=Contact,
                    Email=Email,
                     ZoneID=ZoneID
               };
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
                    result.ZoneID = ZoneID;
                     context.SaveChanges();
               }
           }
        }

        public System.Data.DataTable Addnew()
        {
            throw new NotImplementedException();
        }

        public System.Data.DataTable Search()
        {
            throw new NotImplementedException();
        }

        public List<View_tbl_Customer> Select()
        {
            using(var context=new CashCarryEntities3())
            {
                return context.View_tbl_Customer.ToList();
            }
        }
    }
}