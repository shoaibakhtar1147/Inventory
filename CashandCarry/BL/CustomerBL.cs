using CashandCarry.Interface;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashandCarry.BL
{
    class CustomerBL:IGeneric
    {
        public string Name{get;set;}
        public int CusTypeID{get;set;}
        public string Address{get;set;}
        public string Contact{get;set;}
        public string Email	{get;set;}
        public int ZoneID { get; set; }

        public int Save()
        {
            string spName = "SPInsertCustomer";
            SqlParameter[] prm = new SqlParameter[6];
            prm[0] = new SqlParameter("@Name", Name);
            prm[1] = new SqlParameter("@CusTypeID", CusTypeID);
            prm[2] = new SqlParameter("@Address", Address);
            prm[3] = new SqlParameter("@Contact", Contact);
            prm[4] = new SqlParameter("@Email", Email);
            prm[5] = new SqlParameter("@ZoneID", ZoneID);
            return DB.ExecuteNonQueryWithSP(spName, prm);
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
