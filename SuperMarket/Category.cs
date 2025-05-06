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
    public partial class Category : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        DBconnection dbcon = new DBconnection();
        SqlDataReader dr;
        public Category()
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.Myconnection());
            LoadCategory();
        }
        //Data Retrieve from tbCategory to dgvCategory on Category form
        public void LoadCategory()
        {
            int i = 0;
            dgvCategory.Rows.Clear();
            cn.Open();
            cmd = new SqlCommand("SELECT * FROM tbCategory ORDER BY category", cn);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                i++;
                dgvCategory.Rows.Add(i, dr["id"].ToString(), dr["category"].ToString());
            }
            dr.Close();
            cn.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            CategoryModule moduleForm = new CategoryModule(this);
            moduleForm.ShowDialog();
        }

        private void dgvCategory_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //for updating or delete brand by cell from tbBrand
            string colName = dgvCategory.Columns[e.ColumnIndex].Name;
            if (colName == "Delete")
            {
                if (MessageBox.Show("Are you shure you want to Delete this category?", "Delete Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cn.Open();
                    cmd = new SqlCommand("DELETE FROM tbCategory WHERE id LIKE '" + dgvCategory[1, e.RowIndex].Value.ToString() + "'", cn);
                    cmd.ExecuteNonQuery();
                    cn.Close();
                    MessageBox.Show("Category has been successfuly deleted.", "Point Of Sales", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else if (colName == "Edit")
            {
                CategoryModule categoryModule = new CategoryModule(this);
                categoryModule.lblId.Text = dgvCategory[1, e.RowIndex].Value.ToString();
                categoryModule.txtCategoryName.Text = dgvCategory[2, e.RowIndex].Value.ToString();
                categoryModule.btnSave.Enabled = false;
                categoryModule.btnUpdateCatModule.Enabled = true;
                categoryModule.ShowDialog();
            }
            LoadCategory();
        }

        private void btnAdd_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Shift && e.KeyCode == Keys.Oemplus)
            {
                btnAdd_Click(sender, e);
            }
        }
    }
}
