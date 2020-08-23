using CashandCarry.BL;
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
            LoadCus();
            LoadRoute();
            //LoadSubZone();
        }

        //private void LoadSubZone()
        //{
        //    SubZoneBL objZone = new SubZoneBL();
        //    var dt = objZone.Select();
        //    txtSubZone.DataSource = dt;
        //    txtSubZone.AutoCompleteMode = AutoCompleteMode.Suggest;
        //    txtSubZone.AutoCompleteSource = AutoCompleteSource.ListItems;
        //    txtSubZone.DisplayMember = "SubRouteName";
        //    txtSubZone.ValueMember = "SubRouteId";
        //    txtSubZone.Text = "---Select---";


        //}

        private void LoadCus()
        {
            CustomerBL objCus = new CustomerBL();
            var dt = objCus.Select();
            txtCusName.DataSource = dt;
            txtCusName.AutoCompleteMode = AutoCompleteMode.Suggest;
            txtCusName.AutoCompleteSource = AutoCompleteSource.ListItems;
            txtCusName.DisplayMember = "Name";
            txtCusName.ValueMember = "CustomerID";
            txtCusName.Text = "---Select---";

        }

        private void LoadRoute()
        {
            ZoneBL obj=new ZoneBL();
            var dt=obj.Select();
             txtRoute.DataSource = dt;
            txtRoute.AutoCompleteMode = AutoCompleteMode.Suggest;
            txtRoute.AutoCompleteSource = AutoCompleteSource.ListItems;
            txtRoute.DisplayMember = "ZoneName";
            txtRoute.ValueMember = "ZoneId";
            txtRoute.Text = "---Select---";
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
            dgvLedger.DataSource = null;
            if (txtCusName.Text != "---Select---")
            {
                SaleLedgerBL objLedger = new SaleLedgerBL()
                {
                    CustomerID = Convert.ToInt32(txtCusName.SelectedValue)
                };
                var dt = objLedger.search();
                if (dt != null)
                {
                    dgvLedger.DataSource = dt;
                    this.dgvLedger.Columns["STid"].Visible = false;

                }
                else
                {
                    MessageBox.Show("No Record Found " + txtCusName.Text);
                }
            }
            
           
            else
                {
                    MessageBox.Show("Please Select Customer Name");
                }
           

            

        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            if(txtCusName.Text=="---Select---")
            {
                MessageBox.Show("Please Enter Customer Name");
            }
            else if(dgvLedger.DataSource != null)
            {
                SaleLedgerReport objSale = new SaleLedgerReport();
                rptViewer objView = new rptViewer();
                objSale.SetParameterValue("@CustomerID", txtCusName.SelectedValue);
                SaleLedgerBL objLedger = new SaleLedgerBL() 
                {
                CustomerID=Convert.ToInt32(txtCusName.SelectedValue)
                };
                DataTable dt = objLedger.Search();
                if(dt != null)
                {
                    objSale.SetDataSource(dt);
                    objView.crptViewer.ReportSource = objSale;
                    objView.WindowState = FormWindowState.Maximized;
                    objView.ShowDialog();
                    LoadCus();
                }
                
            }
            else if (dgvLedger.DataSource == null)
            {
                MessageBox.Show("No Record Showed");
            }
        }

        private void txtCusName_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        

        private void btnRouteSearch_Click(object sender, EventArgs e)
        {
            dgvLedger.DataSource=null;
            if (txtRoute.Text != "---Select---")
            {
                CustomerBL objLedger = new CustomerBL()
                {
                    ZoneID = Convert.ToInt32(txtRoute.SelectedValue)
                };
                var dt = objLedger.SearchByZone();
                if (dt != null)
                {
                    dgvLedger.DataSource = dt;
                    

                }
                else
                {
                    MessageBox.Show("No Record Found " + txtRoute.Text);
                }
            }


            else
            {
                MessageBox.Show("Please Select Route Name");
            }
           

           
        }

        private void btnPrintRoute_Click(object sender, EventArgs e)
        {
            if (txtRoute.Text == "---Select---")
            {
                MessageBox.Show("Please Enter Route Name");
            }
            else if (dgvLedger.DataSource != null)
            {
                SaleLedgerByRoute objSale = new SaleLedgerByRoute();
                rptViewer objView = new rptViewer();
                objSale.SetParameterValue("@ZoneId", txtRoute.SelectedValue);
                SaleLedgerBL objLedger = new SaleLedgerBL()
                {
                    ZoneId = Convert.ToInt32(txtRoute.SelectedValue)
                };
                DataTable dt = objLedger.SearchByRoute();
                if (dt != null)
                {
                    objSale.SetDataSource(dt);
                    objView.crptViewer.ReportSource = objSale;
                    objView.WindowState = FormWindowState.Maximized;
                    objView.ShowDialog();
                    LoadRoute();
                }

            }
            else if (dgvLedger.DataSource == null)
            {
                MessageBox.Show("No Record Showed");
            }
        }
    }
}
