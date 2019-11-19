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
            if(!String.IsNullOrEmpty(txtSearch.Text))
            {
                objPro.SetParameterValue("@ProductID", txtSearch.Text);
                
                ProductBL obj = new ProductBL()
                {
                     ProductID=Convert.ToInt32(txtSearch.Text)
                };
                var dt = obj.SearchByPRod();
                if(dt.Rows.Count>0)
                {
                   objPro.SetDataSource(dt);
                    crptViewerProd.ReportSource = objPro;
                    txtSearch.Clear();
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
            objPro.SetParameterValue("@ProductID", null);
            ProductBL obj = new ProductBL();
            var dt = obj.Select();
            if(dt.Count>0)
            {
                //objPro.SetDataSource(dt);
                crptViewerProd.ReportSource = objPro;
            }
        }
    }
}
