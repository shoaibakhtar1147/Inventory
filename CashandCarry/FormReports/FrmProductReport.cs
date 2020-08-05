using CashandCarry.BL;
using CashandCarry.Reports;
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

namespace CashandCarry.FormReports
{
    public partial class FrmProductReport : MetroForm
    {
        public FrmProductReport()
        {
            InitializeComponent();
        }

        private void btnProd_Click(object sender, EventArgs e)
        {
            ProductReport objPro = new ProductReport();
            rptViewer objView = new rptViewer();
            if(!String.IsNullOrEmpty(txtSearch.Text))
            {
                objPro.SetParameterValue("@ProductID", txtSearch.Text);
                
                ProductBL obj = new ProductBL()
                {
                     ProductID=Convert.ToInt32(txtSearch.Text)
                };
                var dt = obj.SearchByPRod();
                if(dt !=null)
                {
                   objPro.SetDataSource(dt);
                   objView.crptViewer.ReportSource = objPro;
                   objView.WindowState = FormWindowState.Maximized;
                   objView.ShowDialog();
                    //crptViewerProd.ReportSource = objPro;
                    txtSearch.Clear();
                }
                else
                {
                    MessageBox.Show("No Record Found");
                }
            }
            else
            {
                MessageBox.Show("Please Enter Product ID");
            }
        }

        private void lblminimize_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnAllRecord_Click(object sender, EventArgs e)
        {
            ProductReport objPro = new ProductReport();
            rptViewer objView = new rptViewer();
           
            ProductBL obj = new ProductBL();
            var dt = obj.SearchByPRodCom();
            if(dt != null)
            {
                objPro.SetDataSource(dt);
                objView.crptViewer.ReportSource = objPro;
                objView.WindowState = FormWindowState.Maximized;
                objView.ShowDialog();
                //crptViewerProd.ReportSource = objPro;
            }
            else
            {
                MessageBox.Show("No Record Found");
            }
        }
    }
}
