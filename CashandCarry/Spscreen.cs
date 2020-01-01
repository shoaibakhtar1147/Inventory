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

namespace CashandCarry
{
    public partial class Spscreen : MetroForm
    {
        public Spscreen()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Spscreen_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
        int i = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (progressBar1.Value < 100)
            {
                progressBar1.Value += 10;
                i+=10;
                lblcount.Text = Convert.ToString(i);
            }
            else
            {
                timer1.Stop();
                this.Hide();
                frmLogin obj = new frmLogin();
                obj.Show();

            }
        }


    }
}

        

