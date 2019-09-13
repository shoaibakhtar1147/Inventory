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
            LoadData();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void btnAddnew_Click(object sender, EventArgs e)
        {
            txtCusName.Focus();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string message = "Are You Sure To Delete  Zone " + txtCusName.Text+ "?";
            if (MessageBox.Show(message, "Delete Alert", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                CustomerBL objCus = new  CustomerBL()
                {
                     CustomerID = Convert.ToInt32(txtSearch.Text)
                };
                objCus.Delete();
                MessageBox.Show("Record Delete Successfull");
                LoadData();
                Clear();
            }
            else
            {
                MessageBox.Show("No Record Deleted");
            }
        }

        private void Clear()
        {
            throw new NotImplementedException();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtSearch.Text == string.Empty)
            {
                MessageBox.Show("Please Select A Customer ID ");
                return;
            }

            else if (MessageBox.Show("Are You Sure To Update Customer?", "UpdateAlert", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                CustomerBL objCus = new CustomerBL()
                {
                     CustomerID = Convert.ToInt32(txtCusID.Text),
                     Name =txtCusName.Text,
                      Address=txtAddress.Text,
                       Contact=txtContact.Text,
                        CusTypeID=Convert.ToInt32(txtCusType.Text),
                         Email=txtEmail.Text,
                          ZoneID=Convert.ToInt32(txtZoneID.Text)

                };
                objCus.Update();
                MessageBox.Show("Customer Update Successfull");



                LoadData();
                Clear();
            }
            else
            {
                MessageBox.Show("Customer Not Update");
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(FormValidate()==true)
            {
                CustomerBL objcus = new CustomerBL()
                {
                    Name = txtCusName.Text,
                    Email = txtEmail.Text,
                    Address = txtAddress.Text,
                    Contact = txtContact.Text,
                    CusTypeID =Convert.ToInt32(txtCusType.SelectedValue),
                    ZoneID = Convert.ToInt32(txtZoneID.SelectedValue)
                };
                objcus.Save();
                MessageBox.Show("record saved successfull");
                LoadData();
               
            }
            else
            {
                MessageBox.Show("Some Error Occur No Record Save");
            }
        }
        private bool FormValidate()
        {
            if (txtCusName.Text==""||txtCusType.Text==""||txtEmail.Text==""||txtContact.MaskCompleted==false||txtAddress.Text==""||txtZoneID.Text=="") return false;
            return true;
        }
        private void LoadZoneID()
        {
            string query = "Select * from tbl_Zone";
            DataTable dt = DB.Select(query);
            txtZoneID.DataSource = dt;        
            txtZoneID.AutoCompleteMode = AutoCompleteMode.Suggest;
            txtZoneID.AutoCompleteSource = AutoCompleteSource.ListItems;
            txtZoneID.DisplayMember = "ZoneName";
            txtZoneID.ValueMember = "ZoneID";
            

        }

        private void LoadData()
        {
            CustomerBL objCus = new CustomerBL();
            List<View_tbl_Customer> dt = objCus.Select();
            dgvCus.Columns.Clear();
            if (dt != null && dt.Count > 0)
            {
                DataGridViewImageColumn edit = new DataGridViewImageColumn();
                edit.Image = Properties.Resources.edit;
                edit.ImageLayout = DataGridViewImageCellLayout.Zoom;
                edit.HeaderText = "Edit";
                DataGridViewImageColumn delete = new DataGridViewImageColumn();
                delete.Image = Properties.Resources.delete;
                delete.ImageLayout = DataGridViewImageCellLayout.Zoom;
                delete.HeaderText = "Delete";
                edit.Width = delete.Width = 20;
                dgvCus.Columns.Add(edit);
                dgvCus.Columns.Add(delete);
                dgvCus.DataSource = dt;
                dgvCus.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }

         }

        private void LoadCusType()
        {
            string query = "select * from tbl_CustomerTypes";
            DataTable dt = DB.Select(query);
            txtCusType.DataSource = dt;
           
            txtCusType.AutoCompleteMode = AutoCompleteMode.Suggest;
            txtCusType.AutoCompleteSource = AutoCompleteSource.ListItems;
            txtCusType.DisplayMember = "CusType";
            txtCusType.ValueMember = "CusTypeID";
            
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
