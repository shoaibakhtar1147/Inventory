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
    public partial class frmCustomer :MetroFramework.Forms.MetroForm
    {
        public frmCustomer()
        {
            InitializeComponent();
        }

        private void frmCustomer_Load(object sender, EventArgs e)
        {
            
            txtCusName.Focus();
            LoadData();
            GridDesign();
            FormDisable();
        }

        private void GridDesign()
        {
            dgvCus.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dgvCus.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvCus.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            dgvCus.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dgvCus.BackgroundColor = Color.White;

            dgvCus.EnableHeadersVisualStyles = false;
            dgvCus.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvCus.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            dgvCus.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        }

        private void FormDisable()
        {
            txtCusID.Enabled = false;
            txtCusName.Enabled = false;
            txtEmail.Enabled = false;
            txtCusType.Enabled = false;
            txtZoneID.Enabled = false;
            txtContact.Enabled = false;
            txtAddress.Enabled = false;
            btnUpdate.Enabled = false;
            btnSave.Enabled = false;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
            txtPreBalance.Enabled = false;
            btnClear.Enabled = false;
        }
        private void FormEnable()
        {
            txtCusName.Enabled = true;
            txtEmail.Enabled = true;
            txtCusType.Enabled = true;
            txtZoneID.Enabled = true;
            txtContact.Enabled = true;
            txtPreBalance.Enabled = true;
            txtAddress.Enabled = true;
            
            
        }

       
        private void btnAddnew_Click(object sender, EventArgs e)
        {
            CustomerBL objCus = new CustomerBL();
            DataTable dt = objCus.Addnew();
            if(dt.Rows.Count>0)
            {
                txtCusID.Text = Convert.ToString(dt.Rows[0]["CustomerID"]);
                FormEnable();
                LoadZoneID();
                //LoadSubZone();
                LoadCusType();
                btnSave.Enabled = true;
                txtCusName.Focus();
                btnAddnew.Enabled = false;
            }
           
        }

        private void LoadSubZone()
        {
            SubZoneBL objsubzone = new SubZoneBL() 
            {
            ZoneID=Convert.ToInt32(txtZoneID.SelectedValue)
            };
            var dt = objsubzone.SearchByZone();
            if (dt != null)
            {
                txtSubZone.DataSource = dt;
                txtSubZone.DisplayMember = "SubRouteName";
                txtSubZone.ValueMember = "SubROuteId";
            }
            else
            {
                MessageBox.Show("No Record Found");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string message = "Are You Sure To Delete  Customer " + txtCusName.Text+ "?";
            if (MessageBox.Show(message, "Delete Alert", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                CustomerBL objCus = new  CustomerBL()
                {
                     CustomerID = Convert.ToInt32(txtCusID.Text)
                };
                objCus.Delete();
                MessageBox.Show("Record Delete Successfull");
                LoadData();
                ClearGroup();
               // Clear();
            }
            else
            {
                MessageBox.Show("No Record Deleted");
            }
        }

        
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtCusID.Text == string.Empty)
            {
                MessageBox.Show("Please Select A Customer ID ");
                return;
            }

            else if (MessageBox.Show("Are You Sure To Update Customer?", "UpdateAlert", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                CustomerBL objCus = new CustomerBL()
                {
                     CustomerID = Convert.ToInt32(txtCusID.Text),
                     Name =txtCusName.Text,
                      Address=txtAddress.Text,
                       Contact=txtContact.Text,
                     CusTypeID = Convert.ToInt32(txtCusType.SelectedValue),
                         Email=txtEmail.Text,
                     ZoneID = Convert.ToInt32(txtZoneID.SelectedValue)

                };
                objCus.Update();
                MessageBox.Show("Customer Update Successfull");



                LoadData();
                ClearGroup();
                // Clear();

            }
            else
            {
                MessageBox.Show("Customer Not Update");
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtCusID.Clear();
            txtCusName.Clear();
            txtCusType.ResetText();
            txtEmail.Clear();
            txtSearch.Clear();
            txtZoneID.ResetText();
            txtAddress.Clear();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                decimal prebal = Convert.ToDecimal(txtPreBalance.Text);
                if (FormValidate() == true)
                {
                    CustomerBL objcus = new CustomerBL()
                    {
                        Name = txtCusName.Text,
                        Email = txtEmail.Text,
                        Address = txtAddress.Text,
                        Contact = txtContact.Text,
                        CusTypeID = Convert.ToInt32(txtCusType.SelectedValue),
                        ZoneID = Convert.ToInt32(txtZoneID.SelectedValue),
                        SubZoneId = Convert.ToInt32(txtSubZone.SelectedValue),
                        Duepayment = Convert.ToDecimal(txtPreBalance.Text)
                    };
                    if (prebal > 0)
                    {
                        SaleLedgerBL objBl = new SaleLedgerBL()
                        {
                            CustomerID = Convert.ToInt32(txtCusID.Text),
                            Credit = Convert.ToDecimal(prebal),
                            Debit = Convert.ToDecimal("0.00"),
                            Date = Convert.ToDateTime(DateTime.Now.ToShortDateString()),
                            Balance = Convert.ToDecimal(prebal),
                            Description = "Opening Balance"

                        };
                        objBl.Save();
                    }
                    objcus.Save();
                    MessageBox.Show("Record Saved Successfull");
                    LoadData();
                    btnAddnew.Enabled = true;
                    btnSave.Enabled = false;
                    ClearGroup();
                }
                else
                {
                    MessageBox.Show("Some Error Occur No Record Save");
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
                if (c is TextBox || c is ComboBox||c is MaskedTextBox)
                {
                    c.Text = "";
                }

            }
        }

        private bool FormValidate()
        {
            if (txtCusName.Text==""||txtCusType.Text==""||txtContact.MaskCompleted==false||txtAddress.Text==""||txtZoneID.Text==""||txtSubZone.Text=="") return false;
            return true;
        }
        private void LoadZoneID()
        {
            
            ZoneBL objZone = new ZoneBL();
            var dt = objZone.Select();
            txtZoneID.DataSource = dt;        
            txtZoneID.AutoCompleteMode = AutoCompleteMode.Suggest;
            txtZoneID.AutoCompleteSource = AutoCompleteSource.ListItems;
            txtZoneID.DisplayMember = "ZoneName";
            txtZoneID.ValueMember = "ZoneID";
            

        }

        private void LoadData()
        {
            CustomerBL objCus = new CustomerBL();
            var dt = objCus.Select();
            dgvCus.Columns.Clear();
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
                dgvCus.Columns.Add(edit);
                dgvCus.Columns.Add(delete);
                dgvCus.DataSource = dt;
                dgvCus.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgvCus.Columns["ZoneID"].Visible = false;
            }

         }

        private void LoadCusType()
        {
            CusTypeBL objCus = new CusTypeBL();
            List<tbl_CustomerTypes> dt = objCus.Select();
            txtCusType.DataSource = dt;
            txtCusType.AutoCompleteMode = AutoCompleteMode.Suggest;
            txtCusType.AutoCompleteSource = AutoCompleteSource.ListItems;
            txtCusType.DisplayMember = "CusType";
            txtCusType.ValueMember = "CusTypeID";
            
        }

        

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if(txtSearch.Text==string.Empty)
            {
                MessageBox.Show("Please Enter An ID");
            }
          else
            {
                CustomerBL objCus = new CustomerBL()
                {

                    CustomerID = Convert.ToInt32(txtSearch.Text)
                };
                var dt = objCus.Search();
                if (dt != null)
                {
                    dgvCus.DataSource = dt;
                    btnDelete.Enabled = true;
                    btnUpdate.Enabled = true;
                }
            }

        }

        private void label14_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

       
        private void txtAddress_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvCus_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            int rowindex = e.RowIndex;
            int columnindex = e.ColumnIndex;
            if (columnindex == 0)
            {
                txtCusID.Text = dgvCus.Rows[rowindex].Cells[2].Value.ToString();
                txtCusName.Text = dgvCus.Rows[rowindex].Cells[3].Value.ToString();
                txtCusType.Text = dgvCus.Rows[rowindex].Cells[4].Value.ToString();
                txtAddress.Text = dgvCus.Rows[rowindex].Cells[5].Value.ToString();
                txtContact.Text = dgvCus.Rows[rowindex].Cells[6].Value.ToString();
                txtEmail.Text = dgvCus.Rows[rowindex].Cells[7].Value.ToString();
                txtZoneID.Text = dgvCus.Rows[rowindex].Cells[8].Value.ToString();
                txtSubZone.Text = dgvCus.Rows[rowindex].Cells[9].Value.ToString();

                FormEnable();
                btnSave.Enabled = false;
                btnUpdate.Enabled = true;
                btnDelete.Enabled = true;
                btnClear.Enabled = true;

            }
            else if (columnindex == 1)
            {
                string message = "Are You Sure To Delete  Customer " + txtCusName.Text + "?";
                if (MessageBox.Show(message, "Delete Alert", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    CustomerBL objCus = new CustomerBL()
                    {
                        CustomerID = Convert.ToInt32(dgvCus.Rows[rowindex].Cells[2].Value.ToString())
                    };
                    objCus.Delete();
                    MessageBox.Show("Record Delete Successfull");
                    LoadData();
                    
                }
                else
                {
                    MessageBox.Show("No Record Deleted");
                }
            }
        }

        private void txtPreBalance_Leave(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txtPreBalance.Text))
            {
                txtPreBalance.Text = "0.00";
            }
        }

        private void txtZoneID_Leave(object sender, EventArgs e)
        {
            LoadSubZone();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (txtSearch.Text == string.Empty)
            {
                LoadData();

            }
            else
            {
                CustomerBL objTest = new CustomerBL()
                {
                    Name = txtSearch.Text.ToLower()
                };
                var dt = objTest.SearchByCusName();
                AutoCompleteStringCollection coll = new AutoCompleteStringCollection();
                txtSearch.AutoCompleteMode = AutoCompleteMode.Suggest;
                txtSearch.AutoCompleteSource = AutoCompleteSource.CustomSource;
                txtSearch.AutoCompleteCustomSource = coll;
                if (dt.Count > 0)
                {
                    dgvCus.DataSource = dt;
                }
            }
        }
    }
}
