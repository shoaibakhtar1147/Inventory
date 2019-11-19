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

namespace CashandCarry.Employee
{
    public partial class FrmEmployeeSalary : MetroForm
    {
        public FrmEmployeeSalary()
        {
            InitializeComponent();
        }

        private void FrmEmployeeSalary_Load(object sender, EventArgs e)
        {
            lblResignDate.Hide();
            txtResignDate.Hide();
            FormDisable();
            LoadData();
        }

        private void txtResign_CheckedChanged(object sender, EventArgs e)
        {
            if(txtResign.Checked==true)
            {
                lblResignDate.Visible=true;
                txtResignDate.Visible=true;
            }
            else if(txtResign.Checked==false)
            {

                lblResignDate.Hide();
                txtResignDate.Hide();
            }
        }

      private void FormEnable()
        {
            btnSave.Enabled = true;
            txtSalary.Enabled = true;
            txtResign.Enabled = true;
            btnSearch.Enabled = true;
            txtSearch.Enabled = true;
            btnClear.Enabled = true;
        }
        private void FormDisable()
      {
        
          btnSave.Enabled = false;
          btnClear.Enabled = false;
          txtEmpId.Enabled = false;
          txtname.Enabled = false;
          txtResign.Enabled = false;
          txtSalary.Enabled = false;
          btnSearch.Enabled = false;
          txtSearch.Enabled = false;
          txtSalaryDate.Enabled = false;
      }

        private void btnAddnew_Click(object sender, EventArgs e)
        {
            EmpSalaryBL obj = new EmpSalaryBL();
            DataTable dt = obj.Addnew();
            if(dt.Rows.Count>0)
            {
                txtSalaryID.Text = Convert.ToString(dt.Rows[0]["SalaryID"]);
              
                FormEnable();
                txtSearch.Focus();
            }
           
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtSearch.Text == string.Empty)
            {
                MessageBox.Show("Please Enter An ID");
            }
            
            else if(!string.IsNullOrEmpty(txtSearch.Text))
            {
                EmployeeBL objEmp = new EmployeeBL() 
                {
                EmployeeID=Convert.ToInt32(txtSearch.Text)
                };
                
                var dt = objEmp.Search();
                if (dt.Count > 0)
                {
                    dgvEmpSalary.DataSource = dt;
                    
                }
            }
            else
            {
                MessageBox.Show("Invalid Employee ID");
            }
           

            }
        private void LoadData()
        {
            EmployeeBL objEmp = new EmployeeBL();
            var dt = objEmp.Select();
            dgvEmpSalary.Columns.Clear();
            if (dt != null && dt.Count > 0)
            {
                DataGridViewImageColumn edit = new DataGridViewImageColumn();
                edit.Image = Properties.Resources.edit;
                edit.ImageLayout = DataGridViewImageCellLayout.Zoom;
                edit.HeaderText = "Edit";
                edit.Width  = 40;
                dgvEmpSalary.Columns.Add(edit);
                dgvEmpSalary.DataSource = dt;
                dgvEmpSalary.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            else
            {
                MessageBox.Show("No Record Found");
            }
        }
        private void dgvEmpSalary_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int columnindex = e.ColumnIndex;
            int rowindex = e.RowIndex;
            if(columnindex==0)
            {
                txtEmpId.Text =dgvEmpSalary.Rows[rowindex].Cells[1].Value.ToString();
                txtname.Text = dgvEmpSalary.Rows[rowindex].Cells[2].Value.ToString();
                txtSalary.Text = dgvEmpSalary.Rows[rowindex].Cells[13].Value.ToString();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
             EmpSalaryBL objEMp = new EmpSalaryBL(); 
            if(txtResign.Checked==false)
            {
                 objEMp.EmployeeID=Convert.ToInt32(txtEmpId.Text);
                 objEMp.Salary=Convert.ToDecimal(txtSalary.Text);
                  objEMp.SalaryDate=Convert.ToDateTime(txtSalaryDate.Text);
                  objEMp.Status=true;  
            }
                else if(txtResign.Checked==true)
                {
                 objEMp.EmployeeID=Convert.ToInt32(txtEmpId.Text);
                objEMp.Salary=Convert.ToDecimal(txtSalary.Text);
                  objEMp.SalaryDate=Convert.ToDateTime(txtSalaryDate.Text);
                 objEMp. ResignDate=Convert.ToDateTime(txtResignDate.Text);
                 objEMp.Status = false;   
                }
            objEMp.Save();
            }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        
    }
}
