﻿using CashandCarry.Interface;
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
    class PurchaseInvoiceBL:IGeneric
    {
        public int PInvoice { get; set; }
        public DateTime PurchaseDate { get; set; }
        public int companyID { get; set; }
        public int ProductID { get; set; }
        public decimal Amount { get; set; }
        public int Quantity { get; set; }
        public string CompanyName { get; set; }
        public DateTime mindate { get; set; }
        public DateTime maxdate { get; set; }
        public decimal Discount { get; set; }
        public decimal TotalAmount { get; set; }
        public decimal GrandTotal { get; set; }
        public decimal TotalBill { get; set; }

        public void SaveDetail()
        {
            using(var context=new CashCarryEntities3())
            {
                Tbl_PurchaseDetail objpur = new Tbl_PurchaseDetail() 
                {
                   PInvoice=PInvoice,
                    ProductID=ProductID,
                     Quantity=Quantity,
                      TotalAmount=TotalAmount
                };
                context.Tbl_PurchaseDetail.Add(objpur);
                context.SaveChanges();
            }
        }
        public  void SaveMaster()
        {
            using(var context=new CashCarryEntities3())
            {
                Tbl_PurchaseMaster objMas = new Tbl_PurchaseMaster() 
                {
                 CompanyID=companyID,
                  Discount=Discount,
                   PurchaseDate=PurchaseDate,
                    TotalAmount=GrandTotal
                };
                context.Tbl_PurchaseMaster.Add(objMas);
                context.SaveChanges();
            }
        }
        public int Save()
        {
            throw new NotImplementedException();
        }

        public int Delete()
        {
            throw new NotImplementedException();
        }
        public int ProdUpdate()
        {
            string query = "update tbl_Product set Quantity= Quantity + '" +Quantity  + "' where ProductID='" + ProductID + "'";
            return DB.insert(query);
        }

        public int Update()
        {
            throw new NotImplementedException();
        }

        public DataTable Addnew()
        {
            string spName = "SP_PInvoice_AddNew";
            SqlParameter[] prm = new SqlParameter[1];
            prm[0] = new SqlParameter("@PInvoice", PInvoice);
            return DB.SelectTableWithSP(spName, null);
            
        }

        public System.Data.DataTable Search()
        {
            throw new NotImplementedException();
        }
        public DataTable SelectByDate()
        {
            string spName = "SP_Purchase_DateDiff";
            SqlParameter[] prm = new SqlParameter[2];
            prm[0] = new SqlParameter("@mindate", mindate);
            prm[1] = new SqlParameter("@maxdate", maxdate);
            return DB.SelectTableWithSP(spName, prm);
        }
        public DataTable SelectByCompany()
        {
            string spName = "SP_Purchase_ByCom";
            SqlParameter[] prm = new SqlParameter[1];
            prm[0] = new SqlParameter("@CompanyName", CompanyName);
            return DB.SelectTableWithSP(spName, prm);
        }
        public DataTable Select()
        {
            throw new NotImplementedException();
        }
    }
}
