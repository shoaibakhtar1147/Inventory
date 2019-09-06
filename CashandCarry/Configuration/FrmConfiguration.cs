using CashandCarry.Configuration;
using CashandCarry.Configuration;
using CashandCarry.Configuration;
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
    public partial class FrmConfiguration : Form
    {
        public FrmConfiguration()
        {
            InitializeComponent();
        }

        private void btnEmployee_Click(object sender, EventArgs e)
        {
            frmEmployeeRegistration objEmp = new frmEmployeeRegistration();
            objEmp.ShowDialog();
        }

        private void btnCompany_Click(object sender, EventArgs e)
        {
            frmCompany objCom = new frmCompany();
            objCom.ShowDialog();
        }

        private void btnProduct_Click(object sender, EventArgs e)
        {
            frmProduct objPro = new frmProduct();
            objPro.ShowDialog();

        }

        private void btnCategory_Click(object sender, EventArgs e)
        {
            ProductCategory objpro = new ProductCategory();
            objpro.ShowDialog();
        }

        private void btnCust_Click(object sender, EventArgs e)
        {
            frmCustomer objCus = new frmCustomer();
            objCus.ShowDialog();
        }

        private void btnZone_Click(object sender, EventArgs e)
        {
            FrmZone objZon = new FrmZone();
            objZon.ShowDialog();
        }

       
        

       
}
    }



