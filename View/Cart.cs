using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;

namespace View
{
    public partial class Cart : MetroForm
    {
        private DataAccess Da { get; set; }
        private AddOrder obj;
        public Cart()
        {
            InitializeComponent();
            this.Da = new DataAccess();
            populate_gridview();
        }
        public Cart(AddOrder obj)
        {
            this.obj = obj;
            InitializeComponent();
            this.Da = new DataAccess();
            populate_gridview();
        }
        private void populate_gridview()
        {
            try
            {
                string sql = "select * from Cart;";
                var ds = this.Da.ExecuteQuery(sql);
                this.dgvCart.AutoGenerateColumns = false;
                this.dgvCart.DataSource = ds.Tables[0];
                string total = "select SUM(totalPrice) from cart;";
                var totalamount = this.Da.ExecuteQuery(total);
                this.totalVal.Text = totalamount.Tables[0].Rows[0][0].ToString();
            }
            catch (Exception exc)
            {
                MessageBox.Show("error" + exc.Message);
            }
        }
        private void infoClear()
        {
            this.pcode.Text = "";
            this.pname.Text = "";
            this.qtyVal.Text = "";
            this.qtySave.Text = "";
            this.pprice.Text = "";
            this.ptotal.Text = "";
        }




        private void tbSlider_Scroll(object sender, EventArgs e)
        {
            if (this.pcode.Text != "") { 
            int value = this.tbSlider.Value;
            this.qtyVal.Text = value.ToString();
            this.ptotal.Text = (Convert.ToInt32(this.pprice.Text) * value).ToString();
            }
        }

        private void editProduct_Click(object sender, EventArgs e)
        {
            if(this.dgvCart.Rows.Count > 0)
            {
                this.pcode.Text = this.dgvCart.CurrentRow.Cells["productCode"].Value.ToString();
                this.pname.Text = this.dgvCart.CurrentRow.Cells["productName"].Value.ToString();
                this.qtyVal.Text = this.dgvCart.CurrentRow.Cells["quantity"].Value.ToString();
                this.qtySave.Text = this.dgvCart.CurrentRow.Cells["quantity"].Value.ToString();
                this.pprice.Text = this.dgvCart.CurrentRow.Cells["price"].Value.ToString();
                this.ptotal.Text = this.dgvCart.CurrentRow.Cells["totalPrice"].Value.ToString();
            }
            else { MessageBox.Show("No product available in the cart to edit!"); }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string qtsql = "select quantity from Product where productCode='" + this.pcode.Text + "' ;";
            var qtycheck= this.Da.ExecuteQuery(qtsql);
            int tqty = Convert.ToInt32(qtycheck.Tables[0].Rows[0][0]) + Convert.ToInt32(this.qtySave.Text);
            if (tqty >= Convert.ToInt32(this.qtyVal.Text))
            {
                try
                {
                    string query = @"update  cart set quantity=" + Convert.ToInt32(this.qtyVal.Text) + " , totalPrice=" + Convert.ToInt32(this.ptotal.Text) + " where productCode = '" + this.pcode.Text + "';";
                    var rs = this.Da.ExecuteDML(query);
                    if (rs == 1)
                    {
                        string sql = "select quantity from Product where productCode='" + this.pcode.Text + "' ;";
                        var ds = this.Da.ExecuteQuery(sql);
                        int quntty = Convert.ToInt32(ds.Tables[0].Rows[0][0]);
                        string que = "update  Product set quantity=" + ((quntty + Convert.ToInt32(this.qtySave.Text)) - Convert.ToInt32(this.qtyVal.Text)) + " where productCode = '" + this.pcode.Text + "';";
                        var qn = this.Da.ExecuteDML(que);
                        MessageBox.Show("Data updated from the cart!");
                        this.infoClear();
                        this.populate_gridview();
                    }
                }
                catch (Exception exc)
                {
                    MessageBox.Show("error" + exc.Message);
                }
            }
            else
            {
                MessageBox.Show("The quantity of the product isn't in the stock!");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(this.dgvCart.Rows.Count > 0)
            {
                var id = this.dgvCart.CurrentRow.Cells["productCode"].Value.ToString();
                var qty = this.dgvCart.CurrentRow.Cells["quantity"].Value.ToString();
                //MessageBox.Show(id);
                try
                {
                    string que = "delete from cart where productCode='" + id + "';";
                    var qn = this.Da.ExecuteDML(que);
                    if (qn == 1)
                    {
                        string tes = "select quantity from Product where productCode='" + id + "' ;";
                        var ds = this.Da.ExecuteQuery(tes);
                        int quntty = Convert.ToInt32(ds.Tables[0].Rows[0][0]);
                        string sql = "update  Product set quantity=" + (quntty + Convert.ToInt32(qty)) + " where productCode = '" + id + "';";
                        var count = this.Da.ExecuteDML(sql);
                        if (count == 1)
                        {
                            this.populate_gridview();
                            MessageBox.Show("Product deleted from the cart!");
                        }
                        else
                        {
                            MessageBox.Show("Fail!");
                        }

                    }
                }
                catch (Exception exc)
                {
                    MessageBox.Show("error" + exc.Message);
                }
            }
            else { MessageBox.Show("No product available in the cart to delete!"); }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.obj.Show();
            this.obj.populate_gridview();
            this.Hide();
        }

        private void PlaceOrder_Click(object sender, EventArgs e)
        {
            string sql = "select * from cart;";
            var ds = this.Da.ExecuteQuery(sql);
            if(ds.Tables[0].Rows.Count != 0)
            {
                string dates = DateTime.UtcNow.ToString("yyyy-MM-dd");
                string order = @"INSERT INTO orderTable (totalPrice,salesman ,orderDate) values("+Convert.ToInt32(this.totalVal.Text) +",'"+session.username+"','"+dates+"');";
                var orderresult = this.Da.ExecuteDML(order);
                if(orderresult == 1)
                {
                    
                    var cartds = this.Da.ExecuteQuery("select * from cart;");
                    int index = 0;
                    while(index < cartds.Tables[0].Rows.Count)
                    {
                        string instaql = @"INSERT INTO orderDetails values('" + cartds.Tables[0].Rows[index][0] + "','" + cartds.Tables[0].Rows[index][1] + "'," + cartds.Tables[0].Rows[index][2] + ",'" + cartds.Tables[0].Rows[index][3] + "'," + cartds.Tables[0].Rows[index][4] + "," + cartds.Tables[0].Rows[index][5] + "," + cartds.Tables[0].Rows[index][6] + ");";
                        this.Da.ExecuteDML(instaql);
                        index++;
                    }
                    this.Da.ExecuteDML("Delete from cart;");
                    this.populate_gridview();
                    MessageBox.Show("Your Order has been placed!");
                }
            }
            else
            {
                MessageBox.Show("Couldn't create a order due to empty cart!");
            }
        }
    }
}
