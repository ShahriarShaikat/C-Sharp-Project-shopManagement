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
    public partial class ManageOrder : MetroForm
    {
        private DataAccess Da { get; set; }
        private Home obj;
        public ManageOrder()
        {
            InitializeComponent();
            this.Da = new DataAccess();
            this.populate_gridview();
        }
        public ManageOrder(Home obj)
        {
            InitializeComponent();
            this.obj = obj;
            this.Da = new DataAccess();
            this.populate_gridview();
        }
        public void populate_gridview()
        {
            string sql = "select * from orderTable where salesman='"+session.username+"';";
            var ds = this.Da.ExecuteQueryTable(sql);
            this.dgvOrder.AutoGenerateColumns = false;
            this.dgvOrder.DataSource = ds;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.obj.Show();
            this.Hide();
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            string id = this.dgvOrder.CurrentRow.Cells["orderid"].Value.ToString();
            ViewOrderDetails vod = new ViewOrderDetails(id);
            vod.Show();
        }
    }
}
