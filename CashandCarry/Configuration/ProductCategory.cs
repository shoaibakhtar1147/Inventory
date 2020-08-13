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

namespace CashandCarry.Configuration
{
    public partial class ProductCategory : MetroForm
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
                    ClearGroup();
                    btnAddnew.Enabled = true;
                              
                }
            else
            {
                MessageBox.Show("Some Error Occur");
            }   
            }


        private void ClearGroup()
        {
            foreach (Control c in groupBox1.Controls)
            {
                if (c is TextBox || c is ComboBox || c is MaskedTextBox)
                {
                    c.Text = "";
                }

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
            //btnDelete.Enabled = false;
            btnUpdate.Enabled = false;
        }
        
        
        private void ProductCategory_Load(object sender, EventArgs e)
        {
           
           
            LoadData();
            GridDesign();
            txtSearch.Focus();
            frmDisable();
        }

        private void GridDesign()
        {
            dgvCategory.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dgvCategory.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvCategory.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            dgvCategory.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dgvCategory.BackgroundColor = Color.White;

            dgvCategory.EnableHeadersVisualStyles = false;
            dgvCategory.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvCategory.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            dgvCategory.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
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
                btnAddnew.Enabled = false;

            }
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            
            //if(txtSearch.Text==string.Empty)
            //{
            //    MessageBox.Show("Please Select An Category ID ");
            //    return;
            //}
                
            if(MessageBox.Show("Are You Sure To Update Category?","UpdateAlert",MessageBoxButtons.YesNo,MessageBoxIcon.Information)==DialogResult.Yes)
            {
                
             CategoryBL ojcate=new CategoryBL()
             {
              CategoryID=Convert.ToInt32(txtCategoryID.Text)
             };
               ojcate.Update();
                MessageBox.Show("Record Updated");
                ClearGroup();
                 

                LoadData();
                
               
                 }
            else
            {
                MessageBox.Show("Record Not Update");
            }
        }
        //private void btnSearch_Click(object sender, EventArgs e)
        //{
        //    if(txtSearch.Text==string.Empty)
        //    {
        //        MessageBox.Show("Please Enter An ID");
        //    }
        //   else if(!string.IsNullOrEmpty(txtSearch.Text))
        //    {
        //        CategoryBL objCate = new CategoryBL()
        //        {
        //            CategoryID = Convert.ToInt32(txtSearch.Text)
        //        };
        //        var dt = objCate.Search();
        //        if (dt != null)
        //        {
        //            dgvCategory.DataSource = dt;
        //            txtCategory.Enabled = true;
        //            btnUpdate.Enabled = true;
        //           // btnDelete.Enabled = true;

        //        }
        //    }
        //    else  
        //    {
        //        MessageBox.Show("Record Not Found");
        //    }
           
                
        //}
        //private void btnDelete_Click(object sender, EventArgs e)
        //{
        //    string message="Are You Sure To Delete Product Category"+txtCategory.Text+"?";
        //    if(MessageBox.Show(message,"Delete Alert",MessageBoxButtons.YesNo,MessageBoxIcon.Warning)==DialogResult.Yes)
        //    {
        //        CategoryBL objCate = new CategoryBL() 
        //        {
        //         CategoryID=Convert.ToInt32(txtSearch.Text)
        //        };
        //        objCate.Delete();
               
        //            MessageBox.Show("Record Delete Successfull");
        //            LoadData();
        //            ClearGroup();
            
        //    }
        //    else
        //    {
        //        MessageBox.Show("No Record Deleted");
        //    }
        //}
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
            //else if(columnindex==1)
            //{
            //     string message = "Are You Sure To Delete  Porduct Category " +txtCategory.Text + "?";
            //    if (MessageBox.Show(message, "Delete Alert", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            //    {

            //        CategoryBL objcate = new CategoryBL()
            //        {
            //            CategoryID = Convert.ToInt32(dgvCategory.Rows[rowindex].Cells[2].Value)
            //        };
            //        objcate.Delete();
            //        MessageBox.Show("Deleted Successfully");
            //        LoadData();
            //        ClearGroup();
            //    }
            //}
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (txtSearch.Text == string.Empty)
            {
                LoadData();

            }
            else
            {
                CategoryBL objTest = new  CategoryBL()
                {
                    CategoryName = txtSearch.Text.ToLower()
                };
                var dt = objTest.SearchByName();
                AutoCompleteStringCollection coll = new AutoCompleteStringCollection();
                txtSearch.AutoCompleteMode = AutoCompleteMode.Suggest;
                txtSearch.AutoCompleteSource = AutoCompleteSource.CustomSource;
                txtSearch.AutoCompleteCustomSource = coll;
                if (dt.Count > 0)
                {
                    dgvCategory.DataSource = dt;
                }
            }
        }
    }
}
