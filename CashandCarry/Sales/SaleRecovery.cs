using CashandCarry.BL;
using CashandCarry.Reports;
using CashandCarry.Reports.Customer;
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

namespace CashandCarry.Sales
{
    public partial class SaleRecovery : MetroForm
    {
        public SaleRecovery()
        {
            InitializeComponent();
        }

        private void SaleRecovery_Load(object sender, EventArgs e)
        {
            FormDisable();
        }

        private void FormDisable()
        {
            txtCusID.Enabled = false;
            txtCusName.Enabled = false;
            txtDuePayment.Enabled = false;
            txtRecoveryDate.Enabled = false;
            txtReturnCash.Enabled = false;
            btnSave.Enabled = false;
            btnClear.Enabled = false;
            btnSearch.Enabled = false;
            txtSearch.Enabled = false;
        }
        private void FormEnable()
        {
            txtRecoveryDate.Enabled = true;
            txtReturnCash.Enabled = true;
            btnSave.Enabled = true;
            btnSearch.Enabled = true;
            txtSearch.Enabled = true;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
          SaleRecoveryBL objRec=new SaleRecoveryBL()
            {
            CustomerID=Convert.ToInt32(txtSearch.Text)
            };
            var dt = objRec.Search();
            dgvSaleRecovery.Columns.Clear();
            if(dt.Count>0)
            {
                DataGridViewImageColumn edit = new DataGridViewImageColumn();
                edit.Image = Properties.Resources.edit;
                edit.ImageLayout = DataGridViewImageCellLayout.Zoom;
                edit.HeaderText = "Edit";
                edit.Width = 20;
                dgvSaleRecovery.Columns.Add(edit); 
                dgvSaleRecovery.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgvSaleRecovery.DataSource = dt;
            }
            else
            {
                MessageBox.Show("Record Not Found Or Invalid Record");
            }
        }

        private void dgvSaleRecovery_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int columnindex = e.ColumnIndex;
            int rowindex = e.RowIndex;
            if(columnindex==0)
            {
                txtCusID.Text = dgvSaleRecovery.Rows[rowindex].Cells[1].Value.ToString();
                txtCusName.Text = dgvSaleRecovery.Rows[rowindex].Cells[2].Value.ToString();
                txtDuePayment.Text = dgvSaleRecovery.Rows[rowindex].Cells[8].Value.ToString();
            }
        }

        private void btnAddnew_Click(object sender, EventArgs e)
        {
            SaleRecoveryBL obj = new SaleRecoveryBL();
           DataTable dt = obj.Addnew();
            if(dt.Rows.Count>0)
            {
                txtSRecoveryID.Text = Convert.ToString(dt.Rows[0]["SRecoveryID"]);
                FormEnable();
                txtSearch.Focus();
            }

            
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaleRecoveryBL objRec = new SaleRecoveryBL() 
            {
                 CustomerID=Convert.ToInt32(txtCusID.Text),
                  ReturnCash=Convert.ToDecimal(txtReturnCash.Text),
                   RecoveryDate=Convert.ToDateTime(txtRecoveryDate.Text)

            };
            objRec.Save();

            ReturnSaleBL objRet = new ReturnSaleBL() 
            {
              CustomerID = Convert.ToInt32(txtCusID.Text),
                DuePayment = Convert.ToDecimal(txtReturnCash.Text)
            };
            objRet.UpdateDueSub();

            SaleRecoveryIDReport objrpt = new SaleRecoveryIDReport();
            objrpt.SetParameterValue("@RecoveryID", txtSRecoveryID.Text);
            rptViewer objView = new rptViewer();
            objView.crptViewer.ReportSource = objrpt;
            //objView.crptViewer.RefreshReport();
            objView.WindowState = FormWindowState.Normal;
            objView.ShowDialog();
            
        }
    }
}
