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
    public partial class frmEmployeeRegistration : Form
    {
        public frmEmployeeRegistration()
        {
            InitializeComponent();
        }
        

        private void frmEmployeeRegistration_Load(object sender, EventArgs e)
        {
            FormDisable();
            LoadData();
        }

        private void FormEnable()
        {
            txtFname.Enabled = true;
            txtname.Enabled = true;
            txtPassword.Enabled = true;
            txtQual.Enabled = true;
            txtUsername.Enabled = true;
            txtDOB.Enabled = true;
            txtDesig.Enabled = true;
            rdfemale.Enabled = true;
            rdmale.Enabled = true;
            txtCnic.Enabled = true;
            txtAddress.Enabled = true;
            txtContact.Enabled = true;
            btnUpdate.Enabled = true;
            btnClear.Enabled = true;
        }
        private void FormDisable()
        {

            txtFname.Enabled = false;
            txtname.Enabled = false;
            txtPassword.Enabled = false;
            txtQual.Enabled = false;
            txtUsername.Enabled = false;
            txtDOB.Enabled = false;
            txtDesig.Enabled = false;
            rdfemale.Enabled = false;
            rdmale.Enabled = false;
            txtCnic.Enabled = false;
            txtAddress.Enabled = false;
            txtContact.Enabled = false;
            btnSave.Enabled = false;
            btnDelete.Enabled = false;
            btnClear.Enabled = false;
            btnUpdate.Enabled = false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            bool Gender = rdmale.Checked ? true : false;
            EmployeeBL objBL = new EmployeeBL()
            {
                Name = txtname.Text,
                Fname = txtFname.Text,
                Username = txtUsername.Text,
                Password = txtPassword.Text,
                Qualifiction = txtQual.Text,
                Cnic = txtCnic.Text,
                Address = txtAddress.Text,
                Contact = txtContact.Text,
                Designation = txtDesig.Text,
                DOB = txtDOB.Text,
                Gender = Gender
            };
           int rowaffected= objBL.Save();
            if(rowaffected>0)
            {
                MessageBox.Show("Record Saved successfull");
            }
            else
            {
                MessageBox.Show("Record Not Saved");
            }
        
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if(txtSearch.Text==string.Empty)
            {
                MessageBox.Show("Please Select An Employee For Update");
                return;
            }
            else if(MessageBox.Show("Are You Sure To Update Employee Record?","Update Alert",MessageBoxButtons.YesNo,MessageBoxIcon.Information)==DialogResult.Yes)
            {
                bool gender=rdmale.Checked? true:false;
                EmployeeBL objEmp = new EmployeeBL() 
            {
             EmployeeID=Convert.ToInt32(txtEmpId.Text),
              Name=txtname.Text,
               Fname=txtFname.Text,
               Username=txtUsername.Text,
                Password=txtPassword.Text,
                  Qualifiction=txtQual.Text,
                   DOB=txtDOB.Text,
                    Address=txtAddress.Text,
                     Cnic=txtCnic.Text,
                      Contact=txtContact.Text,
                       Designation=txtDesig.Text,
                        Gender=gender
            };
                int rowaffected=objEmp.Update();
                if(rowaffected>0)
                {
                    MessageBox.Show("Employee Record Updated");
                }
                else
                {
                    MessageBox.Show("Employee Record Not Updated");
                }
              
                LoadData();
                
            }
            
        }



        private void btnAddnew_Click(object sender, EventArgs e)
        {

            EmployeeBL objEmp = new EmployeeBL();

            DataTable dt = objEmp.Addnew();
            if (dt.Rows.Count > 0)
            {
                txtEmpId.Text = Convert.ToString(dt.Rows[0]["EmployeeID"]);
                FormEnable();
                btnSave.Enabled = true;
                   txtname.Focus();
              
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string message = "Are you sure to Delete Employee" + txtname.Text + "?";

            if (MessageBox.Show(message, "Delete Alert", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                EmployeeBL objEmp = new EmployeeBL()
            {
                EmployeeID = Convert.ToInt32(txtSearch.Text)
            };
                int rowaffected = objEmp.Delete();
                if (rowaffected > 0)
                {
                    MessageBox.Show("Record Deleted Successfull");
                }

            }
            else
            {
                MessageBox.Show("Record Deleted Not Successfull");
            }
            LoadData();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtSearch.Text==string.Empty)
            {
                MessageBox.Show("Please Enter An ID");
            }
            EmployeeBL objEmp = new EmployeeBL()
            {
                 EmployeeID =Convert.ToInt32(txtSearch.Text)
            };
            DataTable dt = objEmp.Search();
            if (dt.Rows.Count > 0)
            {
                txtEmpId.Text = Convert.ToString(dt.Rows[0]["EmployeeID"]);
                txtname.Text = Convert.ToString(dt.Rows[0]["Name"]);
                txtFname.Text = Convert.ToString(dt.Rows[0]["Fname"]);
                txtQual.Text = Convert.ToString(dt.Rows[0]["Qualifiction"]);
                txtPassword.Text = Convert.ToString(dt.Rows[0]["Password"]);
                txtDOB.Text = Convert.ToString(dt.Rows[0]["DOB"]);
                txtDesig.Text = Convert.ToString(dt.Rows[0]["Designation"]);
                txtUsername.Text = Convert.ToString(dt.Rows[0]["Username"]);
                txtCnic.Text = Convert.ToString(dt.Rows[0]["Cnic"]);
                txtContact.Text = Convert.ToString(dt.Rows[0]["Contact"]);
                txtAddress.Text = Convert.ToString(dt.Rows[0]["Address"]);
                string gender = Convert.ToString(dt.Rows[0]["Gender"]);
                if (gender == "Male")
                {
                    rdmale.Checked = true;
                }
                else
                {
                    rdfemale.Checked = true;
                }
                FormEnable();
                btnUpdate.Enabled = true;
                btnDelete.Enabled = true;
                
            }
            else
            {
                MessageBox.Show("Record Not Found");
            }
        }

        private void LoadData()
        {
            EmployeeBL objEmp = new EmployeeBL();
            DataTable dt = objEmp.Select();
            dgvEmp.Columns.Clear();
            if(dt != null && dt.Rows.Count>0)
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
                dgvEmp.Columns.Add(edit);
                dgvEmp.Columns.Add(delete);
                dgvEmp.DataSource = dt;
                dgvEmp.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
        }
        private void dgvEmp_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            int rowindex = e.RowIndex;
            int columnindex = e.ColumnIndex;
            if (columnindex == 0)
            {
                 int i = 2;
                txtEmpId.Text = dgvEmp.Rows[rowindex].Cells[i++].Value.ToString();
                txtname.Text = dgvEmp.Rows[rowindex].Cells[i++].Value.ToString();
                txtFname.Text = dgvEmp.Rows[rowindex].Cells[i++].Value.ToString();
                txtUsername.Text = dgvEmp.Rows[rowindex].Cells[i++].Value.ToString();
                txtPassword.Text = dgvEmp.Rows[rowindex].Cells[i++].Value.ToString();
                txtQual.Text = dgvEmp.Rows[rowindex].Cells[i++].Value.ToString();
                txtDOB.Text = dgvEmp.Rows[rowindex].Cells[i++].Value.ToString();
                txtCnic.Text = dgvEmp.Rows[rowindex].Cells[i++].Value.ToString();
                txtContact.Text = dgvEmp.Rows[rowindex].Cells[i++].Value.ToString();
                txtDesig.Text = dgvEmp.Rows[rowindex].Cells[i++].Value.ToString();
                string gender = dgvEmp.Rows[rowindex].Cells[i++].Value.ToString();
                if (gender == "Male")
                {
                    rdmale.Checked = true;
                }
                else
                {
                    rdfemale.Checked = true;
                }
                txtAddress.Text = dgvEmp.Rows[rowindex].Cells[i++].Value.ToString();
                FormEnable();
                btnUpdate.Enabled = true;
            }
            else if (columnindex == 1)
            {
                EmployeeBL objEmployee = new EmployeeBL()
                {
                    EmployeeID = Convert.ToInt32(dgvEmp.Rows[rowindex].Cells[2].Value)
                };
                int rowaffected = objEmployee.Delete();
                if (rowaffected > 0)
                {
                    MessageBox.Show("Deleted Successfully");
                      
                }

            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        

        
    }
}
