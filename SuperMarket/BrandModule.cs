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
    public partial class BrandModule : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        DBconnection dbcon = new DBconnection();
        Brand brand;
        public BrandModule(Brand br)
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.Myconnection());
            brand = br;
        }

        private void picClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //To Insert Brand Name to tbBrand
            try
            {
                if(MessageBox.Show("Are you shure you want to save this brand?","",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
                {
                    cn.Open();
                    cmd = new SqlCommand("INSERT INTO tbBrand(brand)VALUES(@brand)", cn);
                    cmd.Parameters.AddWithValue("@brand", txtBrandName.Text);
                    cmd.ExecuteNonQuery();
                    cn.Close();
                    MessageBox.Show("Record has been successfuly saved.", "POS");
                    Clear();
                    brand.LoadBrand();
                }
            }
            catch(Exception ex) 
            {
                MessageBox.Show($"{ex.Message}");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtBrandName.Clear();
        }
        public void Clear()
        {
            txtBrandName.Clear();
            btnUpdateBrandModule.Enabled = false;
            btnSave.Enabled = true;
            txtBrandName.Focus();
        }

        private void btnUpdateBrandModule_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you shure you want to update this brand?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                cn.Open();
                cmd = new SqlCommand("UPDATE tbBrand SET brand = @brand WHERE id LIKE'"+lblId.Text+"'", cn);
                cmd.Parameters.AddWithValue("@brand", txtBrandName.Text);
                cmd.ExecuteNonQuery();
                cn.Close();
                MessageBox.Show("Record has been successfuly updated.", "Point Of Sales");
                Clear();
                this.Dispose();//to close this form after update data
            }
        }
    }
}
