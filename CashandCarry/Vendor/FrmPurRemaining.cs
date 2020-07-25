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

namespace CashandCarry.Vendor
{
    public partial class FrmPurRemaining : MetroForm
    {
        public FrmPurRemaining()
        {
            InitializeComponent();
        }

        private void FrmPurRemaining_Load(object sender, EventArgs e)
        {
            FormDisable();
        }

        private void FormDisable()
        {
            txtRemainID.Enabled = false;
            txtComID.Enabled = false;
            txtComName.Enabled = false;
            txtDate.Enabled = false;
            txtPreBalance.Enabled = false;
            txtReturnCash.Enabled = false;
            txtSearch.Enabled = false;
            btnSearch.Enabled = false;
            btnSave.Enabled = false;
            btnClear.Enabled = false;
        }

        private void btnAddnew_Click(object sender, EventArgs e)
        {
            PurRemainBL objPur = new PurRemainBL();
            DataTable dt = objPur.Addnew();
            if(dt.Rows.Count>0)
            {
                txtRemainID.Text = Convert.ToString(dt.Rows[0]["RemainID"]);
                FormEnable();
                txtSearch.Focus();
            }
        }

        private void FormEnable()
        {
            
            txtReturnCash.Enabled = true;
            txtSearch.Enabled = true;
            btnSearch.Enabled = true;
            btnSave.Enabled = true;
            btnClear.Enabled = true;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            CompanyBL objCom = new CompanyBL() 
            {
             CompanyID=Convert.ToInt32(txtSearch.Text)
            };
            var dt = objCom.Search();
            dgvPurRemain.Columns.Clear();
            if(dt.Count>0)
            {
                DataGridViewImageColumn edit = new DataGridViewImageColumn();
                edit.Image = Properties.Resources.edit;
                edit.ImageLayout = DataGridViewImageCellLayout.Zoom;
                edit.HeaderText = "Edit";
                edit.Width = 20;
                dgvPurRemain.Columns.Add(edit);
                dgvPurRemain.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                
                dgvPurRemain.DataSource = dt;
            }
            else
            {
                MessageBox.Show("Record Not Found Or Invalid Record");
            }
        }

        private void dgvPurRemain_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int columnindex = e.ColumnIndex;
            int rowindex = e.RowIndex;
            if(columnindex ==0)
            {
                txtComID.Text = dgvPurRemain.Rows[rowindex].Cells[1].Value.ToString();
                txtComName.Text = dgvPurRemain.Rows[rowindex].Cells[2].Value.ToString();
                txtPreBalance.Text = dgvPurRemain.Rows[rowindex].Cells[6].Value.ToString();
                txtReturnCash.Focus();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            PurRemainBL objPur = new PurRemainBL() 
            {
             CompanyID=Convert.ToInt32(txtComID.Text),
              Date=Convert.ToDateTime(txtDate.Text),
               ReturnCash=Convert.ToDecimal(txtReturnCash.Text)
            };
            objPur.Save();

            PurchaseLedgerBL objLedger = new PurchaseLedgerBL();
            if (string.IsNullOrEmpty(txtDescription.Text))
            {
                objLedger.PRemainID = Convert.ToInt32(txtRemainID.Text);
                objLedger.CompanyID = Convert.ToInt32(txtComID.Text);
                objLedger.Credit = 0;
                objLedger.Debit = Convert.ToDecimal(txtReturnCash.Text);
                objLedger.Date = Convert.ToDateTime(txtDate.Text);
                objLedger.Balance = Convert.ToDecimal(txtNewBalance.Text);
                objLedger.Description = "Credit";
            }
            else
            {
                
                objLedger.PRemainID = Convert.ToInt32(txtRemainID.Text);
                objLedger.CompanyID = Convert.ToInt32(txtComID.Text);
                objLedger.Credit = 0;
                objLedger.Debit = Convert.ToDecimal(txtReturnCash.Text);
                objLedger.Date = Convert.ToDateTime(txtDate.Text);
                objLedger.Balance = Convert.ToDecimal(txtNewBalance.Text);
                objLedger.Description = txtDescription.Text;
            }
            objLedger.save();
            (new PurchaseLedgerBL()).UpdateBalance(objLedger.Balance,objLedger.CompanyID); 
            //PurchaseReturnBL obj = new PurchaseReturnBL() 
            //{ 
            // CompanyID=Convert.ToInt32(txtComID.Text),
            // DuePayment =Convert.ToDecimal(txtReturnCash.Text)
            //};
            //obj.UpdateDuePayment();
            MessageBox.Show("Payment Paid "+ txtReturnCash.Text);

            PurRemainIDReport objrpt = new PurRemainIDReport();

            objrpt.SetParameterValue("@RemainID", txtRemainID.Text);
            rptViewer objView = new rptViewer();
            objView.crptViewer.ReportSource = objrpt;
            objView.WindowState = FormWindowState.Normal;
            objView.ShowDialog();

             ClearGroup();
        }

        private void ClearGroup()
        {
            foreach (Control c in groupBox1.Controls)
            {
                if (c is TextBox || c is ComboBox)
                {
                    c.Text = "";
                }

            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearGroup();
            txtSearch.Clear();
            
           

        }
    }
}
