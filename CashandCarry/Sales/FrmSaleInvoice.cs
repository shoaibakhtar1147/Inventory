using CashandCarry.BL;
using CashandCarry.Model;
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

namespace CashandCarry.Sales
{
    public partial class FrmSaleInvoice : Form
    {
        public FrmSaleInvoice()
        {
            InitializeComponent();
        }

        private void FrmSaleInvoice_Load(object sender, EventArgs e)
        {
            FormDisable();
            txtCusId.Focus();


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
                SumCalculate();
                btnSave.Enabled = true;
                txtCusName.Focus();



            }
        }
        private void FormDisable()
        {
            txtCusName.Enabled = false;
            txtCusId.Enabled = false;
            txtDiscount.Enabled = false;
            txtTotalBill.Enabled = false;
            txtBillDiscount.Enabled = false;
            txtQuantity.Enabled = false;
            txtContact.Enabled = false;
            txtDiscount.Enabled = false;
            txtInvoiceDate.Enabled = false;
            txtDuePay.Enabled = false;
            txtProdName.Enabled = false;
            txtProdId.Enabled = false;
            txtTotalPay.Enabled = false;
            txtPrice.Enabled = false;
            txtAmount.Enabled = false;
            txtPrice.Enabled = false;
            txtPayMode.Enabled = false;
            txtInvoiceID.Enabled = false;
            txtTotalAmount.Enabled = false;
            btnSave.Enabled = false;
            
            
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
            txtBillDiscount.Enabled = true;
            txtQuantity.Enabled = true;
            txtDiscount.Enabled = true;
            txtTotalPay.Enabled = true;

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
                int vl = Convert.ToInt32(txtAmount.Text);
                txtTotalAmount.Text = vl.ToString();
            }
            else
            {
                int val1 = Convert.ToInt32(txtAmount.Text);
                int val = ((val1 / 100) * Convert.ToInt32(txtDiscount.Text));
                int val2 = val1 - val;
                txtTotalAmount.Text = val2.ToString();
            }

        }
        private void LoadGridProd()
        {
          
            dt.Columns.Add("SrNo").AutoIncrement=true;
            dt.Columns["SrNo"].AutoIncrementSeed = 1;
            dt.Columns["SrNo"].AutoIncrementStep=1;
            dt.Columns.Add("ProductID");
            dt.Columns.Add("ProductName");
            dt.Columns.Add("RetailPrice");
            dt.Columns.Add("Quantity");
            dt.Columns.Add("Discount");
            dt.Columns.Add("TotalAmount");
            dgvProduct.DataSource = dt;

        }
        private void ClearGroup()
        {
            foreach(Control c in groupBox3.Controls)
            {
                if(c is TextBox||c is ComboBox)
                {
                    c.Text = "";
                }
               
            }
        }
        
        DataTable dt = new DataTable();
        private void btnAdd_Click(object sender, EventArgs e)
        {
            //SaleInvoiceBL objsale = new SaleInvoiceBL()
            //{
            //    InvoiceNo = Convert.ToInt32(txtInvoiceID.Text),

            //    ProductID = Convert.ToInt32(txtProdID.Text),
            //    Amount = Convert.ToDecimal(txtAmount.Text),
            //    Quantity = Convert.ToInt32(txtQuantity.Text),
            //    Discount = Convert.ToDecimal(txtDiscount.Text),
            //    TotalAmount = Convert.ToDecimal(txtTotalAmount.Text)
            //};
            //objsale.SaveDetail();
            
            DataRow dr = dt.NewRow();
           
           
            dr[1] = txtProdId.Text;
            dr[2] = txtProdName.Text; 
            dr[3] = txtPrice.Text;
            dr[4] = txtQuantity.Text;
            dr[5] = txtDiscount.Text;
            dr[6] = txtTotalAmount.Text;
            dt.Rows.Add(dr);
           // MessageBox.Show("Product Saved Successfull");
            ClearGroup();
           SumCalculate();
           txtBillDiscount.Focus();

        }
        private void SumCalculate()
        {
           
            int sum = 0;
            for (int i = 0; i < dgvProduct.Rows.Count; ++i)
            {
                sum += Convert.ToInt32(dgvProduct.Rows[i].Cells[6].Value);
            }
            txtTotalBill.Text = sum.ToString();
           
        }
       


        private void btnSave_Click(object sender, EventArgs e)
        {
            
            
           
            SaleInvoiceBL objProd = new SaleInvoiceBL();
            for (int i = 0; i < dgvProduct.RowCount - 1; i++)
            {
                objProd.ProductID = Convert.ToInt32(dgvProduct.Rows[i].Cells[1].Value.ToString());
                objProd.Quantity = Convert.ToInt32(dgvProduct.Rows[i].Cells[4].Value.ToString());
                objProd.UpdateProd();

            }
            SaleInvoiceBL objmas = new SaleInvoiceBL() { 
             
                SaleDate = DateTime.Parse(txtInvoiceDate.Text),
                TotalBill = Convert.ToDecimal(txtTotalBill.Text),
                 BillDiscount = Convert.ToDecimal(txtBillDiscount.Text),
                 GrandTotal = Convert.ToDecimal(txtGrandTotal.Text),
                 CustomerID=Convert.ToInt32(txtCusId.Text),
                 Payment=Convert.ToDecimal(txtTotalPay.Text),
                 DuePayment=Convert.ToDecimal(txtDuePay.Text)
        };
           
            SaleInvoiceBL objsale = new SaleInvoiceBL();

            for (int i = 0; i < dgvProduct.RowCount - 1; i++)
            {
                objsale.InvoiceNo = Convert.ToInt32(txtInvoiceID.Text);
                objsale.ProductID = Convert.ToInt32(dgvProduct.Rows[i].Cells[1].Value.ToString());
                objsale.Quantity = Convert.ToInt32(dgvProduct.Rows[i].Cells[4].Value.ToString());
                objsale.Discount = Convert.ToDecimal(dgvProduct.Rows[i].Cells[5].Value.ToString());
                objsale.TotalAmount = Convert.ToDecimal(dgvProduct.Rows[i].Cells[6].Value.ToString());
                objsale.SaveDetail();
            }
            
            objmas.SaveMaster();
           

            
            //MessageBox.Show("Saved Successfull");

           

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
        }

        

        private void txtBillDiscount_Leave(object sender, EventArgs e)
        {

            if (txtBillDiscount.Text == string.Empty)
            {
                txtBillDiscount.Text = "0";
                int Bill = Convert.ToInt32(txtTotalBill.Text);
                txtGrandTotal.Text = Bill.ToString();
            }
            else if (txtBillDiscount.Text == "0")
            {
                txtBillDiscount.Text = "0";
                int Bill = Convert.ToInt32(txtTotalBill.Text);
                txtGrandTotal.Text = Bill.ToString();
            }
        }

        private void txtTotalPay_TextChanged(object sender, EventArgs e)
        {
            if(txtTotalPay.Text==string.Empty)
            {
                txtTotalPay.Text = "0";
                MessageBox.Show("Please Enter Payments");
                txtTotalPay.Focus();
            }
            else
            {
                int val = Convert.ToInt32(txtGrandTotal.Text);
                int val1 = Convert.ToInt32(txtTotalPay.Text);
                int val2 = val - val1;
                txtDuePay.Text = val2.ToString();
              
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
            else
            {

                int val1 = Convert.ToInt32(txtPrice.Text);
                int val2 = Convert.ToInt32(txtQuantity.Text);
                int val3 = val1 * val2;
                txtAmount.Text = val3.ToString();
            }
        }

        private void txtQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsControl(e.KeyChar)&&!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtCusName_Leave(object sender, EventArgs e)
        {
            var customrId=Convert.ToInt32(txtCusName.SelectedValue);
            CustomerBL objCus = new CustomerBL()
            {
                CustomerID = customrId
            };

            var dt = objCus.Search();
                if (dt.Count>0)
            {
                txtCusId.Text = Convert.ToString(dt[0].CustomerID);
                txtContact.Text = dt[0].Contact;
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
                List<tbl_Product> dt = objPro.Search();
                if (dt != null)
                {
                    txtProdId.Text =Convert.ToString(dt[0].ProductID);
                    txtPrice.Text = Convert.ToString(dt[0].RetailPrice);
                    txtWeight.Text = dt[0].weight;


                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
        
        }

        private void btnProdUpdate_Click(object sender, EventArgs e)
        {
            bool found = false;
            if(dgvProduct.Rows.Count>0)
            {
               foreach(DataGridViewRow row in dgvProduct.Rows)
                {

                    if (Convert.ToString(dgvProduct.Rows[0].Cells[2].Value) == txtProdName.Text && Convert.ToString(dgvProduct.Rows[0].Cells[3].Value) == txtPrice.Text)
                    {
                        dgvProduct.Rows[0].Cells[4].Value = Convert.ToString(txtQuantity.Text);
                        dgvProduct.Rows[0].Cells[5].Value = Convert.ToString(txtDiscount.Text);
                        dgvProduct.Rows[0].Cells[6].Value = Convert.ToString(txtTotalAmount.Text);
                        found = true;
                        SumCalculate();
                        ClearGroup();
                        txtBillDiscount.Focus();
                    }
                    if (!found)
                    {
                        MessageBox.Show("Some Error Has Occur");

                    }
                }
                  
                }
           
        }

        private void txtBillDiscount_TextChanged(object sender, EventArgs e)
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

                int val2 = (Bill / 100) * Convert.ToInt32(txtBillDiscount.Text);
                int val3 = Bill - val2;
                txtGrandTotal.Text = val3.ToString();

            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            dgvProduct.DataSource = dt;
            dt.Rows.Clear();
            txtTotalBill.Clear();
            txtGrandTotal.Clear();
            txtBillDiscount.Clear();
        }

        private void dgvProduct_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtDuePay_TextChanged(object sender, EventArgs e)
        {

        }
        
        }
}
