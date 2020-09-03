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
    class SetPriceBL
    {
        public int ProductID { get; set; }
        public decimal BuyerPrice { get; set; }
        public decimal SellerPrice { get; set; }
        public bool IsActive { get; set; }
        public DateTime AddedDate { get; set; }
        public int ProductPriceId { get; set; }
        public string Productname { get; set; }

        public void Save()
        {
            using (var context = new CashCarryEntities3())
            {
                tbl_ProductPrice objPrice = new tbl_ProductPrice()
                {
                    ProductID = ProductID,
                    BuyerPrice = BuyerPrice,
                    SellerPrice = SellerPrice,
                    IsActive = IsActive,
                    AddedDate=AddedDate
                };
                context.tbl_ProductPrice.Add(objPrice);
                context.SaveChanges();
            }
        }

        public void Update()
        {
            using(var context=new CashCarryEntities3())
            {
                var result = context.tbl_ProductPrice.Where(a => a.ProductPriceId== ProductPriceId).SingleOrDefault();
                if(result != null)
                {
                    IsActive = IsActive;
                    SellerPrice=SellerPrice;
                    BuyerPrice = BuyerPrice;
                    context.SaveChanges();
                }
            }
        }

        public DataTable AddNew()
        {
            string spName = "SP_Price_AddNew";
            SqlParameter[] prm = new SqlParameter[1];
            prm[0] = new SqlParameter("@ProductPriceId", ProductPriceId);
            return DB.SelectTableWithSP(spName, prm);
        }

        public List<View_ProductPrice> Select()
        {
            using(var context=new CashCarryEntities3())
            {
                return context.View_ProductPrice.ToList();
            }

        }

        public DataTable selectwithSp()
        {
            string spName = "SP_ProductPrice_view";
            return DB.SelectTableWithSP(spName, null);
        }

        public List<View_ProductPrice> Search()
        {
            using(var context=new CashCarryEntities3() )
            {
                return context.View_ProductPrice.Where(a => a.ProductName.Contains(Productname.ToLower())).ToList();
            }
        }

        public void Delete()
        {
            using (var context = new CashCarryEntities3())
            {
                var result = context.tbl_ProductPrice.Where(a => a.ProductPriceId == ProductPriceId).SingleOrDefault();
                if (result != null)
                {
                    context.tbl_ProductPrice.Remove(result);
                    context.SaveChanges();
                }
            }
        }
    }
}