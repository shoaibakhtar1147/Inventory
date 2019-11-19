using CashandCarry.BL;
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
    public partial class FrmPurchaseReturn : MetroForm
    {
        public FrmPurchaseReturn()
        {
            InitializeComponent();
        }

        private void FrmPurchaseReturn_Load(object sender, EventArgs e)
        {
            FormDisable();
        }
       

        private void btnSearch_Click(object sender, EventArgs e)
        {
            PurchaseInvoiceBL objPur = new PurchaseInvoiceBL() 
            {
            
             PInvoice=Convert.ToInt32(txtInvoiceID.Text)
            };
            DataTable dt = objPur.Search();
            dgvProduct.Columns.Clear();
            if(dt!= null && dt.Rows.Count>0)
            {
                DataGridViewImageColumn edit = new DataGridViewImageColumn();
                edit.Image = Properties.Resources.edit;
                edit.ImageLayout = DataGridViewImageCellLayout.Zoom;
                edit.HeaderText = "Edit";
                edit.Width = 40;
                dgvProduct.Columns.Add(edit);
                dgvProduct.DataSource = dt;
                dgvProduct.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
               

            }
            else
            {
                MessageBox.Show("No Record Against Invoice No '" + txtInvoiceID.Text + "'  ");
            }
        }

        private void dgvProduct_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int columnindex=e.ColumnIndex;
            int rowindex=e.RowIndex;
            if(columnindex==0)
            {
                txtComID.Text = dgvProduct.Rows[rowindex].Cells[3].Value.ToString();
                txtComName.Text = dgvProduct.Rows[rowindex].Cells[4].Value.ToString();
                txtComContact.Text = dgvProduct.Rows[rowindex].Cells[5].Value.ToString();
                txtProdName.Text = dgvProduct.Rows[rowindex].Cells[7].Value.ToString();
                txtBillDiscount.Text = dgvProduct.Rows[rowindex].Cells[11].Value.ToString();

                txtProdName.Focus();
            }
        }
        private void FormDisable()
        {
            txtComName.Enabled = false;
            txtComID.Enabled = false;
            txtBillDiscount.Enabled = false;
            txtReturnDate.Enabled = false;
            txtReturnID.Enabled = false;
            txtQuantity.Enabled = false;
            txtComContact.Enabled = false;
            txtBalance.Enabled = false;
            txtProdName.Enabled = false;
            txtProdID.Enabled = false;

            txtPrice.Enabled = false;
            txtAmount.Enabled = false;
            txtPrice.Enabled = false;

            txtInvoiceID.Enabled = false;
            txtTotalBill.Enabled = false;
            btnSave.Enabled = false;
            btnSearch.Enabled = false;
           
            txtProdID.Enabled = false;
           
            btnProdUpdate.Enabled = false;
            btnRemove.Enabled = false;
            btnAdd.Enabled = false;
            btnReset.Enabled = false;
            btnClear.Enabled = false;
            txtReturnCash.Enabled = false;
            txtPayDue.Enabled = false;


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
            txtReturnCash.Enabled = true;
           
            txtProdName.Enabled = true;
            txtBalance.Enabled = true;
            btnSave.Enabled = true;

        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            PurchaseReturnBL objAdd = new PurchaseReturnBL();
            DataTable dt = objAdd.Addnew();
            if(dt.Rows.Count>0)
            {
                txtReturnID.Text = Convert.ToString(dt.Rows[0]["PReturnID"]);
                FormEnable();
                txtInvoiceID.Focus();
                LoadGridProd();
            }
        }

        private void txtProdName_Leave(object sender, EventArgs e)
        {
            ProductBL objPro = new ProductBL() 
            {
            ProductName=txtProdName.Text
            };
            var dt = objPro.SearchByName();
            if(dt.Count>0)
            {
                txtProdID.Text = Convert.ToString(dt[0].ProductID);
                txtPrice.Text = Convert.ToString(dt[0].TradePrice);
                GetDue();
            }
        }

        private void GetDue()
        {
            CompanyBL objCOm = new CompanyBL()
            {
                CompanyID=Convert.ToInt32(txtComID.Text)
            };
            var dt = objCOm.Search();
            if(dt.Count>0)
            {
                txtPayDue.Text =Convert.ToString(dt[0].DuePayment);
            }
        }

        private void txtQuantity_Leave(object sender, EventArgs e)
        {
            if (txtQuantity.Text == string.Empty)
            {
                MessageBox.Show("Please Enter Quantity");
                txtQuantity.Focus();
            }
            if (txtQuantity.Text != string.Empty)
            {
                int val1 = Convert.ToInt32(txtPrice.Text);
                int val2 = Convert.ToInt32(txtQuantity.Text);
                int val3 = val1 * val2;
                txtAmount.Text = val3.ToString();
            }
        }
        private void LoadGridProd()
        {
            
            dt.Columns.Add("SrNo").AutoIncrement = true;
            dt.Columns["SrNo"].AutoIncrementSeed = 1;
            dt.Columns["SrNo"].AutoIncrementStep = 1;
            dt.Columns.Add("ProductID");
            dt.Columns.Add("CompanyID");
            dt.Columns.Add("CompanyName");
            dt.Columns.Add("ProductName");
            dt.Columns.Add("RetailPrice");
            dt.Columns.Add("Quantity");
            dt.Columns.Add("Amount");


            dgvReturnItem.DataSource = dt;

        }
        DataTable dt = new DataTable();
        private void btnAdd_Click(object sender, EventArgs e)
        {
            
            DataRow dr = dt.NewRow();
            dr[1] = txtProdID.Text;
            dr[2] = txtProdName.Text;
            dr[3] = txtComID.Text;
            dr[4] = txtComName.Text; 
            dr[5] = txtPrice.Text;
            dr[6] = txtQuantity.Text;
            dr[7] = txtAmount.Text;
            dt.Rows.Add(dr);
            SumCalculate();
            txtReturnCash.Focus();


        }

        private void SumCalculate()
        {

            int sum = 0;
            for (int i = 0; i < dgvReturnItem.Rows.Count; ++i)
            {
                sum += Convert.ToInt32(dgvReturnItem.Rows[i].Cells[7].Value);
            }
            txtTotalBill.Text = sum.ToString();

            decimal Bill = Convert.ToDecimal(txtTotalBill.Text);
            decimal val2 = (Bill / 100) * Convert.ToDecimal(txtBillDiscount.Text);
            decimal val3 = Bill - val2;
            txtGrandTotal.Text = val3.ToString();

        }

        //private void txtReturnCash_TextChanged(object sender, EventArgs e)
        //{

        //    if (!(string.IsNullOrEmpty(txtTotalBill.Text) || string.IsNullOrEmpty(txtReturnCash.Text)))
        //    {
        //        decimal Bill = Convert.ToDecimal(txtTotalBill.Text);
        //        decimal val2 = Convert.ToDecimal(txtReturnCash.Text);
        //        decimal val3 = Bill - val2;
        //        txtBalance.Text = val3.ToString();
        //    } 
        //}

        private void txtReturnCash_Leave(object sender, EventArgs e)
        {
            if (txtReturnCash.Text == string.Empty)
            {
                txtReturnCash.Text = "0.00";
                decimal total = Convert.ToDecimal(txtGrandTotal.Text);
                txtBalance.Text = total.ToString();
            }
            else
            {
                decimal total = Convert.ToDecimal(txtGrandTotal.Text);
                decimal Due = Convert.ToDecimal(txtReturnCash.Text);
                decimal result = Due - total;
              txtBalance.Text = result.ToString();
            }
        }

        private void txtBalance_Leave(object sender, EventArgs e)
        {
            if (txtBalance.Text == string.Empty)
            {
                txtReturnCash.Text = "0.00";

            }
            else
            {
                decimal bal = Convert.ToDecimal(txtBalance.Text);
                decimal Due = Convert.ToDecimal(txtPayDue.Text);
                decimal result = Due - bal;
                txtPayDue.Text = result.ToString();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            PurchaseReturnBL objDue = new PurchaseReturnBL()
            {
                DuePayment = Convert.ToDecimal(txtBalance.Text),
                CompanyID = Convert.ToInt32(txtComID.Text)
            };
            objDue.UpdateDuePayment();
            PurchaseReturnBL objUp = new PurchaseReturnBL();
            for (int i = 0; i < dgvReturnItem.RowCount - 1; i++)
            {
                objUp.Amount = Convert.ToDecimal(dgvReturnItem.Rows[0].Cells[7].Value.ToString());
                objUp.PInvoice = Convert.ToInt32(txtInvoiceID.Text);
                objUp.Quantity = Convert.ToInt32(dgvReturnItem.Rows[0].Cells[6].Value.ToString());
                objUp.ProductID = Convert.ToInt32(dgvReturnItem.Rows[0].Cells[1].Value.ToString());
                objUp.UpdatePInvoice();
            }
            PurchaseReturnBL obj2 = new PurchaseReturnBL()
            {

                GrandTotal = Convert.ToDecimal(txtGrandTotal.Text),
                PInvoice = Convert.ToInt32(txtInvoiceID.Text)

            };
            obj2.UpdatePInvoice();

            PurchaseReturnBL objUpdate = new PurchaseReturnBL();
            {
                for (int i = 0; i < dgvReturnItem.RowCount - 1; i++)
                {
                    objUpdate.ProductID = Convert.ToInt32(dgvReturnItem.Rows[i].Cells[1].Value.ToString());
                    objUpdate.Quantity = Convert.ToInt32(dgvReturnItem.Rows[i].Cells[6].Value.ToString());
                    objUpdate.ProdUpdate();
                }

            }
            PurchaseReturnBL objDetail = new PurchaseReturnBL();
            {
                for (int i = 0; i < dgvReturnItem.RowCount - 1; i++)
                {
                    objDetail.PReturnID = Convert.ToInt32(txtReturnID.Text);
                    objDetail.ProductID = Convert.ToInt32(dgvReturnItem.Rows[i].Cells[1].Value.ToString());
                    objDetail.Quantity = Convert.ToInt32(dgvReturnItem.Rows[i].Cells[6].Value.ToString());
                    objDetail.Amount = Convert.ToInt32(dgvReturnItem.Rows[i].Cells[7].Value.ToString());
                    objDetail.SaveDetail();

                }
            }
            PurchaseReturnBL objMas = new PurchaseReturnBL()
            {
                PInvoice = Convert.ToInt32(txtInvoiceID.Text),
                CompanyID = Convert.ToInt32(txtComID.Text),
                Discount = Convert.ToDecimal(txtBillDiscount.Text),
                ReturnDate = DateTime.Parse(txtReturnDate.Text),
                TotalAmount = Convert.ToDecimal(txtGrandTotal.Text),
                ReturnCash = Convert.ToDecimal(txtReturnCash.Text),
                DuePayment = Convert.ToDecimal(txtBalance.Text)

            };
            objMas.SaveMaster();
          //  DesignClear(this);
            
        }

        //public void DesignClear(Form frm)
        //{
        //    foreach (Control ctr in frm.Controls)
        //    {
        //        if (ctr is GroupBox)
        //        {
        //            ctr.Text = "";
        //        }

        //    }
        //}
    }
}
