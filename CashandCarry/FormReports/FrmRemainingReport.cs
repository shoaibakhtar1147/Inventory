using CashandCarry.BL;
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
                RemainByComIDReport objCom = new RemainByComIDReport();
                rptViewer objView = new rptViewer();
                objCom.SetParameterValue("@ComID", txtComID.Text);
                PurRemainBL objBL = new PurRemainBL() 
                {
                CompanyID=Convert.ToInt32(txtComID.Text)
                };
                var dt = objBL.SearchByComID();
                if(dt !=null)
                {
                    objCom.SetDataSource(dt);
                    objView.crptViewer.ReportSource = objCom;
                    objView.WindowState = FormWindowState.Maximized;
                    objView.ShowDialog();
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
