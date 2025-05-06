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
    public partial class ProductModule : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        DBconnection dbcon = new DBconnection();
        string sTitle = "Point of Sales";
        Product product;
        public ProductModule(Product pd)
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.Myconnection());
            product = pd;
            LoadBrand();
            LoadCategory();


        }
        public void LoadCategory()
        {
            cmbCategory.Items.Clear();
            cmbCategory.DataSource = dbcon.getTable("SELECT * FROM tbCategory");
            cmbCategory.DisplayMember = "category";
            cmbCategory.ValueMember = "id";
        }
        public void LoadBrand()
        {
            cmbBrand.Items.Clear();
            cmbBrand.DataSource = dbcon.getTable("SELECT * FROM tbBrand");
            cmbBrand.DisplayMember = "brand";
            cmbBrand.ValueMember = "id";
        }

        private void picClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        public void Clear()
        {
            txtProductCode.Clear();
            txtBarcode.Clear();
            txtDescription.Clear();
            cmbBrand.SelectedIndex= 0;
            cmbCategory.SelectedIndex = 0;
            txtPrice.Clear();
            numUpDReOrder.Value = 1;
            txtProductCode.Enabled = true;
            txtProductCode.Focus();
            btnUpdateModule.Enabled = false;
            btnSave.Enabled = true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Are you shure you want to save this product?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cmd = new SqlCommand("INSERT INTO tbProduct(pcode,barcode,pdesc,bid,cid,price,reorder)VALUES(@pcode,@barcode,@pdesc,@bid,@cid,@price,@reorder)", cn);
                    cmd.Parameters.AddWithValue("@pcode",txtProductCode.Text);
                    cmd.Parameters.AddWithValue("@barcode", txtBarcode.Text);
                    cmd.Parameters.AddWithValue("@pdesc", txtDescription.Text);
                    cmd.Parameters.AddWithValue("@bid", cmbBrand.SelectedValue);
                    cmd.Parameters.AddWithValue("@cid", cmbCategory.SelectedValue);
                    cmd.Parameters.AddWithValue("@price",double.Parse(txtPrice.Text));
                    cmd.Parameters.AddWithValue("@reorder", numUpDReOrder.Value);
                    cn.Open();
                    cmd.ExecuteNonQuery();
                    cn.Close();
                    MessageBox.Show("Product has been successfuly saved.", sTitle);
                    Clear();
                    product.LoadProduct();//כדי שהעדכון יופיע במסך של PRODUCT בתוך DGV
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
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
                if (MessageBox.Show("Are you shure you want to update this Product?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cmd = new SqlCommand("UPDATE tbProduct SET barcode=@barcode, pdesc=@pdesc, bid=@bid, cid=@cid, price=@price, reorder=@reorder WHERE pcode LIKE @pcode", cn);
                    cmd.Parameters.AddWithValue("@pcode", txtProductCode.Text);
                    cmd.Parameters.AddWithValue("@barcode", txtBarcode.Text);
                    cmd.Parameters.AddWithValue("@pdesc", txtDescription.Text);
                    cmd.Parameters.AddWithValue("@bid", cmbBrand.SelectedValue);
                    cmd.Parameters.AddWithValue("@cid", cmbCategory.SelectedValue);
                    cmd.Parameters.AddWithValue("@price", double.Parse(txtPrice.Text));
                    cmd.Parameters.AddWithValue("@reorder", numUpDReOrder.Value);
                    cn.Open();
                    cmd.ExecuteNonQuery();
                    cn.Close();
                    MessageBox.Show("Product has been successfuly updated.", sTitle);
                    Clear();
                    this.Dispose();
                    //product.LoadProduct();//כדי שהעדכון יופיע במסך של PRODUCT בתוך DGV
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
