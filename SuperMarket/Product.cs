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
    public partial class Product : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        DBconnection dbcon = new DBconnection();
        SqlDataReader dr;
        public Product()
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.Myconnection());
            LoadProduct();
        }

        public void LoadProduct()
        {
            int i = 0;
            dgvProduct.Rows.Clear();
            cmd=new SqlCommand("SELECT p.pcode, p.barcode, p.pdesc, b.brand, c.category, p.price, p.reorder FROM tbProduct AS p INNER JOIN tbBrand AS b on b.id=p.bid INNER JOIN tbCategory AS c on c.id=p.cid WHERE CONCAT( p.pdesc, b.brand, c.category) LIKE'%" + txtSearch.Text+"%'", cn);
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

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ProductModule productModule = new ProductModule(this);
            productModule.ShowDialog();
        }

        private void btnAdd_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Shift && e.KeyCode == Keys.Oemplus)
            {
                btnAdd_Click(sender, e);
            }
        }

        private void dgvProduct_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = dgvProduct.Columns[e.ColumnIndex].Name;
            if(colName=="Edit")
            {
                ProductModule product=new ProductModule(this);
                product.txtProductCode.Text = dgvProduct.Rows[e.RowIndex].Cells[1].Value.ToString();
                product.txtBarcode.Text = dgvProduct.Rows[e.RowIndex].Cells[2].Value.ToString();
                product.txtDescription.Text = dgvProduct.Rows[e.RowIndex].Cells[3].Value.ToString();
                product.cmbBrand.Text = dgvProduct.Rows[e.RowIndex].Cells[4].Value.ToString();
                product.cmbCategory.Text = dgvProduct.Rows[e.RowIndex].Cells[5].Value.ToString();
                product.txtPrice.Text = dgvProduct.Rows[e.RowIndex].Cells[6].Value.ToString();
                product.numUpDReOrder.Value = int.Parse(dgvProduct.Rows[e.RowIndex].Cells[7].Value.ToString());

                product.txtProductCode.Enabled = false;
                product.btnSave.Enabled = false;
                product.btnUpdateModule.Enabled = true;
                product.ShowDialog();

            }
            else if (colName == "Delete")
            {
                if (MessageBox.Show("Are you shure you want to Delete this category?", "Delete Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                   cn.Open();
                   cmd = new SqlCommand("DELETE FROM tbProduct WHERE pcode LIKE '" + dgvProduct[1, e.RowIndex].Value.ToString() + "'", cn);
                   cmd.ExecuteNonQuery();
                   cn.Close();
                   MessageBox.Show("Product has been successfuly deleted.", "Point Of Sales", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            LoadProduct();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            LoadProduct();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtSearch_Click(object sender, EventArgs e)
        {

        }

        private void lblManageBrand_Click(object sender, EventArgs e)
        {

        }
    }
}
