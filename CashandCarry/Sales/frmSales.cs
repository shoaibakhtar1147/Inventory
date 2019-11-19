using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CashandCarry.Sales
{
    public partial class frmSales : Form
    {
        public frmSales()
        {
            InitializeComponent();
        }

        private void frmSales_Load(object sender, EventArgs e)
        {

        }

        private void btnSaleInv_Click(object sender, EventArgs e)
        {
            FrmSaleInvoice objSale = new FrmSaleInvoice();
            objSale.ShowDialog();
        }

        private void btnSaleReturn_Click(object sender, EventArgs e)
        {
            FrmSaleReturn objReturn = new FrmSaleReturn();
            objReturn.ShowDialog();
        }

        private void btnRecovery_Click(object sender, EventArgs e)
        {
            SaleRecovery obj = new SaleRecovery();
            obj.ShowDialog();
        }
    }
}
