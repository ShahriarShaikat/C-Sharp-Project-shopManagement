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
    public partial class AddProduct : MetroForm
    {
        private DataAccess Da { get; set; }
        private Dashboard dbord;
        public AddProduct()
        {
            InitializeComponent();
            this.Da = new DataAccess();
            this.populate_gridview();
        }
        public AddProduct(Dashboard obj)
        {
            InitializeComponent();
            this.dbord = obj;
            this.Da = new DataAccess();
            this.populate_gridview();
        }
        public void populate_gridview()
        {
            string sql = "select * from Product;";
            var ds = this.Da.ExecuteQueryTable(sql);
            this.gdvProduct.AutoGenerateColumns = false;
            this.gdvProduct.DataSource = ds;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            dbord.Show();
            this.Hide();
        }

        private void addNew_Click(object sender, EventArgs e)
        {
            Product prd = new Product(this);
            prd.Show();
            prd.addNewProduct();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string id = this.gdvProduct.CurrentRow.Cells["productCode"].Value.ToString();
            Product prd = new Product(this);
            prd.Show();
            prd.showInfo(id);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //string id = this.gdvProduct.CurrentRow.Cells["productCode"].Value.ToString();
            if (0 < this.gdvProduct.Rows.Count)
            {
                string ProductCode = this.gdvProduct.CurrentRow.Cells["productCode"].Value.ToString();
                string sql = "delete from Product where productCode='"+ProductCode+"';";
                var ds = this.Da.ExecuteDML(sql);
                if (ds == 1)
                {
                    MessageBox.Show("User deleted!");
                    this.populate_gridview();
                }
                else { MessageBox.Show("User deleted!"); }
            }
            else
            {
                MessageBox.Show("No product available to delete!");
            }
        }
    }
}
