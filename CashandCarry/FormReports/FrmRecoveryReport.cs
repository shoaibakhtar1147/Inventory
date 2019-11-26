using CashandCarry.Reports.Customer;
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
                objrpt.SetParameterValue("@RecoveryID", txtRecoveryID.Text);
                crptViewerRecovery.ReportSource = objrpt;
            }
            else if(!string.IsNullOrEmpty(txtCusID.Text))
            {
                RecoveryByCusIDReport objCus = new RecoveryByCusIDReport();
                objCus.SetParameterValue("@CustomerID", txtCusID.Text);
                crptViewerRecovery.ReportSource = objCus;
            }
        }
    }
}
