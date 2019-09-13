using CashandCarry.Interface;
using CashandCarry.Model;
using System;
using System.Collections.Generic;
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


        public void Save()
        {
            using(var context=new CashCarryEntities3())
            {
                tbl_Product objPro = new tbl_Product() 
                {
                  ProductName=ProductName,
                   CategoryID=CategoryID,
                    CompanyID=CompanyID,
                     Unit=Unit,
                       weight=weight,
                        RetailPrice=RetailPrice,
                        TradePrice=TradePrice,
                
                };
                context.tbl_Product.Add(objPro);
                context.SaveChanges();
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

        public System.Data.DataTable Addnew()
        {
            throw new NotImplementedException();
        }

        public tbl_Product Search()
        {
           using(var context=new CashCarryEntities3())
           {
               return context.tbl_Product.Where(a => a.ProductID == ProductID).FirstOrDefault();
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
