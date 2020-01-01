using CashandCarry.BL;
using CashandCarry.Configuration;
using CashandCarry.FormReports;
using CashandCarry.Purchase;
using CashandCarry.Sales;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CashandCarry.Manager
{
    public partial class FrmOperater : Form
    {
        public FrmOperater()
        {
            InitializeComponent();
        }

        private void pnlmain_Paint(object sender, PaintEventArgs e)
        {

        }


        private void ShowForm(Form obj)
        {
            if (pnlmain.Controls.Count > 0)
            {
                pnlmain.Controls.Clear();
            }
            obj.TopLevel = false;
            obj.Dock = DockStyle.Fill;
            pnlmain.Controls.Add(obj);
            obj.Show();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            frmHomePage obj = new frmHomePage();
            ShowForm(obj);
        }

        private void btnSales_Click(object sender, EventArgs e)
        {
            frmSales objSale = new frmSales();
            ShowForm(objSale);
        }

        private void btnPuchase_Click(object sender, EventArgs e)
        {
            frmPurchase objPur = new frmPurchase();
            ShowForm(objPur);
        }

        

        private void FrmOperater_Load_1(object sender, EventArgs e)
        {
            frmHomePage objHome = new frmHomePage();
            ShowForm(objHome);
            lblUsername.Text = LoginInfoBL.Name;
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            FrmOperaterForReports objRep = new FrmOperaterForReports();
                ShowForm(objRep);
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            frmLogin objLog = new frmLogin();
            this.Hide();
            objLog.Show();
        }
    }
}
