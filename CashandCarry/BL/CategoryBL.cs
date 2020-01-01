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
    class CategoryBL
    {
        public int CategoryID { get; set; }
        public string CategoryName { get; set; }
      
        
        public void Save()
        {
            using (var context = new CashCarryEntities3())
            {
                tbl_Category objCate = new tbl_Category()
                {
                    CategoryName = CategoryName
                };
                context.tbl_Category.Add(objCate);
                context.SaveChanges();
            }
        }

        //public void Delete()
        //{
        //   using(var context=new CashCarryEntities3())
        //   {
        //       var result = context.tbl_Category.Where(a => a.CategoryID == CategoryID).SingleOrDefault();
        //       if(result != null)
        //       {
        //           context.tbl_Category.Remove(result);
        //           context.SaveChanges();
        //       }
        //   }
        //}

        public void Update()
        {
            using (var context = new CashCarryEntities3())
            {
                var result = context.tbl_Category.Where(m => m.CategoryID == CategoryID).SingleOrDefault();
                if (result != null)
                {
                    result.CategoryName = CategoryName;
                    context.SaveChanges();
                }
                
            }
        }
        public DataTable Addnew()
        {
            string spName = "SP_Cate_AddNew";
            SqlParameter[] prm = new SqlParameter[1];
            prm[0] = new SqlParameter("@CategoryID", CategoryID);
            return DB.SelectTableWithSP(spName, prm);
        }

        public List<tbl_Category> Search()
        {
            using(var context=new CashCarryEntities3())
            {
                return  context.tbl_Category.Where(a => a.CategoryID==CategoryID).ToList();
            }
            
            
        }

        public List<tbl_Category> Select()
        {
        using(var context=new CashCarryEntities3())
        {
            var result = context.tbl_Category.ToList();
            return result;
        }
            
        }
    }
}
