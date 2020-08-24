﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using MetroFramework.Forms;
using CashandCarry.BL;
using CashandCarry.Manager;

namespace CashandCarry
{
    public partial class frmLogin : MetroForm
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
                DateTime RegDate = Convert.ToDateTime("08/24/2020");
                DateTime expDate = Convert.ToDateTime("10/24/2020");
                DateTime currentDate=Convert.ToDateTime(DateTime.Now.ToShortDateString());
                TimeSpan t = expDate - currentDate;
                double nrofDays = t.TotalDays;
                if(nrofDays>0)
                {
                    EmployeeBL objemp = new EmployeeBL()
                    {
                        Username = txtusername.Text,
                        Password = txtpassword.Text
                    };
                    var dt = objemp.ForLogin();
                    if (dt != null)
                    {
                        int LoginType = Convert.ToInt32(dt.LoginTypeID);
                        string Name = Convert.ToString(dt.Name);
                        Properties.Settings.Default.Name = Name;
                        LoginInfoBL.Name = Convert.ToString(dt.Name);
                        this.Hide();
                        if (LoginType == 1)
                        {
                            frmStartup objstart = new frmStartup();
                            objstart.Show();
                        }
                        else if (LoginType == 2)
                        {
                            FrmOperater objope = new FrmOperater();
                            objope.Show();
                        }

                    }
                    else
                    {
                        MessageBox.Show("Invalid Username Or Password ", "Altert");
                        txtpassword.Clear();
                    }
                }
              
                else
                {
                    MessageBox.Show("Your software is expired.Please contact your software prodiver for renewal. ");
                }
                


            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
