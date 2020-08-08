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
    public partial class FrmSubZone : MetroForm
    {
        public FrmSubZone()
        {
            InitializeComponent();
        }

        private void FrmSubZone_Load(object sender, EventArgs e)
        {
            formDisable();
            GridDesign();
            LoadData();
        }

        private void LoadData()
        {
            SubZoneBL obJBl = new SubZoneBL();
            var dt = obJBl.Select();
            if(dt != null)
            {
                //DataGridViewImageColumn edit = new DataGridViewImageColumn();
                //edit.Image = Properties.Resources.edit;
                //edit.ImageLayout = DataGridViewImageCellLayout.Zoom;
                //edit.HeaderText = "Edit";
                //DataGridViewImageColumn delete = new DataGridViewImageColumn();
                //delete.Image = Properties.Resources.delete;
                //delete.ImageLayout = DataGridViewImageCellLayout.Zoom;
                //delete.HeaderText = "Delete";
                //edit.Width = delete.Width = 20;
                //dgvSubZone.Columns.Add(edit);
                //dgvSubZone.Columns.Add(delete);
                dgvSubZone.DataSource = dt;
                dgvSubZone.Columns["ZoneID"].Visible = false;
                dgvSubZone.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
        }

        private void formDisable()
        {
            txtSubZoneName.Enabled = false;
            txtZone.Enabled = false;
            btnSave.Enabled = false;
         
            
        }

        private void btnAddnew_Click(object sender, EventArgs e)
        {
            FormEnable();
            LoadZone();
        }

        private void GridDesign()
        {
            dgvSubZone.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dgvSubZone.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvSubZone.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            dgvSubZone.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dgvSubZone.BackgroundColor = Color.White;

            dgvSubZone.EnableHeadersVisualStyles = false;
            dgvSubZone.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvSubZone.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            dgvSubZone.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        }

        private void LoadZone()
        {
            ZoneBL objBl = new ZoneBL();
            var dt = objBl.Select();
            txtZone.DataSource = dt;
            txtZone.DisplayMember = "ZoneName";
            txtZone.ValueMember = "ZoneID";
        }

        private void FormEnable()
        {
            txtSubZoneName.Enabled = true;
            txtZone.Enabled = true;
            btnSave.Enabled = true;
           
            btnAddnew.Enabled = false;
            
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if(FormValidate()==true)
                {
                    SubZoneBL objBl = new SubZoneBL() 
                    {
                    ZoneID=Convert.ToInt32(txtZone.SelectedValue),
                    SubRouteName=txtSubZoneName.Text
                    };
                    objBl.Save();
                    MessageBox.Show("Record Saved Successfull");
                    ClearGroup();
                    formDisable();
                    btnAddnew.Enabled = true;
                }
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
        private bool FormValidate()
        {
            if (txtSubZoneName.Text == "" || txtZone.Text == "") return false;
            return true;
        }

        //private void btnSearch_Click(object sender, EventArgs e)
        //{
        //    if(!string.IsNullOrEmpty(txtSearch.Text))
        //    {
        //        SubZoneBL objBl = new SubZoneBL()
        //        {
        //            SubRouteName = txtSearch.Text
        //        };
        //        var dt = objBl.SearchByName();
        //        if(dt!= null)
        //        {

        //        }
        //    }
        //}

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (txtSearch.Text == string.Empty)
            {
                LoadData();

            }
            else
            {
                SubZoneBL objTest = new  SubZoneBL()
                {
                    SubRouteName = txtSearch.Text.ToLower()
                };
                var dt = objTest.SearchByName();
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
