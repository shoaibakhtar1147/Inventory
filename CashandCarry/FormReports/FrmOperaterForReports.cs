using CashandCarry.FrmMessageBox;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CashandCarry.FormReports
{
    public partial class FrmOperaterForReports : Form
    {
        public FrmOperaterForReports()
        {
            InitializeComponent();
        }

        private void FrmOperaterForReports_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            SaleMesage objmsg = new SaleMesage();
            objmsg.ShowDialog(); 
        }

        private void button3_Click(object sender, EventArgs e)
        {
            PurchaseMesageBox objPur = new PurchaseMesageBox();
            objPur.ShowDialog();
        }
    }
}
