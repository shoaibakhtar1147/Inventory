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
    public partial class FrmZone : MetroForm
    {
        public FrmZone()
        {
            InitializeComponent();
        }

        private void lblClose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        private void FormDisable()
        {
            txtZoneID.Enabled = false;
            txtZoneName.Enabled = false;
            btnSave.Enabled = false;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;

        }
        private void loadData()
        {
            ZoneBL objzone = new ZoneBL();
            List<tbl_Zone> dt = objzone.Select();
            dgvZone.Columns.Clear();
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
                dgvZone.Columns.Add(edit);
                dgvZone.Columns.Add(delete);
                dgvZone.DataSource = dt;
                dgvZone.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            
        }
        private void Clear()
        {
            txtZoneID.Clear();
            txtZoneName.Clear();
            txtSearch.Clear();
        }
        private bool FormValidate()
        {
            if (txtZoneName.Text == "") return false;
            return true;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (FormValidate() == true)
            {
                ZoneBL objZone = new ZoneBL()
                {
                    ZoneName = txtZoneName.Text
                };
                objZone.Save();
               
                    MessageBox.Show("Record Save Successfull");
                               loadData();
                               btnAddnew.Enabled = true;
                Clear();
            }
            else
            {
                MessageBox.Show("Some Error Occur No Record Save");
            }
        }
        private void FrmZone_Load(object sender, EventArgs e)
        {
            FormDisable();
            loadData();
        }
        private void btnAddnew_Click(object sender, EventArgs e)
        {
            ZoneBL objZone = new ZoneBL();
            DataTable dt = objZone.Addnew();
            if(dt.Rows.Count>0)
            {
                txtZoneID.Text = Convert.ToString(dt.Rows[0]["ZoneID"]);
                btnSave.Enabled = true;
                txtZoneName.Enabled = true;
                txtZoneName.Focus();
                btnAddnew.Enabled = false;
            }
           
          

        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtSearch.Text == string.Empty)
            {
                MessageBox.Show("Please Select A Zone ID ");
                return;
            }

            else if (MessageBox.Show("Are You Sure To Update Zone?", "UpdateAlert", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                ZoneBL objCate = new ZoneBL()
                {
                     ZoneId = Convert.ToInt32(txtZoneID.Text),
                     ZoneName = txtZoneName.Text
                };
                 objCate.Update();
                    MessageBox.Show("Zone Update Successfull");

                
                
                loadData();
                Clear();
            }
            else
            {
                MessageBox.Show("Zone Not Update");
            }

            
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            if(txtSearch.Text==string.Empty)
            {
                MessageBox.Show("Please Enter An ID");
            }
            else if(!string.IsNullOrEmpty(txtSearch.Text))
            {
                ZoneBL objZone = new ZoneBL()
                {
                    ZoneId = Convert.ToInt32(txtSearch.Text)
                };
                var dt = objZone.Search();
                if (dt != null)
                {
                    dgvZone.DataSource = dt;
                    txtZoneName.Enabled = true;
                    btnUpdate.Enabled = true;
                    btnDelete.Enabled = true;

                }
            }
            else
            {
                MessageBox.Show("No Record Found OR Empty");
            }
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
              string message="Are You Sure To Delete  Zone "+txtZoneName.Text+"?";
            if(MessageBox.Show(message,"Delete Alert",MessageBoxButtons.YesNo,MessageBoxIcon.Warning)==DialogResult.Yes)
            {
                ZoneBL objCate = new ZoneBL() 
                {
                 ZoneId=Convert.ToInt32(txtSearch.Text)
                };
                objCate.Delete(); 
                MessageBox.Show("Record Delete Successfull");
                    loadData();
                    Clear();  
            }
            else
            {
                MessageBox.Show("No Record Deleted");
            }
        }
      
        private void dgvZone_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            int rowindex = e.RowIndex;
            int Columnindex = e.ColumnIndex;
            if (Columnindex == 0)
            {
                txtZoneID.Text = dgvZone.Rows[rowindex].Cells[2].Value.ToString();
                txtZoneName.Text = dgvZone.Rows[rowindex].Cells[3].Value.ToString();
                btnUpdate.Enabled = true;
                txtZoneName.Enabled = true;
                btnDelete.Enabled = true;
            }
            else if (Columnindex == 1)
            {
                ZoneBL objcate = new ZoneBL()
                {
                    ZoneId = Convert.ToInt32(dgvZone.Rows[rowindex].Cells[2].Value)
                };
                objcate.Delete();

                MessageBox.Show("Deleted Successfully");
                loadData();

            }
        }
        }
        
    }

