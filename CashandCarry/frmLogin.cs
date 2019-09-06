using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CashandCarry
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        
        private void frmLogin_Load(object sender, EventArgs e)
        {
            Design obj = new Design();
            obj.Designform(this);
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            try
            {
                string constring = @"Data Source=SHOAIB-PC\SQLEXPRESS;Database=CashCarry;integrated security=true;";
                SqlConnection con = new SqlConnection(constring);
                string query = "select * from tbl_Login where Username='" + txtusername.Text + "' and Password='" + txtpassword.Text + "'";
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataAdapter adt = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adt.Fill(ds);
                DataTable dt = ds.Tables[0];
                if (dt != null && dt.Rows.Count > 0)
                {
                    int LoginType = Convert.ToInt32(dt.Rows[0]["LoginType"]);
                    this.Hide();
                    if (LoginType == 1)
                    {
                        frmStartup objstart = new frmStartup();
                        objstart.Show();
                    }
                    else
                    {
                        MessageBox.Show("Invalid Information", "Altert");
                    }

                }


            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
