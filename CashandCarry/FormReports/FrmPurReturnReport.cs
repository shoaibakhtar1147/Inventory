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
            objRet.SetParameterValue("@MinDate", txtMinDate.Text);
            objRet.SetParameterValue("@MaxDate", txtmaxdate.Text);
            crptViewerPurchaseReturn.ReportSource = objRet;
            
        }

        private void btnComName_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(txtComname.Text))
            {
                PurReturnByComReport objRep = new PurReturnByComReport();
                objRep.SetParameterValue("@ComID", txtComname.Text);
                crptViewerPurchaseReturn.ReportSource = objRep;
            }
        }
    }
}
