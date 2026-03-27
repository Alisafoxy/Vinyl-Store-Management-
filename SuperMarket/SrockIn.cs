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
    public partial class SrockIn : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        DBconnection dbcon = new DBconnection();
        string sTitle = "Point of Sales";
        SqlDataReader dr;

        public SrockIn()
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.Myconnection());
            LoadSupplier();
            GetRefNo();
        }

        public void GetRefNo()
        {
            Random rnd = new Random();
            txtRefNo.Clear();
            txtRefNo.Text += rnd.Next();
        }

        public void LoadSupplier()
        {
            cbSupplier.Items.Clear();
            cbSupplier.DataSource = dbcon.getTable("SELECT * FROM tbSupplier");
            cbSupplier.DisplayMember = "supplier";
        }
        public void LoadStockIn()
        {
            int i = 0; 
            dgvStockIn.Rows.Clear();
            cn.Open();
            cmd = new SqlCommand("SELECT * FROM vwStockIn WHERE refno LIKE'" + txtRefNo.Text + "' AND status LIKE 'Pending'",cn);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                i++;
                dgvStockIn.Rows.Add(i, dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString(), dr[5].ToString(), dr[6].ToString(), dr[7].ToString());
            }
            dr.Close();
            cn.Close();
        }

        private void cbSupplier_SelectedIndexChanged(object sender, EventArgs e)
        {
            cn.Open();
            cmd = new SqlCommand("SELECT * FROM tbSupplier WHERE supplier LIKE'"+cbSupplier.Text+"'", cn);
            dr= cmd.ExecuteReader();
            dr.Read();
            if(dr.HasRows)
            {
                lblId.Text = dr["id"].ToString();
                txtConPer.Text = dr["contactperson"].ToString();
                txtAddress.Text = dr["address"].ToString();
            }
            dr.Close();
            cn.Close();
        }

        private void cbSupplier_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void LinGenerate_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            GetRefNo();
        }

        private void linkProduct_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ProductStockIn productStock = new ProductStockIn(this);
            productStock.ShowDialog();
        }

        private void btnEntry_Click(object sender, EventArgs e)
        {
            try
            {
                if(dgvStockIn.Rows.Count>0)
                {
                    if (MessageBox.Show("Are you sure you want to save this records", sTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        for (int i = 0; i < dgvStockIn.Rows.Count; i++)
                        {
                            //update product quantity
                            cn.Open();
                            cmd =new SqlCommand("UPDATE tbProduct SET qty = qty+ " + int.Parse(dgvStockIn.Rows[i].Cells[5].Value.ToString()) + "WHERE pcode LIKE '" + dgvStockIn.Rows[i].Cells[3].Value.ToString() + "'" ,cn);
                            cmd.ExecuteNonQuery();
                            cn.Close();
                            //update product quantity

                            cn.Open();
                            cmd = new SqlCommand("UPDATE tbStockIn1 SET qty = qty+ " + int.Parse(dgvStockIn.Rows[i].Cells[5].Value.ToString()) + "WHERE pcode LIKE '" + dgvStockIn.Rows[i].Cells[3].Value.ToString() + "'", cn);
                            cmd.ExecuteNonQuery();
                            cn.Close();
                        }
                    }
                    Clear();
                    LoadStockIn();
                }
                
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message,sTitle ,MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }
        public void Clear ()
        {
            txtRefNo.Clear();
            txtSrockInBy.Clear();
            dateStockIn.Value = DateTime.Now;
        }

        private void dgvStockIn_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = dgvStockIn.Columns[e.ColumnIndex].Name;
            if (colName == "Delete")
            {
                
                if (MessageBox.Show("Remove this item?", sTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    
                    cn.Open();
                    cmd = new SqlCommand("DELETE FROM tbStockIn1 WHERE id='" + dgvStockIn.Rows[e.RowIndex].Cells[1].Value.ToString() + "'", cn);
                    cmd.ExecuteNonQuery();
                    cn.Close();
                    MessageBox.Show("Iten has been successfully removed", sTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadStockIn();
                }
            }
        }
    }
}
