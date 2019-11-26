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
                objrpt.SetParameterValue("@SalaryID", txtsalaryID.Text);
                crptViewerEmp.ReportSource = objrpt;
            }
            else if(!string.IsNullOrEmpty(txtEmpID.Text))
            {
                EmpAllSalaryReport obj = new EmpAllSalaryReport();
                obj.SetParameterValue("@EmployeeID", txtEmpID.Text);
                crptViewerEmp.ReportSource = obj;
            }
        }
    }
}
