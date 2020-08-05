using CashandCarry.BL;
using CashandCarry.Reports;
using CashandCarry.Reports.PurchaseReturn;
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
    public partial class FrmPurReturnReport : MetroForm
    {
        public FrmPurReturnReport()
        {
            InitializeComponent();
        }

        private void FrmPurReturnReport_Load(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            PurReturnGeneralReport objRet = new PurReturnGeneralReport();
            rptViewer objView = new rptViewer();
            objRet.SetParameterValue("@MinDate", txtMinDate.Text);
            objRet.SetParameterValue("@MaxDate", txtmaxdate.Text);
            PurchaseReturnBL objBl = new PurchaseReturnBL() 
            {
            minDate=Convert.ToDateTime(txtMinDate.Text),
            maxDate=Convert.ToDateTime(txtmaxdate.Text)
            };
            var dt = objBl.SearchByDateDiff();
            if(dt !=null)
            {
                objRet.SetDataSource(dt);
                objView.crptViewer.ReportSource = objRet;
                objView.WindowState = FormWindowState.Maximized;
                objView.ShowDialog();
                
            }

            else
            {
                MessageBox.Show("No Record Found");
            }
            //crptViewerPurchaseReturn.ReportSource = objRet;
            
        }

        private void btnComName_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(txtComname.Text))
            {
                PurReturnByComReport objRep = new PurReturnByComReport();
                rptViewer objView = new rptViewer();
                objRep.SetParameterValue("@ComID", txtComname.Text);
                PurchaseReturnBL objBl = new PurchaseReturnBL() 
                {
                CompanyID=Convert.ToInt32(txtComname.Text)
                };
                var dt = objBl.SearchByComId();
                if(dt != null)
                {
                    objRep.SetDataSource(dt);
                    objView.crptViewer.ReportSource = objRep;
                    objView.crptViewer.RefreshReport();
                    objView.WindowState = FormWindowState.Maximized;
                    objView.ShowDialog();
                }

                else
                {
                    MessageBox.Show("No Record Found");
                }
                //crptViewerPurchaseReturn.ReportSource = objRep;
                //crptViewerPurchaseReturn.RefreshReport();
            }
            else if(!string.IsNullOrEmpty(txtInvoice.Text))
            {
                PurReturnInvoiceReport objret = new PurReturnInvoiceReport();
                rptViewer objView = new rptViewer();
                objret.SetParameterValue("@PReturnID", txtInvoice.Text);
                PurchaseReturnBL objBl = new PurchaseReturnBL() 
                {
                PReturnID=Convert.ToInt32(txtInvoice.Text)
                };
                var dt = objBl.SearchByInovice();
                if(dt != null)
                {
                    objret.SetDataSource(dt);
                    objView.crptViewer.ReportSource = objret;
                    objView.crptViewer.RefreshReport();
                    objView.WindowState = FormWindowState.Maximized;
                    objView.ShowDialog();
                }

                else
                {
                    MessageBox.Show("No Record Found");
                }
                //crptViewerPurchaseReturn.ReportSource = objret;
                //crptViewerPurchaseReturn.RefreshReport();
            }
        }
    }
}
