using CashandCarry.BL;
using CashandCarry.Reports;
using CashandCarry.Reports.Customer;
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
    public partial class FrmRecoveryReport : MetroForm
    {
        public FrmRecoveryReport()
        {
            InitializeComponent();
        }

        private void FrmRecoveryReport_Load(object sender, EventArgs e)
        {

        }

        private void btnCusName_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(txtRecoveryID.Text))
            {
                SaleRecoveryIDReport objrpt = new SaleRecoveryIDReport();
                rptViewer objView = new rptViewer();
                objrpt.SetParameterValue("@RecoveryID", txtRecoveryID.Text);
                SaleRecoveryBL objBl = new SaleRecoveryBL()
                {
                    SRecoveryID = Convert.ToInt32(txtRecoveryID.Text)
                };
                var dt = objBl.SearchByRecoveryID();
                if (dt != null)
                {
                    objrpt.SetDataSource(dt);
                    objView.crptViewer.ReportSource = objrpt;
                    objView.WindowState = FormWindowState.Maximized;
                    objView.ShowDialog();
                    txtRecoveryID.Clear();
                }
                else
                {
                    MessageBox.Show("No Record Found");
                }
                
                
                //crptViewerRecovery.ReportSource = objrpt;
            }
            else if(!string.IsNullOrEmpty(txtCusID.Text))
            {
                SaleLedgerReport objSale = new SaleLedgerReport();
                rptViewer objView = new rptViewer();
                objSale.SetParameterValue("@CustomerID", txtCusID.Text);
                SaleLedgerBL objLedger = new SaleLedgerBL()
                {
                    CustomerID = Convert.ToInt32(txtCusID.Text)
                };
                DataTable dt = objLedger.Search();
                if(dt != null)
                {
                    objSale.SetDataSource(dt);
                    objView.crptViewer.ReportSource = objSale;
                    objView.WindowState = FormWindowState.Maximized;
                    objView.ShowDialog();
                    txtCusID.Clear();
                }
                //crptViewerRecovery.ReportSource = objCus;
                else
                {
                    MessageBox.Show("No Record Found");
                }
            }
        }
    }
}
