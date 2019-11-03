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
    public partial class frmCompany : Form
    {
        public frmCompany()
        {
            InitializeComponent();
        }
        private int CompanyID = 0;

        private void label2_Click_1(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            CompanyBL objCom = new CompanyBL() 
            {
             CompanyName=txtComName.Text,
             Email=txtEmail.Text,
              Contact=txtContact.Text,
               Address=txtAddress.Text 
            };
            objCom.Save();
            MessageBox.Show("Record Saved Successfull");
            LoadData();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
             if (txtSearch.Text == string.Empty)
            {
                MessageBox.Show("Please Select A Zone ID ");
                return;
            }

             else if (MessageBox.Show("Are You Sure To Update Company?", "UpdateAlert", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
             {
                 CompanyBL objCom = new CompanyBL()
                 {
                     CompanyID = Convert.ToInt32(txtComID.Text),
                     CompanyName = txtComName.Text,
                     Email = txtEmail.Text,
                     Contact = txtContact.Text,
                     Address = txtAddress.Text
                 };
                 objCom.Update();
                 MessageBox.Show("Record Updated Successfull");
             }
            else
             {
                 MessageBox.Show("Record Not Update ");
             }
            LoadData();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if(txtSearch.Text==string.Empty)
            {
                MessageBox.Show("Please Enter ID");
            }

            CompanyBL objCom = new CompanyBL() 
            {
                CompanyID=Convert.ToInt32(txtSearch.Text)
            };
            var dt = objCom.Search();
            if(dt != null)
            {
                dgvCompany.DataSource = dt;
                btnDelete.Enabled = true;
                btnUpdate.Enabled = true;
                
            }

            else
            {
                MessageBox.Show("Record Not Found");
            }
            FormEnable();
            btnDelete.Enabled = true;
            btnUpdate.Enabled = true;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string message = "Are You Sure To Delete Company " + txtComName.Text+"?";
            if(MessageBox.Show(message,"Delete Alert",MessageBoxButtons.YesNo,MessageBoxIcon.Warning)==DialogResult.Yes)
            {
                CompanyBL objCom = new CompanyBL()
                {
                    CompanyID = int.Parse(txtSearch.Text)
                };
                objCom.Delete();

                    MessageBox.Show("Record Deleted Successfull");
                    LoadData();
                
            }
            else
            {
                MessageBox.Show("Record Not Deleted");
            }

        }

        private void FormEnable()
        {
            txtComName.Enabled = true;
            txtContact.Enabled = true;
            txtEmail.Enabled = true;
            txtAddress.Enabled = true;
            
        }
        private void FormDisable()
        {
            txtComName.Enabled = false;
            txtContact.Enabled = false;
            txtEmail.Enabled = false;
            txtAddress.Enabled = false;
            btnClear.Enabled = false;
            btnDelete.Enabled = false;
            btnSave.Enabled = false;
            btnUpdate.Enabled = false;
            
        }
        private void LoadData()
        {
            CompanyBL objCom = new CompanyBL();
            List<tbl_Company> dt = objCom.Select();
            dgvCompany.Columns.Clear();
            if(dt != null && dt.Count>0)
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
                dgvCompany.Columns.Add(edit);
                dgvCompany.Columns.Add(delete);
                dgvCompany.DataSource = dt;
                dgvCompany.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
        }

        private void frmCompany_Load(object sender, EventArgs e)
        {
            LoadData();
            FormDisable();
        }

        private void btnAddnew_Click(object sender, EventArgs e)
        {
            CompanyBL objCom = new CompanyBL(); 
            DataTable dt = objCom.Addnew();
            if(dt.Rows.Count>0)
            {
                txtComID.Text = Convert.ToString(dt.Rows[0]["CompanyID"]);
            }
            FormEnable();
            btnSave.Enabled = true;
            txtComName.Focus();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {

        }

        private void txtAddress_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvCompany_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowindex = e.RowIndex;
            int columnindex = e.ColumnIndex;
            if(columnindex ==0)
            {
                txtComID.Text = dgvCompany.Rows[rowindex].Cells[2].Value.ToString();
                txtComName.Text = dgvCompany.Rows[rowindex].Cells[3].Value.ToString();
                txtEmail.Text = dgvCompany.Rows[rowindex].Cells[4].Value.ToString();
                txtContact.Text = dgvCompany.Rows[rowindex].Cells[5].Value.ToString();
                txtAddress.Text = dgvCompany.Rows[rowindex].Cells[6].Value.ToString();
                FormEnable();
                btnSave.Enabled = false;
            }
            else if(columnindex==1)
            {
                 string message = "Are You Sure To Delete Company " + txtComName.Text+"?";
            if(MessageBox.Show(message,"Delete Alert",MessageBoxButtons.YesNo,MessageBoxIcon.Warning)==DialogResult.Yes)
            {
                CompanyBL objCom = new CompanyBL()
                {
                    CompanyID = int.Parse(txtSearch.Text)
                };
                objCom.Delete();

                    MessageBox.Show("Record Deleted Successfull");
                    LoadData();
                
            }
            }
        }
    }
}
