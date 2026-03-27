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
    public partial class SupplierModule : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        DBconnection dbcon = new DBconnection();
        string sTitle = "Point of Sales";
        Supplier supplier;
        
        public SupplierModule(Supplier sp)
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.Myconnection());
            supplier = sp;
        }

        private void SupplierModule_Load(object sender, EventArgs e)
        {

        }

        private void picClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        public void Clear()
        {
            txtSupplierName.Clear();
            txtAddress.Clear();
            txtContactP.Clear();
            txtPhone.Clear();
            txtEmail.Clear();
            txtFax.Clear();
            btnSave.Enabled = true;
            btnUpdateModule.Enabled = false;
            txtSupplierName.Focus();
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if(MessageBox.Show("Save this record? click yes to confirm", "CONFIRM", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cmd = new SqlCommand("INSERT INTO tbSupplier(supplier,address,contactperson,phone,email,fax)VALUES(@supplier,@address,@contactperson,@phone,@email,@fax)", cn);
                    cmd.Parameters.AddWithValue("@supplier", txtSupplierName.Text);
                    cmd.Parameters.AddWithValue("@address", txtAddress.Text);
                    cmd.Parameters.AddWithValue("@contactperson", txtContactP.Text);
                    cmd.Parameters.AddWithValue("@phone", txtPhone.Text);
                    cmd.Parameters.AddWithValue("@email", txtEmail.Text);
                    cmd.Parameters.AddWithValue("@fax",txtFax.Text);
                    cn.Open();
                    cmd.ExecuteNonQuery();
                    cn.Close();
                    MessageBox.Show("Record has been successfully saved!","Save Record",MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Clear();
                    supplier.LoadSupplier();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, sTitle);
            }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void btnUpdateModule_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Are you shure you want to update this Supplier?", "CONFIRM", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cn.Open();
                    cmd = new SqlCommand("UPDATE tbSupplier SET supplier=@supplier, address=@address, contactperson=@contactperson, phone=@phone, email=@email, fax=@fax WHERE id=@id", cn);
                    cmd.Parameters.AddWithValue("@id", lblId.Text);
                    cmd.Parameters.AddWithValue("@supplier", txtSupplierName.Text);
                    cmd.Parameters.AddWithValue("@address", txtAddress.Text);
                    cmd.Parameters.AddWithValue("@contactperson", txtContactP.Text);
                    cmd.Parameters.AddWithValue("@phone", txtPhone.Text);
                    cmd.Parameters.AddWithValue("@email", txtEmail.Text);
                    cmd.Parameters.AddWithValue("@fax", txtFax.Text);
                    cmd.ExecuteNonQuery();
                    cn.Close();
                    MessageBox.Show("Record has been successfully updated!", "update supplier", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Dispose();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Warning");
            }
        }
    }
}
