using CashandCarry.BL;
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
            PurchaseInvoiceBL obj = new PurchaseInvoiceBL()
            {
                mindate = Convert.ToDateTime(txtMinDate.Value),
                maxdate = Convert.ToDateTime(txtmaxdate.Value)
            };
            DataTable dt = obj.SelectByDate();
            if (dt.Rows.Count > 0)
            {
                objPur.SetDataSource(dt);
            }
            crptViewerPurchase.ReportSource = objPur;
           
        }

        private void btnCusName_Click(object sender, EventArgs e)
        {
            PurchaseReportCom objPur = new  PurchaseReportCom();

            if(!string.IsNullOrEmpty(txtComname.Text))
            {
                objPur.SetParameterValue("@CompanyID", txtComname.Text);
                PurchaseInvoiceBL obj = new PurchaseInvoiceBL()
                {
                    companyID = Convert.ToInt32(txtComname.Text)
                };
                DataTable dt = obj.SelectByCompany();
                if (dt.Rows.Count > 0)
                {
                    objPur.SetDataSource(dt);
                    crptViewerPurchase.ReportSource = objPur;
                }
            }
            else
            {
                MessageBox.Show("Please Enter Company ID");
            }
        }

        private void FrmPurReport_Load(object sender, EventArgs e)
        {

        }
    }
}
