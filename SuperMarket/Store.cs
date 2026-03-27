using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuperMarket
{
    public partial class Store : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        DBconnection dbcon = new DBconnection();
        SqlDataReader dr;
        Cachier1 cachier1;
        bool havestoreinfo = false;
        string sTitle = "Point of Sales";
        public Store()
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.Myconnection());
            LoadStore();
        }
        public void LoadStore()
        {
            try
            {
                cn.Open();
                cmd = new SqlCommand("SELECT * FROM tbStore", cn);
                dr = cmd.ExecuteReader();
                dr.Read();
                if (dr.HasRows)
                {
                    havestoreinfo = true;
                    txtStName.Text = dr["store"].ToString();
                    txtAddress.Text = dr["address"].ToString();
                }
                else
                {
                    txtStName.Clear();
                    txtAddress.Clear();
                }
                dr.Close();
                cn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Save store details?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    if (havestoreinfo)
                    {
                        dbcon.ExecuteQuery("UPDATE tbStore SET store = '" + txtStName.Text + "', address= '" + txtAddress.Text + "'");
                    }
                    else
                    {
                        dbcon.ExecuteQuery("INSERT INTO tbStore (store,address) VALUES ('" + txtStName.Text + "','" + txtAddress.Text + "')");
                    }
                MessageBox.Show("Store detail has been successfully saved!", "Save Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void Store_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            { this.Dispose(); }
        }
    }
}
