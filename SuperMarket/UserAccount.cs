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
    public partial class UserAccount : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        DBconnection dbcon = new DBconnection();
        SqlDataReader dr;
        public UserAccount()
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.Myconnection());
        }
        


        public void Clear()
        {
            txtUserName.Clear();
            txtPassword.Clear();
            txtReTypePassword.Clear();
            txtFullName.Clear();
            cmbRole.Text = "";
            txtUserName.Focus();
        }
        private void btnSaveAcc_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtPassword.Text != txtReTypePassword.Text)
                {
                    MessageBox.Show("Password did not march!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    cn.Open();
                    cmd = new SqlCommand("INSERT INTO tbUsers(username,password,role,name) Values (@username,@password,@role,@name)", cn);
                    cmd.Parameters.AddWithValue("@username", txtUserName.Text);
                    cmd.Parameters.AddWithValue("@password", txtPassword.Text);
                    cmd.Parameters.AddWithValue("@role", cmbRole.Text);
                    cmd.Parameters.AddWithValue("@name", txtFullName.Text);
                    cmd.ExecuteNonQuery();
                    cn.Close();
                    MessageBox.Show("New account has been successfully saved!", "saved account", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Clear();
                }
                
            }
            catch(Exception ex) 
            {
                MessageBox.Show(ex.Message,"WARNING");
            }
        }

        private void btnCancelAcc_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void UserAccount_Load(object sender, EventArgs e)
        {
            txtUserName.Focus();

        }
    }
}
