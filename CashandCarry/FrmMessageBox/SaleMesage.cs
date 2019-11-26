using CashandCarry.FormReports;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CashandCarry.FrmMessageBox
{
    public partial class SaleMesage : Form
    {
        public SaleMesage()
        {
            InitializeComponent();
        }

     

        private void SaleMesage_Load(object sender, EventArgs e)
        {

        }

        private void btnSaleReturn_Click(object sender, EventArgs e)
        {
            FrmsalReturn obj = new FrmsalReturn();
            this.Hide();
            obj.ShowDialog();
        }

        private void btnSaleInvoice_Click_1(object sender, EventArgs e)
        {
            FrmsalReport obj = new FrmsalReport();
            this.Hide();
            obj.ShowDialog();
         
        }

        private void btnRecovery_Click(object sender, EventArgs e)
        {
            FrmRecoveryReport obj = new FrmRecoveryReport();
            this.Hide();
            obj.ShowDialog();
        }
    }
}
