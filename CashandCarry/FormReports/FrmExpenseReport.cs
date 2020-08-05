using CashandCarry.BL;
using CashandCarry.Reports;
using CashandCarry.Reports.Expense;
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
    public partial class FrmExpenseReport : MetroForm
    {
        public FrmExpenseReport()
        {
            InitializeComponent();
        }

        private void FrmExpenseReport_Load(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            ExpenseReport objrep = new  ExpenseReport();
            rptViewer objView = new rptViewer();
            objrep.SetParameterValue("@mindate", txtMinDate.Value);
            objrep.SetParameterValue("@maxdate", txtmaxdate.Value);

            ExpenseBL objBL = new ExpenseBL() 
            {
                mindate=Convert.ToDateTime(txtMinDate.Text),
                maxdate=Convert.ToDateTime(txtmaxdate.Text)
            };
            var dt = objBL.SelectByDateDiff();
            if(dt != null)
            {
                objrep.SetDataSource(dt);
                objView.crptViewer.ReportSource = objrep;
                objView.WindowState = FormWindowState.Maximized;
                objView.ShowDialog();
            }
            else
            {
                MessageBox.Show("No Record Found");
            }
            //crptViewerExpense.ReportSource = objrep;
        }
    }
}
