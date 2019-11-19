using CashandCarry.BL;
using CashandCarry.Model;
using CashandCarry.Reports;
using CashandCarry.Reports.Company;
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
    public partial class FrmComReport : MetroForm
    {
        public FrmComReport()
        {
            InitializeComponent();
        }

        private void lblminimize_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnComName_Click(object sender, EventArgs e)
        {
            CompanyReport objcom = new CompanyReport();

            if(!String.IsNullOrEmpty(txtSearch.Text))
            {
                objcom.SetParameterValue("@ComID", txtSearch.Text);
            }
            //CompanyBL obj = new CompanyBL() 
            //{
            //CompanyID=Convert.ToInt32(txtSearch.Text)
            //};
            //var dt = obj.Search();
            //if(dt.Count>0)
            //{
            //    objcom.SetDataSource(dt);
               
            //}
            crptViewerCom.ReportSource = objcom;
        }

        private void btnAllRecord_Click(object sender, EventArgs e)
        {
            CompanyGeneralReport objCom = new CompanyGeneralReport();
            objCom.SetParameterValue("@ComID", null);
            //CompanyBL obj = new CompanyBL();
            //var dt = obj.Select();
            //if(dt.Count>0)
            //{
            //    objCom.SetDataSource(dt);
               
            //}
            crptViewerCom.ReportSource = objCom;

        }

        private void FrmComReport_Load(object sender, EventArgs e)
        {

        }
    }
}
