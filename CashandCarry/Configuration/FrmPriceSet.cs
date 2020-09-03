using CashandCarry.BL;
using CashandCarry.Model;
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

namespace CashandCarry.Configuration
{
    public partial class FrmPriceSet : MetroForm
    {
        public FrmPriceSet()
        {
            InitializeComponent();
        }

        private void FrmPriceSet_Load(object sender, EventArgs e)
        {
            FormDisabled();
            LoadData();
            LoadGridDesign();
        }

        private void LoadGridDesign()
        {
            
            dgvProductPrice.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dgvProductPrice.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvProductPrice.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            dgvProductPrice.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dgvProductPrice.BackgroundColor = Color.White;

            dgvProductPrice.EnableHeadersVisualStyles = false;
            dgvProductPrice.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvProductPrice.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            dgvProductPrice.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        }
        

        private void FormDisabled()
        {
            txtProductId.Enabled = false;
            txtProductName.Enabled = false;
            txtBuyerPrice.Enabled = false;
            txtSellerPrice.Enabled = false;
            rdActive.Enabled = false;
            rdNotActive.Enabled = false;
            btnSave.Enabled = false;
            btnUpdate.Enabled = false;
        }

        private void FromEnable()
        {
            txtProductId.Enabled = true;
            txtProductName.Enabled = true;
            txtBuyerPrice.Enabled = true;
            txtSellerPrice.Enabled = true;
            rdActive.Enabled = true;
            rdNotActive.Enabled = true;
            btnSave.Enabled = true;
            btnAddnew.Enabled = false;
        }

        private void btnAddnew_Click(object sender, EventArgs e)
        {
            SetPriceBL objBL = new SetPriceBL();
            var dt = objBL.AddNew();
            if(dt.Rows.Count>0)
            {
                txtPriceId.Text = Convert.ToString(dt.Rows[0]["ProductPriceId"]);
                FromEnable();
                LoadProduct();
                txtProductName.Focus();
            }
           
            
        }

        private void LoadData()
        {
            SetPriceBL objBL = new SetPriceBL();
            var dt = objBL.selectwithSp();
            dgvProductPrice.Columns.Clear();
            if(dt != null)
            {
                DataGridViewImageColumn edit = new DataGridViewImageColumn();
                edit.Image = Properties.Resources.edit;
                edit.ImageLayout = DataGridViewImageCellLayout.Zoom;
                edit.HeaderText = "Edit";

                DataGridViewImageColumn delete = new DataGridViewImageColumn();
                delete.Image = Properties.Resources.delete;
                delete.ImageLayout = DataGridViewImageCellLayout.Zoom;
                delete.HeaderText = "Delete";
                edit.Width = delete.Width = 40;
                dgvProductPrice.Columns.Add(edit);
                dgvProductPrice.Columns.Add(delete);
                dgvProductPrice.DataSource = dt;
                dgvProductPrice.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                //dgvProductPrice.Columns["ProductPriceId"].Visible = false;
            }
        }

        private void LoadProduct()
        {
            ProductBL objPro = new ProductBL();
            List<View_tbl_Product> dt = objPro.Select();
            txtProductName.DataSource = dt;
            txtProductName.AutoCompleteMode = AutoCompleteMode.Suggest;
            txtProductName.AutoCompleteSource = AutoCompleteSource.ListItems;
            txtProductName.DisplayMember = "ProductName";
            txtProductName.ValueMember = "ProductID";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try {
                
            if(FormValidate()==true)
            {
                bool status = rdActive.Checked ? true : false;
                SetPriceBL objBL = new SetPriceBL() 
                {
                 BuyerPrice=Convert.ToDecimal(txtBuyerPrice.Text),
                 SellerPrice=Convert.ToDecimal(txtSellerPrice.Text),
                 ProductID=Convert.ToInt32(txtProductName.SelectedValue),
                 IsActive=status,
                 AddedDate=Convert.ToDateTime(DateTime.Now.ToShortDateString())
                };
                objBL.Save();
                MessageBox.Show("Price Saved Successfull");
                ClearGroup();
                LoadData();
                btnAddnew.Enabled = true;
            }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void ClearGroup()
        {
            foreach (Control c in groupBox1.Controls)
            {
                if (c is TextBox || c is ComboBox || c is MaskedTextBox)
                {
                    c.Text = "";
                }
                rdActive.Checked = false;
                rdNotActive.Checked = false;

            }
        }

        private bool FormValidate()
        {
            if (txtBuyerPrice.Text == "" || txtProductName.Text == "" || txtSellerPrice.Text == "" )
            {
                return false;
            }
            {
                return true;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try {
                bool Status=rdActive.Checked ? true : false;
                SetPriceBL obj = new SetPriceBL() 
                {
                    ProductPriceId=Convert.ToInt32(txtPriceId.Text),
                IsActive=Status,
                SellerPrice=Convert.ToDecimal(txtSellerPrice.Text),
                BuyerPrice=Convert.ToDecimal(txtBuyerPrice.Text)
                };
                obj.Update();
                MessageBox.Show("Update Successfull");
                LoadData();
                ClearGroup();
                
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());

            }
        }

        private void dgvProductPrice_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowindex = e.RowIndex;
            int columnindex = e.ColumnIndex;
            if(columnindex ==0)
            {
                txtPriceId.Text = dgvProductPrice.Rows[rowindex].Cells[2].Value.ToString();
                txtProductId.Text = dgvProductPrice.Rows[rowindex].Cells[3].Value.ToString();
                txtProductName.Text = dgvProductPrice.Rows[rowindex].Cells[4].Value.ToString();
                txtBuyerPrice.Text =  dgvProductPrice.Rows[rowindex].Cells[5].Value.ToString();
                 txtSellerPrice.Text= dgvProductPrice.Rows[rowindex].Cells[6].Value.ToString();
                 string Status =   dgvProductPrice.Rows[rowindex].Cells[8].Value.ToString();
                if(Status=="Active")
                {
                    rdActive.Checked = true;
                }
                else if(Status=="Not Active")
                {
                    rdNotActive.Checked = true;
                }
                
                FromEnable();
                btnUpdate.Enabled = true;
            }

            else if(columnindex ==1)
            {
                string message = "Are You Sure To Delete Price of " + dgvProductPrice.Rows[rowindex].Cells[4].Value.ToString() + "?";
                if (MessageBox.Show(message, "Delete Alert", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    SetPriceBL objCus = new SetPriceBL()
                    {
                        ProductPriceId = Convert.ToInt32(dgvProductPrice.Rows[rowindex].Cells[2].Value.ToString())
                    };
                    objCus.Delete();
                    MessageBox.Show("Record Delete Successfull");
                    LoadData();

                }
                else
                {
                    MessageBox.Show("No Record Deleted");
                }
            }
        }

        private void txtProductName_Leave(object sender, EventArgs e)
        {
            ProductBL objPro = new ProductBL()
            {
                ProductID = Convert.ToInt32(txtProductName.SelectedValue)
            };
            List<View_tbl_Product> dt = objPro.Search();
            if (dt != null)
            {
                txtProductId.Text = Convert.ToString(dt[0].ProductID);
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (txtSearch.Text == string.Empty)
            {
                LoadData();

            }
            else
            {
                SetPriceBL obj = new SetPriceBL()
                {
                     Productname= txtSearch.Text.ToLower()
                };
                var dt = obj.Search();
                AutoCompleteStringCollection coll = new AutoCompleteStringCollection();
                txtSearch.AutoCompleteMode = AutoCompleteMode.Suggest;
                txtSearch.AutoCompleteSource = AutoCompleteSource.CustomSource;
                txtSearch.AutoCompleteCustomSource = coll;
                if (dt.Count > 0)
                {
                    dgvProductPrice.DataSource = dt;
                }
            }
        }

       

    }
}
