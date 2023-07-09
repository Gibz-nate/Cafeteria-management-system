using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CAFETARIA_MANAGEMENT.AllUserControls
{
    public partial class UC_welcome : UserControl
    {
        public UC_welcome()
        {
            InitializeComponent();
        }

        int num = 0;

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(num==0)
            {
                lblBanner.Location = new Point(157,365);
                lblBanner.ForeColor = Color.Green;
                num++;


            }
            else if(num==1)
            {
                lblBanner.Location = new Point(157, 365);
                lblBanner.ForeColor = Color.Orange;
                num++;
            }
            else if(num==2)
            {
                lblBanner.Location = new Point(157, 365);
                lblBanner.ForeColor = Color.Red;
                num = 0;

            }

        }

        private void UC_welcome_Load(object sender, EventArgs e)
        {
            timer1.Start();

        }
    }
}
