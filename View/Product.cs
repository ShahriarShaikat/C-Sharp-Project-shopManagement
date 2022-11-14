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
    public partial class Product : MetroForm
    {
        private DataAccess Da { get; set; }
        private AddProduct adp;
        public Product()
        {
            InitializeComponent();
            this.Da = new DataAccess();
        }
        public Product(AddProduct obj)
        {
            InitializeComponent();
            this.adp = obj;
            this.Da = new DataAccess();
        }
        public void addNewProduct()
        {
            //string sql = "select MAX(serial) from Product;";
            //var ds = this.Da.ExecuteQueryTable(sql);
            this.textserial.Visible = false;
            this.lblSerial.Visible = false;
            this.btnSave.Visible = true;
            this.btnEdit.Visible = false;
            this.lblTitle.Text = "Add New Product";

        }
        public void showInfo(string id)
        {
            string sql = "select * from Product where productCode='" + id + "';";
            var ds = this.Da.ExecuteQueryTable(sql);
            if (ds.Rows.Count == 1)
            {
                this.textserial.Text = ds.Rows[0][0].ToString();
                this.txtPcode.Text = ds.Rows[0][1].ToString();
                this.txtPname.Text = ds.Rows[0][2].ToString();
                this.txtPqty.Text = ds.Rows[0][3].ToString();
                this.txtPcategory.Text = ds.Rows[0][4].ToString();
                this.txtPprice.Text = ds.Rows[0][5].ToString();
                this.textserial.Visible = true;
                this.lblSerial.Visible = true;
                this.btnSave.Visible = false;
                this.btnEdit.Visible = true;
                this.lblTitle.Text = "Update Product Details";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = @"update  Product set productCode='" + this.txtPcode.Text + "', productName='" + this.txtPname.Text + "', quantity='" + this.txtPqty.Text + "' , category='" + this.txtPcategory.Text + "', price=" + this.txtPprice.Text + " where serial='"+ this.textserial.Text + "' ;";
                var result = this.Da.ExecuteDML(sql);
                if (result == 1)
                {
                    MessageBox.Show("Date Updated!");
                    adp.populate_gridview();
                    this.Hide();
                }
                else MessageBox.Show("Date Updated failed!");
            }
            catch (Exception exc)
            {
                MessageBox.Show("Error " + exc);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            string sql = "insert into Product (productCode,productName,quantity,category,price) values('"+this.txtPcode.Text+ "','" + this.txtPname.Text + "','" + this.txtPqty.Text + "','" + this.txtPcategory.Text + "','" + this.txtPprice.Text + "');";
            var ds = this.Da.ExecuteDML(sql);
            if (ds == 1)
            {
                MessageBox.Show("New Product created!");
                adp.populate_gridview();
                this.Hide();
            }
            else
            {
                MessageBox.Show("User created failed!");
            }
        }
    }
}
