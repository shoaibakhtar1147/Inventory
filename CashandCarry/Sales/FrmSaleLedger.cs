﻿using CashandCarry.BL;
using CashandCarry.Reports;
using CashandCarry.Reports.Sale;
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

namespace CashandCarry.Sales
{
    public partial class FrmSaleLedger : MetroForm
    {
        public FrmSaleLedger()
        {
            InitializeComponent();
        }

        private void FrmSaleLedger_Load(object sender, EventArgs e)
        {
            GridDesign();
        }

        private void GridDesign()
        {
            dgvLedger.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dgvLedger.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvLedger.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            dgvLedger.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dgvLedger.BackgroundColor = Color.White;

            dgvLedger.EnableHeadersVisualStyles = false;
            dgvLedger.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvLedger.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            dgvLedger.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            SaleLedgerBL objLedger = new SaleLedgerBL()
            {
                CustomerID =Convert.ToInt32( txtSearch.Text)
            };
            var dt = objLedger.search();
            if(dt !=null)
            {
                dgvLedger.DataSource = dt;
                this.dgvLedger.Columns["STid"].Visible = false;
                    
            }
            else
            {
                MessageBox.Show("No Record Found " + txtSearch.Text);
            }

        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txtSearch.Text))
            {
                MessageBox.Show("Please Enter Customer Id");
            }
            else
            {
                SaleLedgerReport objSale = new SaleLedgerReport();
                rptViewer objView = new rptViewer();
                objSale.SetParameterValue("@CustomerID", txtSearch.Text);
                SaleLedgerBL objLedger = new SaleLedgerBL() 
                {
                CustomerID=Convert.ToInt32(txtSearch.Text)
                };
                DataTable dt = objLedger.Search();
                if(dt != null)
                {
                    objSale.SetDataSource(dt);
                    objView.crptViewer.ReportSource = objSale;
                    objView.WindowState = FormWindowState.Normal;
                    objView.ShowDialog();
                }
            }
        }
    }
}