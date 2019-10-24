﻿using CashandCarry.BL;
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

namespace CashandCarry.Vendor
{
    public partial class PurchaseInvoice : Form
    {
        public PurchaseInvoice()
        {
            InitializeComponent();
        }

        private void lblminimize_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void LoadComp()
        {
            CompanyBL objCom = new CompanyBL();
             List<tbl_Company> dt=objCom.Select();
             txtCompanyName.DataSource = dt;
             txtCompanyName.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
             txtCompanyName.AutoCompleteSource = AutoCompleteSource.ListItems;
             txtCompanyName.DisplayMember = "CompanyName";
             txtCompanyName.ValueMember = "CompanyID";

            

        }
        private void FormDisable()
        {
           
            txtComID.Enabled = false;
            txtContact.Enabled = false;
            txtTotalBill.Enabled = false;
            txtBillDiscount.Enabled = false;
            txtQuantity.Enabled = false;
            txtCompanyName.Enabled = false;
            txtPurInvoiceDate.Enabled = false;
            txtPayDue.Enabled = false;
            txtProdName.Enabled = false;
            txtProdID.Enabled = false;
            txtTotalPay.Enabled = false;
            txtPrice.Enabled = false;
            txtAmount.Enabled = false;
            txtPrice.Enabled = false;
            txtPayMode.Enabled = false;
            txtInvoiceID.Enabled = false;
           
            btnSave.Enabled = false;
            btnUpdate.Enabled = false;
           
            btnProdUpdate.Enabled = false;
            btnRemove.Enabled = false;
            btnAdd.Enabled = false;
            btnReset.Enabled = false;
            btnClear.Enabled = false;
            txtWeight.Enabled = false;
            txtComContact.Enabled = false;
        }

        private void FormEnable()
        {

            txtCompanyName.Enabled = true;
            txtBillDiscount.Enabled = true;
            txtQuantity.Enabled = true;
           
            txtProdName.Enabled = true;
            txtTotalPay.Enabled = true;
            
            btnSave.Enabled = true;
            btnAdd.Enabled = true;
            btnReset.Enabled = true;
            btnClear.Enabled = true;
            
        }
        private void PurchaseInvoice_Load(object sender, EventArgs e)
        {
            FormDisable();
            btnNew.Focus();
           
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            PurchaseInvoiceBL objPur = new PurchaseInvoiceBL(); 
            DataTable dt=objPur.Addnew();
            if(dt.Rows.Count>0)
            {

                txtInvoiceID.Text = Convert.ToString(dt.Rows[0]["PInvoice"]);
                FormEnable();
            LoadComp();
            LoadProd();
            LoadGridProd();
            txtCompanyName.Focus();
            }
           
        }

        private void LoadProd()
        {
            ProductBL objPro = new ProductBL();
            List<View_tbl_Product> dt = objPro.Select();
            txtProdName.DataSource = dt;
            txtProdName.AutoCompleteSource = AutoCompleteSource.ListItems;
            txtProdName.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txtProdName.DisplayMember = "ProductName";
            txtProdName.ValueMember = "ProductID";
        }

        private void txtCompanyName_Leave(object sender, EventArgs e)
        {
            if(txtCompanyName.Text==string.Empty)
            {
                MessageBox.Show("Please Enter Company Name");
                txtCompanyName.Focus();
            }
            else
            {
                CompanyBL objCom = new CompanyBL() 
                {
                 CompanyID=Convert.ToInt32(txtCompanyName.SelectedValue)
                };
                tbl_Company dt = objCom.Search();
                if(dt != null)
                {
                    txtComID.Text = Convert.ToString(dt.CompanyID);
                    txtComContact.Text = dt.Contact;
                }

            }

        }

        private void txtProdName_Leave(object sender, EventArgs e)
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
                tbl_Product dt = objPro.Search();
                if (dt != null)
                {
                    txtProdID.Text = Convert.ToString(dt.ProductID);
                    txtPrice.Text = Convert.ToString(dt.RetailPrice);
                    txtWeight.Text = dt.weight;

                }
            }
        }
        DataTable dt=new DataTable();
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
            
           
            dgvProduct.DataSource = dt;

        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            DataRow dr = dt.NewRow();

            
            dr[1] = txtProdID.Text;
            dr[2] = txtComID.Text;
            dr[3] = txtCompanyName.Text;
            dr[4] = txtProdName.Text;
            dr[5] = txtPrice.Text;
            dr[6] = txtQuantity.Text;
            dr[7] = txtAmount.Text;
            dt.Rows.Add(dr);

            SumCalculate();
            txtTotalBill.Focus();
        }
        private void SumCalculate()
        {

            int sum = 0;
            for (int i = 0; i < dgvProduct.Rows.Count; ++i)
            {
                sum += Convert.ToInt32(dgvProduct.Rows[i].Cells[7].Value);
            }
            txtTotalBill.Text = sum.ToString();

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
            int val = Convert.ToInt32(txtPrice.Text);
            int val1 = Convert.ToInt32(txtQuantity.Text);
            int val2 = val * val1;
            txtAmount.Text = val2.ToString();
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

                int val2 = (Bill / 100) * Convert.ToInt32(txtBillDiscount.Text);
                int val3 = Bill - val2;
                txtGrandTotal.Text = val3.ToString();

            }
        }

        private void txtTotalPay_TextChanged(object sender, EventArgs e)
        {
            if (txtTotalPay.Text == string.Empty)
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

        private void btnSave_Click(object sender, EventArgs e)
        {
            PurchaseInvoiceBL objpur = new PurchaseInvoiceBL();
            for(int i=0;i<dgvProduct.RowCount-1;i++)
            {
                objpur.ProductID = Convert.ToInt32(dgvProduct.Rows[i].Cells[1].Value.ToString());
                objpur.Quantity = Convert.ToInt32(dgvProduct.Rows[i].Cells[5].Value.ToString());
                objpur.ProdUpdate();
            }
            PurchaseInvoiceBL objmas = new PurchaseInvoiceBL() 
            {
             companyID=Convert.ToInt32(txtComID.Text),
             Discount=Convert.ToInt32(txtBillDiscount.Text),
              PurchaseDate=DateTime.Parse(txtPurInvoiceDate.Text),
               GrandTotal=Convert.ToInt32(txtGrandTotal.Text)
            };

            PurchaseInvoiceBL objDet = new PurchaseInvoiceBL();
            for(int i=0;i<dgvProduct.RowCount-1;i++)
            {
                objDet.PInvoice = Convert.ToInt32(txtInvoiceID.Text);
                objDet.ProductID = Convert.ToInt32(dgvProduct.Rows[i].Cells[1].Value.ToString());
                objDet.companyID = Convert.ToInt32(dgvProduct.Rows[i].Cells[2].Value.ToString());
                objDet.Quantity=Convert.ToInt32(dgvProduct.Rows[i].Cells[6].Value.ToString());
                objDet.TotalAmount = Convert.ToInt32(dgvProduct.Rows[i].Cells[7].Value.ToString());
                objDet.SaveDetail();
                
            }
            objmas.SaveMaster();
        }

      
       
       
       
    }
}
