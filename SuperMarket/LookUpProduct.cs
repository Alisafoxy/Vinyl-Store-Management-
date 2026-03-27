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
    public partial class LookUpProduct : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        DBconnection dbcon = new DBconnection();
        SqlDataReader dr;
        string stitle = "Point of Sales";
        Cachier1 cachier1;
        public LookUpProduct(Cachier1 cach)
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.Myconnection());
            cachier1 = cach;
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
            cmd = new SqlCommand("SELECT p.pcode, p.barcode, p.pdesc, b.brand, c.category, p.price, p.qty FROM tbProduct AS p INNER JOIN tbBrand AS b on b.id=p.bid INNER JOIN tbCategory AS c on c.id=p.cid WHERE CONCAT( p.pdesc, b.brand, c.category) LIKE'%" + txtSearch.Text + "%'", cn);
            cn.Open();
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                i++;
                dgvProduct.Rows.Add(i, dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString(), dr[5].ToString(), dr[6].ToString());
            }
            dr.Close();
            cn.Close();

        }

        private void dgvProduct_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
                return;


            string colName= dgvProduct.Columns[e.ColumnIndex].Name;

            if(colName =="Select")
            {
                if (dgvProduct.Rows[e.RowIndex].Cells[7].Value == null ||
                string.IsNullOrWhiteSpace(dgvProduct.Rows[e.RowIndex].Cells[7].Value.ToString()))
                {
                    dgvProduct.Rows[e.RowIndex].Cells[7].Value = 0;
                }

                Qty qty = new Qty(cachier1);
                qty.ProductDetails(dgvProduct.Rows[e.RowIndex].Cells[1].Value.ToString(), double.Parse(dgvProduct.Rows[e.RowIndex].Cells[6].Value.ToString()), cachier1.lblTranNo.Text, int.Parse(dgvProduct.Rows[e.RowIndex].Cells[7].Value.ToString()));
                
                qty.ShowDialog();
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            LoadProduct();
        }

        private void LookUpProduct_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Escape)
            {
                this.Dispose();
            }
        }
    }
}
