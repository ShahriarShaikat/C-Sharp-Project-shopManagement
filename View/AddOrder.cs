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
    public partial class AddOrder : MetroForm
    {
        private DataAccess Da { get; set; }
        private Home obj;
        public AddOrder()
        {
            InitializeComponent();
            this.Da = new DataAccess();
            populate_gridview();
        }
        public AddOrder(Home obj)
        {
            InitializeComponent();
            this.obj = obj;
            this.Da = new DataAccess();
            populate_gridview();
        }
        public void populate_gridview()
        {
            try
            {
                string sql = "select * from Product;";
                var ds = this.Da.ExecuteQuery(sql);
                this.dgvProduct.AutoGenerateColumns = false;
                this.dgvProduct.DataSource = ds.Tables[0];
            }
            catch (Exception exc)
            {
                MessageBox.Show("error" + exc.Message);
            }
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            string max = "select max(orderid) from orderTable;";
            var maxOId = this.Da.ExecuteQuery(max);
            var id = this.dgvProduct.CurrentRow.Cells["productCode"].Value.ToString();
            var name = this.dgvProduct.CurrentRow.Cells["productName"].Value.ToString();
            var qty = this.dgvProduct.CurrentRow.Cells["quantity"].Value.ToString();
            int quntty = Convert.ToInt32(qty);
            quntty = quntty - 1;
            var category = this.dgvProduct.CurrentRow.Cells["category"].Value.ToString();
            var price = this.dgvProduct.CurrentRow.Cells["price"].Value.ToString();
            var totalprice = this.dgvProduct.CurrentRow.Cells["price"].Value.ToString();
            string check = "select * from cart where productCode='"+id+"';";
            var ds = this.Da.ExecuteQuery(check);
            if (ds.Tables[0].Rows.Count < 1)
            {
                try
                {
                    string sql = @"insert into cart values('" + id + "','" + name + "',1,'" + category + "'," + price + "," + totalprice + ","+((Convert.ToInt32(maxOId.Tables[0].Rows[0][0])) +1)+");";
                    var result = this.Da.ExecuteDML(sql);
                    if (result == 1)
                    {
                        string query = "update  Product set quantity=" + quntty + " where productCode = '" + id + "';";
                        var rs = this.Da.ExecuteDML(query);
                        if (rs == 1)
                        {
                            MessageBox.Show("Product added to the cart!");
                            populate_gridview();
                        }
                        else
                        {
                            MessageBox.Show("Failed!");
                        }

                    }
                    else
                    {
                        MessageBox.Show("Product added failed!");
                    }
                }
                catch (Exception exc)
                {
                    MessageBox.Show("error" + exc.Message);
                }
            }
            else
            {
                MessageBox.Show("Product already added to the cart!");
            }
            
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            Cart c = new Cart(this);
            
            c.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.obj.Show();
            this.Hide();
        }

        private void btnSearch_KeyUp(object sender, KeyEventArgs e)
        {
            int val = this.btnSearch.Text.Length;
            if ( val < 1)
            {
                this.populate_gridview();
            }
            else 
            {
                string secheck = "select * from Product where productCode like '%" + this.btnSearch.Text + "%' or productName like '%" + this.btnSearch.Text + "%' or category like '%" + this.btnSearch.Text + "%';";
                var search = this.Da.ExecuteQuery(secheck);
                this.dgvProduct.AutoGenerateColumns = false;
                this.dgvProduct.DataSource = search.Tables[0];
            }
            
        }
    }
}
