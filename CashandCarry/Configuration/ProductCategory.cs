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
    public partial class ProductCategory : Form
    {
        public ProductCategory()
        {
            InitializeComponent();
        }

     
        private void btnSave_Click(object sender, EventArgs e)
        {
            if(FormValidate()==true)
            {
                CategoryBL objcate=new CategoryBL() 
                {
                 CategoryName=txtCategory.Text
                };
                objcate.Save();
                    MessageBox.Show("Saved Successfull");
                    LoadData();
                    Clear();
                
                }
            else
            {
                MessageBox.Show("Some Error Occur");
            }   
            }
            
        
        
        private void LoadData()
        {
            CategoryBL objCate = new CategoryBL();
            List<tbl_Category> dt = objCate.Select();
            dgvCategory.Columns.Clear();
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
                edit.Width = delete.Width = 20;
                dgvCategory.Columns.Add(edit);
                dgvCategory.Columns.Add(delete);
                dgvCategory.DataSource = dt;
                dgvCategory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            
        }
        private void frmDisable()
        {
            txtCategory.Enabled = false;
            txtCategoryID.Enabled = false;
            btnSave.Enabled = false;
            btnDelete.Enabled = false;
            btnUpdate.Enabled = false;
        }
        private void Clear()
        {
            txtSearch.Clear();
            txtCategoryID.Clear();
            txtCategory.Clear();
        }
        private void ProductCategory_Load(object sender, EventArgs e)
        {
           
           
            LoadData();
            txtSearch.Focus();
            frmDisable();
        }
        private void btnAddnew_Click(object sender, EventArgs e)
        {
            CategoryBL objCate = new CategoryBL();
            DataTable dt = objCate.Addnew();
            if(dt.Rows.Count>0)
            {
                txtCategoryID.Text = Convert.ToString(dt.Rows[0]["CategoryID"]);
                btnSave.Enabled = true;
                txtCategory.Enabled = true;
                txtCategory.Focus();

            }
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            
            if(txtSearch.Text==string.Empty)
            {
                MessageBox.Show("Please Select An Category ID ");
                return;
            }
                
            else if(MessageBox.Show("Are You Sure To Update Category?","UpdateAlert",MessageBoxButtons.YesNo,MessageBoxIcon.Information)==DialogResult.Yes)
            {
                
             CategoryBL ojcate=new CategoryBL()
             {
              CategoryID=Convert.ToInt32(txtSearch.Text)
             };
               ojcate.Update();
                MessageBox.Show("Record Updated");    
                 

                LoadData();
                Clear(); 
               
                 }
            else
            {
                MessageBox.Show("Record Not Update");
            }
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            if(txtSearch.Text==string.Empty)
            {
                MessageBox.Show("Please Enter An ID");
            }
            CategoryBL objCate = new CategoryBL() 
            { 
            CategoryID=Convert.ToInt32(txtSearch.Text)
            };
            var dt= objCate.Search();
            if(dt != null)
            {
                dgvCategory.DataSource = dt;
                txtCategory.Enabled = true;
                
            }
            else  
            {
                MessageBox.Show("Record Not Found");
            }
            btnUpdate.Enabled = true;
            btnDelete.Enabled = true;
                
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            string message="Are You Sure To Delete  Category"+txtCategory.Text+"?";
            if(MessageBox.Show(message,"Delete Alert",MessageBoxButtons.YesNo,MessageBoxIcon.Warning)==DialogResult.Yes)
            {
                CategoryBL objCate = new CategoryBL() 
                {
                 CategoryID=Convert.ToInt32(txtSearch.Text)
                };
                objCate.Delete();
               
                    MessageBox.Show("Record Delete Successfull");
                    LoadData();  
            }
            else
            {
                MessageBox.Show("No Record Deleted");
            }
        }
        private void lbminimize_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        private bool FormValidate()
        {
            if (txtCategory.Text == "") return false;
            return true;
        }
        private void dgvCategory_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowindex = e.RowIndex;
            int columnindex = e.ColumnIndex;
            if(columnindex==0)
            {
                txtCategoryID.Text = dgvCategory.Rows[rowindex].Cells[2].Value.ToString();
                txtCategory.Text = dgvCategory.Rows[rowindex].Cells[3].Value.ToString();
                btnUpdate.Enabled = true;
                txtCategory.Enabled = true;
            }
            else if(columnindex==1)
            {
                CategoryBL objcate = new CategoryBL()
                {
                    CategoryID=Convert.ToInt32(dgvCategory.Rows[rowindex].Cells[2].Value)
                };
                objcate.Delete();
                MessageBox.Show("Deleted Successfully");
                LoadData();
            }
        }
    }
}
