using CashandCarry.BL;
using CashandCarry.Reports;
using CashandCarry.Reports.Purchase;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CashandCarry.FormReports
{
    public partial class FrmPurchaseReport : Form
    {
        public FrmPurchaseReport()
        {
            InitializeComponent();
        }
        private bool isReport1 = false;

        private void btnSearchdate_Click(object sender, EventArgs e)
        {
            PurchaseInvoiceBL objPur = new PurchaseInvoiceBL()
            {
                mindate = Convert.ToDateTime(txtMinDate.Value),
                maxdate = Convert.ToDateTime(txtmaxdate.Value)
            };
            DataTable dt = objPur.SelectByDate();
            if (dt.Rows.Count > 0)
            {
                dgvPurchase.DataSource = dt;
                btnPrint.Visible = true;
            }
            isReport1 = true;

            
        }

        private void btnComName_Click(object sender, EventArgs e)
        {
            isReport1 = false;
            PurchaseInvoiceBL objpur = new PurchaseInvoiceBL()
            {
                CompanyName = txtCompName.Text
            };
            DataTable dt = objpur.SelectByCompany();
            if (dt.Rows.Count > 0)
            {
                dgvPurchase.DataSource = dt;
               // btnComprint.Visible = true;
            }
         
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (isReport1)
            {
                PurchaseGeneralReport objPur = new PurchaseGeneralReport();
                rptViewer objView = new rptViewer();
                objPur.SetParameterValue("@mindate", txtMinDate.Value);
                objPur.SetParameterValue("@maxdate", txtmaxdate.Value);
                objView.crptViewer.ReportSource = objPur;
                objView.WindowState = FormWindowState.Normal;
                objView.ShowDialog();
            }
            else
            {
                PurchaseByCompReport objPur = new PurchaseByCompReport();
                rptViewer objView = new rptViewer();
                objPur.SetParameterValue("@CompanyName", txtCompName.Text);
                objView.crptViewer.ReportSource = objPur;
                objView.WindowState = FormWindowState.Normal;
                objView.ShowDialog();
            }
            
        }

      
        private void FrmPurchaseReport_Load(object sender, EventArgs e)
        {
            
        }

        private void lblminimize_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
