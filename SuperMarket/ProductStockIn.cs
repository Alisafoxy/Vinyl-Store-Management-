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
    public partial class ProductStockIn : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        DBconnection dbcon = new DBconnection();
        SqlDataReader dr;
        SrockIn stockIn;
        string sTitle = "Point of Sales";
        public ProductStockIn(SrockIn s)
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.Myconnection());
            stockIn = s;
            LoadProduct();

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        public void LoadProduct()
        {
            int i = 0;
            dgvProduct.Rows.Clear();
            cmd = new SqlCommand("SELECT pcode,pdesc,qty FROM tbProduct WHERE pdesc LIKE'%" + txtSearch.Text + "%'", cn);
            cn.Open();
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                i++;
                dgvProduct.Rows.Add(i, dr[0].ToString(), dr[1].ToString(), dr[2].ToString());
            }
            dr.Close();
            cn.Close();
        }

        private void dgvProduct_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = dgvProduct.Columns[e.ColumnIndex].Name;
            if (colName == "Select")
            {
                if(stockIn.txtSrockInBy.Text==string.Empty)

                {
                    MessageBox.Show("Please enter stock in by name", sTitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    
                    stockIn.txtSrockInBy.Focus();
                    this.Dispose();
                    return;
                }
                if (MessageBox.Show("Add this item?", sTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        cn.Open();
                        cmd = new SqlCommand("INSERT INTO tbStockIn1(refno,pcode,sdate,stockinby,supplierid)VALUES(@refno,@pcode,@sdate,@stockinby,@supplierid)", cn);
                        cmd.Parameters.AddWithValue("@refno", stockIn.txtRefNo.Text);
                        cmd.Parameters.AddWithValue("@pcode", dgvProduct.Rows[e.RowIndex].Cells[1].Value.ToString());
                        cmd.Parameters.AddWithValue("@sdate", stockIn.dateStockIn.Value);
                        cmd.Parameters.AddWithValue("@stockinby", stockIn.txtSrockInBy.Text);
                        cmd.Parameters.AddWithValue("@supplierid", stockIn.lblId.Text);
                        cmd.ExecuteNonQuery();
                        cn.Close();
                        stockIn.LoadStockIn();
                        MessageBox.Show("Succeessfully Added", sTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch(Exception ex) 
                    {
                        MessageBox.Show(ex.Message, sTitle);
                    }
                }
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            LoadProduct();
        }
    }
}
