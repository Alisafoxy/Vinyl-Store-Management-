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
    public partial class Supplier : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        DBconnection dbcon = new DBconnection();
        SqlDataReader dr;
        public Supplier()
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.Myconnection());
            LoadSupplier();
        }

        public void LoadSupplier()
        {
            dgvSupplier.Rows.Clear();
            int i = 0;
            cn.Open();
            cmd = new SqlCommand("SELECT * FROM tbSupplier", cn);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                i++;
                dgvSupplier.Rows.Add(i, dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString(), dr[5].ToString(), dr[6].ToString());
            }
            dr.Close();
            cn.Close();
        }
            
        private void Supplier_Load(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            SupplierModule supplierModule = new SupplierModule(this);
            supplierModule.ShowDialog();
        }

        private void btnAdd_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Shift && e.KeyCode == Keys.Oemplus)
            {
                btnAdd_Click(sender, e);
            }
        }

        private void dgvSupplier_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = dgvSupplier.Columns[e.ColumnIndex].Name;
            if(colName =="Edit")
            {
                SupplierModule supplierModule = new SupplierModule(this);
                supplierModule.lblId.Text = dgvSupplier.Rows[e.RowIndex].Cells[1].Value.ToString();
                supplierModule.txtSupplierName.Text = dgvSupplier.Rows[e.RowIndex].Cells[2].Value.ToString();
                supplierModule.txtAddress.Text = dgvSupplier.Rows[e.RowIndex].Cells[3].Value.ToString();
                supplierModule.txtContactP.Text = dgvSupplier.Rows[e.RowIndex].Cells[4].Value.ToString();
                supplierModule.txtPhone.Text = dgvSupplier.Rows[e.RowIndex].Cells[5].Value.ToString();
                supplierModule.txtEmail.Text = dgvSupplier.Rows[e.RowIndex].Cells[6].Value.ToString();
                supplierModule.txtFax.Text = dgvSupplier.Rows[e.RowIndex].Cells[7].Value.ToString();

                supplierModule.btnSave.Enabled = false;
                supplierModule.btnUpdateModule.Enabled = true;
                supplierModule.ShowDialog();
            }
            else if(colName =="Delete")
            {
                if (MessageBox.Show("Are you shure you want to Delete this category?", "Delete Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cn.Open();
                    cmd = new SqlCommand("DELETE FROM tbProduct WHERE pcode LIKE '" + dgvSupplier[1, e.RowIndex].Value.ToString() + "'", cn);
                    cmd.ExecuteNonQuery();
                    cn.Close();
                    MessageBox.Show("Product has been successfuly deleted.", "Point Of Sales", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            LoadSupplier();
        }
    }
}
