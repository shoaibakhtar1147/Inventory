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

namespace CashandCarry.Expense
{
    public partial class FrmAddExpense : MetroForm
    {
        public FrmAddExpense()
        {
            InitializeComponent();
        }

        private void FrmAddExpense_Load(object sender, EventArgs e)
        {
            formDisable();
        }

        private void formDisable()
        {
            btnSave.Enabled = false;
            txtExPType.Enabled = false;
            txtExpName.Enabled = false;
            txtDescription.Enabled = false;
            txtDate.Enabled = false;
            txtAmount.Enabled = false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try { 
            if(FormValidate() ==true)
            {
                ExpenseBL objExp = new ExpenseBL()
                {
                    ExType = txtExPType.SelectedText,
                    ExName = txtExpName.Text,
                    Description = txtDescription.Text,
                    Date = Convert.ToDateTime(txtDate.Text),
                    Amount = Convert.ToDecimal(txtAmount.Text)
                };
                objExp.Save();
                MessageBox.Show("Saved Successfull");
                ClearForm();
                formDisable();
                btnAddnew.Enabled = true;

            }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
            

        }

        private bool FormValidate()
        {
            if (txtAmount.Text == "" || txtDate.Text == ""||txtDescription.Text=="" || txtExpName.Text == "" || txtExPType.Text=="") return false;
            return true;
        }

        private void ClearForm()
        {
            foreach (Control c in groupBox1.Controls)
            {
                if (c is TextBox || c is ComboBox || c is MaskedTextBox)
                {
                    c.Text = "";
                }

            }
        }


        private void btnAddnew_Click(object sender, EventArgs e)
        {
            FormEnable();
        }

        private void FormEnable()
        {
            btnSave.Enabled = true;
            txtExPType.Enabled = true;
            txtExpName.Enabled = true;
            txtDescription.Enabled = true;
            txtDate.Enabled = true;
            btnAddnew.Enabled = false;
            txtAmount.Enabled = true;
        }

        
   }
}
