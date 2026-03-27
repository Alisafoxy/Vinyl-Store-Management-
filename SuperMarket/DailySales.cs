using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuperMarket
{
    public partial class DailySales : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        DBconnection dbcon = new DBconnection();
        SqlDataReader dr;
        public DailySales()
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.Myconnection());
            LoadCashier();
        }

        private void picClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        public void LoadCashier()
        {
            cmbCashier.Items.Clear();
            cmbCashier.Items.Add("All Cashier");
            cn.Open();
            cmd = new SqlCommand("SELECT * FROM tbUsers WHERE role LIKE 'Cashier'", cn);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                cmbCashier.Items.Add(dr["username"].ToString());
            }
            dr.Close();
            cn.Close();
        }
        public void LoadSold()
        {
            /*int i = 0;
            dgvSold.Rows.Clear();
            cn.Open();
            if (cmbCashier.Text == "All Cashier")
            {
                cmd = new SqlCommand("select c.id, c.transno, c.pcode, p.pdesc, c.price, c.qty, c.disc, c.total from tbCartCart as c inner join tbProduct as p on c.pcode = p.pcode where status like 'Sold' and sdate between '" + dtFrom.Value + "' and '" + dtTo.Value + "'", cn);
            }
            else
            {
                cmd = new SqlCommand("select c.id, c.transno, c.pcode, p.pdesc, c.price, c.qty, c.disc, c.total from tbCartCart as c inner join tbProduct as p on c.pcode = p.pcode where status like 'Sold' and sdate between '" + dtFrom.Value + "' and '" + dtTo.Value + "' and cashier like '" + cmbCashier.Text + "'", cn);
            }
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                i++;
                dgvSold.Rows.Add(i, dr["id"].ToString(), dr["transno"].ToString(), dr["pcode"].ToString(), dr["pdesc"].ToString(), dr["price"].ToString(), dr["qty"].ToString(), dr["disc"].ToString(), dr["total"].ToString());
            }
            dr.Close();
            cn.Close();*/
            int i = 0;
            dgvSold.Rows.Clear();
            double total = 0;

            try
            {
                cn.Open();

                if (cmbCashier.Text == "All Cashier")
                {
                    cmd = new SqlCommand(
                        "SELECT c.id, c.transno, c.pcode, p.pdesc, c.price, c.qty, c.disc, c.total " +
                        "FROM tbCartCart AS c " +
                        "INNER JOIN tbProduct AS p ON c.pcode = p.pcode " +
                        "WHERE c.status = @status AND c.sdate >= @dateFrom AND c.sdate < @dateTo", cn);
                }
                else
                {
                    cmd = new SqlCommand(
                        "SELECT c.id, c.transno, c.pcode, p.pdesc, c.price, c.qty, c.disc, c.total " +
                        "FROM tbCartCart AS c " +
                        "INNER JOIN tbProduct AS p ON c.pcode = p.pcode " +
                        "WHERE c.status = @status AND c.sdate >= @dateFrom AND c.sdate < @dateTo AND c.cashier = @cashier", cn);

                    cmd.Parameters.AddWithValue("@cashier", cmbCashier.Text);
                }

                cmd.Parameters.AddWithValue("@status", "Sold");
                cmd.Parameters.AddWithValue("@dateFrom", dtFrom.Value.Date);
                cmd.Parameters.AddWithValue("@dateTo", dtTo.Value.Date.AddDays(1));

                dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    i++;
                    total += double.Parse(dr["total"].ToString());
                    dgvSold.Rows.Add(
                        i,
                        dr["id"].ToString(),
                        dr["transno"].ToString(),
                        dr["pcode"].ToString(),
                        dr["pdesc"].ToString(),
                        dr["price"].ToString(),
                        dr["qty"].ToString(),
                        dr["disc"].ToString(),
                        dr["total"].ToString()
                    );
                }

                dr.Close();
                cn.Close();
                lblTotal.Text = total.ToString("#,#0.00");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cn.Close();
            }
        }

        private void cmbCashier_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadSold();
        }

        private void dtFrom_ValueChanged(object sender, EventArgs e)
        {
            LoadSold();
        }

        private void dtTo_ValueChanged(object sender, EventArgs e)
        {
            LoadSold();
        }

        private void DailySales_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {

            }
        }
    }
}
