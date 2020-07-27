using CashandCarry.BL;
using CashandCarry.Model;
using CashandCarry.Reports;
using CashandCarry.Reports.Sale;
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
    public partial class FrmSaleInvoice : MetroForm
    {
        public FrmSaleInvoice()
        {
            InitializeComponent();
        }

        private void FrmSaleInvoice_Load(object sender, EventArgs e)
        {
            GridDesign();
            FormDisable();
            txtCusId.Focus();


        }

        private void GridDesign()
        {
            dgvProduct.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dgvProduct.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvProduct.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            dgvProduct.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dgvProduct.BackgroundColor = Color.White;

            dgvProduct.EnableHeadersVisualStyles = false;
            dgvProduct.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvProduct.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            dgvProduct.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        }



        private void label19_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            SaleInvoiceBL objSale = new SaleInvoiceBL();
            DataTable dt = objSale.Addnew();
            if (dt.Rows.Count > 0)
            {
                txtInvoiceID.Text = Convert.ToString(dt.Rows[0]["Invoice#"]);
                LoadCus();
                LoadProd();
                btnSave.Enabled = true;
                btnClear.Enabled = true;
                FormEnable();
                //LoadSaleDetail();
                LoadGridProd();
                LoadSalesman();
                SumCalculate();
                btnSave.Enabled = true;
                txtSalesman.Focus();
                btnNew.Enabled = false ;



            }
        }

        private void LoadSalesman()
        {

            EmployeeBL objEmp = new EmployeeBL();
            var dt = objEmp.SearchByDesig();
            if(dt != null)
            {
                txtSalesman.DataSource = dt;
                txtSalesman.AutoCompleteMode = AutoCompleteMode.Suggest;
                txtSalesman.AutoCompleteSource = AutoCompleteSource.ListItems;
                txtSalesman.DisplayMember = "Name";
                txtSalesman.ValueMember = "Designation";
           
            }
            
        }
        private void FormDisable()
        {
            txtCusName.Enabled = false;
            txtCusId.Enabled = false;
            txtDiscount.Enabled = false;
            txtQuantity.Enabled = false;
            txtContact.Enabled = false;
            txtDiscount.Enabled = false;
            txtInvoiceDate.Enabled = false;
            txtDuePay.Enabled = false;
            txtProdName.Enabled = false;
            txtSalesman.Enabled = false;
            txtProdId.Enabled = false;
            txtCtn.Enabled = false;
            txtTotalPay.Enabled = false;
            txtPrice.Enabled = false;
            txtAmount.Enabled = false;
            txtPrice.Enabled = false;
            
            txtInvoiceID.Enabled = false;
            txtTotalAmount.Enabled = false;
            btnSave.Enabled = false;
            txtPreBalance.Enabled = false;
            txtnewBalance.Enabled = false;

            btnProdUpdate.Enabled = false;
            
            btnAdd.Enabled = false;
            btnReset.Enabled = false;
            btnClear.Enabled = false;
            txtWeight.Enabled = false;
        }

        private void FormEnable()
        {
            txtProdName.Enabled = true;
            txtCusName.Enabled = true;
            txtDiscount.Enabled = true;

            
            txtDiscount.Enabled = true;
            txtTotalPay.Enabled = true;
            txtSalesman.Enabled = true;
            btnProdUpdate.Enabled = true;
            btnAdd.Enabled = true;
            btnReset.Enabled = true;
        }
        private void LoadCus()
        {
            CustomerBL objCus = new CustomerBL();
            List<View_tbl_Customer> dt = objCus.Select();
            txtCusName.DataSource = dt;
            txtCusName.AutoCompleteMode = AutoCompleteMode.Suggest;
            txtCusName.AutoCompleteSource = AutoCompleteSource.ListItems;
            txtCusName.DisplayMember = "Name";
            txtCusName.ValueMember = "CustomerID";
        }


        private void LoadProd()
        {
            ProductBL objPro = new ProductBL();
            List<View_tbl_Product> dt = objPro.Select();
            txtProdName.DataSource = dt;
            txtProdName.AutoCompleteMode = AutoCompleteMode.Suggest;
            txtProdName.AutoCompleteSource = AutoCompleteSource.ListItems;
            txtProdName.DisplayMember = "ProductName";
            txtProdName.ValueMember = "ProductID";
        }



        private void txtDiscount_Leave(object sender, EventArgs e)
        {
            if (txtDiscount.Text == string.Empty)
            {
                txtDiscount.Text = "0";
                decimal vl = Convert.ToDecimal(txtAmount.Text);
                txtTotalAmount.Text = vl.ToString();
            }
            else
            {
                decimal val1 = Convert.ToDecimal(txtAmount.Text);
                decimal val = Convert.ToDecimal(txtDiscount.Text);
                decimal val2 = val1 - val;
                txtTotalAmount.Text = val2.ToString();
            }

        }
        private void LoadGridProd()
        {

            dt.Columns.Add("SrNo").AutoIncrement = true;
            dt.Columns["SrNo"].AutoIncrementSeed = 1;
            dt.Columns["SrNo"].AutoIncrementStep = 1;
            dt.Columns.Add("ProductID");
            dt.Columns.Add("ProductName");
            dt.Columns.Add("RetailPrice");
            dt.Columns.Add("Ctn");
            dt.Columns.Add("Quantity");
            dt.Columns.Add("Discount");
            dt.Columns.Add("TotalAmount");
            dgvProduct.DataSource = dt;

        }
        private void ClearGroup()
        {
            foreach (Control c in groupBox3.Controls)
            {
                if (c is TextBox || c is ComboBox)
                {
                    c.Text = "";
                }

            }
        }

        DataTable dt = new DataTable();
        private void btnAdd_Click(object sender, EventArgs e)
        {
            
            DataRow dr = dt.NewRow();
            dr[1] = txtProdId.Text;
            dr[2] = txtProdName.Text;
            dr[3] = txtPrice.Text;
            dr[4] = txtCtn.Text;
            dr[5] = txtQuantity.Text;
            dr[6] = txtDiscount.Text;
            dr[7] = txtTotalAmount.Text;
            dt.Rows.Add(dr);
            // MessageBox.Show("Product Saved Successfull");
            ClearGroup();
            SumCalculate();
            ChkComplete.Focus();
            if(ChkCtn.Checked==true)
            {
                ChkCtn.Checked = false;
            }
            else if(ChkPiece.Checked==true)
            {
                ChkPiece.Checked = false;
            }
             


              }
        
        private void SumCalculate()
        {

            decimal sum = 0;
            for (int i = 0; i < dgvProduct.Rows.Count; ++i)
            {
                sum += Convert.ToDecimal(dgvProduct.Rows[i].Cells[7].Value);
            }
            txtGrandTotal.Text= sum.ToString();

        }



        private void btnSave_Click(object sender, EventArgs e)
        {



            SaleInvoiceBL objProd = new SaleInvoiceBL();
            for (int i = 0; i < dgvProduct.Rows.Count; i++)
            {
                objProd.ProductID = Convert.ToInt32(dgvProduct.Rows[i].Cells[1].Value.ToString());
                objProd.Quantity = Convert.ToInt32(dgvProduct.Rows[i].Cells[5].Value.ToString());
                objProd.UpdateProd();

            }

            PurchaseReturnBL objCtn = new PurchaseReturnBL();
            for (int i = 0; i < dgvProduct.Rows.Count; i++)
            {
                objCtn.ProductID = Convert.ToInt32(dgvProduct.Rows[i].Cells[1].Value.ToString());
                objCtn.Ctn = Convert.ToDecimal(dgvProduct.Rows[i].Cells[4].Value.ToString());
                objCtn.CtnUpdate();
            }


            SaleInvoiceBL objmas = new SaleInvoiceBL()
            {

                SaleDate = DateTime.Parse(txtInvoiceDate.Text),
                GrandTotal = Convert.ToDecimal(txtGrandTotal.Text),
                CustomerID = Convert.ToInt32(txtCusId.Text),
                Payment = Convert.ToDecimal(txtTotalPay.Text),
                DuePayment = Convert.ToDecimal(txtDuePay.Text),
                OrderBy=txtSalesman.Text
            };

            SaleInvoiceBL objsale = new SaleInvoiceBL();

            for (int i = 0; i < dgvProduct.Rows.Count; i++)
            {
                objsale.InvoiceNo = Convert.ToInt32(txtInvoiceID.Text);
                objsale.ProductID = Convert.ToInt32(dgvProduct.Rows[i].Cells[1].Value.ToString());
                objsale.Ctn = Convert.ToDecimal(dgvProduct.Rows[i].Cells[4].Value.ToString());
                objsale.Quantity = Convert.ToInt32(dgvProduct.Rows[i].Cells[5].Value.ToString());
                objsale.Discount = Convert.ToDecimal(dgvProduct.Rows[i].Cells[6].Value.ToString());
                objsale.TotalAmount = Convert.ToDecimal(dgvProduct.Rows[i].Cells[7].Value.ToString());
                objsale.SaveDetail();
            }
            objmas.SaveMaster();

           
            //SaleInvoiceBL objDue = new SaleInvoiceBL()
            //{
            //    CustomerID = Convert.ToInt32(txtCusId.Text),
            //    DuePayment = Convert.ToDecimal(txtnewBalance.Text)
            //};
            //objDue.UpdateDueSum();
           
            SaleLedgerBL objLedger = new SaleLedgerBL(); 
            
            objLedger.Invoiceno=Convert.ToInt32(txtInvoiceID.Text);
            objLedger.CustomerID=Convert.ToInt32(txtCusId.Text);
            objLedger.Credit=Convert.ToDecimal(txtDuePay.Text);
            objLedger.Debit = 0;
            


            objLedger.Date=Convert.ToDateTime(txtInvoiceDate.Text);
            objLedger.Balance=Convert.ToDecimal(txtnewBalance.Text);
            objLedger.Description = "Credit";
            objLedger.Save();
            (new SaleLedgerBL()).UpdateBalance(objLedger.Balance, objLedger.CustomerID);

            saleInvoiceReport objSale = new saleInvoiceReport();
            rptViewer objview = new rptViewer();
            //objSale.SetDataSource =;
            objSale.SetParameterValue("@InvoiceNo", txtInvoiceID.Text);
            SaleInvoiceBL obj = new SaleInvoiceBL()
            {
                InvoiceNo = Convert.ToInt32(txtInvoiceID.Text)
            };
            DataTable dt = obj.Search();
            if (dt.Rows.Count > 0)
            {
                objSale.SetDataSource(dt);
            }
            objview.crptViewer.ReportSource = objSale;
            objview.WindowState = FormWindowState.Normal;
            objview.ShowDialog();
            ClearForm();
            btnNew.Enabled = true;
        }



        private void ClearForm()
        {


            foreach (Control c in groupBox1.Controls)
            {
                if (c is TextBox || c is ComboBox || c is MaskedTextBox)
                {
                    c.Text = "";
                }

            }
            foreach (Control c in groupBox2.Controls)
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
            dgvProduct.DataSource = null;
        }


        private void txtTotalPay_TextChanged(object sender, EventArgs e)
        {
            //if (txtTotalPay.Text == string.Empty)
            //{
            //    txtTotalPay.Text = "0.00";
            //    MessageBox.Show("Please Enter Payments");
            //    txtTotalPay.Focus();
            //}

           
            if(!string.IsNullOrEmpty(txtTotalPay.Text))
            {
                decimal val = Convert.ToDecimal(txtGrandTotal.Text);
                decimal val1 = Convert.ToDecimal(txtTotalPay.Text);
                decimal val2 = val - val1;
               
                
                txtDuePay.Text = val2.ToString();
                decimal prebal = Convert.ToDecimal(txtPreBalance.Text);
                txtnewBalance.Text = (prebal + val2).ToString();
           }

        }

        private void txtQuantity_Leave_1(object sender, EventArgs e)
        {
            if (txtQuantity.Text == string.Empty)
            {
                MessageBox.Show("Please Enter Quantity");
                txtQuantity.Focus();
            }
            else if (txtQuantity.Text == "00" || txtQuantity.Text == "0")
            {
                MessageBox.Show("Null Value Not Acceptable Please Enter Quantity");
                txtQuantity.Focus();


            }
            else if(ChkPiece.Checked==true)
            {

                decimal val1 = Convert.ToDecimal(txtPrice.Text);                
                decimal val2 = Convert.ToDecimal(txtQuantity.Text);
                int piePerCtn = Convert.ToInt32(lblPiePerCtn.Text);
                decimal val3 = (val1/piePerCtn) * val2;
                txtAmount.Text = val3.ToString();
            }
        }

        private void txtQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtCusName_Leave(object sender, EventArgs e)
        {
            var customrId = Convert.ToInt32(txtCusName.SelectedValue);
            CustomerBL objCus = new CustomerBL()
            {
                CustomerID = customrId
            };

            var dt = objCus.Search();
            if (dt.Count > 0)
            {
                txtCusId.Text = Convert.ToString(dt[0].CustomerID);
                txtContact.Text = dt[0].Contact;
                txtPreBalance.Text = Convert.ToString(dt[0].DuePayment);
            }
        }

        private void txtProd_Leave(object sender, EventArgs e)
        {
            if (txtProdName.Text == string.Empty)
            {
                MessageBox.Show("Please Enter Product Name");
                txtProdName.Focus();
            }
            else
            {
                ProductBL objPro = new ProductBL()
                {
                    ProductID = Convert.ToInt32(txtProdName.SelectedValue)
                };
                List<View_tbl_Product> dt = objPro.Search();
                if (dt != null)
                {
                    txtProdId.Text = Convert.ToString(dt[0].ProductID);
                    txtPrice.Text = Convert.ToString(dt[0].RetailPrice);
                    lblQuantity.Text = Convert.ToString(dt[0].Piece);
                    txtWeight.Text = dt[0].weight;
                    lblCtn.Text = Convert.ToString(dt[0].Ctn);
                    lblPiePerCtn.Text = Convert.ToString(dt[0].PiecePerCtn);



                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {

        }

        private void btnProdUpdate_Click(object sender, EventArgs e)
        {
            bool found = false;
            if (dgvProduct.Rows.Count > 0)
            {
               foreach (DataGridViewRow row in dgvProduct.Rows)
              
                {

                    if (Convert.ToString(row.Cells[2].Value) == txtProdName.Text && Convert.ToString(row.Cells[3].Value) == txtPrice.Text)
                    {

                       row.Cells[4].Value = Convert.ToString(Convert.ToInt32(txtQuantity.Text));
                        row.Cells[5].Value = Convert.ToString(Convert.ToDecimal(txtDiscount.Text));
                        row.Cells[6].Value = Convert.ToString(Convert.ToDecimal(txtTotalAmount.Text));
                        found = true;
                        SumCalculate();
                        ClearGroup();



                    }
                   
                }
                if(!found)
                {
                    dgvProduct.Rows.Add(txtProdName.Text, txtPrice.Text, 1);
                }
              

        }

        }



        private void btnReset_Click(object sender, EventArgs e)
        {
            dgvProduct.DataSource = dt;
            dt.Rows.Clear();
            
            txtGrandTotal.Clear();

        }

        private void txtDiscount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtTotalPay_KeyPress(object sender, KeyPressEventArgs e)
            {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void dgvProduct_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtTotalPay_Leave(object sender, EventArgs e)
        {
            // if (txtTotalPay.Text == string.Empty)
            //{
            //    txtTotalPay.Text = "0.00";
            //    MessageBox.Show("Please Enter Payments");
            //    txtTotalPay.Focus();
            //}
            btnSave.Focus();
        }

        private void txtCtn_Leave(object sender, EventArgs e)
        {
            if(ChkCtn.Checked==true)
            {
                if(!string.IsNullOrEmpty(txtCtn.Text))
                {
                    decimal ctn = Convert.ToDecimal(txtCtn.Text);
                    decimal retailPrice = Convert.ToDecimal(txtPrice.Text);
                    decimal result = Convert.ToDecimal(ctn * retailPrice);
                    txtAmount.Text = result.ToString();
                }
                else
                {
                    txtCtn.Text = "0.00";
                    txtAmount.Text = "0.00";
                }
            }
        }

        private void txtCtn_TextChanged(object sender, EventArgs e)
        {
            if (ChkCtn.Checked == true &&!string.IsNullOrEmpty(txtCtn.Text))
            {
                
                decimal Ctn = Convert.ToDecimal(txtCtn.Text);
                int piePerCtn = Convert.ToInt32(lblPiePerCtn.Text);
                int result = Convert.ToInt32(Ctn * piePerCtn);
                txtQuantity.Text = result.ToString();
            }
        }

        private void ChkCtn_CheckedChanged(object sender, EventArgs e)
        {
            if(ChkCtn.Checked==true)
            {
                txtCtn.Enabled = true;
                ChkPiece.Checked = false;
            }
            else if (ChkCtn.Checked != true)
            {
                txtCtn.Enabled = false;
            }
        }

        private void txtQuantity_TextChanged(object sender, EventArgs e)
        {
            if(ChkPiece.Checked==true &&!string.IsNullOrEmpty(txtQuantity.Text))
            {
                decimal Quan = Convert.ToDecimal(txtQuantity.Text);
                int piePerCtn = Convert.ToInt32(lblPiePerCtn.Text);
                decimal result = Convert.ToDecimal(Quan / piePerCtn);
                txtCtn.Text = result.ToString();
            }
        }

        private void ChkPiece_CheckedChanged(object sender, EventArgs e)
        {
            if(ChkPiece.Checked==true)
            {
                txtQuantity.Enabled = true;
                ChkCtn.Checked = false;
            }
            else if(ChkPiece.Checked !=true)
            {
                txtQuantity.Enabled = false;
            }
        }

        private void txtSalesman_Leave(object sender, EventArgs e)
        {
            txtCusName.Focus();
        }

        private void ChkComplete_CheckedChanged(object sender, EventArgs e)
        {
            if(ChkComplete.Checked==true)
            {
                txtTotalPay.Focus();
            }
            else if(ChkComplete.Checked !=true)
            {
                ChkCtn.Focus();
            }
        }

      

       
        

        

    }
}
