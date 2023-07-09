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
    public partial class UC_RemoveMeals : UserControl
    {
        function fn = new function();
        string query;
        public UC_RemoveMeals()
        {
            InitializeComponent();
        }

        private void UC_RemoveMeals_Load(object sender, EventArgs e)
        {
            lbldel.Text = "How to delete?";
            lbldel.ForeColor = Color.Blue;
            loadData();
        }
        public void loadData()
        {
            query = "select * from Meals";
            DataSet ds = fn.getData(query);
            guna2DataGridView1.DataSource = ds.Tables[0];
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            query = "select * from Meals where names like'" + txtSearch.Text + "%'";
            DataSet ds = fn.getData(query);
            guna2DataGridView1.DataSource = ds.Tables[0];
        }

        private void guna2DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (MessageBox.Show("Delete Meal?", "important message", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK) ;
            {
                int id = int.Parse(guna2DataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
                query = "delete from Meals where iid = " + id + "";
                fn.setData(query);
                loadData();
            }

        }

        private void lbldel_Click(object sender, EventArgs e)
        {
            lbldel.ForeColor = Color.Red;
            lbldel.Text = "*Click on Row to delete the Meal.";
        }

        private void UC_RemoveMeals_Enter(object sender, EventArgs e)
        {
            loadData();
        }
    }
}
