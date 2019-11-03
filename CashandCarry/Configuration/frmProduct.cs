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

namespace CashandCarry.Configuration
{
    public partial class frmProduct : Form
    {
        public frmProduct()
        {
            InitializeComponent();
        }
       
        private void label7_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void frmProduct_Load(object sender, EventArgs e)
        {
            FormDisable();
           
            LoadData();

        }
        private void LoadCategory()
        {
            //string query = "Select * from tbl_Category";
            //DataTable dt = DB.Select(query);
            CategoryBL objcate = new CategoryBL();
            var dt = objcate.Select();
            txtProdCate.DataSource = dt;
            txtProdCate.DisplayMember = "CategoryName";
            txtProdCate.ValueMember = "CategoryID";
        }
        private void LoadCompany()
        {
            //string query = "Select * from tbl_Company";
            //DataTable dt = DB.Select(query);
            CompanyBL objcom = new CompanyBL();
            var dt = objcom.Select();
            txtComName.DataSource = dt;
            txtComName.DisplayMember = "CompanyName";
            txtComName.ValueMember = "CompanyID";
        }

        public void FormDisable()
        {
            txtComName.Enabled = false;
            txtPP.Enabled = false;
            txtProdCate.Enabled = false;
            txtProdName.Enabled = false;
            txtRP.Enabled = false;
            txtWeight.Enabled = false;
            btnSave.Enabled = false;
            btnUpdate.Enabled = false;
            btnUpdate.Enabled = false;
            btnClear.Enabled = false;
            btnDelete.Enabled = false;
          
           
        }
        public void FormEnable()
        {
            txtComName.Enabled = true;
            txtPP.Enabled = true;
            txtProdCate.Enabled = true;
            txtProdName.Enabled = true;
            txtRP.Enabled = true;
            txtWeight.Enabled = true;
          
        }

        private void btnAddnew_Click(object sender, EventArgs e)
        {
            ProductBL obPro = new ProductBL();
            DataTable dt = obPro.Addnew();
            if(dt.Rows.Count>0)
            {
                txtProductID.Text = Convert.ToString(dt.Rows[0]["ProductID"]);
                btnSave.Enabled = true;
                FormEnable();
                txtProdName.Focus();
                LoadCategory();
                LoadCompany();
            }
           
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(FormValidate()==true)
            {
                ProductBL objPro = new ProductBL() 
                {
                 ProductName=txtProdName.Text,
                  TradePrice=Convert.ToDecimal(txtPP.Text),
                   RetailPrice=Convert.ToDecimal(txtRP.Text),
                    weight=txtWeight.Text,
                      CategoryID=Convert.ToInt32(txtProdCate.SelectedValue),
                       CompanyID=Convert.ToInt32(txtComName.SelectedValue),
                        
                };
                objPro.Save();
                MessageBox.Show("Product Saved Successfull");
                LoadData();
            }
            else
            {
                MessageBox.Show("Some Fields Are Missing Or Error Occur");
            }
        }

        private void LoadData()
        {
            ProductBL objPro = new ProductBL();
            List<View_tbl_Product> dt = objPro.Select();
            dgvProduct.Columns.Clear();
            if(dt!= null&& dt.Count>0)
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
                dgvProduct.Columns.Add(edit);
                dgvProduct.Columns.Add(delete);
                dgvProduct.DataSource = dt;
                dgvProduct.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
        }
        private bool FormValidate()
        {
            if (txtProdName.Text == "" || txtRP.Text == "" || txtWeight.Text == "" || txtProdCate.Text == "" || txtComName.Text == "" || txtPP.Text == "") return false;
            return true;
        }

        private void dgvProduct_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int columnindex = e.ColumnIndex;
            int rowindex = e.RowIndex;
            if(columnindex==0)
            {
                txtProductID.Text = dgvProduct.Rows[rowindex].Cells[2].Value.ToString();
                txtProdName.Text = dgvProduct.Rows[rowindex].Cells[3].Value.ToString();
                txtProdCate.Text = dgvProduct.Rows[rowindex].Cells[4].Value.ToString();
                txtComName.Text = dgvProduct.Rows[rowindex].Cells[5].Value.ToString();
               
                txtWeight.Text = dgvProduct.Rows[rowindex].Cells[6].Value.ToString();
                txtRP.Text = dgvProduct.Rows[rowindex].Cells[7].Value.ToString();
                txtPP.Text = dgvProduct.Rows[rowindex].Cells[8].Value.ToString();
                FormEnable();
            }
            else if(columnindex==1)
            {
                ProductBL objPro = new ProductBL() 
                {
                 ProductID=Convert.ToInt32(dgvProduct.Rows[rowindex].Cells[2].Value)

                };
                objPro.Delete();
                MessageBox.Show("Record Delete Successfull");
                LoadData();
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if(txtSearch.Text==string.Empty)
            {
                MessageBox.Show("Please Enter An Id");
            }
            ProductBL objPro = new ProductBL() 
            {
            ProductID=Convert.ToInt32(txtSearch.Text)
            };
            var dt = objPro.Search();
            if(dt != null)
            {
                dgvProduct.DataSource = dt;
                btnUpdate.Enabled = true;
                btnDelete.Enabled = true;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if(txtSearch.Text==string.Empty)
            {
                MessageBox.Show("Please Select A Product ID ");
            }
            else if (MessageBox.Show("Are You Sure To Update Product?", "UpdateAlert", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                ProductBL objPro = new ProductBL()
                {
                    ProductID=Convert.ToInt32(txtProductID.Text),
                    ProductName = txtProdName.Text,
                    TradePrice = Convert.ToDecimal(txtPP.Text),
                    RetailPrice = Convert.ToDecimal(txtRP.Text),
                    weight = txtWeight.Text,
                    CategoryID = Convert.ToInt32(txtProdCate.SelectedValue),
                    CompanyID = Convert.ToInt32(txtComName.SelectedValue),
                   
                };
                objPro.Update();
                MessageBox.Show("Product Update Successfull");
                LoadData();
            }
            else
            {
                MessageBox.Show("Product Not Update");
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string message = "Are You Sure To Delete  Product " + txtProdName.Text + "?";
            if (MessageBox.Show(message, "Delete Alert", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                ProductBL objPro=new ProductBL()
                {
                     ProductID = Convert.ToInt32(txtSearch.Text)
                };
                objPro.Delete();
                MessageBox.Show("Record Delete Successfull");
                LoadData();
                
            }
        }
      
    }
}
