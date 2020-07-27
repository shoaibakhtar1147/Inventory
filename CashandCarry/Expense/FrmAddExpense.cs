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

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            ExpenseBL objExp = new ExpenseBL() 
            {
            ExType=txtExPType.SelectedText,
            ExName=txtExpName.Text,
            Description=txtDescription.Text,
            Date=Convert.ToDateTime(txtDate.Text),
            Amount=Convert.ToDecimal(txtAmount.Text)
            };
            objExp.Save();
            MessageBox.Show("Saved Successfull");
            ClearForm();


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

        
   }
}
