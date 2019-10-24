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
    public partial class FrmPurReport : Form
    {
        public FrmPurReport()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            PurchaseGeneralReport objPur = new PurchaseGeneralReport();
           
            objPur.SetParameterValue("@mindate", txtMinDate.Value);
            objPur.SetParameterValue("@maxdate", txtmaxdate.Value);
            crptViewerPurchase.ReportSource = objPur;
           
        }

        private void btnCusName_Click(object sender, EventArgs e)
        {
            PurchaseByCompReport objPur = new PurchaseByCompReport();
           
            objPur.SetParameterValue("@CompanyName", txtComname.Text);
            crptViewerPurchase.ReportSource = objPur;
           
        }
    }
}
