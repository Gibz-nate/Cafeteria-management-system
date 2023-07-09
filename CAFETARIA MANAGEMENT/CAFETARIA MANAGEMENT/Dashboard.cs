using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CAFETARIA_MANAGEMENT
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }
        public Dashboard(String user)
        {
            InitializeComponent();

            if (user == "Guest")
            {
                btnAdd.Hide();
                btnUpdate.Hide();
                btnRemove.Hide();

            }
            else if(user == "Admin")
            {
                btnAdd.Show();
                btnUpdate.Show();
                btnRemove.Show();

            }
        }
        //This hides the contents of the buttons when on the welcome screen//
        private void Dashboard_Load(object sender, EventArgs e)
        {
            uC_Addmeals1.Visible = false;
            uC_Makesale1.Visible = false;
            uC_UpdateMeals1.Visible = false;
            uC_RemoveMeals1.Visible = false;
            
        }

        private void linkLogOut_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LoginPage fm = new LoginPage();
            this.Hide();
            fm.Show();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            uC_Addmeals1.Visible = true;
            uC_Addmeals1.BringToFront();

        }

        private void btnMake_Click(object sender, EventArgs e)
        {
            uC_welcome1.SendToBack();
            guna2Transition1.ShowSync(uC_Makesale1);
            uC_Makesale1.Visible = true;
            uC_Makesale1.BringToFront();
            
        }

        private void uC_Makesale1_Load(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            uC_UpdateMeals1.Visible = true;
            uC_UpdateMeals1.BringToFront();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            uC_RemoveMeals1.Visible = true;
            uC_RemoveMeals1.BringToFront();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
