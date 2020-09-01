using CashandCarry.BL;
using CashandCarry.Model;
using CashandCarry.Reports;
using CashandCarry.Reports.SaleReturn;
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
    public partial class FrmSaleReturn : MetroForm
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
            txtCtn.Enabled = false;
            txtDiscount.Enabled = false;
            txtnewBalance.Enabled = false;
            txtpreBalance.Enabled = false;
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
            txtReturnCash.Enabled = false;
            txtnewBalance.Enabled = false;
            
           
        }

        private void FormEnable()
        {
            txtInvoiceID.Enabled = true;
            
            btnProdUpdate.Enabled = true;
            btnRemove.Enabled = true;
            btnAdd.Enabled = true;
            btnSearch.Enabled = true;
            btnReset.Enabled = true;
            txtReturnCash.Enabled = true;
            txtDiscount.Enabled = true;
            txtCusName.Enabled = true;
            txtProdName.Enabled = true;
            btnSave.Enabled = true;
            
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
                this.dgvProduct.Columns["Date"].Visible = false;
                this.dgvProduct.Columns["InvoiceNo"].Visible = false;
                this.dgvProduct.Columns["Balance"].Visible = false;
                this.dgvProduct.Columns["Total Balance"].Visible = false;
                this.dgvProduct.Columns["GrandTotal"].Visible = false;
                this.dgvProduct.Columns["Payment"].Visible = false;
                this.dgvProduct.Columns["Code"].Visible = false;
                this.dgvProduct.Columns["OrderBy"].Visible = false;
                this.dgvProduct.Columns["CustomerID"].Visible = false;
                this.dgvProduct.Columns["ProfitLoss"].Visible = false;
                dgvProduct.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
               
            }

        }
        //private void GetDue()
        //{
            
        //    CustomerBL objCus = new CustomerBL() 
        //    { 
        //        CustomerID=Convert.ToInt32(txtCusID.Text)  
        //    };
        //    var dt = objCus.Search();
        //    if(dt!= null &&dt.Count>0)
        //    {
        //        txtDuePay.Text = Convert.ToString(dt[0].DuePayment);
        //    }


            
        //}

        private void btnNew_Click(object sender, EventArgs e)
        {
            ReturnSaleBL obj = new ReturnSaleBL();
            DataTable dt = obj.Addnew();
            if(dt.Rows.Count>0)
            {
                txtReturnID.Text = Convert.ToString(dt.Rows[0]["RInvoice"]);
                FormEnable();
                txtInvoiceID.Focus();
                btnNew.Enabled = false ;
            }
            
        }

        private void FrmSaleReturn_Load(object sender, EventArgs e)
        {
            
            FormDisable();
            GridDesignReturn();
            GridDesignProd();
            LoadGridProd();
        }

        private void GridDesignReturn()
        {
            dgvReturnItem.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dgvReturnItem.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvReturnItem.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            dgvReturnItem.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dgvReturnItem.BackgroundColor = Color.White;

            dgvReturnItem.EnableHeadersVisualStyles = false;
            dgvReturnItem.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvReturnItem.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            dgvReturnItem.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        }

        private void GridDesignProd()
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
            if (txtQuantity.Text == string.Empty)
            {
                MessageBox.Show("Please Enter Quantity");
                txtQuantity.Focus();
                return;
            }
                if(txtQuantity.Text != string.Empty)
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
            dt.Columns.Add("InvoiceNo");
            dt.Columns.Add("ProductID");
            dt.Columns.Add("ProductName");
            dt.Columns.Add("RetailPrice");
            dt.Columns.Add("Ctn");
            dt.Columns.Add("Quantity");
            dt.Columns.Add("Discount");
            dt.Columns.Add("TotalAmount");
            dgvReturnItem.DataSource = dt;

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

                int val = Convert.ToInt32(txtAmount.Text);

                decimal val1 = Convert.ToDecimal(txtDiscount.Text);
                decimal val2 = val - val1;
                txtTotalAmount.Text = val2.ToString();
            }
              

           

        }
        private void ClearGroup()
        {
            foreach (Control c in groupBox3.Controls)
            {
                if (c is TextBox)
                {
                    c.Text = "";
                }

            }
        }
        DataTable dt = new DataTable();
        private void btnAdd_Click(object sender, EventArgs e)
        {
            
            DataRow dr = dt.NewRow();

            dr[1] = txtInvoiceID.Text;
            dr[2] = txtProdID.Text;
            dr[3] = txtProdName.Text;
            dr[4] = txtPrice.Text;
            dr[5] = txtCtn.Text;
            dr[6] = txtQuantity.Text;
            dr[7] = txtDiscount.Text;
            dr[8] = txtTotalAmount.Text;
            dt.Rows.Add(dr);
            txtReturnCash.Focus();
            SumCalculate();
           ClearGroup();
        }
        private void SumCalculate()
        {

            decimal sum = 0;
            for (int i = 0; i<dgvReturnItem.Rows.Count; ++i)
            {
                sum += Convert.ToDecimal(dgvReturnItem.Rows[i].Cells[8].Value);
            }
            txtTotalBill.Text = sum.ToString();

        }
       
        private void btnSave_Click(object sender, EventArgs e)
        {
      
        
          

            ReturnSaleBL objMas = new ReturnSaleBL()
            {
                Invoiceno = Convert.ToInt32(txtInvoiceID.Text),
                ReturnAmount = Convert.ToDecimal(txtBalance.Text),
                ReturnDate = DateTime.Parse(txtReturnDate.Text),
                TotalBill = Convert.ToDecimal(txtTotalBill.Text),
                ReturnCash = Convert.ToDecimal(txtReturnCash.Text),
                CustomerID=Convert.ToInt32(txtCusID.Text)
            };
            ReturnSaleBL objDetail = new ReturnSaleBL();
            for (int i = 0; i < dgvReturnItem.Rows.Count ; i++)
            {

                objDetail.RInvoice = Convert.ToInt32(txtReturnID.Text);
                objDetail.ProductID = Convert.ToInt32(dgvReturnItem.Rows[i].Cells[2].Value.ToString());
                objDetail.RP=Convert.ToDecimal(dgvReturnItem.Rows[i].Cells[4].Value.ToString());
                objDetail.Ctn = Convert.ToDecimal(dgvReturnItem.Rows[i].Cells[5].Value.ToString());
                objDetail.Quantity = Convert.ToInt32(dgvReturnItem.Rows[i].Cells[6].Value.ToString());
                objDetail.Discount = Convert.ToDecimal(dgvReturnItem.Rows[i].Cells[7].Value.ToString());
                objDetail.Amount = Convert.ToDecimal(dgvReturnItem.Rows[i].Cells[8].Value.ToString());
                objDetail.SaveDetail();
            }
            PurchaseInvoiceBL objPur = new PurchaseInvoiceBL();
            for (int i = 0; i < dgvReturnItem.Rows.Count; i++)
            {
                objPur.ProductID = Convert.ToInt32(dgvReturnItem.Rows[0].Cells[2].Value.ToString());
                objPur.Quantity = Convert.ToInt32(dgvReturnItem.Rows[0].Cells[6].Value.ToString());
                objPur.ProdUpdate();
            }

            PurchaseInvoiceBL objCtn = new PurchaseInvoiceBL();
            for (int i = 0; i < dgvReturnItem.Rows.Count; i++)
            {
                objCtn.ProductID = Convert.ToInt32(dgvReturnItem.Rows[0].Cells[2].Value.ToString());
                objCtn.Ctn= Convert.ToInt32(dgvReturnItem.Rows[0].Cells[5].Value.ToString());
                objCtn.CtnUpdate();
            }

            SaleLedgerBL objLedger = new SaleLedgerBL();
            objLedger.RInvoice = Convert.ToInt32(txtReturnID.Text);
            objLedger.CustomerID=Convert.ToInt32(txtCusID.Text);
            objLedger.Debit = Convert.ToDecimal(txtBalance.Text);
            objLedger.Credit = 0;
            objLedger.Date = Convert.ToDateTime(txtReturnDate.Text);
            objLedger.Balance = Convert.ToDecimal(txtnewBalance.Text);
            objLedger.Description = "Debit";
            objLedger.Save();
            (new SaleLedgerBL()).UpdateBalance(objLedger.Balance, objLedger.CustomerID);

            
            //ReturnSaleBL objDue = new ReturnSaleBL()
            //{
            //    CustomerID = Convert.ToInt32(txtCusID.Text),
            //    DuePayment = Convert.ToDecimal(txtBalance.Text)
            //};
            //objDue.UpdateDueSub();

            if(txtBalance.Text !="0.00")
            {
                SaleRecoveryBL objRec = new SaleRecoveryBL() 
                {
                 CustomerID=Convert.ToInt32(txtCusID.Text),
                  RecoveryDate=Convert.ToDateTime(txtReturnDate.Text),
                   RInvoice=Convert.ToInt32(txtReturnID.Text),
                    ReturnCash=Convert.ToDecimal(txtBalance.Text)
                };
                objRec.Save();
            }

            objMas.SaveMaster();

           SaleReturnReport objRep = new SaleReturnReport();
           rptViewer objView = new rptViewer();
           objRep.SetParameterValue("@RinvoiceNo", txtReturnID.Text);
           ReturnSaleBL obj = new ReturnSaleBL() 
           {
            RInvoice=Convert.ToInt32(txtReturnID.Text)
           }; 
           DataTable dt = obj.Select();
            if( dt.Rows.Count>0 )
            {
                objRep.SetDataSource(dt);
            }
            objView.crptViewer.ReportSource = objRep;
            objView.WindowState = FormWindowState.Normal;
            objView.ShowDialog();
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
            foreach (Control c in groupBox3.Controls)
            {
                if (c is TextBox || c is ComboBox || c is MaskedTextBox)
                {
                    c.Text = "";
                }

            }
            foreach (Control c in groupBox4.Controls)
            {
                if (c is TextBox || c is ComboBox || c is MaskedTextBox)
                {
                    c.Text = "";
                }

            }
            foreach (Control c in groupBox7.Controls)
            {
                if (c is TextBox || c is ComboBox || c is MaskedTextBox)
                {
                    c.Text = "";
                }

            }
            dgvProduct.DataSource = null;
            dgvReturnItem.DataSource = null;
            lblCtn.Text = "";
            lblPiePerCtn.Text = "";
            lblQuantity.Text = "";
        }

        private void txtReturnPay_TextChanged(object sender, EventArgs e)
        {


            if (!(string.IsNullOrEmpty(txtTotalBill.Text) || string.IsNullOrEmpty(txtReturnCash.Text)))
            {
                decimal Bill = Convert.ToDecimal(txtTotalBill.Text);
                decimal val2 = Convert.ToDecimal(txtReturnCash.Text);
                decimal val3 = Bill - val2;
                txtBalance.Text = val3.ToString();
                decimal prebal = Convert.ToDecimal(txtpreBalance.Text);
                txtnewBalance.Text = (prebal - val3).ToString();
            } 
        }

        private void dgvProduct_CellContentClick_2(object sender, DataGridViewCellEventArgs e)
        {
            
            int rowindex = e.RowIndex;
            int columnindex = e.ColumnIndex;
            if(columnindex==0)
            {
                txtCusName.Text = dgvProduct.Rows[rowindex].Cells[2].Value.ToString();
                txtProdName.Text = dgvProduct.Rows[rowindex].Cells[4].Value.ToString();
               // txtDiscount.Text = dgvProduct.Rows[rowindex].Cells[8].Value.ToString();
                lblCtn.Text = dgvProduct.Rows[rowindex].Cells[6].Value.ToString();
                lblQuantity.Text=dgvProduct.Rows[rowindex].Cells[7].Value.ToString();
                txtPrice.Text = dgvProduct.Rows[rowindex].Cells[5].Value.ToString();
               
                FormEnable();
                txtCusName.Focus();
            
 
}
        }

        private void dgvReturnItem_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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
                txtpreBalance.Text = Convert.ToString(dt[0].DuePayment);
                //GetDue();
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
                    ProductName = txtProdName.Text
                };
                List<View_tbl_Product> dt = objPro.SearchByName();
                if (dt != null && dt.Count > 0)
                {
                    txtProdID.Text = Convert.ToString(dt[0].ProductID);
                    lblPiePerCtn.Text = Convert.ToString(dt[0].PiecePerCtn);
                }
            }
            
        }

       

        private void txtBalance_Leave(object sender, EventArgs e)
        {
            if (txtBalance.Text == string.Empty)
            {
                txtReturnCash.Text = "0";
            }
            else
            {
                decimal bal = Convert.ToDecimal(txtBalance.Text);
                decimal Due = Convert.ToDecimal(txtnewBalance.Text);
                decimal result = Due - bal;
                txtnewBalance.Text = result.ToString();
            }
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void btnProdUpdate_Click(object sender, EventArgs e)
        {
            bool found = false;
            if (dgvProduct.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in dgvReturnItem.Rows)
                {

                    if (Convert.ToString(row.Cells[3].Value) == txtProdName.Text && Convert.ToString(row.Cells[4].Value) == txtPrice.Text)
                    {

                        row.Cells[5].Value = Convert.ToString(Convert.ToInt32(txtQuantity.Text));
                        row.Cells[7].Value = Convert.ToString(Convert.ToDecimal(txtTotalAmount.Text));
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

        private void btnRemove_Click(object sender, EventArgs e)
        {

        }

        private void ChkCtn_CheckedChanged(object sender, EventArgs e)
        {
            if (ChkCtn.Checked == true)
            {
                txtCtn.Enabled = true;
            }
        }

        private void ChkPiece_CheckedChanged(object sender, EventArgs e)
        {
            if (ChkPiece.Checked == true)
            {
                txtQuantity.Enabled = true;
            }
        }

        private void txtCtn_TextChanged(object sender, EventArgs e)
        {
            if (ChkCtn.Checked == true && !string.IsNullOrEmpty(txtCtn.Text))
            {

                decimal Ctn = Convert.ToDecimal(txtCtn.Text);
                int piePerCtn = Convert.ToInt32(lblPiePerCtn.Text);
                int result = Convert.ToInt32(Ctn * piePerCtn);
                txtQuantity.Text = result.ToString();
            }
        }

        private void txtQuantity_TextChanged(object sender, EventArgs e)
        {
            if (ChkPiece.Checked == true && !string.IsNullOrEmpty(txtQuantity.Text))
            {
                decimal Quan = Convert.ToDecimal(txtQuantity.Text);
                int piePerCtn = Convert.ToInt32(lblPiePerCtn.Text);
                decimal result = Convert.ToDecimal(Quan / piePerCtn);
                txtCtn.Text = result.ToString();
            }
        }

        private void txtCtn_Leave(object sender, EventArgs e)
        {
            if (ChkCtn.Checked == true)
            {
                decimal ctn = Convert.ToDecimal(txtCtn.Text);
                decimal retailPrice = Convert.ToDecimal(txtPrice.Text);
                decimal result = Convert.ToDecimal(ctn * retailPrice);
                txtAmount.Text = result.ToString();
            }
        }
    }
}
