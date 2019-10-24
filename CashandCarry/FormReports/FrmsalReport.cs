using CashandCarry.Reports.Sale;
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
    public partial class FrmsalReport : Form
    {
        public FrmsalReport()
        {
            InitializeComponent();
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            SaleGeneralReport objrep = new SaleGeneralReport();
          
            //objSale.SetDataSource =;
            objrep.SetParameterValue("@mindate", txtMinDate.Value);
            objrep.SetParameterValue("@maxdate", txtmaxdate.Value);
            crptViewerSale.ReportSource = objrep;

            
        }

        private void btnCusName_Click(object sender, EventArgs e)
        {
            SaleByCusReport objSale = new SaleByCusReport();
            objSale.SetParameterValue("@CusName", txtCusnam.Text);
            crptViewerSale.ReportSource = objSale;

            
        }
    }
}
