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

                PInvoice = Convert.ToInt32(txtInvoiceID.Text)
            };
            var dt = objPur.Search();
            dgvProduct.Columns.Clear();
            if (dt != null && dt.Rows.Count > 0)
            {
                DataGridViewImageColumn edit = new DataGridViewImageColumn();
                edit.Image = Properties.Resources.edit;
                edit.ImageLayout = DataGridViewImageCellLayout.Zoom;
                edit.HeaderText = "Edit";
                edit.Width = 40;
                dgvProduct.Columns.Add(edit);
                dgvProduct.DataSource = dt;
                this.dgvProduct.Columns["Sr#"].Visible=false;
                this.dgvProduct.Columns["InvoiceNo"].Visible = false;
                this.dgvProduct.Columns["Date"].Visible = false;
                this.dgvProduct.Columns["CompanyID"].Visible = false;
                this.dgvProduct.Columns["New Balance"].Visible = false;
                this.dgvProduct.Columns["Contact"].Visible = false;
                this.dgvProduct.Columns["GrandTotal"].Visible = false;
                this.dgvProduct.Columns["Balance"].Visible = false;
                this.dgvProduct.Columns["Payment"].Visible = false;
                this.dgvProduct.Columns["Discount"].Visible = false;
                dgvProduct.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;


            }
            else
            {
                MessageBox.Show("No Record Against Invoice No '" + txtInvoiceID.Text + "'  ");
            }
        }

        private void dgvProduct_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int columnindex = e.ColumnIndex;
            int rowindex = e.RowIndex;
            if (columnindex == 0)
            {
                
                txtComName.Text = dgvProduct.Rows[rowindex].Cells[4].Value.ToString();
                
                txtProdName.Text = dgvProduct.Rows[rowindex].Cells[7].Value.ToString();
               
                lblQuantity.Text = dgvProduct.Rows[rowindex].Cells[10].Value.ToString();
                lblctn.Text = dgvProduct.Rows[rowindex].Cells[9].Value.ToString();
                

                txtComName.Focus();
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
            txtPreBalance.Enabled = false;
            txtNewBalance.Enabled = false;
            txtBalance.Enabled = false;
            btnAdd.Enabled = false;
            btnReset.Enabled = false;
            btnClear.Enabled = false;
            txtReturnCash.Enabled = false;
            txtPreBalance.Enabled = false;
            txtCtn.Enabled = false;
        }

        private void FormEnable()
        {
            txtInvoiceID.Enabled = true;
            btnProdUpdate.Enabled = true;
            btnAdd.Enabled = true;
            btnSearch.Enabled = true;
            btnReset.Enabled = true;
            txtReturnCash.Enabled = true;
            txtComName.Enabled = true;
            txtCtn.Enabled = true;
            txtProdName.Enabled = true;
            txtBillDiscount.Enabled = true;
            btnSave.Enabled = true;
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            PurchaseReturnBL objAdd = new PurchaseReturnBL();
            DataTable dt = objAdd.Addnew();
            if (dt.Rows.Count > 0)
            {
                txtReturnID.Text = Convert.ToString(dt.Rows[0]["PReturnID"]);
                FormEnable();
                txtInvoiceID.Focus();
                LoadGridProd();
                btnNew.Enabled = false;
            }
        }

        private void txtProdName_Leave(object sender, EventArgs e)
        {
            ProductBL objPro = new ProductBL()
            {
                ProductName = txtProdName.Text
            };
            var dt = objPro.SearchByName();
            if (dt.Count > 0)
            {
                txtProdID.Text = Convert.ToString(dt[0].ProductID);
                txtPrice.Text = Convert.ToString(dt[0].TradePrice);
                lblPiePerCtn.Text = Convert.ToString(dt[0].PiecePerCtn);
               // GetDue();
            }
        }

        //private void GetDue()
        //{
        //    CompanyBL objCOm = new CompanyBL()
        //    {
        //        CompanyID = Convert.ToInt32(txtComID.Text)
        //    };
        //    var dt = objCOm.Search();
        //    if (dt.Count > 0)
        //    {
        //        txtPreBalance.Text = Convert.ToString(dt[0].DuePayment);
        //    }
        //}

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
            dt.Columns.Add("Ctn");
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
            dr[6] = txtCtn.Text;
            dr[7] = txtQuantity.Text;
            dr[8] = txtAmount.Text;
            dt.Rows.Add(dr);
            SumCalculate();
            txtBillDiscount.Focus();
            ClearGroup();

        }
      


        private void SumCalculate()
        {

            int sum = 0;
            for (int i = 0; i < dgvReturnItem.Rows.Count; ++i)
            {
                sum += Convert.ToInt32(dgvReturnItem.Rows[i].Cells[8].Value);
            }
            txtTotalBill.Text = sum.ToString();

           

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
                decimal Due = Convert.ToDecimal(txtPreBalance.Text);
                decimal result = Due - bal;
                txtPreBalance.Text = result.ToString();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //PurchaseReturnBL objDue = new PurchaseReturnBL()
            //{
            //    DuePayment = Convert.ToDecimal(txtBalance.Text),
            //    CompanyID = Convert.ToInt32(txtComID.Text)
            //};
            //objDue.UpdateDuePayment();
            //PurchaseReturnBL objUp = new PurchaseReturnBL();
            //for (int i = 0; i < dgvReturnItem.Rows.Count; i++)
            //{
            //    objUp.Amount = Convert.ToDecimal(dgvReturnItem.Rows[0].Cells[7].Value.ToString());
            //    objUp.PInvoice = Convert.ToInt32(txtInvoiceID.Text);
            //    objUp.Quantity = Convert.ToInt32(dgvReturnItem.Rows[0].Cells[6].Value.ToString());
            //    objUp.ProductID = Convert.ToInt32(dgvReturnItem.Rows[0].Cells[1].Value.ToString());
            //    objUp.UpdatePInvoice();
            //}
            //PurchaseReturnBL obj2 = new PurchaseReturnBL()
            //{

            //    GrandTotal = Convert.ToDecimal(txtGrandTotal.Text),
            //    PInvoice = Convert.ToInt32(txtInvoiceID.Text)

            //};
            //obj2.UpdatePInvoice();

            PurchaseReturnBL objUpdate = new PurchaseReturnBL();
            {
                for (int i = 0; i < dgvReturnItem.Rows.Count; i++)
                {
                    objUpdate.ProductID = Convert.ToInt32(dgvReturnItem.Rows[i].Cells[1].Value.ToString());
                    objUpdate.Quantity = Convert.ToInt32(dgvReturnItem.Rows[i].Cells[7].Value.ToString());
                    objUpdate.ProdUpdate();
                }

            }
            PurchaseReturnBL objCtn = new PurchaseReturnBL();
            {
                for (int i = 0; i < dgvReturnItem.Rows.Count; i++)
                {
                    objCtn.ProductID = Convert.ToInt32(dgvReturnItem.Rows[i].Cells[1].Value.ToString());
                    objCtn.Ctn = Convert.ToDecimal(dgvReturnItem.Rows[i].Cells[6].Value.ToString());
                    objCtn.CtnUpdate();
                }
            }
            
            PurchaseReturnBL objDetail = new PurchaseReturnBL();
            {
                for (int i = 0; i < dgvReturnItem.Rows.Count; i++)
                {
                    objDetail.PReturnID = Convert.ToInt32(txtReturnID.Text);
                    objDetail.ProductID = Convert.ToInt32(dgvReturnItem.Rows[i].Cells[1].Value.ToString());
                    objDetail.Ctn = Convert.ToDecimal(dgvReturnItem.Rows[i].Cells[6].Value.ToString());
                    objDetail.Quantity = Convert.ToInt32(dgvReturnItem.Rows[i].Cells[7].Value.ToString());
                    objDetail.Amount = Convert.ToInt32(dgvReturnItem.Rows[i].Cells[8].Value.ToString());
                    objDetail.SaveDetail();

                }
            }

           
            if (txtBalance.Text != "0.00")
            {
                PurRemainBL objPurc = new PurRemainBL()
                {
                    CompanyID = Convert.ToInt32(txtComID.Text),
                    ReturnCash = Convert.ToDecimal(txtBalance.Text),
                    Date = Convert.ToDateTime(txtReturnDate.Text),
                    PReturnID = Convert.ToInt32(txtReturnID.Text)
                };
                objPurc.Save();
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
            PurchaseLedgerBL objLedger = new PurchaseLedgerBL();
            objLedger.PReturnID = Convert.ToInt32(txtReturnID.Text);
            objLedger.CompanyID = Convert.ToInt32(txtComID.Text);
            objLedger.Credit = 0;
            objLedger.Debit = Convert.ToInt32(txtBalance.Text);
            objLedger.Date = Convert.ToDateTime(txtReturnDate.Text);
            objLedger.Balance = Convert.ToDecimal(txtNewBalance.Text);
            objLedger.Description = "Credit";
            objLedger.save();
            (new PurchaseLedgerBL()).UpdateBalance(objLedger.Balance,objLedger.CompanyID);
            ClearForm();
            btnNew.Enabled = true;
            //  DesignClear(this);

        }
        private void ClearForm()
        {
             
        
            foreach (Control c in groupBox1.Controls )
            {
                if (c is TextBox || c is ComboBox || c is MaskedTextBox)
                {
                    c.Text = "";
                }

            }
            foreach (Control c in groupBox3.Controls)
            {
                if (c is TextBox || c is ComboBox || c is MaskedTextBox)
                {
                    c.Text = "";
                }

            }
            foreach (Control c in groupBox5.Controls)
            {
                if (c is TextBox || c is ComboBox || c is MaskedTextBox)
                {
                    c.Text = "";
                }

            }
            foreach (Control c in groupBox7.Controls)
            {
                if (c is TextBox || c is ComboBox ||c is MaskedTextBox)
                {
                    c.Text = "";
                }

            }
            dgvProduct.DataSource = null;
            dgvReturnItem.DataSource = null;
        }

        private void btnProdUpdate_Click(object sender, EventArgs e)
        {
            bool found = false;
            if (dgvProduct.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in dgvReturnItem.Rows)
                {

                    if (Convert.ToString(row.Cells[2].Value) == txtProdName.Text && Convert.ToString(row.Cells[5].Value) == txtPrice.Text)
                    {

                        row.Cells[6].Value=Convert.ToString(Convert.ToDecimal(txtCtn.Text));
                        row.Cells[7].Value = Convert.ToString(Convert.ToInt32(txtQuantity.Text));
                        row.Cells[8].Value = Convert.ToString(Convert.ToDecimal(txtAmount.Text));
                        found = true;
                        SumCalculate();
                        ClearGroup();



                    }

                }
                if (!found)
                {
                    dgvProduct.Rows.Add(txtProdName.Text, txtPrice.Text, 1);
                }

            }
        }

        private void ClearGroup()
        {
            foreach (Control c in groupBox4.Controls)
            {
                if (c is TextBox || c is ComboBox)
                {
                    c.Text = "";
                }

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

        private void txtReturnCash_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtReturnCash.Text))
            {
                decimal grand = Convert.ToDecimal(txtGrandTotal.Text);
                decimal returnCash = Convert.ToDecimal(txtReturnCash.Text);
                decimal res = grand - returnCash;
                txtBalance.Text = res.ToString();
                decimal preBal = Convert.ToDecimal(txtPreBalance.Text);
                txtNewBalance.Text = (preBal - res).ToString();
            }
            else
            {
                txtReturnCash.Text = "0.00";
            }
            
        }

        private void txtCtn_TextChanged(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(txtCtn.Text))
            {
                decimal ctn = Convert.ToDecimal(txtCtn.Text);
                int pie = Convert.ToInt32(lblPiePerCtn.Text);
                int result = Convert.ToInt32(ctn * pie);
                txtQuantity.Text = result.ToString();
            }
        }

        private void txtCtn_Leave(object sender, EventArgs e)
        {
            if (txtCtn.Text == string.Empty)
            {
                MessageBox.Show("Please Enter Quantity");
                txtCtn.Focus();
            }
            if (txtCtn.Text != string.Empty)
            {
                int val1 = Convert.ToInt32(txtPrice.Text);
                int val2 = Convert.ToInt32(txtQuantity.Text);
                int val3 = val1 * val2;
                txtAmount.Text = val3.ToString();
            }

        }

        private void txtComName_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtComName.Text))
            {
                MessageBox.Show("Please Enter Company Name");
                txtComName.Focus();
            }
            else
            {
                CompanyBL objCom = new CompanyBL()
                {
                    CompanyName = txtComName.Text
                };
                var dt = objCom.SearchByName();
                if (dt != null)
                {
                    txtComID.Text = Convert.ToString(dt[0].CompanyID);
                    txtComContact.Text = dt[0].Contact;
                    txtPreBalance.Text = Convert.ToString(dt[0].DuePayment);
                }

            }
        }



        private void txtBillDiscount_Leave(object sender, EventArgs e)
        {
            if (txtBillDiscount.Text == string.Empty)
            {
                txtBillDiscount.Text = "0";
                int Bill = Convert.ToInt32(txtTotalBill.Text);
                txtGrandTotal.Text = Bill.ToString();
            }
            else
            {
                int Bill = Convert.ToInt32(txtTotalBill.Text);

                int val2 = Convert.ToInt32(txtBillDiscount.Text);
                int val3 = Bill - val2;
                txtGrandTotal.Text = val3.ToString();

            }

        }

        

       

        //private void txtBillDiscount_TextChanged(object sender, EventArgs e)
        //{
        //    decimal Bill = Convert.ToDecimal(txtTotalBill.Text);
        //    decimal val2 = (Bill / 100) * Convert.ToDecimal(txtBillDiscount.Text);
        //    decimal val3 = Bill - val2;
        //    txtGrandTotal.Text = val3.ToString();
        //}
    }
}
