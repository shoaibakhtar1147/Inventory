using CashandCarry.BL;
using CashandCarry.Model;
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

            txtBalance.Enabled = false;
            txtProdName.Enabled = false;
            txtProdID.Enabled = false;
            
            txtPrice.Enabled = false;
            txtAmount.Enabled = false;
            txtPrice.Enabled = false;
            
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
            txtReturnPay.Enabled = false;
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
            txtReturnPay.Enabled = true;
            txtCusName.Enabled = true;
            txtProdName.Enabled = true;
            txtBalance.Enabled = true;
            
        }


        private void btnSearch_Click(object sender, EventArgs e)
        {
            ReturnSaleBL obj = new ReturnSaleBL() 
            {
             Invoiceno=Convert.ToInt32(txtInvoiceID.Text)
            };
            DataTable dt = obj.Search();
            dgvProduct.Columns.Clear();
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
        private void GetDue()
        {
            ReturnSaleBL objRet = new ReturnSaleBL() 
            {
             CustomerID = Convert.ToInt32(txtCusID.Text)
            };
            
            txtDuePay.Text = objRet.GetDuePayment().ToString();

            
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
            LoadGridProd();
        }

        private void dgvProduct_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnReset_Click(object sender, EventArgs e)
        {

        }

       
        private void txtCusName_Leave(object sender, EventArgs e)
        {
            
            
        }


        

        private void txtInvoiceID_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtQuantity_Leave(object sender, EventArgs e)
        {
            int val = Convert.ToInt32(txtAmount.Text);

            decimal val1 = ((val * Convert.ToDecimal(txtDiscount.Text)) / 100);
            decimal val2 = val - val1;
            txtTotalAmount.Text = val2.ToString();
        }
        private void LoadGridProd()
        {
            
            dt.Columns.Add("SrNo").AutoIncrement = true;
            dt.Columns["SrNo"].AutoIncrementSeed = 1;
            dt.Columns["SrNo"].AutoIncrementStep = 1;
            dt.Columns.Add("InvoiceNo");
            dt.Columns.Add("ProductID");
            dt.Columns.Add("ProductName");
            dt.Columns.Add("RetailPrice");
            dt.Columns.Add("Quantity");
            dt.Columns.Add("Discount");
            dt.Columns.Add("TotalAmount");
            dgvReturnItem.DataSource = dt;

        }
        private void txtDiscount_Leave(object sender, EventArgs e)
        {
           
              

           

        }
        DataTable dt = new DataTable();
        private void btnAdd_Click(object sender, EventArgs e)
        {
            
            DataRow dr = dt.NewRow();

            dr[1] = txtInvoiceID.Text;
            dr[2] = txtProdID.Text;
            dr[3] = txtProdName.Text;
            dr[4] = txtPrice.Text;
            dr[5] = txtQuantity.Text;
            dr[6] = txtDiscount.Text;
            dr[7] = txtTotalAmount.Text;
            dt.Rows.Add(dr);
            txtReturnPay.Focus();
            SumCalculate();
        }
        private void SumCalculate()
        {

            decimal sum = 0;
            for (int i = 0; i<dgvReturnItem.Rows.Count-1; ++i)
            {
                sum += Convert.ToDecimal(dgvReturnItem.Rows[i].Cells[7].Value);
            }
            txtTotalBill.Text = sum.ToString();

        }
       
        private void btnSave_Click(object sender, EventArgs e)
        {

        }

        private void txtReturnPay_TextChanged(object sender, EventArgs e)
        {
            
           
                decimal Bill = Convert.ToDecimal(txtTotalBill.Text);

                decimal val2 = Convert.ToDecimal(txtReturnPay.Text);
                decimal val3 = Bill - val2;
                txtBalance.Text = val3.ToString();

           
            
        }

        private void dgvProduct_CellContentClick_2(object sender, DataGridViewCellEventArgs e)
        {
            int rowindex = e.RowIndex;
            int columnindex = e.ColumnIndex;
            if(columnindex==0)
            {
                txtCusName.Text = dgvProduct.Rows[rowindex].Cells[2].Value.ToString();
                txtProdName.Text = dgvProduct.Rows[rowindex].Cells[4].Value.ToString();
                txtDiscount.Text = dgvProduct.Rows[rowindex].Cells[7].Value.ToString();
                FormEnable();
                txtCusName.Focus();
               
 
}
        }

        private void dgvReturnItem_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtQuantity_TextChanged(object sender, EventArgs e)
        {
            if (txtQuantity.Text == string.Empty)
            {
                MessageBox.Show("Please Enter Quantity");
                txtQuantity.Focus();
            }
            else if (txtQuantity.Text == null)
            {
                MessageBox.Show("Null Value Not Acceptable Please Enter Quantity");
                txtQuantity.Focus();


            }
            else
            {

                int val1 = Convert.ToInt32(txtPrice.Text);
                int val2 = Convert.ToInt32(txtQuantity.Text);
                int val3 = val1 * val2;
                txtAmount.Text = val3.ToString();
            }
        }

        private void txtCusName_Leave_1(object sender, EventArgs e)
        {

            CustomerBL objCus = new CustomerBL()
            {
                Name = txtCusName.Text
            };
            List<tbl_Customer> dt = objCus.SearchByName();
            if (dt.Count > 0)
            {
                txtCusID.Text = Convert.ToString(dt[0].CustomerID);
                txtContact.Text = Convert.ToString(dt[0].Contact);
                GetDue();
            }


        }

        private void txtProdName_Leave(object sender, EventArgs e)
        {
            ProductBL objPro = new ProductBL()
            {
                ProductName = txtProdName.Text
            };
            List<tbl_Product> dt = objPro.SearchByName();
            if (dt != null && dt.Count > 0)
            {
                txtProdID.Text = Convert.ToString(dt[0].ProductID);
                txtPrice.Text = Convert.ToString(dt[0].RetailPrice);
            }
        }

        private void txtReturnPay_Leave(object sender, EventArgs e)
        {
            decimal bal = Convert.ToDecimal(txtBalance.Text);
            decimal Due = Convert.ToDecimal(txtDuePay.Text);
            decimal result = Due - bal;
            txtDuePay.Text = result.ToString();
        }
    }
}
