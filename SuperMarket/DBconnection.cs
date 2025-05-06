using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SuperMarket
{
    internal class DBconnection
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        private string _connectionString;
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

    }
}
    