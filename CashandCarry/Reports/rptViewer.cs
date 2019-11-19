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

namespace CashandCarry.Reports
{
    public partial class rptViewer : MetroForm
    {
        public rptViewer()
        {
            InitializeComponent();
        }

        private void rptViewer_Load(object sender, EventArgs e)
        {

            this.crptViewer.RefreshReport();
            this.crptViewer.RefreshReport();
            this.crptViewer.RefreshReport();
        }

        private void crptView_Load(object sender, EventArgs e)
        {

        }

       
    }
}
