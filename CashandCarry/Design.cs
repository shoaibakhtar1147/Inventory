using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CashandCarry
{
    class Design
    {
        
        public void Designform(Form frm)
        {
            foreach (Control control in frm.Controls)
            {
                if (control is TextBox)
                {
                    control.Height = 23;
                    control.Width = 184;
                    control.Font = new Font("Century Gothic", 10, FontStyle.Bold);

                }
                else if (control is Label)
                {
                    control.Height = 19;
                    control.Width = 91;
                    control.Font = new Font("Century Gothic", 12, FontStyle.Bold);
                }
                else if (control is Button)
                {
                    control.Height = 40;
                    control.Width = 120;
                    control.BackColor = Color.FromArgb(52, 73, 94);
                    control.ForeColor = Color.WhiteSmoke;
                }
            }

        }

       

    }

}
 
       
  
