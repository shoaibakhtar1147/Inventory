using CashandCarry.BL;
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
    public partial class frmHomePage : Form
    {
        public frmHomePage()
        {
            InitializeComponent();
        }

        private void frmHomePage_Load(object sender, EventArgs e)
        {
            GridDesign();
            LoadData();
        }

        private void GridDesign()
        
            
        {
            dgvCus.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dgvCus.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvCus.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            dgvCus.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dgvCus.DefaultCellStyle.ForeColor = Color.Black;
            dgvCus.BackgroundColor = Color.White;

            dgvCus.EnableHeadersVisualStyles = false;
            dgvCus.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvCus.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            dgvCus.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        }
        

        private void LoadData()
        {
            CustomerBL objBL = new CustomerBL();
            var dt = objBL.Select15days();
            if(dt != null)
            {
                dgvCus.DataSource=dt;
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
