using CashandCarry.BL;
using CashandCarry.Employee;
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
    public partial class frmEmployeeRegistration :MetroForm
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
            
            txtQual.Enabled = true;
            
            txtDOB.Enabled = true;
            txtDesig.Enabled = true;
            rdfemale.Enabled = true;
            rdmale.Enabled = true;
            txtCnic.Enabled = true;
            txtAddress.Enabled = true;
            txtContact.Enabled = true;
            btnUpdate.Enabled = true;
            btnClear.Enabled = true;
            txtAssignID.Enabled = true ;
            txtSalary.Enabled = true;
            txtAsignDate.Enabled = true;
        }
        private void FormDisable()
        {
            txtSalary.Enabled = false;
            txtAsignDate.Enabled = false;
            txtFname.Enabled = false;
            txtname.Enabled = false;
            txtQual.Enabled = false;
            lblLoginType.Hide();
            lblPassword.Hide();
            lblUsername.Hide();
            txtUsername.Hide();
            txtPassword.Hide();
            txtLoginType.Hide();
            txtAssignID.Enabled = false;
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
            if(FormValidate() == true)
            {
             if(txtAssignID.Checked==false)
             {
                 bool Gender = rdmale.Checked ? true : false;
                 EmployeeBL objBL = new EmployeeBL()
                 {


                     Name = txtname.Text,
                     Fname = txtFname.Text,
                     Qualifiction = txtQual.Text,
                     Cnic = txtCnic.Text,
                     Address = txtAddress.Text,
                     Contact = txtContact.Text,
                     Designation = txtDesig.Text,
                     DOB = txtDOB.Text,
                     Gender = Gender,
                     AsignDate = Convert.ToDateTime(txtAsignDate.Text),
                     Salary = Convert.ToDecimal(txtSalary.Text),
                     
                 };
                 objBL.Save();


                 
             }
              else if(txtAssignID.Checked== true)
             {
                 bool Gender = rdmale.Checked ? true : false;
                 EmployeeBL objBL = new EmployeeBL()
                 {

                     Name = txtname.Text,
                     Fname = txtFname.Text,
                     Qualifiction = txtQual.Text,
                     Cnic = txtCnic.Text,
                     Address = txtAddress.Text,
                     Contact = txtContact.Text,
                     Designation = txtDesig.Text,
                     DOB = txtDOB.Text,
                     Gender = Gender,
                     AsignDate = Convert.ToDateTime(txtAsignDate.Text),
                     Salary = Convert.ToDecimal(txtSalary.Text),
                     Password = txtPassword.Text,
                     Username = txtUsername.Text,
                     LoginType = Convert.ToInt32(txtLoginType.SelectedValue),
                 };
                 objBL.Save();
             }
                 MessageBox.Show("Record Saved successfull");
                 LoadData();
                 btnAddnew.Enabled = true;
             
            }
            else
            {
                MessageBox.Show("Record Not Saved");
            }
        
        }
        private bool FormValidate()
        {
            if (txtname.Text == "" || txtFname.Text == "" || txtQual.Text == "" || txtDOB.Text == "" || txtAddress.Text == "" || txtDesig.Text == "" || txtCnic.MaskCompleted == false || txtContact.MaskCompleted == false)
            {
                return false;
            }
            { 
                return true; 
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
                  Qualifiction=txtQual.Text,
                   DOB=txtDOB.Text,
                    Address=txtAddress.Text,
                     Cnic=txtCnic.Text,
                      Contact=txtContact.Text,
                       Designation=txtDesig.Text,
                        Gender=gender,
                        AsignDate=Convert.ToDateTime( txtAsignDate.Text),
                        Salary=Convert.ToDecimal(txtSalary.Text)

            };
                objEmp.Update();
               MessageBox.Show("Employee Record Updated");
                LoadData();
                
            }
            else
            {
                MessageBox.Show("Employee Record Not Updated");
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
                   btnAddnew.Enabled = false;
                  
              
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
                objEmp.Delete();
                    MessageBox.Show("Record Deleted Successfull");
               

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
            else if(!string.IsNullOrEmpty(txtSearch.Text))
            {
                EmployeeBL objEmp = new EmployeeBL()
                {
                    EmployeeID = Convert.ToInt32(txtSearch.Text)
                };
                var dt = objEmp.Search();
                if (dt != null)
                {
                    dgvEmp.DataSource = dt;
                    btnDelete.Enabled = true;


                }
            }
            else
            {
                MessageBox.Show("Record Not Found");
            }
        }

        private void LoadData()
        {
            EmployeeBL objEmp = new EmployeeBL();
            var dt = objEmp.Select();
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
            else
            {
                MessageBox.Show("No Record Found");
            }
        }
        

        private void btnClear_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        
        private void dgvEmp_CellContentClick_2(object sender, DataGridViewCellEventArgs e)
        {
            int rowindex = e.RowIndex;
            int columnindex = e.ColumnIndex;

            if (columnindex == 0)
            {
                txtAssignID.Checked = false;
                txtEmpId.Text = dgvEmp.Rows[rowindex].Cells[2].Value.ToString();
                txtname.Text = dgvEmp.Rows[rowindex].Cells[3].Value.ToString();
                txtFname.Text = dgvEmp.Rows[rowindex].Cells[4].Value.ToString();
                txtQual.Text = dgvEmp.Rows[rowindex].Cells[7].Value.ToString();
                txtDOB.Text = dgvEmp.Rows[rowindex].Cells[8].Value.ToString();
                txtCnic.Text = dgvEmp.Rows[rowindex].Cells[9].Value.ToString();
                txtContact.Text = dgvEmp.Rows[rowindex].Cells[10].Value.ToString();
                txtDesig.Text = dgvEmp.Rows[rowindex].Cells[11].Value.ToString();
                txtAddress.Text = dgvEmp.Rows[rowindex].Cells[12].Value.ToString();
                txtSalary.Text = dgvEmp.Rows[rowindex].Cells[13].Value.ToString();
                txtAsignDate.Text = dgvEmp.Rows[rowindex].Cells[14].Value.ToString();
                if (!string.IsNullOrEmpty(dgvEmp.Rows[rowindex].Cells[15].Value.ToString()) && !string.IsNullOrEmpty(dgvEmp.Rows[rowindex].Cells[6].Value.ToString()))
                {
                    txtAssignID.Checked = true;
                 txtPassword.Text = dgvEmp.Rows[rowindex].Cells[6].Value.ToString();
                 txtUsername.Text = dgvEmp.Rows[rowindex].Cells[5].Value.ToString();
                 txtLoginType.SelectedItem = dgvEmp.Rows[rowindex].Cells[15].Value.ToString();
            }
                
                string gender = dgvEmp.Rows[rowindex].Cells[16].Value.ToString();
                if (gender == "Male")
                {
                    rdmale.Checked = true;
                }
                if(gender =="Female")
                {
                    rdfemale.Checked = true;
                }
               
                
                
                FormEnable();
                btnDelete.Enabled = true;
            }
            else if (columnindex == 1)
            {
                string message = "Are you sure to Delete Employee" + txtname.Text + "?";

                if (MessageBox.Show(message, "Delete Alert", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    EmployeeBL objEmp = new EmployeeBL()
                    {
                        EmployeeID = Convert.ToInt32(txtSearch.Text)
                    };
                    objEmp.Delete();
                    MessageBox.Show("Record Deleted Successfull");


                }
                else
                {
                    MessageBox.Show("Record Deleted Not Successfull");
                }
                LoadData();
            }

        }


        private void txtAssignID_CheckedChanged(object sender, EventArgs e)
        {
         if(txtAssignID.Checked==true)
         {
             lblLoginType.Visible = true;
             lblPassword.Visible = true;
             lblUsername.Visible = true;
             txtUsername.Visible = true;
             txtPassword.Visible = true;
             txtLoginType.Visible = true;
            LoadLoginType();
         }
            else if(txtAssignID.Checked==false)
         {
             lblLoginType.Hide();
             lblPassword.Hide();
             lblUsername.Hide();
             txtUsername.Hide();
             txtPassword.Hide();
             txtLoginType.Hide();
         }
        }
        private void LoadLoginType()
        {
            EmployeeBL objEmp = new EmployeeBL();
            var dt = objEmp.SelectLogin();
            txtLoginType.DataSource = dt;
            txtLoginType.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txtLoginType.AutoCompleteSource = AutoCompleteSource.ListItems;
            txtLoginType.DisplayMember = "LoginType";
            txtLoginType.ValueMember = "LoginTypeID";
        }
        

        
    }
}
