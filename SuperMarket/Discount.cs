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
    public partial class Discount : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        DBconnection dbcon = new DBconnection();
        string sTitle = "Point of Sales";
        Cachier1 cachier1;

        public Discount(Cachier1 cach)
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.Myconnection());
            cachier1 = cach;
            txtDiscountP.Focus();
            this.KeyPreview = true;
        }

        private void picClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void Discount_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Escape)
            {
                this.Dispose();
            }
            if (e.KeyCode == Keys.Escape) this.Dispose();
            else if (e.KeyCode == Keys.Enter) btnSave.PerformClick();
        }

        private void txtDiscountP_TextChanged(object sender, EventArgs e)
        {
            try
            {
                double disc = double.Parse(txtTotalPrice.Text)* double.Parse(txtDiscountP.Text) * 0.01;
                txtDiscountAmount.Text = disc.ToString("#,#0.00");
            }
            catch(Exception ex) 
            {
                /*MessageBox.Show(ex.Message, sTitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);*/
                txtDiscountAmount.Text = "0.00";
            }

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if(MessageBox.Show("Add Discount? Click Yes To Confirm", sTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question)==DialogResult.Yes)
                {
                    cn.Open();
                    /* cmd = new SqlCommand("INSERT tbCartCart SET disc = @disc, disc_precent = @disc_precent WHERE id = @id", cn);*/
                    /* cmd.Parameters.AddWithValue("@disc",double.Parse(txtDiscountAmount.Text));*/
                    cmd = new SqlCommand("UPDATE tbCartCart SET disc_precent = @disc_precent WHERE id = @id", cn);
                    cmd.Parameters.AddWithValue("@disc_precent", double.Parse(txtDiscountP.Text));
                    cmd.Parameters.AddWithValue("@id", int.Parse(lblId.Text));
                    cmd.ExecuteNonQuery();
                    cn.Close();
                    cachier1.LoadCart();
                    this.Dispose();


                }
            }
            catch (Exception ex)
            {
                cn.Close();
                MessageBox.Show(ex.Message, sTitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }
    }
}
