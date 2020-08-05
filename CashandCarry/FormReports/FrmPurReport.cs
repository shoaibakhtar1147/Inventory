using CashandCarry.BL;
using CashandCarry.Reports;
using CashandCarry.Reports.Purchase;
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

namespace CashandCarry.FormReports
{
    public partial class FrmPurReport : MetroForm
    {
        public FrmPurReport()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            PurchaseGeneralReport objPur = new PurchaseGeneralReport();
            rptViewer objView = new rptViewer();
            objPur.SetParameterValue("@mindate", txtMinDate.Value);
            objPur.SetParameterValue("@maxdate", txtmaxdate.Value);
            PurchaseInvoiceBL obj = new PurchaseInvoiceBL()
            {
                mindate = Convert.ToDateTime(txtMinDate.Value),
                maxdate = Convert.ToDateTime(txtmaxdate.Value)
            };
            DataTable dt = obj.SelectByDate();
            if (dt.Rows.Count > 0)
            {
                objPur.SetDataSource(dt);
                objView.crptViewer.ReportSource = objPur;
                objView.WindowState = FormWindowState.Maximized;
                objView.ShowDialog();
            }
            else
            {
                MessageBox.Show("No Record Found");
            }
           // crptViewerPurchase.ReportSource = objPur;
           
        }

        private void btnCusName_Click(object sender, EventArgs e)
        {
           if(!string.IsNullOrEmpty(txtComname.Text))
           {
               PurchaseReportCom objPur = new PurchaseReportCom();
               rptViewer objView = new rptViewer();
               objPur.SetParameterValue("@CompanyID", txtComname.Text);
               PurchaseInvoiceBL obj = new PurchaseInvoiceBL()
                  {
                      companyID = Convert.ToInt32(txtComname.Text)
                  };
               DataTable dt = obj.SelectByCompany();
               if (dt.Rows.Count > 0)
               {
                   objPur.SetDataSource(dt);
                   objView.crptViewer.ReportSource = objPur;
                   objView.WindowState = FormWindowState.Maximized;
                   objView.ShowDialog();
               }

               else
               {
                   MessageBox.Show("No Record Found");
               }
                  // crptViewerPurchase.ReportSource = objPur;
            }
           else if(!string.IsNullOrEmpty(txtInvoice.Text))
           {
               PurchaseInvoiceReport objPurchase = new PurchaseInvoiceReport();
               rptViewer objView = new rptViewer();
               objPurchase.SetParameterValue("@PInvoice", txtInvoice.Text);
               PurchaseInvoiceBL obj = new PurchaseInvoiceBL()
               {
                   PInvoice = Convert.ToInt32(txtInvoice.Text)
               };
               DataTable dt = obj.Search();
               if (dt.Rows.Count > 0)
               {
                   objPurchase.SetDataSource(dt);
                   objView.crptViewer.ReportSource = objPurchase;
                   objView.WindowState = FormWindowState.Maximized;
                   objView.ShowDialog();


               }
               else
               {
                   MessageBox.Show("No Record Found");
               }
               //crptViewerPurchase.ReportSource = objPurchase;
               txtInvoice.Clear();
           }
            else
            {
                MessageBox.Show("Please Enter Company ID");
            }
        }

        private void FrmPurReport_Load(object sender, EventArgs e)
        {

        }
    }
}
