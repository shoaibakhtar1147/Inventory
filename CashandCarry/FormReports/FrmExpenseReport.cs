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
            objrep.SetParameterValue("@mindate", txtMinDate.Value);
            objrep.SetParameterValue("@maxdate", txtmaxdate.Value);
            crptViewerExpense.ReportSource = objrep;
        }
    }
}
