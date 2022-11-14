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
    public partial class DashboardOrder : MetroForm
    {
        private DataAccess Da { get; set; }
        private Dashboard obj;
        public DashboardOrder()
        {
            InitializeComponent();
            this.Da = new DataAccess();
            populate_gridview();

        }
        public DashboardOrder(Dashboard obj)
        {
            InitializeComponent();
            this.obj = obj;
            this.Da = new DataAccess();
            populate_gridview();

        }
        public void populate_gridview()
        {
            string sql = "select * from orderTable;";
            var ds = this.Da.ExecuteQueryTable(sql);
            this.gdvOrder.AutoGenerateColumns = false;
            this.gdvOrder.DataSource = ds;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            obj.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //var id = this.gdvOrder.CurrentRow.Cells["orderId"].Value.ToString();
            if (0 < this.gdvOrder.Rows.Count)
            {
                string id = this.gdvOrder.CurrentRow.Cells["orderId"].Value.ToString();
                string sql = "delete from orderTable where orderid=" + Convert.ToInt32(id) + ";";
                var ds = this.Da.ExecuteDML(sql);
                if (ds == 1)
                {
                    this.Da.ExecuteDML("delete from orderDetails where orderid=" + Convert.ToInt32(id) + ";");
                    MessageBox.Show("Order deleted!");
                    this.populate_gridview();
                }
                else { MessageBox.Show("Failed!"); }
            }
            else
            {
                MessageBox.Show("No order available to delete!");
            }
        }
    }
}
