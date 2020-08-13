using CashandCarry.BL;
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
    public partial class FrmCustomerType : MetroForm
    {
        public FrmCustomerType()
        {
            InitializeComponent();
        }

        private void FrmCustomerType_Load(object sender, EventArgs e)
        {
            LoadData();
            GridDesign();
            FormDisable();
        }

        private void GridDesign()
        {
            dgvCusType.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dgvCusType.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvCusType.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            dgvCusType.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dgvCusType.BackgroundColor = Color.White;

            dgvCusType.EnableHeadersVisualStyles = false;
            dgvCusType.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvCusType.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            dgvCusType.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        }

        private void FormDisable()
        {
            txtCusType.Enabled = false;
            txtCusTypeID.Enabled = false;
           
            btnSave.Enabled = false;
        }
        private void FormEnable()
        {
            btnSave.Enabled = true;
            txtCusType.Enabled = true;
        }

        private void btnAddnew_Click(object sender, EventArgs e)
        {
            CusTypeBL objCus = new CusTypeBL();
            var dt = objCus.Addnew();
            if(dt.Rows.Count>0)
            {
                txtCusTypeID.Text = Convert.ToString(dt.Rows[0]["CusTypeID"]);

                FormEnable();
                txtCusType.Focus();
                btnAddnew.Enabled = false;
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtSearch.Text == string.Empty)
            {
                MessageBox.Show("Please Enter An ID");
            }
            else if (!string.IsNullOrEmpty(txtSearch.Text))
            {
                CusTypeBL obJCus=new CusTypeBL()
                {
                CusTypeID=Convert.ToInt32(txtSearch.Text)
                };
                var dt = obJCus.Search();
               if(dt!= null)
               {
                   dgvCusType.DataSource = dt;
                  
               }
                }
            
            else
            {
                MessageBox.Show("Record Not Found");
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try 
            {
                CusTypeBL objCus = new CusTypeBL()
                {
                    CusType = txtCusType.Text
                };
                objCus.Save();
                MessageBox.Show("Record Saved Successful");
                LoadData();
                btnAddnew.Enabled = true;
                ClearGroup();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
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

        //private void btnUpdate_Click(object sender, EventArgs e)
        //{
        //    //if (txtCusType.Text == string.Empty)
        //    //{
        //    //    MessageBox.Show("Please Enter An Customer Type For Update");
        //    //    return;
        //    //}
        //    if (MessageBox.Show("Are You Sure To Update Customer Type?", "Update Alert", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
        //    {
        //        CusTypeBL obJCus = new CusTypeBL()
        //        {
        //            CusTypeID = Convert.ToInt32(txtCusTypeID.Text),
        //            CusType = txtCusType.Text
        //        };
        //        obJCus.Update();
        //        MessageBox.Show("Update Successful");
        //        LoadData();
                
               
        //    }
        //    else
        //    {
        //        MessageBox.Show("Customer Type Not Updated");
        //    }
        //    ClearGroup();
        //}

        //private void btnDelete_Click(object sender, EventArgs e)
        //{
        //     string message = "Are you sure to Delete Customer Type " + txtCusType.Text + "?";

        //     if (MessageBox.Show(message, "Delete Alert", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
        //     {

        //         CusTypeBL objCus = new CusTypeBL() 
        //         {
        //              CusTypeID=Convert.ToInt32(txtCusTypeID.Text)
        //         };
        //         objCus.Delete();
        //         MessageBox.Show("Record Deleted Successfull");
               

        //    }
        //    else
        //    {
        //        MessageBox.Show("Record Not Deleted ");
        //    }
        //    LoadData();
        //     }

          private void LoadData()
        {
 	     CusTypeBL objCus=new CusTypeBL();
              var dt=objCus.Select();
              dgvCusType.Columns.Clear();
              if(dt.Count>0 && dt!= null)
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
                dgvCusType.Columns.Add(edit);
                dgvCusType.Columns.Add(delete);
                dgvCusType.DataSource = dt;
                dgvCusType.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            else
            {
                MessageBox.Show("No Record Found");
            }
              }

          private void dgvCusType_CellContentClick(object sender, DataGridViewCellEventArgs e)
          {
              int columnIndex = e.ColumnIndex;
              int rowindex = e.RowIndex;
              if(columnIndex==0)
              {
                  txtCusTypeID.Text = dgvCusType.Rows[rowindex].Cells[2].Value.ToString();
                  txtCusType.Text = dgvCusType.Rows[rowindex].Cells[3].Value.ToString();
                
                  txtCusType.Enabled = true;
                  
              }
              //if(columnIndex==1)
              //{
              //    string message = "Are you sure to Delete Customer Type " + txtCusType.Text + "?";

              //    if (MessageBox.Show(message, "Delete Alert", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
              //    {

              //        CusTypeBL objCus = new CusTypeBL()
              //        {
              //            CusTypeID = Convert.ToInt32(txtSearch.Text)
              //        };
              //        objCus.Delete();
              //        MessageBox.Show("Record Deleted Successfull");


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
                  CusTypeBL objTest = new  CusTypeBL()
                  {
                      CusType = txtSearch.Text.ToLower()
                  };
                  var dt = objTest.SearchByName();
                  AutoCompleteStringCollection coll = new AutoCompleteStringCollection();
                  txtSearch.AutoCompleteMode = AutoCompleteMode.Suggest;
                  txtSearch.AutoCompleteSource = AutoCompleteSource.CustomSource;
                  txtSearch.AutoCompleteCustomSource = coll;
                  if (dt.Count > 0)
                  {
                      dgvCusType.DataSource = dt;
                  }
              }
          }
        }

           

 

        }
    

