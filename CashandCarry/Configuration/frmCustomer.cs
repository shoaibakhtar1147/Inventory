﻿using CashandCarry.BL;
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
    public partial class frmCustomer :MetroFramework.Forms.MetroForm
    {
        public frmCustomer()
        {
            InitializeComponent();
        }

        private void frmCustomer_Load(object sender, EventArgs e)
        {
            txtCusName.Focus();
            
            LoadData();
            FormDisable();
        }

        private void FormDisable()
        {
            txtCusID.Enabled = false;
            txtCusName.Enabled = false;
            txtEmail.Enabled = false;
            txtCusType.Enabled = false;
            txtZoneID.Enabled = false;
            txtContact.Enabled = false;
            txtAddress.Enabled = false;
            btnUpdate.Enabled = false;
            btnSave.Enabled = false;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
            btnClear.Enabled = false;
        }
        private void FormEnable()
        {
            txtCusName.Enabled = true;
            txtEmail.Enabled = true;
            txtCusType.Enabled = true;
            txtZoneID.Enabled = true;
            txtContact.Enabled = true;
            txtAddress.Enabled = true;
            
            
        }

       
        private void btnAddnew_Click(object sender, EventArgs e)
        {
            CustomerBL objCus = new CustomerBL();
            DataTable dt = objCus.Addnew();
            if(dt.Rows.Count>0)
            {
                txtCusID.Text = Convert.ToString(dt.Rows[0]["CustomerID"]);
                FormEnable();
                LoadZoneID();
                LoadCusType();
                btnSave.Enabled = true;
                txtCusName.Focus();
                btnAddnew.Enabled = false;
            }
           
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string message = "Are You Sure To Delete  Customer " + txtCusName.Text+ "?";
            if (MessageBox.Show(message, "Delete Alert", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                CustomerBL objCus = new  CustomerBL()
                {
                     CustomerID = Convert.ToInt32(txtSearch.Text)
                };
                objCus.Delete();
                MessageBox.Show("Record Delete Successfull");
                LoadData();
               // Clear();
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
                     CusTypeID = Convert.ToInt32(txtCusType.SelectedValue),
                         Email=txtEmail.Text,
                     ZoneID = Convert.ToInt32(txtZoneID.SelectedValue)

                };
                objCus.Update();
                MessageBox.Show("Customer Update Successfull");



                LoadData();
               // Clear();
            }
            else
            {
                MessageBox.Show("Customer Not Update");
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtCusID.Clear();
            txtCusName.Clear();
            txtCusType.ResetText();
            txtEmail.Clear();
            txtSearch.Clear();
            txtZoneID.ResetText();
            txtAddress.Clear();
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
                MessageBox.Show("Record Saved Successfull");
                LoadData();
                btnAddnew.Enabled = true;
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
            
            ZoneBL objZone = new ZoneBL();
            var dt = objZone.Select();
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
            CusTypeBL objCus = new CusTypeBL();
            List<tbl_CustomerTypes> dt = objCus.Select();
            txtCusType.DataSource = dt;
            txtCusType.AutoCompleteMode = AutoCompleteMode.Suggest;
            txtCusType.AutoCompleteSource = AutoCompleteSource.ListItems;
            txtCusType.DisplayMember = "CusType";
            txtCusType.ValueMember = "CusTypeID";
            
        }

        

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if(txtSearch.Text==string.Empty)
            {
                MessageBox.Show("Please Enter An ID");
            }
          else
            {
                CustomerBL objCus = new CustomerBL()
                {

                    CustomerID = Convert.ToInt32(txtSearch.Text)
                };
                var dt = objCus.Search();
                if (dt != null)
                {
                    dgvCus.DataSource = dt;
                    btnDelete.Enabled = true;
                    btnUpdate.Enabled = true;
                }
            }

        }

        private void label14_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

       
        private void txtAddress_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvCus_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            int rowindex = e.RowIndex;
            int columnindex = e.ColumnIndex;
            if (columnindex == 0)
            {
                txtCusID.Text = dgvCus.Rows[rowindex].Cells[2].Value.ToString();
                txtCusName.Text = dgvCus.Rows[rowindex].Cells[3].Value.ToString();
                txtCusType.Text = dgvCus.Rows[rowindex].Cells[4].Value.ToString();
                txtAddress.Text = dgvCus.Rows[rowindex].Cells[5].Value.ToString();
                txtContact.Text = dgvCus.Rows[rowindex].Cells[6].Value.ToString();
                txtEmail.Text = dgvCus.Rows[rowindex].Cells[7].Value.ToString();
                txtZoneID.Text = dgvCus.Rows[rowindex].Cells[8].Value.ToString();

                FormEnable();
                btnSave.Enabled = false;
                btnUpdate.Enabled = true;
                btnDelete.Enabled = true;
                btnClear.Enabled = true;

            }
            else if (columnindex == 1)
            {
                string message = "Are You Sure To Delete  Zone " + txtCusName.Text + "?";
                if (MessageBox.Show(message, "Delete Alert", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    CustomerBL objCus = new CustomerBL()
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
        }
    }
}
