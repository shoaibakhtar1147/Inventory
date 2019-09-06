using CashandCarry.Interface;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashandCarry.BL
{
    class EmployeeBL:IGeneric
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

        public int Save()
        {
            string spName = "SPInsertEmployee";
            SqlParameter[] prm = new SqlParameter[11];
            prm[0] = new SqlParameter("@Name", Name);
            prm[1] = new SqlParameter("@Fname", Fname);
            prm[2] = new SqlParameter("@Username", Username);
            prm[3] = new SqlParameter("@Password", Password);
            prm[4] = new SqlParameter("@Qualifiction", Qualifiction);
            prm[5] = new SqlParameter("@DOB", DOB);
            prm[6] = new SqlParameter("@Cnic", Cnic);
            prm[7] = new SqlParameter("@Contact", Contact);
            prm[8] = new SqlParameter("@Designation", Designation);
            prm[9] = new SqlParameter("@Gender", Gender);
            prm[10] = new SqlParameter("@Address", Address);
            return DB.ExecuteNonQueryWithSP(spName, prm);
        }

        public int Delete()
        {
            string spName = "SPDeleteEmp";
            SqlParameter[] prm = new SqlParameter[1];
            prm[0] = new SqlParameter("@EmployeeID", EmployeeID);
            return DB.ExecuteNonQueryWithSP(spName, prm);
        }

        public int Update()
        {
            string spName = "SPUpdateEmp";
            SqlParameter[] prm = new SqlParameter[12];
            prm[0]=new SqlParameter("@EmployeeID",EmployeeID);
            prm[1]=new SqlParameter("@Name",Name);
            prm[2]=new SqlParameter("@Fname",Fname);
            prm[3] = new SqlParameter("@Username", Username);
            prm[4] = new SqlParameter("@Password", Password);
            prm[5] = new SqlParameter("@Qualifiction", Qualifiction);
            prm[6] = new SqlParameter("@DOB", DOB);
            prm[7] = new SqlParameter("@Cnic", Cnic);
            prm[8] = new SqlParameter("@Contact", Contact);
            prm[9] = new SqlParameter("@Designation", Designation);
            prm[10] = new SqlParameter("@Gender", Gender);
            prm[11] = new SqlParameter("@Address", Address);
            return DB.ExecuteNonQueryWithSP(spName, prm);
        }


        public DataTable Addnew()
        {
            string spName = "SPAddNewEmp";
            SqlParameter[] prm = new SqlParameter[1];
            prm[0] = new SqlParameter("@EmployeeID", EmployeeID);
            return DB.SelectTableWithSP(spName, prm);
        }


        public DataTable Search()
        {
            string spName = "SPSearchEmp";
            SqlParameter[] prm = new SqlParameter[1];
            prm[0] = new SqlParameter("@EmployeeID", EmployeeID);
            return DB.SelectTableWithSP(spName, prm);
        }

        public DataTable Select()
        {
            string spName = "SPSelectEmp";
            return DB.SelectTableWithSP(spName, null);
        }
    }
}
