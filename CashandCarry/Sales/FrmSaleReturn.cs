using CashandCarry.BL;
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
    public partial class FrmSaleReturn : Form
    {
        public FrmSaleReturn()
        {
            InitializeComponent();
        }

        private void label19_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void dgvPaymentInfo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtPayment_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox7_Enter(object sender, EventArgs e)
        {

        }
        private void FormDisable()
        {
            txtCusName.Enabled = false;
            txtCusID.Enabled = false;
            txtDiscount.Enabled = false;
            txtReturnDate.Enabled = false;
            txtReturnID.Enabled = false;
            txtQuantity.Enabled = false;
            txtContact.Enabled = false;
            txtDiscount.Enabled = false;

            
            txtProdName.Enabled = false;
            txtProdID.Enabled = false;
            
            txtPrice.Enabled = false;
            txtAmount.Enabled = false;
            txtPrice.Enabled = false;
            txtPayMode.Enabled = false;
            txtInvoiceID.Enabled = false;
            txtTotalAmount.Enabled = false;
            btnSave.Enabled = false;
            btnSearch.Enabled = false;
            txtCusName.Enabled = false;
            txtProdID.Enabled = false;
            txtDiscount.Enabled = false;
            btnProdUpdate.Enabled = false;
            btnRemove.Enabled = false;
            btnAdd.Enabled = false;
            btnReset.Enabled = false;
            btnClear.Enabled = false;
            txtPayment.Enabled = false;
            txtDuePay.Enabled = false;
            
           
        }

        private void FormEnable()
        {
            txtInvoiceID.Enabled = true;
            txtQuantity.Enabled = true;
            btnProdUpdate.Enabled = true;
            btnRemove.Enabled = true;
            btnAdd.Enabled = true;
            btnSearch.Enabled = true;
            btnReset.Enabled = true;
            txtPayment.Enabled = true;
            
        }


        private void btnSearch_Click(object sender, EventArgs e)
        {
            ReturnSaleBL obj = new ReturnSaleBL() 
            {
             Invoiceno=Convert.ToInt32(txtInvoiceID.Text)
            };
            DataTable dt = obj.Search();
            if(dt.Rows.Count>0)
            {
                DataGridViewImageColumn edit = new DataGridViewImageColumn();
                edit.Image = Properties.Resources.edit;
                edit.ImageLayout = DataGridViewImageCellLayout.Zoom;
                edit.HeaderText = "Edit";
                edit.Width  = 40;
                dgvProduct.Columns.Add(edit);
                dgvProduct.DataSource = dt;
                dgvProduct.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }

        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            ReturnSaleBL obj = new ReturnSaleBL();
            DataTable dt = obj.Addnew();
            if(dt.Rows.Count>0)
            {
                txtReturnID.Text = Convert.ToString(dt.Rows[0]["RInvoice"]);
                FormEnable();
                txtInvoiceID.Focus();
            }
            
        }

        private void FrmSaleReturn_Load(object sender, EventArgs e)
        {
            FormDisable();
        }

        private void dgvProduct_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnReset_Click(object sender, EventArgs e)
        {

        }
    }
}
