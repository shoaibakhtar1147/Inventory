using CashandCarry.Vendor;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CashandCarry.Purchase
{
    public partial class frmPurchase : Form
    {
        public frmPurchase()
        {
            InitializeComponent();
        }

        private void btnSaleInv_Click(object sender, EventArgs e)
        {
            PurchaseInvoice objPur = new PurchaseInvoice();
            objPur.ShowDialog();
        }

        private void btnSaleReturn_Click(object sender, EventArgs e)
        {
            FrmPurchaseReturn objRet = new FrmPurchaseReturn();
            objRet.ShowDialog();
        }

        private void btnRecovery_Click(object sender, EventArgs e)
        {
            FrmPurRemaining obj = new FrmPurRemaining();
            obj.ShowDialog();
        }
    }
}
