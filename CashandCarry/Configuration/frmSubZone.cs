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
    public partial class frmSubZone : MetroForm
    {
        public frmSubZone()
        {
            InitializeComponent();
        }

        private void frmSubZone_Load(object sender, EventArgs e)
        {
            FormDisable();
            LoadData();
        }

        private void LoadData()
        {
            SubZoneBL obj = new SubZoneBL();
            var dt = obj.Select();
            dgvSubZone.Columns.Clear();
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
                edit.Width = delete.Width = 40;
                dgvSubZone.Columns.Add(edit);
                dgvSubZone.Columns.Add(delete);
                dgvSubZone.DataSource = dt;
                dgvSubZone.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
        }

        

        private void btnSave_Click(object sender, EventArgs e)
        {
           if(!string.IsNullOrEmpty(txtSubRouteName.Text))
           {

               SubZoneBL obj = new SubZoneBL()
               {
                   SubRouteName = txtSubRouteName.Text,
                   ZoneID = Convert.ToInt32(txtRoute.SelectedValue)
               };
               obj.Save();
               MessageBox.Show("Sub Route Save Successfull");

           }
            else
           {
               MessageBox.Show("Please Enter Sub Route Name");
           }

        }

        private void btnAddnew_Click(object sender, EventArgs e)
        {
            FormEnable();
            LoadZone();
        
        }

        
        private void LoadZone()
        {
            ZoneBL objzone = new ZoneBL();
            var dt = objzone.Select();
            if(dt != null)
            {
                txtRoute.DataSource = dt;
                txtRoute.DisplayMember = "ZoneName";
                txtRoute.ValueMember = "ZoneID";
            }
            
        }

        private void FormDisable()
        {
            txtSearch.Enabled = false;
           
            txtRoute.Enabled = false;
            txtSubRouteName.Enabled = false;
            txtSubRouteId.Enabled = false;
            btnSave.Enabled = false;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
        }
        private void FormEnable()
        {
            txtSearch.Enabled = true;
           
            txtRoute.Enabled = true;
            txtSubRouteName.Enabled = true;
            btnSave.Enabled = true;
            btnUpdate.Enabled = true;
            btnDelete.Enabled = true;
            btnAddnew.Enabled = false;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (txtSearch.Text == string.Empty)
            {
                LoadData();

            }
            else
            {
                SubZoneBL obj = new SubZoneBL()
                {
                    SubRouteName=txtSearch.Text.ToLower()
                };
                var dt = obj.SearchByName();
                AutoCompleteStringCollection coll = new AutoCompleteStringCollection();
                txtSearch.AutoCompleteMode = AutoCompleteMode.Suggest;
                txtSearch.AutoCompleteSource = AutoCompleteSource.CustomSource;
                txtSearch.AutoCompleteCustomSource = coll;
                if (dt.Count > 0)
                {
                    dgvSubZone.DataSource = dt;
                }
            }
        }

       

       
    }
}
