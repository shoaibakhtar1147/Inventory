using CashandCarry.BL;
using CashandCarry.Reports;
using CashandCarry.Reports.SaleReturn;
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
    public partial class FrmsalReturn : MetroForm
    {
        public FrmsalReturn()
        {
            InitializeComponent();
        }

        private void FrmSaleReturn_Load(object sender, EventArgs e)
        {

        }

        private void crptViewerSale_Load(object sender, EventArgs e)
        {

        }

        private void btnCusID_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(txtRinvoiceNo.Text))
            {
                SaleReturnReport objRet = new SaleReturnReport();
                rptViewer objView=new rptViewer();
                objRet.SetParameterValue("@RinvoiceNo", txtRinvoiceNo.Text);
                ReturnSaleBL obj = new ReturnSaleBL() 
                {
                 RInvoice=Convert.ToInt32(txtRinvoiceNo.Text)
                };
                DataTable dt = obj.Select();
                if(dt.Rows.Count>0)
                {
                    objRet.SetDataSource(dt);

                    objView.crptViewer.ReportSource = objRet;
                    objView.WindowState = FormWindowState.Maximized;
                    objView.ShowDialog();
                    //crptViewerReturn.ReportSource = objRet;
                    txtRinvoiceNo.Clear();
                }
                else
                {
                    MessageBox.Show("No Record Found");
                }
                
            }
            else if (!string.IsNullOrEmpty(txtCus.Text))
            {
                ReturnByCusReport objCus = new ReturnByCusReport();
                rptViewer objView = new rptViewer();
                objCus.SetParameterValue("@CusID", txtCus.Text);
                    ReturnSaleBL obj = new ReturnSaleBL() 
                    {
                    CustomerID=Convert.ToInt32(txtCus.Text)
                    };
                    DataTable dt = obj.SelectByCus();
                    if(dt.Rows.Count>0)
                    {
                        objCus.SetDataSource(dt);
                        objView.crptViewer.ReportSource = objCus;
                        objView.WindowState = FormWindowState.Normal;
                        objView.ShowDialog();
                        txtCus.Clear();    
                    }
                else
                    {
                        MessageBox.Show("No Record Found");
                    }
                 
            }
           
                //crptViewerReturn.ReportSource = objCus;
                
        else
            {
                MessageBox.Show("Please Enter Customer ID OR Return Invoice");
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            SaleReturnGeneralReport objGen = new SaleReturnGeneralReport();
            rptViewer objView = new rptViewer();
            objGen.SetParameterValue("@MinDate", txtMinDate.Text);
            objGen.SetParameterValue("@MaxDate", txtmaxdate.Text);
            ReturnSaleBL obj = new ReturnSaleBL()
            {
                mindate = Convert.ToDateTime(txtMinDate.Text),
                maxdate = Convert.ToDateTime(txtmaxdate.Text)
            };
            DataTable dt = obj.SelectDateDiff();
            if (dt.Rows.Count > 0)
            {
                objGen.SetDataSource(dt);

                objView.crptViewer.ReportSource = objGen;
                objView.WindowState = FormWindowState.Maximized;
                objView.ShowDialog();
             
            }
               //crptViewerReturn.ReportSource = objGen;
            else
            {
                MessageBox.Show("No Record Found");
            }
        }
    }
}
