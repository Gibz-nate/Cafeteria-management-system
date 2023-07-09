using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace CAFETARIA_MANAGEMENT
{
    
    class function
    {
        protected SqlConnection getConnetion()
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDb)\LocalDBCafe;Initial Catalog=MUT;Integrated Security=True");
            
            return con;

        }
        public DataSet getData(string query)
        {
            SqlConnection con = getConnetion();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = query;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;
        }

        public void setData  (string query)
        {
            SqlConnection con = getConnetion();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            con.Open();
            cmd.CommandText = query;
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Data processed succesfully.", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


      
        
        
       
  
    }
}
