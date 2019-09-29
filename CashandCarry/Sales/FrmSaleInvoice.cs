using CashandCarry.BL;
using CashandCarry.Model;
using CashandCarry.Reports;
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
            txtCusName.Focus();


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
                FormEnable();
                //LoadSaleDetail();
                LoadGridProd();
                SumCalculate();
                btnSave.Enabled = true;
                txtCusID.Focus();



            }
        }
        private void FormDisable()
        {
            txtCusID.Enabled = false;
            txtCusName.Enabled = false;
            txtDiscount.Enabled = false;
            txtTotalBill.Enabled = false;
            txtBillDiscount.Enabled = false;
            txtQuantity.Enabled = false;
            txtContact.Enabled = false;
            txtDiscount.Enabled = false;
            txtInvoiceDate.Enabled = false;
            txtPayDue.Enabled = false;
            txtProdID.Enabled = false;
            txtProdName.Enabled = false;
            txtTotalPay.Enabled = false;
            txtPrice.Enabled = false;
            txtAmount.Enabled = false;
            txtPrice.Enabled = false;
            txtPayMode.Enabled = false;
            txtInvoiceID.Enabled = false;
            txtTotalAmount.Enabled = false;
            btnSave.Enabled = false;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
            btnProdUpdate.Enabled = false;
            btnRemove.Enabled = false;
            btnAdd.Enabled = false;
            btnReset.Enabled = false;
            btnClear.Enabled = false;
            txtWeight.Enabled = false;
        }

        private void FormEnable()
        {
            txtProdID.Enabled = true;
            txtCusID.Enabled = true;
            txtDiscount.Enabled = true;
            txtBillDiscount.Enabled = true;
            txtQuantity.Enabled = true;
            txtDiscount.Enabled = true;
            txtTotalPay.Enabled = true;

            btnProdUpdate.Enabled = true;
            btnRemove.Enabled = true;
            btnAdd.Enabled = true;
            btnReset.Enabled = true;
        }
        private void LoadCus()
        {
            CustomerBL objCus = new CustomerBL();
            List<View_tbl_Customer> dt = objCus.Select();
            txtCusID.DataSource = dt;
            txtCusID.AutoCompleteMode = AutoCompleteMode.Suggest;
            txtCusID.AutoCompleteSource = AutoCompleteSource.ListItems;
            txtCusID.DisplayMember = "CustomerID";
            txtCusID.ValueMember = "CustomerID";
        }

        private void txtCusID_Leave(object sender, EventArgs e)
        {
            CustomerBL objCus = new CustomerBL()
            {
                CustomerID = Convert.ToInt32(txtCusID.Text)
            };
            tbl_Customer dt = objCus.Search();
            if (dt != null)
            {
                txtCusName.Text = dt.Name;
                txtContact.Text = dt.Contact;
            }
        }
        private void LoadProd()
        {
            ProductBL objPro = new ProductBL();
            List<View_tbl_Product> dt = objPro.Select();
            txtProdID.DataSource = dt;
            txtProdID.AutoCompleteMode = AutoCompleteMode.Suggest;
            txtProdID.AutoCompleteSource = AutoCompleteSource.ListItems;
            txtProdID.DisplayMember = "ProductID";
            txtProdID.ValueMember = "ProductID";
        }
        private void txtProdID_Leave(object sender, EventArgs e)
        {
            if (txtProdID.Text == string.Empty)
            {
                MessageBox.Show("Please Enter Product Id");
                txtProdID.Focus();
            }
            else
            {
                ProductBL objPro = new ProductBL()
                {
                    ProductID = Convert.ToInt32(txtProdID.Text)
                };
                tbl_Product dt = objPro.Search();
                if (dt != null)
                {
                    txtProdName.Text = dt.ProductName;
                    txtPrice.Text = Convert.ToString(dt.RetailPrice);
                    txtWeight.Text = dt.weight;


                }
            }
            
        }

        private void txtQuantity_Leave(object sender, EventArgs e)
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
            dt.Columns.Add("Edit");
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
           
            dr[0] = Properties.Resources.edit;
            dr[2] = txtProdID.Text;
            dr[3] = txtProdName.Text;
            dr[4] = txtPrice.Text;
            dr[5] = txtQuantity.Text;
            dr[6] = txtDiscount.Text;
            dr[7] = txtTotalAmount.Text;
            dt.Rows.Add(dr);
           // MessageBox.Show("Product Saved Successfull");
            ClearGroup();
           SumCalculate();
           txtBillDiscount.Focus();

        }
        private void SumCalculate()
        {
            //SaleInvoiceBL objSale = new SaleInvoiceBL()
            //{
            //    InvoiceNo = Convert.ToInt32(txtInvoiceID.Text)
            //};
            //DataTable dt = objSale.sumSalesDetail();

            //if (dt.Rows.Count > 0)
            //{
            //    txtTotalBill.Text = Convert.ToString(dt.Rows[0]["Invoice#"]);
            //    txtGrandTotal.Text = Convert.ToString(dt.Rows[0]["Invoice#"]);
            //}
            int sum = 0;
            for (int i = 0; i < dgvProduct.Rows.Count; ++i)
            {
                sum += Convert.ToInt32(dgvProduct.Rows[i].Cells[7].Value);
            }
            txtTotalBill.Text = sum.ToString();
           
        }
        //private void LoadSaleDetail()
        //{
        //    SaleInvoiceBL objSale = new SaleInvoiceBL()
        //    {
        //        InvoiceNo = Convert.ToInt32(txtInvoiceID.Text)
        //    };
        //    List<View_DetailSale> dt = objSale.SelectSaleDetail();
        //    //string query = "Select * from View_DetailSale where Invoice#=2";
        //    //DataTable dt = DB.Select(query);
        //    dgvProduct.Columns.Clear();
        //    if (dt != null && dt.Count > 0)
        //    {
        //        DataGridViewImageColumn edit = new DataGridViewImageColumn();
        //       edit.Image = Properties.Resources.edit;
        //        edit.ImageLayout = DataGridViewImageCellLayout.Zoom;
        //        edit.HeaderText = "Edit";
        //        edit.Width = 40;
        //        dgvProduct.Columns.Add(edit);
        //        dgvProduct.DataSource = dt;
        //        dgvProduct.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        //    }

        //}



        private void btnSave_Click(object sender, EventArgs e)
        {


           //string query="update tbl_Quantity set Qty=Qty - '"+txtQuantity.Text +"' where qtyId='1'";
           //DB.insert(query);
           
            SaleInvoiceBL objProd = new SaleInvoiceBL() ;

            objProd.ProductID = txtProdID.SelectedIndex;
            objProd.Quantity = Convert.ToInt32(txtQuantity.Text);
            
            int rowaffected = objProd.UpdateProd();
            if(rowaffected>0)
            {
                MessageBox.Show("Update Successfull");
            }
            else
            {
                MessageBox.Show("Update Error");
            }
            SaleInvoiceBL objmas = new SaleInvoiceBL()
             {
                 SaleDate = DateTime.Parse(txtInvoiceDate.Text),


                 TotalBill = Convert.ToDecimal(txtTotalBill.Text),
                 BillDiscount = Convert.ToDecimal(txtBillDiscount.Text),
                 GrandTotal = Convert.ToDecimal(txtGrandTotal.Text),
                 CustomerID=Convert.ToInt32(txtCusID.Text)
             };
           
            SaleInvoiceBL objsale = new SaleInvoiceBL();

            for (int i = 0; i < dgvProduct.RowCount - 1; i++)
            {
                objsale.InvoiceNo = Convert.ToInt32(txtInvoiceID.Text);
                objsale.ProductID = Convert.ToInt32(dgvProduct.Rows[i].Cells[2].Value.ToString());
                objsale.Quantity = Convert.ToInt32(dgvProduct.Rows[i].Cells[5].Value.ToString());
                objsale.Discount = Convert.ToDecimal(dgvProduct.Rows[i].Cells[6].Value.ToString());
                objsale.TotalAmount = Convert.ToDecimal(dgvProduct.Rows[i].Cells[7].Value.ToString());
                objsale.SaveDetail();
            }
            
            objmas.SaveMaster();
           

            
            //MessageBox.Show("Saved Successfull");

           

            saleInvoiceReport objSale = new saleInvoiceReport();
           
            rptViewer objview = new rptViewer();
           //objSale.SetDataSource =;
            objSale.SetParameterValue("@InvoiceNo", txtInvoiceID.Text);
            objview.crptViewer.ReportSource = objSale;
            objview.WindowState = FormWindowState.Normal;
            objview.ShowDialog();
        }

        

        private void txtBillDiscount_Leave(object sender, EventArgs e)
        {
            if(txtBillDiscount.Text ==string.Empty )
            {
                txtBillDiscount.Text = "0";
                int Bill = Convert.ToInt32(txtTotalBill.Text);
                txtGrandTotal.Text=Bill.ToString();
            }
            else
            {
                int Bill = Convert.ToInt32(txtTotalBill.Text);

                int val2 = (Bill / 100) * Convert.ToInt32(txtBillDiscount.Text);
                int val3 = Bill - val2;
                txtGrandTotal.Text = val3.ToString();

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
                txtPayDue.Text = val2.ToString();
              
            }
           
        }

        

       







    }

}
