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
    public partial class CategoryModule : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        DBconnection dbcon = new DBconnection();
        Category category;
        public CategoryModule(Category cat)
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.Myconnection());
            category = cat;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void btnUpdateCatModule_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you shure you want to update this category?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                cn.Open();
                cmd = new SqlCommand("UPDATE tbCategory SET category = @category WHERE id LIKE'" + lblId.Text + "'", cn);
                cmd.Parameters.AddWithValue("@category", txtCategoryName.Text);
                cmd.ExecuteNonQuery();
                cn.Close();
                MessageBox.Show("Category has been successfuly updated.", "Point Of Sales");
                Clear();
                this.Dispose();//to close this form after update data
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //To Insert Brand Name to tbBrand
            try
            {
                if (MessageBox.Show("Are you shure you want to save this category?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cn.Open();
                    cmd = new SqlCommand("INSERT INTO tbCategory(category)VALUES(@category)", cn);
                    cmd.Parameters.AddWithValue("@category", txtCategoryName.Text);
                    cmd.ExecuteNonQuery();
                    cn.Close();
                    MessageBox.Show("Category has been successfuly saved.", "Point of Sales");
                    Clear();
                    
                }
                category.LoadCategory();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}");
            }
        }
        public void Clear()
        {
            txtCategoryName.Clear();
            btnUpdateCatModule.Enabled = false;
            btnSave.Enabled = true;
            txtCategoryName.Focus();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
