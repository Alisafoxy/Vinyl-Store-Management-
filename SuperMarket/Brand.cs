using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SuperMarket
{
    public partial class Brand : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        DBconnection dbcon = new DBconnection();
        SqlDataReader dr;
        public Brand()
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.Myconnection());
            LoadBrand();
        }
        //Data Retrieve from tbBrand to dgvBrand on Brand form
        public void LoadBrand()
        {
            int i = 0;
            dgvBrand.Rows.Clear();
            cn.Open();
            cmd = new SqlCommand("SELECT * FROM tbBrand ORDER BY brand", cn);
            dr=cmd.ExecuteReader();
            while (dr.Read())
            {
                i++;
                dgvBrand.Rows.Add(i, dr["id"].ToString(), dr["brand"].ToString());
            }
            dr.Close();
            cn.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            BrandModule moduleForm=new BrandModule(this);
            moduleForm.ShowDialog();
        }

        private void dgvBrand_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //for updating or delete brand by cell from tbBrand
            string colName = dgvBrand.Columns[e.ColumnIndex].Name;
            if(colName == "Delete")
            {
                if (MessageBox.Show("Are you shure you want to Delete this brand?", "Delete Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cn.Open();
                    cmd = new SqlCommand("DELETE FROM tbBrand WHERE id LIKE '"+dgvBrand[1,e.RowIndex].Value.ToString()+"'",cn);
                    cmd.ExecuteNonQuery();
                    cn.Close();
                    MessageBox.Show("Brand has been successfuly deleted.", "Point Of Sales", MessageBoxButtons.OK,MessageBoxIcon.Information);                 
                }
            }
            else if(colName=="Edit")
            {
                BrandModule brandModule = new BrandModule(this);
                brandModule.lblId.Text = dgvBrand[1, e.RowIndex].Value.ToString();
                brandModule.txtBrandName.Text= dgvBrand[2, e.RowIndex].Value.ToString();
                brandModule.btnSave.Enabled = false;
                brandModule.btnUpdateBrandModule.Enabled = true;
                brandModule.ShowDialog();
            }
            LoadBrand();
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
