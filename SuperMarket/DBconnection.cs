using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace SuperMarket
{
    internal class DBconnection
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        private string _connectionString;
        SqlDataReader dr;
        public string Myconnection()
        {
            _connectionString = "server=DESKTOP-UE89UBA\\SQLEXPRESS;database=DBPOSales;Integrated Security=SSPI;";
            return _connectionString;
        }
        public DataTable getTable(string qury)
        {
            cn.ConnectionString = Myconnection();
            cmd = new SqlCommand(qury, cn);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
        public void ExecuteQuery(String sql)
        {
            try
            {
                cn.ConnectionString = Myconnection();
                cn.Open();
                cmd = new SqlCommand(sql, cn);
                cmd.ExecuteNonQuery();
                cn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public String getPassword(string username)
        {
            string password = "";
            cn.ConnectionString = Myconnection();
            cn.Open();
            cmd = new SqlCommand("SELECT password FROM tbUsers WHERE username = '" + username + "'", cn);
            dr = cmd.ExecuteReader();
            dr.Read();
            if (dr.HasRows)
            {
                password = dr["password"].ToString();
            }
            dr.Close();
            cn.Close();
            return password;
        }

    }
}
    