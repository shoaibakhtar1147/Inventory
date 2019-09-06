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
    }
}
