using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashandCarry.Interface
{
    interface IGeneric
    {
        int Save();
        int Delete();
        int Update();
        DataTable Addnew();
        DataTable Search();
        DataTable Select();

    }
}
