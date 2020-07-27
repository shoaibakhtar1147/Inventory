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

namespace CashandCarry.Sales
{
    public partial class SaleRecoveryDgv : MetroForm
    {
        public SaleRecoveryDgv()
        {
            InitializeComponent();
        }

        private void SaleRecoveryDgv_Load(object sender, EventArgs e)
        {
            GridDesign();
        }

        private void GridDesign()
        {
            dgvSaleRecovery.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dgvSaleRecovery.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvSaleRecovery.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            dgvSaleRecovery.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dgvSaleRecovery.BackgroundColor = Color.White;

            dgvSaleRecovery.EnableHeadersVisualStyles = false;
            dgvSaleRecovery.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvSaleRecovery.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            dgvSaleRecovery.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        }
    }
}
