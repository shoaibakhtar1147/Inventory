using CashandCarry.Backup;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CashandCarry.Manager
{
    public partial class FrmBackUp : Form
    {
        public FrmBackUp()
        {
            InitializeComponent();
        }

        private void FrmBackUp_Load(object sender, EventArgs e)
        {

        }

        private void btnSaleInv_Click(object sender, EventArgs e)
        {
            FormBack obj = new FormBack();
            obj.ShowDialog();
        }
    }
}
