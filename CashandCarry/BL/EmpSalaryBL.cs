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
    class EmpSalaryBL
    {
        public int EmployeeID { get; set; }
        public decimal Salary { get; set; }
        public DateTime ResignDate {get;set;}
        public bool Status { get; set; }
        public DateTime SalaryDate { get; set; }
        public int SalaryID { get; set; }

        public void Save()
        {
           using(var context=new CashCarryEntities3())
           {
              if(Status== true)
              {
                  tbl_Employee_Salary objemp = new tbl_Employee_Salary()
                  {
                      EmployeeID = EmployeeID,
                      Salary = Salary,
                      SalaryDate = SalaryDate,
                      Status = Status
                  };
                  context.tbl_Employee_Salary.Add(objemp);
                  context.SaveChanges();
              }
               else
              {
                  tbl_Employee_Salary objemp = new tbl_Employee_Salary()
                  {
                      EmployeeID = EmployeeID,
                      ResginDate = ResignDate,
                      Salary = Salary,
                      SalaryDate = SalaryDate,
                      Status = Status
                  };
                  context.tbl_Employee_Salary.Add(objemp);
                  context.SaveChanges();
              }
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

        public DataTable Addnew()
        {
            string spName = "SP_EmpSalary_AddNew";
            SqlParameter[] prm = new SqlParameter[1];
            prm[0] = new SqlParameter("@SalaryID", SalaryID);
            return DB.SelectTableWithSP(spName,prm);
        }

        public System.Data.DataTable Search()
        {
            throw new NotImplementedException();
        }

        public System.Data.DataTable Select()
        {
            throw new NotImplementedException();
        }
    }
}
