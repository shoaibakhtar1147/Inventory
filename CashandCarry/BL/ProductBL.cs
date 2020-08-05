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
    class ProductBL
    {
       public int ProductID	{get;set;}
       public string ProductName{get;set;}
       public string Unit{get;set;}
       public string  weight{get;set;}
        public int CategoryID{get;set;}
       public int CompanyID{get;set;}
       public decimal RetailPrice{get;set;}
        public decimal TradePrice{get;set;}
        public decimal Ctn { get; set; }
        public int PiecePerCtn {get;set;}
        public string Company { get; set; }


        public void Save()
        {
            using(var context=new CashCarryEntities3())
            {
                tbl_Product objPro = new tbl_Product() 
                {
                  ProductName=ProductName,
                   CategoryID=CategoryID,
                    CompanyID=CompanyID,
                    
                       weight=weight,
                        RetailPrice=RetailPrice,
                        TradePrice=TradePrice,
                        Quantity=0,
                        PiecePerCtn=PiecePerCtn,
                        Ctn=0
                
                };
                context.tbl_Product.Add(objPro);
                context.SaveChanges();
            }
        }

        public void Delete()
        {
            using(var context=new CashCarryEntities3())
            {
                var result = context.tbl_Product.Where(a => a.ProductID == ProductID).SingleOrDefault();
                if(result != null)
                {
                    context.tbl_Product.Remove(result);
                    context.SaveChanges();
                }
            }
        }

        public void Update()
        {
            using(var context=new CashCarryEntities3())
            {
                var result = context.tbl_Product.Where(a => a.ProductID == ProductID).SingleOrDefault();
                if(result != null)
                {
                     result.ProductName=ProductName;   
                       result.weight=weight;
                        result.RetailPrice=RetailPrice;
                        result.TradePrice = TradePrice;
                        result.PiecePerCtn = PiecePerCtn;
                        context.SaveChanges();
                }
            }
        }

        public DataTable Addnew()
        {
            string spName = "SP_Prod_AddNew";
            SqlParameter[] prm = new SqlParameter[1];
            prm[0] = new SqlParameter("@ProductID", ProductID);
            return DB.SelectTableWithSP(spName, prm);
        }
        public DataTable SearchByPRod()
        {
            string spName = "SP_Search_Product";
            SqlParameter[] prm = new SqlParameter[1];
            prm[0] = new SqlParameter("@ProductID", ProductID);
            return DB.SelectTableWithSP(spName, prm);
        }

        public DataTable SearchByPRodCom()
        {
            string spName = "SP_Search_Product";
            return DB.SelectTableWithSP(spName, null);
        }
        public List<View_tbl_Product> Search()
        {
           using(var context=new CashCarryEntities3())
           {
               return context.View_tbl_Product.Where(a => a.ProductID == ProductID).ToList();
           }
        }
        public List<tbl_Product> SearchByName()
        {
            using (var context = new CashCarryEntities3())
            {
                return context.tbl_Product.Where(a => a.ProductName == ProductName).ToList();
            }
        }
        public List<View_tbl_Product> SearchByComp()
        {
            using (var context = new CashCarryEntities3())
            {
                return context.View_tbl_Product.Where(a => a.Company == Company).ToList();
            }
        }
        public List<View_tbl_Product> Select()
        {
            using(var context=new CashCarryEntities3())
            {
                return context.View_tbl_Product.ToList();
            }
        }
    }
}
