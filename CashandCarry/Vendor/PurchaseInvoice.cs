using CashandCarry.BL;
using CashandCarry.Configuration;
using CashandCarry.Model;
using CashandCarry.Reports;
using CashandCarry.Reports.Purchase;
using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CashandCarry.Vendor
{
    public partial class PurchaseInvoice : MetroForm
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
            List<tbl_Company> dt = objCom.Select();
            txtCompanyName.DataSource = dt;
            txtCompanyName.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txtCompanyName.AutoCompleteSource = AutoCompleteSource.ListItems;
            txtCompanyName.DisplayMember = "CompanyName";
            txtCompanyName.ValueMember = "CompanyID";



        }
        private void FormDisable()
        {

            txtComID.Enabled = false;
            txtComContact.Enabled = false;
            txtTotalBill.Enabled = false;
            txtBillDiscount.Enabled = false;
            txtQuantity.Enabled = false;
            txtCompanyName.Enabled = false;
            txtPurInvoiceDate.Enabled = false;
            txtPayDue.Enabled = false;
            txtQuantity.Enabled = false;
            txtProdName.Enabled = false;
            txtProdID.Enabled = false;
            txtTotalPay.Enabled = false;
            txtPrice.Enabled = false;
            txtAmount.Enabled = false;
            txtPrice.Enabled = false;
            txtPreBalance.Enabled = false;
            txtnewBalance.Enabled = false;
            txtInvoiceID.Enabled = false;

            btnSave.Enabled = false;


            btnProdUpdate.Enabled = false;
            //btnRemove.Enabled = false;
            btnAdd.Enabled = false;
            btnReset.Enabled = false;
            btnClear.Enabled = false;
            txtWeight.Enabled = false;
            lblfrieghtCtn.Hide();
            txtfrieghtCtn.Hide();
            lblfrieghtQuan.Hide();
            txtfrieghtQuan.Hide();
            txtCtn.Enabled = false;
            ChkFrieghtOrder.Enabled = false;
            txtComContact.Enabled = false;
        }

        private void FormEnable()
        {

            txtCompanyName.Enabled = true;
            txtBillDiscount.Enabled = true;
           // txtQuantity.Enabled = true;
            txtCtn.Enabled = true;
            txtProdName.Enabled = true;
            ChkFrieghtOrder.Enabled = true;
            txtTotalPay.Enabled = true;
            btnProdUpdate.Enabled = true;
           // btnRemove.Enabled = true;
            btnSave.Enabled = true;
            btnAdd.Enabled = true;
            btnReset.Enabled = true;
            btnClear.Enabled = true;

        }
        private void PurchaseInvoice_Load(object sender, EventArgs e)
        {
            FormDisable();
            GridDesign();
            btnNew.Focus();

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

        private void btnNew_Click(object sender, EventArgs e)
        {
            PurchaseInvoiceBL objPur = new PurchaseInvoiceBL();
            DataTable dt = objPur.Addnew();
            if (dt.Rows.Count > 0)
            {

                txtInvoiceID.Text = Convert.ToString(dt.Rows[0]["PInvoice"]);
                FormEnable();
                LoadComp();
                LoadProd();
                LoadGridProd();
                txtCompanyName.Focus();
                btnNew.Enabled = false;
            }

        }

        private void LoadProd()
        {
            ProductBL objPro = new ProductBL() 
            {
             Company=txtCompanyName.Text
            };
            List<View_tbl_Product> dt = objPro.SearchByComp();
            if(dt != null)
            {
                txtProdName.DataSource = dt;
                txtProdName.AutoCompleteSource = AutoCompleteSource.ListItems;
                txtProdName.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                txtProdName.DisplayMember = "ProductName";
                txtProdName.ValueMember = "ProductID";
            }
            
        }

        private void txtCompanyName_Leave(object sender, EventArgs e)
        {
            if (txtCompanyName.Text == string.Empty)
            {
                MessageBox.Show("Please Enter Company Name");
                txtCompanyName.Focus();
            }
            else
            {
                CompanyBL objCom = new CompanyBL()
                {
                    CompanyID = Convert.ToInt32(txtCompanyName.SelectedValue)
                };
                var dt = objCom.Search();
                if (dt != null)
                {
                    txtComID.Text = Convert.ToString(dt[0].CompanyID);
                    txtComContact.Text = dt[0].Contact;
                    txtPreBalance.Text = Convert.ToString(dt[0].DuePayment);
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
                var dt = objPro.Search();
                if (dt != null)
                {
                    txtProdID.Text = Convert.ToString(dt[0].ProductID);
                    txtPrice.Text = Convert.ToString(dt[0].PurchasePrice);
                    lblQuantity.Text = Convert.ToString(dt[0].Piece);
                    lblCtn.Text = Convert.ToString(dt[0].Ctn);
                    lblPieCtn.Text = Convert.ToString(dt[0].PiecePerCtn);
                    txtWeight.Text = dt[0].weight;

                }
            }
        }
        DataTable dt = new DataTable();
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
            dt.Columns.Add("Ctn");
            dt.Columns.Add("Frieght Order");
            dt.Columns.Add("Total Ctn");
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
            if(!string.IsNullOrEmpty(txtfrieghtQuan.Text))
            {
                int quan = Convert.ToInt32(txtQuantity.Text);
                int frieQuan=Convert.ToInt32(txtfrieghtQuan.Text);
                dr[6] =quan +frieQuan;
            }
            else
            {
                dr[6] = txtQuantity.Text;
            }
            
            dr[7] = txtCtn.Text;
            
            if(!string.IsNullOrEmpty(txtfrieghtCtn.Text))
            {
                dr[8] = txtfrieghtCtn.Text;
                decimal ctn = Convert.ToDecimal(txtCtn.Text);
                decimal frieCtn = Convert.ToDecimal(txtfrieghtCtn.Text);
                dr[9] = ctn + frieCtn;
            }
            else
            {
                dr[8] = 0;
                dr[9] = txtCtn.Text;
            }
            dr[10] = Convert.ToDecimal(txtAmount.Text);
            dt.Rows.Add(dr);
            ChkFrieghtOrder.Checked = false;
            SumCalculate();
            txtTotalBill.Focus();
            ClearGroup();
        }
        private void SumCalculate()
        {

            decimal sum = 0;
            for (int i = 0; i < dgvProduct.Rows.Count; ++i)
            {
                sum += Convert.ToDecimal(dgvProduct.Rows[i].Cells[10].Value);
            }
            txtTotalBill.Text = sum.ToString();

        }

        private void txtQuantity_Leave(object sender, EventArgs e)
        {
            
        }

        private void txtBillDiscount_Leave(object sender, EventArgs e)
        {
            if (txtBillDiscount.Text == string.Empty)
            {
                txtBillDiscount.Text = "0.00";
                decimal Bill = Convert.ToDecimal(txtTotalBill.Text);
                txttotalAmount.Text = Bill.ToString();
            }
            else
            {
                //int Bill = Convert.ToInt32(txtTotalBill.Text);

                //int val2 = Convert.ToInt32(txtBillDiscount.Text);
                //int val3 = Bill - val2;
                decimal bill = Convert.ToDecimal(txtTotalBill.Text);
                decimal billDiscount=Convert.ToDecimal(txtBillDiscount.Text);
                decimal result = (bill / 100) * billDiscount;
                decimal resu = Convert.ToDecimal(bill - result);
                txttotalAmount.Text = resu.ToString();

            }
        }

        private void txtTotalPay_TextChanged(object sender, EventArgs e)
        {
            //if (txtTotalPay.Text == string.Empty)
            //{
            //    txtTotalPay.Text = "0";
            //    MessageBox.Show("Please Enter Payments");
            //    txtTotalPay.Focus();
            //}
            if(!string.IsNullOrEmpty(txtTotalPay.Text))
            {
                decimal val = Convert.ToDecimal(txtGrandTotal.Text);
                decimal val1 = Convert.ToDecimal(txtTotalPay.Text);
                decimal val2 = val - val1;
                txtPayDue.Text = val2.ToString();

                decimal prebal = Convert.ToDecimal(txtPreBalance.Text);
                txtnewBalance.Text = (prebal + val2).ToString();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            PurchaseInvoiceBL objpur = new PurchaseInvoiceBL();
            for (int i = 0; i < dgvProduct.Rows.Count; i++)
            {
                objpur.ProductID = Convert.ToInt32(dgvProduct.Rows[i].Cells[1].Value.ToString());
                objpur.Quantity = Convert.ToInt32(dgvProduct.Rows[i].Cells[6].Value.ToString());
                objpur.ProdUpdate();
            }
            PurchaseInvoiceBL objCtn = new PurchaseInvoiceBL();
            for (int i = 0; i < dgvProduct.Rows.Count; i++)
            {


                objCtn.ProductID = Convert.ToInt32(dgvProduct.Rows[i].Cells[1].Value.ToString());
                objCtn.Ctn = Convert.ToInt32(dgvProduct.Rows[i].Cells[9].Value.ToString());
                objCtn.CtnUpdate();



            }


            //PurchaseInvoiceBL obj = new PurchaseInvoiceBL()
            //{
            //    DuePayment = Convert.ToDecimal(txtPayDue.Text),
            //    companyID = Convert.ToInt32(txtComID.Text)
            //};
            //obj.UpdateDuePayment();
            
            PurchaseInvoiceBL objmas = new PurchaseInvoiceBL()
            {
                PInvoice = Convert.ToInt32(txtInvoiceID.Text),
                companyID = Convert.ToInt32(txtComID.Text),
                Discount = Convert.ToInt32(txtBillDiscount.Text),
                PurchaseDate = DateTime.Parse(txtPurInvoiceDate.Text),
                TotalAmount = Convert.ToDecimal(txttotalAmount.Text),
                Payment = Convert.ToDecimal(txtTotalPay.Text),
                DuePayment = Convert.ToDecimal(txtPayDue.Text),
                furDiscount=Convert.ToInt32(txtfurDiscount.Text),
                GrandTotal=Convert.ToDecimal(txtGrandTotal.Text)
            };

            PurchaseInvoiceBL objDet = new PurchaseInvoiceBL();
            for (int i = 0; i < dgvProduct.Rows.Count ; i++)
            {
                objDet.PInvoice = Convert.ToInt32(txtInvoiceID.Text);
                objDet.ProductID = Convert.ToInt32(dgvProduct.Rows[i].Cells[1].Value.ToString());
                objDet.Quantity = Convert.ToInt32(dgvProduct.Rows[i].Cells[6].Value.ToString());
                objDet.frieght = Convert.ToDecimal(dgvProduct.Rows[i].Cells[8].Value.ToString());
                objDet.Ctn = Convert.ToDecimal(dgvProduct.Rows[i].Cells[9].Value.ToString());
                objDet.Amount = Convert.ToDecimal(dgvProduct.Rows[i].Cells[10].Value.ToString());
                objDet.SaveDetail();

            }
            objmas.SaveMaster();
            PurchaseLedgerBL objLedger=new PurchaseLedgerBL();
            objLedger.PInvoice=Convert.ToInt32(txtInvoiceID.Text);
            objLedger.CompanyID=Convert.ToInt32(txtComID.Text);
            objLedger.Credit=Convert.ToDecimal(txtPayDue.Text);
            objLedger.Debit=0;
            objLedger.Date=Convert.ToDateTime(txtPurInvoiceDate.Text);
            objLedger.Balance=Convert.ToDecimal(txtnewBalance.Text);
            objLedger.Description="Debit";
            objLedger.save();
            (new PurchaseLedgerBL()).UpdateBalance(objLedger.Balance, objLedger.CompanyID);

            PurchaseInvoiceReport objretp = new PurchaseInvoiceReport();
            rptViewer objView = new rptViewer();
            objretp.SetParameterValue("@PInvoice", txtInvoiceID.Text);
            PurchaseInvoiceBL objBl = new PurchaseInvoiceBL()
            {
                PInvoice=Convert.ToInt32(txtInvoiceID.Text)
            };
            var dt = objBl.Search();
            if(dt !=null)
            {
                objretp.SetDataSource(dt);
                objView.crptViewer.ReportSource = objretp;
                objView.WindowState = FormWindowState.Maximized;
                objView.ShowDialog();
            }
            ClearForm();
            ChkFrieghtOrder.Checked = false;
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
            dgvProduct.DataSource = null;
        }
        private void btnReset_Click(object sender, EventArgs e)
        {
            dgvProduct.DataSource = dt;
            dt.Rows.Clear();
            txtTotalBill.Clear();
            txtGrandTotal.Clear();
            txtBillDiscount.Clear();
        }

        private void btnProdUpdate_Click(object sender, EventArgs e)
        {
            bool found = false;
            if (dgvProduct.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in dgvProduct.Rows)
                {

                    if (Convert.ToString(row.Cells[3].Value) == txtCompanyName.Text && Convert.ToString(row.Cells[4].Value) == txtProdName.Text && Convert.ToString(row.Cells[5].Value) == txtPrice.Text)
                    {

                        row.Cells[6].Value = Convert.ToString(Convert.ToInt32(txtQuantity.Text));
                        row.Cells[10].Value = Convert.ToString(Convert.ToDecimal(txtAmount.Text));
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
                lblCtn.Text = "";
                lblPieCtn.Text = "";
                lblQuantity.Text = "";


            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {

        }

        private void txtQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            if(Regex.IsMatch(txtQuantity.Text,@"\. \d\d"))
            {
                e.Handled = true;
            }
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void txtCtn_TextChanged(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(txtCtn.Text))
            {
                decimal ctn = Convert.ToDecimal(txtCtn.Text);
                int piePerCtn = Convert.ToInt32(lblPieCtn.Text);

                txtQuantity.Text = (ctn * piePerCtn).ToString();

            }
        }

        private void ChkFrieghtOrder_CheckedChanged(object sender, EventArgs e)
        {
            if(ChkFrieghtOrder.Checked==true)
            {
                lblfrieghtCtn.Visible = true;
                txtfrieghtCtn.Visible = true;
                lblfrieghtQuan.Visible = true;
                txtfrieghtQuan.Visible = true;
                txtfrieghtCtn.Focus();

            }
            else if(ChkFrieghtOrder.Checked==false)
            {
                lblfrieghtCtn.Hide();
                txtfrieghtCtn.Hide();
                lblfrieghtQuan.Hide();
                txtfrieghtQuan.Hide();
            }
        }

        private void txtfrieghtCtn_TextChanged(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(txtfrieghtCtn.Text))
            {
                decimal ctn = Convert.ToDecimal(txtfrieghtCtn.Text);
                int piePerCtn = Convert.ToInt32(lblPieCtn.Text);

                int result=Convert.ToInt32(ctn * piePerCtn);
                txtfrieghtQuan.Text = result.ToString();

            }
        }

        private void txtCtn_Leave(object sender, EventArgs e)
        {
            if (txtCtn.Text == string.Empty)
            {
                MessageBox.Show("Please Enter Quantity");
                txtCtn.Focus();
            }
            else if (txtCtn.Text == "00" || txtCtn.Text == "0")
            {
                MessageBox.Show("Null Value Not Acceptable Please Enter Quantity");
                txtCtn.Focus();
            }
            else
            {
                decimal val = Convert.ToDecimal(txtPrice.Text);
                decimal val1 = Convert.ToDecimal(txtCtn.Text);
                decimal val2 = val * val1;
                txtAmount.Text = val2.ToString();
            }
        }

        private void btnPrice_Click(object sender, EventArgs e)
        {
            frmProduct objpro = new frmProduct();
            objpro.ShowDialog();
        }

        private void txtfrieghtQuan_Leave(object sender, EventArgs e)
        {
            btnAdd.Focus();
        }

        private void txtfurDiscount_Leave(object sender, EventArgs e)
        {
            if (txtfurDiscount.Text == string.Empty)
            {
                txtfurDiscount.Text = "0.00";
                decimal GrandTotal = Convert.ToDecimal(txtGrandTotal.Text);
                txtGrandTotal.Text= GrandTotal.ToString();
            }
            else
            {
                //int Bill = Convert.ToInt32(txtTotalBill.Text);

                //int val2 = Convert.ToInt32(txtBillDiscount.Text);
                //int val3 = Bill - val2;
                decimal TotalAmount = Convert.ToDecimal(txttotalAmount.Text);
                decimal furDiscount = Convert.ToDecimal(txtfurDiscount.Text);
                decimal result = (TotalAmount / 100) * furDiscount;
                decimal resu = Convert.ToDecimal(TotalAmount - result);
                txtGrandTotal.Text = resu.ToString();

            }
        }

        private void txtTotalPay_Leave(object sender, EventArgs e)
        {
            btnSave.Focus();
        }

       
        //private void txtQuantity_TextChanged(object sender, EventArgs e)
        //{
        //    if(!string.IsNullOrEmpty(txtQuantity.Text))
        //    {
        //        decimal quan = Convert.ToInt32(txtQuantity.Text);
        //        decimal piePerCtn = Convert.ToInt32(lblPieCtn.Text);
        //        decimal result = quan / piePerCtn;
        //        txtCtn.Text = result.ToString();
        //    }
        //}
    }
      
       
       
       
    }

