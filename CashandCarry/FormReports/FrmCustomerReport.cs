﻿using CashandCarry.BL;
using CashandCarry.Model;
using CashandCarry.Reports;
using CashandCarry.Reports.Customer;
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
    public partial class FrmCustomerReport : MetroForm
    {
        public FrmCustomerReport()
        {
            InitializeComponent();
        }

        private void btnCusName_Click(object sender, EventArgs e)
        {
            
            CustomerReport objCus = new CustomerReport();
            rptViewer objView = new rptViewer();
            if (!string.IsNullOrEmpty(txtSearch.Text))
            {
                objCus.SetParameterValue("@CustomerID", txtSearch.Text);
                CustomerBL objBL = new CustomerBL()
                {
                    CustomerID = Convert.ToInt32(txtSearch.Text),

                };
                var dt = objBL.SelectByCus();
                if (dt != null)
                {
                    objCus.SetDataSource(dt);
                    objView.crptViewer.ReportSource = objCus;
                    objView.WindowState = FormWindowState.Maximized;
                    objView.ShowDialog();
                }
                //crptViewerCus.ReportSource = objCus;
                else
                {
                    MessageBox.Show("No Record Found");
                }
                txtSearch.Clear();
            }
            else
            {
                MessageBox.Show("Please Enter Enter ID");
            }
           
        }

        private void lblminimize_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
           

            //LoadReport();
            //PrintDialog printDialog = new PrintDialog();
            //if(printDialog.ShowDialog()==DialogResult.OK)
            //{
            //    CrystalDecisions.Shared.OpenReportMethod reportDocument = new CrystalDecisions.Shared.OpenReportMethod();
            //    reportDocument.Load(Application.StartupPath,LoadReport());
            //    reportDocument.PrintOptions.PrinterName = printDialog.PrinterSettings.PrinterName;
            //    reportDocument.PrintToPrinter(printDialog.PrinterSettings.Copies, printDialog.PrinterSettings.Collate,printDialog.PrinterSettings.FromPage,printDialog.PrinterSettings.ToPage);

            //}

        }

        private void FrmCustomerReport_Load(object sender, EventArgs e)
        {
           
        }

        private void btnAllRecord_Click(object sender, EventArgs e)
        {
            CustomerGeneralReport objCus = new CustomerGeneralReport();
            rptViewer objView = new rptViewer();
            CustomerBL objBL = new CustomerBL();
            var dt = objBL.SelectAllCus();
            if(dt != null)
            {
                objCus.SetDataSource(dt);
                objView.crptViewer.ReportSource = objCus;
                objView.WindowState = FormWindowState.Maximized;
                objView.ShowDialog();
            }
            else
            {
                MessageBox.Show("No Record Found");
            }
            //crptViewerCus.ReportSource = objCus;
        }

       
      

      

       
    }
}
