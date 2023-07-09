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
    public partial class UC_Addmeals : UserControl
    {
        function fn = new function();
        string query;


        public UC_Addmeals()
        {
            InitializeComponent();
        }

        private void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAddmeal_Click(object sender, EventArgs e)
        {
            
            query = "insert into Meals (names,category,price) values('"+txtMealname.Text+"','"+txtCategory.Text+"',"+txtPrice.Text+")";
            fn.setData(query);
            clearAll();

        }

        public void clearAll()
        {
            txtCategory.SelectedIndex = -1;
            txtMealname.Clear();
            txtPrice.Clear();

        }

        private void UC_Addmeals_Load(object sender, EventArgs e)
        {
            
        }

        private void UC_Addmeals_Leave(object sender, EventArgs e)
        {
            clearAll();
        }
    }
}
