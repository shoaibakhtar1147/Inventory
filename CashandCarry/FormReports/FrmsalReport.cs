using CashandCarry.BL;
using CashandCarry.Reports;
using CashandCarry.Reports.Sale;
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
    public partial class FrmsalReport : MetroForm
    {
        public FrmsalReport()
        {
            InitializeComponent();
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            SaleGeneralReport objrep = new SaleGeneralReport();
            rptViewer objView = new rptViewer();
            objrep.SetParameterValue("@mindate", txtMinDate.Value);
            objrep.SetParameterValue("@maxdate", txtmaxdate.Value);
            SaleInvoiceBL obj = new SaleInvoiceBL()
            {
                mindate = Convert.ToDateTime(txtMinDate.Value),
                maxdate = Convert.ToDateTime(txtmaxdate.Value)
            };
            DataTable dt = obj.SelectByDate();
            if (dt.Rows.Count > 0)
            {
                objrep.SetDataSource(dt);

                objView.crptViewer.ReportSource = objrep;
                objView.WindowState = FormWindowState.Maximized;
                objView.ShowDialog();
            }
            else
            {
                MessageBox.Show("No Record Found");
            }
            
           
            
        }

        private void btnCusName_Click(object sender, EventArgs e)
        {
            if(!String.IsNullOrEmpty(txtCus.Text))
            {

                SaleByCusReport objSale = new SaleByCusReport();
                rptViewer objView = new rptViewer();
                objSale.SetParameterValue("@CusID", txtCus.Text);
                SaleInvoiceBL objsal = new SaleInvoiceBL()
                {
                    CustomerID = Convert.ToInt32(txtCus.Text)
                };
                DataTable dt = objsal.SelectByCus();
                if (dt.Rows.Count > 0)
                {
                    objSale.SetDataSource(dt);
                    // btnCusprint.Visible = true;
                    objView.crptViewer.ReportSource = objSale;
                    objView.WindowState = FormWindowState.Maximized;
                    objView.ShowDialog();
                    txtCus.Clear();
                }
                else
                {
                    MessageBox.Show("No Record Found");
                }
                
           
            
            
            }
            else if(!String.IsNullOrEmpty(txtinvoiceNo.Text))
            {
                 saleInvoiceReport objSale = new saleInvoiceReport();
                 rptViewer objView = new rptViewer();
                objSale.SetParameterValue("@InvoiceNo", txtinvoiceNo.Text);
                SaleInvoiceBL obj = new SaleInvoiceBL()
                {
                    InvoiceNo = Convert.ToInt32(txtinvoiceNo.Text)
                };
                DataTable dt = obj.Search();
                if (dt.Rows.Count > 0)
                {
                    objSale.SetDataSource(dt);

                    objView.crptViewer.ReportSource = objSale;
                    objView.WindowState = FormWindowState.Maximized;
                    objView.ShowDialog();
                    txtinvoiceNo.Clear();
                }
                //crptViewerSale.ReportSource = objSale;
                else
                {
                    MessageBox.Show("No Record Found");
                }
            }
            else
            {
                MessageBox.Show("Please Enter Customer ID OR Return Invoice");
            }
            
        }

        private void FrmsalReport_Load(object sender, EventArgs e)
        {

        }
    }
}
