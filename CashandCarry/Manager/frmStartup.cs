﻿using CashandCarry.Configuration;
using CashandCarry.Configuration;
using CashandCarry.Purchase;
using CashandCarry.Reports;
using CashandCarry.Sales;
using System;
using System.Windows.Forms;

namespace CashandCarry
{
    public partial class frmStartup : Form
    {
        public frmStartup()
        {
            InitializeComponent();
        }

        private void ShowForm(Form obj)
        {
            if(pnlmain.Controls.Count>0)
            {
                pnlmain.Controls.Clear();
            }
            obj.TopLevel = false;
            obj.Dock = DockStyle.Fill;
            pnlmain.Controls.Add(obj);
            obj.Show();
        }

        private void frmStartup_Load(object sender, EventArgs e)
        {
            frmHomePage objHome = new frmHomePage();
            ShowForm(objHome);
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            frmHomePage obj = new frmHomePage();
            ShowForm(obj);
        }

       

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            frmLogin objLog = new frmLogin();
            this.Hide();
            objLog.Show();
        }

        private void btnSales_Click(object sender, EventArgs e)
        {
            frmSales objSale = new frmSales();
            ShowForm(objSale);
            
        }

        private void btnPuchase_Click(object sender, EventArgs e)
        {
            frmPurchase objPur = new frmPurchase();
            ShowForm(objPur);
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            frmReports objRep = new frmReports();
            ShowForm(objRep);
        }

        private void btnConfiguration_Click(object sender, EventArgs e)
        {
            FrmConfiguration obj = new FrmConfiguration();
            ShowForm(obj);
        }

        

       
        

      
       

       

       

           }
}
