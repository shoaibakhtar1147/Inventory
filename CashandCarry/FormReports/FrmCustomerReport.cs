using CashandCarry.BL;
using CashandCarry.Model;
using CashandCarry.Reports;
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
    public partial class FrmCustomerReport : Form
    {
        public FrmCustomerReport()
        {
            InitializeComponent();
        }

        private void btnCusName_Click(object sender, EventArgs e)
        {
            if(txtSearch.Text !=string.Empty)
            {
                CustomerBL objCus = new CustomerBL()
                {
                    CustomerID = Convert.ToInt32(txtSearch.Text)
                };
                tbl_Customer dt = objCus.Search();
                if (dt != null)
                {
                    dgvCus.DataSource = dt;
                }
            }
            else
            {
                CustomerBL objCus = new CustomerBL();
                List<View_tbl_Customer> dt = objCus.Select();
                if(dt!= null)
                {
                    dgvCus.DataSource = dt;
                }
            }
           
        }

        private void lblminimize_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            //LoadReport();
            //PrintDialog printDialog = new PrintDialog();
            //if(printDialog.ShowDialog()==DialogResult.OK)
            //{
            //    CrystalDecisions.Shared.OpenReportMethod reportDocument = new CrystalDecisions.Shared.OpenReportMethod();
            //    reportDocument.Load(Application.StartupPath,LoadReport());
            //    reportDocument.PrintOptions.PrinterName = printDialog.PrinterSettings.PrinterName;
            //    reportDocument.PrintToPrinter(printDialog.PrinterSettings.Copies, printDialog.PrinterSettings.Collate,printDialog.PrinterSettings.FromPage,printDialog.PrinterSettings.ToPage);

            //}
        }
        private void LoadReport()
        {
            CustomerReport objCus = new CustomerReport();
            if (!string.IsNullOrEmpty(txtSearch.Text))
            {
                objCus.SetParameterValue("@CustomerID", txtSearch.Text);
            }
            else
            {
                objCus.SetParameterValue("@CustomerID", null);
            }
            rptViewer obView = new rptViewer();
            obView.crptViewer.ReportSource = objCus;
            //obView.WindowState = FormWindowState.Maximized;
            //obView.ShowDialog();
        }
        private void btnView_Click(object sender, EventArgs e)
        {
            CustomerReport objCus = new CustomerReport();
            if (!string.IsNullOrEmpty(txtSearch.Text))
            {
                objCus.SetParameterValue("@CustomerID", txtSearch.Text);
            }
            else
            {
                objCus.SetParameterValue("@CustomerID", null);
            }
            rptViewer obView = new rptViewer();
            obView.crptViewer.ReportSource = objCus;
            obView.WindowState = FormWindowState.Maximized;
            obView.ShowDialog();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
