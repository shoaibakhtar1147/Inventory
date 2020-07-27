using CashandCarry.BL;
using CashandCarry.Reports;
using CashandCarry.Reports.Purchase;
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

namespace CashandCarry.Vendor
{
    public partial class FrmPurchaseLedger : MetroForm
    {
        public FrmPurchaseLedger()
        {
            InitializeComponent();
        }

        private void FrmPurchaseLedger_Load(object sender, EventArgs e)
        {
            GridDesign();
        }

        private void GridDesign()
        {
            dgvCompany.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dgvCompany.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvCompany.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            dgvCompany.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dgvCompany.BackgroundColor = Color.White;

            dgvCompany.EnableHeadersVisualStyles = false;
            dgvCompany.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvCompany.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            dgvCompany.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            PurchaseLedgerBL objLedger = new PurchaseLedgerBL() 
            {
            CompanyID=Convert.ToInt32(txtSearch.Text)
            };
            var dt=objLedger.search();
            if(dt != null)
            {
                dgvCompany.DataSource = dt;
                this.dgvCompany.Columns["PTid"].Visible = false;
            }
            else
            {
                MessageBox.Show("No Record Found " + txtSearch.Text);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txtSearch.Text))
            {
                MessageBox.Show("Please Enter Company id");
                
            }
            else 
            {
                PurLedger objrpt = new PurLedger();
                rptViewer objview = new rptViewer();
                objrpt.SetParameterValue("@CompanyID", txtSearch.Text);
                PurchaseLedgerBL objLedger = new PurchaseLedgerBL() 
                {
                    CompanyID=Convert.ToInt32(txtSearch.Text)
                };
                DataTable dt = objLedger.Search();
                if(dt!= null)
                {
                    objrpt.SetDataSource(dt);
                    objview.crptViewer.ReportSource = objrpt;
                    objview.WindowState = FormWindowState.Normal;
                    objview.ShowDialog();
                }

            }
        }
    }
}
