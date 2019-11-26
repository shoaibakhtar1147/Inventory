using CashandCarry.FormReports;
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

namespace CashandCarry.Reports
{
    public partial class frmReports : Form
    {
        public frmReports()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //FrmSaleReport obj = new FrmSaleReport();
           // FrmsalReport obj = new FrmsalReport();
            
            SaleMesage objmsg = new SaleMesage();
            objmsg.ShowDialog();     
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //FrmPurReport objPur = new FrmPurReport();
            PurchaseMesageBox objPur = new PurchaseMesageBox();
            objPur.ShowDialog();
        }

        private void btnCus_Click(object sender, EventArgs e)
        {
            FrmCustomerReport objCus = new FrmCustomerReport();
            objCus.ShowDialog();
        }

        private void btnComReport_Click(object sender, EventArgs e)
        {
            FrmComReport objCom = new FrmComReport();
            objCom.ShowDialog();
        }

        private void btnProdReport_Click(object sender, EventArgs e)
        {
            FrmProductReport objpro = new FrmProductReport();
            objpro.ShowDialog();
        }

        private void btnEmployee_Click(object sender, EventArgs e)
        {
            FrmEmployeeReport obj = new FrmEmployeeReport();
            obj.ShowDialog();
        }

        
       
       
    }
}
