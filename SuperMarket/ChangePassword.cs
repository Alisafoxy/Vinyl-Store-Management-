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
    public partial class ChangePassword : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        DBconnection dbcon = new DBconnection();
        SqlDataReader dr;
        string stitle = "Point of Sales";
        Cachier1 cachier1;
        public ChangePassword(Cachier1 cash)
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.Myconnection());
            cachier1 = cash;
            lblUserName.Text = cachier1.lblUsername.Text;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            try
            {
                string oldpass = dbcon.getPassword(lblUserName.Text);
                if (oldpass != txtPass.Text)
                {
                    MessageBox.Show("Wrong password, please try again!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else
                {
                    txtPass.Visible = false;
                    btnNext.Visible = false;
                    lblCurrPass.Visible = false;

                    txtNewPass.Visible = true;
                    txtComPass.Visible = true;
                    btnSave.Visible = true;
                    lblNewPassword.Visible = true;
                    lblComPass.Visible = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void picClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtNewPass.Text != txtComPass.Text)
                {
                    MessageBox.Show("New password and confirm password did not matched!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    if (MessageBox.Show("Change password?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        dbcon.ExecuteQuery("UPDATE tbUsers set password = '" + txtNewPass.Text + "' WHERE username = '" + lblUserName.Text + "'");
                        MessageBox.Show("Password has been successfully update!", "Save Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Dispose();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
