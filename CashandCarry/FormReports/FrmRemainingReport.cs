using CashandCarry.BL;
using CashandCarry.Reports;
using CashandCarry.Reports.Company;
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
    public partial class FrmRemainingReport : MetroForm
    {
        public FrmRemainingReport()
        {
            InitializeComponent();
        }

        private void FrmRemainingReport_Load(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(txtRemainID.Text))
            {
                PurRemainIDReport objrpt = new PurRemainIDReport();
                rptViewer objView = new rptViewer();
                objrpt.SetParameterValue("@RemainID", txtRemainID.Text);
                PurRemainBL objBl = new PurRemainBL() 
                {
                PRemainID=Convert.ToInt32(txtRemainID.Text)
                };
                var dt = objBl.SearchByRemainID();
                if(dt != null)
                {
                    objrpt.SetDataSource(dt);
                    objView.crptViewer.ReportSource = objrpt;
                    objView.WindowState = FormWindowState.Maximized;
                    objView.ShowDialog();

                }
                else
                {
                    MessageBox.Show("No Record Found");
                }
                //crptViewerRemain.ReportSource = objrpt;
            }
            else if(!string.IsNullOrEmpty(txtComID.Text))
            {
                PurLedger objrpt = new PurLedger();
                rptViewer objview = new rptViewer();
                objrpt.SetParameterValue("@CompanyID", txtComID.Text);
                PurchaseLedgerBL objLedger = new PurchaseLedgerBL()
                {
                    CompanyID = Convert.ToInt32(txtComID.Text)
                };
                DataTable dt = objLedger.Search();
                if(dt !=null)
                {
                    objrpt.SetDataSource(dt);
                    objview.crptViewer.ReportSource = objrpt;
                    objview.WindowState = FormWindowState.Maximized;
                    objview.ShowDialog();
                }
                else
                {
                    MessageBox.Show("No Record Found");
                }
                
                //crptViewerRemain.ReportSource = objCom;
            }

            else
            {
                MessageBox.Show("Please Enter Company ID Or Remaining ID");
            }
        }

        
    }
}
