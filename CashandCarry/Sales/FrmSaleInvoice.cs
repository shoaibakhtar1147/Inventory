using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CashandCarry.Sales
{
    public partial class FrmSaleInvoice : Form
    {
        public FrmSaleInvoice()
        {
            InitializeComponent();
        }

        private void FrmSaleInvoice_Load(object sender, EventArgs e)
        {
            txtCusName.Focus();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void groupBox5_Enter(object sender, EventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }
    }
}
