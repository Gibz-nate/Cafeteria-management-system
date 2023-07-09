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
    public partial class UC_UpdateMeals : UserControl
    {
        function fn = new function();
        string query;
        public UC_UpdateMeals()
        {
            InitializeComponent();
        }

        private void UC_UpdateMeals_Load(object sender, EventArgs e)
        {
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
            query = "select * from Meals where names like '" + txtSearch.Text + "%'";
            DataSet ds = fn.getData(query);
            guna2DataGridView1.DataSource = ds.Tables[0];
        }

        int id;
        private void guna2DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id = int.Parse(guna2DataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            string category = guna2DataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            string name = guna2DataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            int price = int.Parse(guna2DataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString());


            txtUpdateCategory.Text = category;
            txtUpdateMeal.Text = name;
            txtUpdatePrice.Text = price.ToString();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            query = "update Meals set names='" + txtUpdateMeal.Text + "',category = '" + txtUpdateCategory.Text + "',price=" + txtUpdatePrice.Text + "where iid= " + id + "";
            fn.setData(query);
            loadData();

            txtUpdateMeal.Clear();
            txtUpdateCategory.Clear();
            txtUpdatePrice.Clear();
        }
    }
}
