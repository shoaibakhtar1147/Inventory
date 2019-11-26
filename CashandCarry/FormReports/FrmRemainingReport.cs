using CashandCarry.Reports;
using CashandCarry.Reports.Company;
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
                objrpt.SetParameterValue("@RemainID", txtRemainID.Text);
                crptViewerRemain.ReportSource = objrpt;
            }
            else if(!string.IsNullOrEmpty(txtComID.Text))
            {
                RemainByComIDReport objCom = new RemainByComIDReport();
                objCom.SetParameterValue("@ComID", txtComID.Text);
                crptViewerRemain.ReportSource = objCom;
            }

            else
            {
                MessageBox.Show("Please Enter Company ID Or Remaining ID");
            }
        }

        
    }
}
