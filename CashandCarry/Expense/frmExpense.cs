using CashandCarry.FormReports;
using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CashandCarry.Expense
{
    public partial class frmExpense : Form
    {
        public frmExpense()
        {
            InitializeComponent();
        }

        private void frmExpense_Load(object sender, EventArgs e)
        {

        }

        private void btnSaleInv_Click(object sender, EventArgs e)
        {
            FrmAddExpense objExp = new FrmAddExpense();
            objExp.ShowDialog();
        }

        private void btnSaleReturn_Click(object sender, EventArgs e)
        {
            FrmExpenseReport objrpt = new FrmExpenseReport();
            objrpt.ShowDialog();
        }
    }
}
