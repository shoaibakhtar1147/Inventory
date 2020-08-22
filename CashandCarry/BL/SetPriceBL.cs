using System;
using System.Collections.Generic;
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
    }
}
