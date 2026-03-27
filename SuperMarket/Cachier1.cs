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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace SuperMarket
{
    public partial class Cachier1 : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        DBconnection dbcon = new DBconnection();
        SqlDataReader dr;
        string stitle = "Point of Sales";

        int qty;
        string id;
        string price;

        public Cachier1()
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.Myconnection());
            GetTranNo();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


        private void picClose_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Exit Appliction?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        public void slide (Button button)
        {
            panelSlide.BackColor = Color.Black;
            panelSlide.Height = button.Height;
            panelSlide.Top = button.Top;
        }
        #region button
        private void btnNTran_Click(object sender, EventArgs e)
        {
            slide(btnNTran);
            GetTranNo();
        }
        private void btnSearch_Click_Click(object sender, EventArgs e)
        {
            slide(btnSearch_Click);
            LookUpProduct lookup = new LookUpProduct(this);
            lookup.LoadProduct();
            lookup.ShowDialog();
        }

        private void btnDiscount_Click_Click(object sender, EventArgs e)
        {
            slide(btnDiscount_Click);
            Discount discount = new Discount(this);
            discount.lblId.Text = id;
            discount.txtTotalPrice.Text = price;
            discount.ShowDialog();
        }

        private void btnSettle_Click_Click(object sender, EventArgs e)
        {
            slide(btnSettle_Click);
            Settle settle = new Settle(this);
            settle.txtSale.Text = lblDisplayTotal.Text;
            settle.ShowDialog();
        }

        private void btnClear_Click_Click(object sender, EventArgs e)
        {
            slide(btnClear_Click);
            if (MessageBox.Show("Remove all items from cart?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                cn.Open();
                cmd = new SqlCommand("Delete from tbCartCart where transno like'" + lblTranNo.Text + "'", cn);
                cmd.ExecuteNonQuery();
                cn.Close();
                MessageBox.Show("All items has been successfully remove", "Remove item", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadCart();
            }
        }

        private void btnDsales_Click_Click(object sender, EventArgs e)
        {
            slide(btnDsales_Click);
            DailySales dailySales = new DailySales();
            dailySales.ShowDialog();
        }

        private void btnPass_Click_Click(object sender, EventArgs e)
        {
            slide(btnPass_Click);
            ChangePassword change = new ChangePassword(this);
            change.ShowDialog();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            slide(btnLogOut);
            if (dgvCash.Rows.Count > 0)
            {
                MessageBox.Show("Unable to logout. Please cancel the transaction.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (MessageBox.Show("LogOut Application?", "LogOut", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Hide();
                Login login = new Login();
                login.ShowDialog();
            }
        }
        #endregion button

        public void LoadCart()
        {
            try
            {
                Boolean hascart = false;
                int i = 0;
                double total = 0;
                double discount = 0;
                dgvCash.Rows.Clear();
                cn.Open();
                cmd = new SqlCommand("select c.id, c.pcode, p.pdesc ,c.price,c.qty, c.disc, c.total FROM tbCartCart AS c INNER JOIN tbProduct AS p ON c.pcode=p.pcode WHERE c.transno LIKE @transno and c.status LIKE 'Pending'", cn);
                cmd.Parameters.AddWithValue("@transno", lblTranNo.Text);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    i++;
                    total += Convert.ToDouble(dr["total"].ToString());
                    discount += Convert.ToDouble(dr["disc"].ToString());
                    dgvCash.Rows.Add(i, dr["id"].ToString(), dr["pcode"].ToString(), dr["pdesc"].ToString(), dr["price"].ToString(), dr["qty"].ToString(), dr["disc"].ToString(), double.Parse(dr["total"].ToString()).ToString("#,##0.00"));
                    hascart = true;
                }
                dr.Close();
                cn.Close();
                lblSalesTotalNum.Text = total.ToString("#,#0.00");
                lblDiscountNum.Text = discount.ToString("#,#0.00");
                GetCartTotal();
                if(hascart)
                {
                    btnClear_Click.Enabled = true;
                    btnSettle_Click.Enabled = true;
                    btnDiscount_Click.Enabled = true;
                }
                else
                {
                    btnClear_Click.Enabled = false;
                    btnSettle_Click.Enabled = false;
                    btnDiscount_Click.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, stitle);
            }
            
        }
        public void GetCartTotal()
        {
            double discount=double.Parse(lblDiscountNum.Text);
            double sales = double.Parse(lblSalesTotalNum.Text);
            double vat = sales * 0.12;//vat 12% of vat payable (output tax less input tax)
            double vatable = sales - vat;
            lblTaxNum.Text = vat.ToString("#,#0.00");
            lblVatNum.Text = vatable.ToString("#,#0.00");
            lblDisplayTotal.Text = sales.ToString("#,#0.00");

        }
        private void timer2_Tick(object sender, EventArgs e)
        {
            lblTimer.Text = DateTime.Now.ToString("hh:mm:ss tt");
        }
        public void GetTranNo()
        {
            try
            {
                string sdate = DateTime.Now.ToString("yyyMMdd");
                int count;
                string transno;
                cn.Open();
                cmd = new SqlCommand("SELECT TOP 1 transno FROM tbCartCart WHERE transno LIKE'" + sdate + "%' ORDER BY id desc", cn);
                dr = cmd.ExecuteReader();
                dr.Read();
                if (dr.HasRows)
                {
                    transno = dr[0].ToString();
                    count = int.Parse(transno.Substring(8, 4));
                    lblTranNo.Text = sdate + (count + 1);
                }
                else
                {
                    transno = sdate + "1001";
                    lblTranNo.Text = transno;
                }
                dr.Close();
                cn.Close();
            }
            catch(Exception ex)
            {
                cn.Close();
                MessageBox.Show(ex.Message, stitle);
            }
        }

        private void txtBarcode_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtBarcode.Text == string.Empty) return;
                else
                {
                    string _pcode;
                    double _price;
                    int _qty;
                    cn.Open();
                    cmd = new SqlCommand("SELECT * FROM tbProduct WHERE barcode LIKE'" + txtBarcode.Text + "'", cn);
                    dr = cmd.ExecuteReader();
                    dr.Read();
                    if (dr.HasRows)
                    {
                        qty= int.Parse(dr["qty"].ToString());
                        _pcode = dr["pcode"].ToString();
                        _price = double.Parse(dr["price"].ToString()) ;
                        _qty = int.Parse(txtQty.Text) ;
                        
                        dr.Close();
                        cn.Close();
                        //insert to tbCartCart
                        AddToCart(_pcode, _price, _qty);
                    }
                    dr.Close();
                    cn.Close();
                }
            }
            catch (Exception ex)
            {
                cn.Close();
                MessageBox.Show(ex.Message, stitle,MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }
        private void AddToCart(string _pcode,double _price,int _qty)
        {
            try
            {
                string id = "";
                int cart_qty = 0;
                bool found = false;

                cn.Open();
                cmd = new SqlCommand("SELECT * FROM tbCartCart WHERE transno= @transno AND pcode=@pcode", cn);
                cmd.Parameters.AddWithValue("@transno", lblTranNo.Text);
                cmd.Parameters.AddWithValue("@pcode", _pcode);
                dr = cmd.ExecuteReader();
                dr.Read();
                if (dr.HasRows)
                {
                    id = dr["id"].ToString();
                    cart_qty = int.Parse(dr["qty"].ToString());
                    found = true;
                }
                else found= false;
                dr.Close();
                cn.Close();

                if(found)
                {
                    if(qty<int.Parse(txtQty.Text)+cart_qty)
                    {                  
                        MessageBox.Show("Unable to procced. Remaining quantity on hand is " + qty, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    cn.Open();
                    cmd = new SqlCommand("Update tbCartCart SET qty = (qty + " + _qty + ")WHERE id ='" + id + "'", cn);
                    cmd.ExecuteReader();
                    cn.Close();
                    LoadCart();
                }
                else
                {
                    if (qty < int.Parse(txtQty.Text) + cart_qty)
                    {
                        MessageBox.Show("Unable to procced. Remaining qty on hand is " + qty, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    cn.Open();
                    cmd = new SqlCommand("INSERT INTO tbCartCart(transno, pcode, price, qty, sdate, cashier)VALUES(@transno, @pcode, @price, @qty, @sdate, @cashier)", cn);
                    cmd.Parameters.AddWithValue("@transno", lblTranNo.Text);
                    cmd.Parameters.AddWithValue("@pcode", _pcode);
                    cmd.Parameters.AddWithValue("@price", _price);
                    cmd.Parameters.AddWithValue("@qty", _qty);
                    cmd.Parameters.AddWithValue("@sdate", DateTime.Now);
                    cmd.Parameters.AddWithValue("@cashier", lblUsername.Text);
                    cmd.ExecuteNonQuery();
                    cn.Close();
                    txtBarcode.SelectionStart = 0;
                    txtBarcode.SelectionLength=txtBarcode.Text.Length;
                    LoadCart();
                }
                
            }
            catch (Exception ex)
            {
                cn.Close();
                MessageBox.Show(ex.Message , stitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dgvCash_SelectionChanged(object sender, EventArgs e)
        {
            int i = dgvCash.CurrentRow.Index;
            id = dgvCash[1,i].Value.ToString();
            price= dgvCash[7, i].Value.ToString();

        }

        private void dgvCash_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = dgvCash.Columns[e.ColumnIndex].Name;

            

            if (colName == "Delete")
            {
                if (MessageBox.Show("Remove this item", "Remove item", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    dbcon.ExecuteQuery("Delete from tbCartCart where id like'" + dgvCash.Rows[e.RowIndex].Cells[1].Value.ToString() + "'");
                    MessageBox.Show("Items has been successfully remove", "Remove item", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadCart();
                }
            }
            else if (colName == "calAdd")
            {
                int i = 0;
                cn.Open();
                cmd = new SqlCommand("SELECT SUM(qty) as qty FROM tbProduct WHERE pcode LIKE'" + dgvCash.Rows[e.RowIndex].Cells[2].Value.ToString() + "' GROUP BY pcode", cn);
                i = int.Parse(cmd.ExecuteScalar().ToString());
                cn.Close();

                if (int.Parse(dgvCash.Rows[e.RowIndex].Cells[5].Value.ToString()) < i)
                {
                    dbcon.ExecuteQuery("UPDATE tbCartCart SET qty = qty + " + int.Parse(txtQty.Text) + "WHERE transno LIKE '" + lblTranNo.Text + "' AND pcode LIKE '" + dgvCash.Rows[e.RowIndex].Cells[2].Value.ToString() + "'");
                    LoadCart();
                }
                else
                {
                    MessageBox.Show("Remaining qty on hand is " + i + " ! ", " out of Stock",MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

            }
            else if (colName=="colReduce")
            {
                /*int i = 0;
                cn.Open();
                cmd = new SqlCommand("SELECT SUM(qty) as qty FROM tbCartCart WHERE pcode LIKE'" + dgvCash.Rows[e.RowIndex].Cells[2].Value.ToString() + "' GROUP BY pcode", cn);
                i = int.Parse(cmd.ExecuteScalar().ToString());
                cn.Close();

                if (i>1)
                {
                    dbcon.ExecuteQuery("UPDATE tbCartCart SET qty = qty - " + int.Parse(txtQty.Text) + " WHERE transno LIKE '" + lblTranNo.Text + "' AND pcode LIKE '" + dgvCash.Rows[e.RowIndex].Cells[2].Value.ToString() + "'");
                    LoadCart();
                }
                else
                {
                    MessageBox.Show("Remaining qty on hand is " + i + " ! ", " out of Stock", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }*/

                int currentQty = 0;
                int reduceBy = 1;

                cn.Open();
                cmd = new SqlCommand(
                    "SELECT qty FROM tbCartCart WHERE transno = @transno AND pcode = @pcode", cn);
                cmd.Parameters.AddWithValue("@transno", lblTranNo.Text);
                cmd.Parameters.AddWithValue("@pcode", dgvCash.Rows[e.RowIndex].Cells[2].Value.ToString());

                object result = cmd.ExecuteScalar();
                cn.Close();

                if (result == null) return;

                currentQty = int.Parse(result.ToString());

                if (currentQty > 1)
                {
                    dbcon.ExecuteQuery(
                        "UPDATE tbCartCart SET qty = qty - 1 WHERE transno LIKE '" + lblTranNo.Text +
                        "' AND pcode LIKE '" + dgvCash.Rows[e.RowIndex].Cells[2].Value.ToString() + "'"
                    );
                }
                else if (currentQty == 1)
                {
                    dbcon.ExecuteQuery(
                        "DELETE FROM tbCartCart WHERE transno LIKE '" + lblTranNo.Text +
                        "' AND pcode LIKE '" + dgvCash.Rows[e.RowIndex].Cells[2].Value.ToString() + "'"
                    );
                }

                LoadCart();

            }
        }
    }
}
