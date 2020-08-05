using CashandCarry.BL;
using CashandCarry.Reports;
using CashandCarry.Reports.EmployeeRpt;
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
    public partial class FrmEmployeeReport : MetroForm
    {
        public FrmEmployeeReport()
        {
            InitializeComponent();
        }

        private void FrmEmployeeReport_Load(object sender, EventArgs e)
        {

        }

        private void btnCusName_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(txtsalaryID.Text))
            {
                EmpSalaryReport objrpt = new EmpSalaryReport();
                rptViewer objView = new rptViewer();
                objrpt.SetParameterValue("@SalaryID", txtsalaryID.Text);
                EmpSalaryBL objBL = new EmpSalaryBL() 
                {
                SalaryID=Convert.ToInt32(txtsalaryID.Text)
                };
                var dt = objBL.SalaryIDSelect();
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
                //crptViewerEmp.ReportSource = objrpt;
            }
            else if(!string.IsNullOrEmpty(txtEmpID.Text))
            {
                EmpAllSalaryReport obj = new EmpAllSalaryReport();
                rptViewer objView = new rptViewer();
                obj.SetParameterValue("@EmployeeID", txtEmpID.Text);
                EmpSalaryBL objBL = new EmpSalaryBL() 
                {
                EmployeeID=Convert.ToInt32(txtEmpID.Text)
                };
                var dt = objBL.EmployeeIDSelect();
                if(dt != null)
                {
                    obj.SetDataSource(dt);
                    objView.crptViewer.ReportSource = obj;
                    objView.WindowState = FormWindowState.Maximized;
                    objView.ShowDialog();
                }
                else
                {
                    MessageBox.Show("No Record Found");
                }
                //crptViewerEmp.ReportSource = obj;
            }
        }
    }
}
