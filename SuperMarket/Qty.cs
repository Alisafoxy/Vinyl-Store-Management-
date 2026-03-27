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
    public partial class Qty : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        DBconnection dbcon = new DBconnection();
        SqlDataReader dr;
        private string pcode;
        private double price;
        private String transno;
        private int qty;
        Cachier1 cachier1;
        string sTitle = "Point of Sales";

        public Qty(Cachier1 cash)
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.Myconnection());
            cachier1 = cash;
        }
        public void ProductDetails(string pcode,double price,string transno,int qty)
        {
            this.pcode = pcode;
            this.price = price;
            this.transno = transno;
            this.qty = qty;

        }

        private void txtQty_KeyPress(object sender, KeyPressEventArgs e)
        {
            if((e.KeyChar==13) && (txtQty.Text != string.Empty))
            {
                //cn.Open();
                //cmd=new SqlCommand("INSERT INTO tbCartCart(transno,pcode,price,qty,sdate,cashier)VALUES(@transno,@pcode,@price,@qty,@sdate,@cashier)",cn);
                //cmd.Parameters.AddWithValue("@transno", transno);
                //cmd.Parameters.AddWithValue("@pcode", pcode);
                //cmd.Parameters.AddWithValue("price",price);
                //cmd.Parameters.AddWithValue("@qty",int.Parse(txtQty.Text));
                //cmd.Parameters.AddWithValue("@sdate",DateTime.Now);
                //cmd.Parameters.AddWithValue("@cashier",cachier1.lblUsername.Text);
                //cmd.ExecuteNonQuery();
                //cn.Close();
                //cachier1.LoadCart();
                //this.Dispose();

                try
                {
                    string id = "";
                    int cart_qty = 0;
                    bool found = false;

                    cn.Open();
                    /*cmd = new SqlCommand("SELECT * FROM tbCartCart WHERE transno= @transno AND pcode=@pcode", cn);*/
                    cmd = new SqlCommand("SELECT * FROM tbCartCart WHERE transno = @transno AND pcode = @pcode", cn);
                    cmd.Parameters.AddWithValue("@transno", transno);
                    cmd.Parameters.AddWithValue("@pcode", pcode);
                    dr = cmd.ExecuteReader();
                    dr.Read();
                    if (dr.HasRows)
                    {
                        id = dr["id"].ToString();
                        cart_qty = int.Parse(dr["qty"].ToString());
                        found = true;
                    }
                    else found = false;
                    dr.Close();
                    cn.Close();

                    if (found)
                    {
                        if (qty < int.Parse(txtQty.Text) + cart_qty)
                        {
                            MessageBox.Show("Unable to procced. Remaining qty on hand is " + qty, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                        cn.Open();
                        cmd = new SqlCommand("Update tbCartCart SET qty = (qty + " + int.Parse(txtQty.Text) + ")WHERE id ='" + id + "'", cn);
                        /*cmd.ExecuteReader();*/
                        cmd.ExecuteNonQuery();
                        cn.Close();
                        cachier1.txtBarcode.Clear();
                        cachier1.txtBarcode.Focus();
                        cachier1.LoadCart();
                        this.Dispose();
                    }
                    else
                    {
                        if (qty < int.Parse(txtQty.Text) + cart_qty)
                        {
                            MessageBox.Show("Unable to procced. Remaining qty on hand is " + qty, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }

                        cn.Open();
                        /* cmd = new SqlCommand("INSERT INTO tbCartCart(transo, pcode, price, qty, sdate, cashier)VALUES(@transo, @pcode, @price, @qty, @sdate, @cashier)", cn);*/
                        cmd = new SqlCommand("INSERT INTO tbCartCart(transno, pcode, price, qty, sdate, cashier) VALUES(@transno, @pcode, @price, @qty, @sdate, @cashier)", cn);
                        cmd.Parameters.AddWithValue("@transno", transno);
                        cmd.Parameters.AddWithValue("@pcode", pcode);
                        cmd.Parameters.AddWithValue("@price", price);
                        cmd.Parameters.AddWithValue("@qty", int.Parse(txtQty.Text));
                        cmd.Parameters.AddWithValue("@sdate", DateTime.Now);
                        cmd.Parameters.AddWithValue("@cashier", cachier1.lblUsername.Text);
                        cmd.ExecuteNonQuery();
                        cn.Close();
                        cachier1.txtBarcode.Clear();
                        cachier1.txtBarcode.Focus();
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
}
