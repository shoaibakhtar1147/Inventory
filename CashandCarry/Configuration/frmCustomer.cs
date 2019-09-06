using CashandCarry.BL;
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
    public partial class frmCustomer : Form
    {
        public frmCustomer()
        {
            InitializeComponent();
        }

        private void frmCustomer_Load(object sender, EventArgs e)
        {
            txtCusName.Focus();
            LoadZoneID();
            LoadCusType();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void btnAddnew_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var CusType = txtCusType.ToString().Split('#')[0].Trim();
            var ZoneIDs = txtZoneID.ToString().Split('#')[0].Trim();
            string query = "insert into tbl_Customer(Name,CusTypeID,Address,Contact,Email,ZoneID) values(" + txtCusName.Text.TrimEnd() + "," + CusType + "," + txtAddress.Text.TrimEnd() + "," + txtContact.Text.TrimEnd() + "," + txtEmail.Text.TrimEnd() + "," + ZoneIDs + ");"; 
           
            DB.insert(query.TrimEnd(','));
            MessageBox.Show("Record Save Successfully");

        }

        private void LoadZoneID()
        {
          string query = "Select * from tbl_Zone";
                DataTable dt = DB.Select(query);
                //listBox2.DataSource = dt;
                foreach (DataRow dr in dt.Rows)
                {
                    txtZoneID.Items.Add(dr["ZoneID"] + "#" + dr["ZoneName"].ToString());
                }
                    txtZoneID.AutoCompleteMode = AutoCompleteMode.Suggest;
            txtZoneID.AutoCompleteSource = AutoCompleteSource.ListItems;
            txtZoneID.DisplayMember = "ZoneName";
            txtZoneID.ValueMember = "ZoneID";
            

        }


        private void LoadCusType()
        {
            string query = "select * from tbl_CustomerTypes";
            DataTable dt = DB.Select(query);
            //txtCusType.DataSource = dt;
            foreach (DataRow dr in dt.Rows)
            {
                txtCusType.Items.Add(dr["CusTypeId"] + "#" + dr["CusType"].ToString());
            }
            txtCusType.AutoCompleteMode = AutoCompleteMode.Suggest;
            txtCusType.AutoCompleteSource = AutoCompleteSource.ListItems;
            txtCusType.DisplayMember = "CusType";
            txtCusType.ValueMember = "CusTypeID";
            //txtCusType.SelectedValue = "CusType";
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
