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

namespace CashandCarry.Employee
{
    public partial class FrmEmployee : Form
    {
        public FrmEmployee()
        {
            InitializeComponent();
        }

        private void btnEmployee_Click(object sender, EventArgs e)
        {
            frmEmployeeRegistration objEmp = new frmEmployeeRegistration();
            objEmp.ShowDialog();
        }

        private void btnSalary_Click(object sender, EventArgs e)
        {
            FrmEmployeeSalary objemp = new FrmEmployeeSalary();
            objemp.ShowDialog();
        }
    }
}
