using CashandCarry.BL;
using CashandCarry.Reports;
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
    public partial class FrmSaleReport : Form
    {
        public FrmSaleReport()
        {
            InitializeComponent();
        }
        private bool isReport1 = false;

        private void btnSearch_Click(object sender, EventArgs e)
        {
            
            SaleInvoiceBL obj = new SaleInvoiceBL()
            {
                mindate = Convert.ToDateTime(txtMinDate.Value),
                maxdate = Convert.ToDateTime(txtmaxdate.Value)
            };
            DataTable dt = obj.SelectByDate();
            if (dt.Rows.Count > 0)
            {
                dgvSale.DataSource = dt;
                btnPrint.Visible = true;
            }
            isReport1 = true;
        }

        private void btnCusName_Click(object sender, EventArgs e)
        {
            isReport1 = false;
            SaleInvoiceBL objsal = new SaleInvoiceBL()
            {
                CusName = txtCusnam.Text
            };
            DataTable dt = objsal.SelectByCus();
            if (dt.Rows.Count > 0)
            {
                dgvSale.DataSource = dt;
               // btnCusprint.Visible = true;
            }
        }

        private void FrmSaleReport_Load(object sender, EventArgs e)
        {
            btnPrint.Hide();
          
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            if(isReport1)
            {
                SaleGeneralReport objrep = new SaleGeneralReport();
                rptViewer objview = new rptViewer();
                //objSale.SetDataSource =;
                objrep.SetParameterValue("@mindate", txtMinDate.Value);
                objrep.SetParameterValue("@maxdate", txtmaxdate.Value);
                objview.crptViewer.ReportSource = objrep;
                objview.WindowState = FormWindowState.Normal;
                objview.ShowDialog();
            }
            else
            {
                SaleByCusReport objSale = new SaleByCusReport();
                rptViewer objView = new rptViewer();
                objSale.SetParameterValue("@CusName", txtCusnam.Text);
                objView.crptViewer.ReportSource = objSale;
                objView.WindowState = FormWindowState.Normal;
                objView.ShowDialog();
            }
        }

        private void btnCusprint_Click(object sender, EventArgs e)
        {
            
        }

        private void lblminimize_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
