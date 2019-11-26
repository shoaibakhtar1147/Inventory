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

namespace CashandCarry.FrmMessageBox
{
    public partial class PurchaseMesageBox : Form
    {
        public PurchaseMesageBox()
        {
            InitializeComponent();
        }

        private void btnPurInvoice_Click(object sender, EventArgs e)
        {
            FrmPurReport obj = new FrmPurReport();
            this.Hide();
            obj.ShowDialog();
        }

        private void btnPurReturn_Click(object sender, EventArgs e)
        {
            FrmPurReturnReport obj = new FrmPurReturnReport();
            this.Hide();
            obj.ShowDialog();
        }

        private void PurchaseMesageBox_Load(object sender, EventArgs e)
        {

        }

        private void btnRamaining_Click(object sender, EventArgs e)
        {
            FrmRemainingReport obj = new FrmRemainingReport();
            this.Hide();
            obj.ShowDialog();
        }
    }
}
