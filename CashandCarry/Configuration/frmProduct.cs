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
            LoadCategory();
            LoadCompany();
            LoadData();

        }
        private void LoadCategory()
        {
            string query = "Select * from tbl_Category";
            DataTable dt = DB.Select(query);
            txtProdCate.DataSource = dt;

            txtProdCate.DisplayMember = "CategoryName";
            txtProdCate.ValueMember = "CategoryID";
        }
        private void LoadCompany()
        {
            string query = "Select * from tbl_Company";
            DataTable dt = DB.Select(query);
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
            btnSave.Enabled = true;

        }

        private void btnAddnew_Click(object sender, EventArgs e)
        {
            
            FormEnable();
            txtProdName.Focus();
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
                        Unit=txtUnit.Text
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
            tbl_Product dt = objPro.Search();
            if(dt != null)
            {
                btnUpdate.Enabled = true;
                btnDelete.Enabled = true;
            }
        }
    }
}
