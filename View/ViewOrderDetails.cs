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
    public partial class ViewOrderDetails : MetroForm
    {
        private DataAccess Da { get; set; }
        private string id;
        public ViewOrderDetails()
        {
            InitializeComponent();
            this.Da = new DataAccess();
            this.showDetails();
        }
        public ViewOrderDetails(string id)
        {
            InitializeComponent();
            this.Da = new DataAccess();
            this.id = id;
            this.showDetails();
        }
        public void showDetails()
        {
            string sqls = "select * from orderTable where orderid="+this.id+";";
            var dass = this.Da.ExecuteQuery(sqls);
            this.txtId.Text = "#"+(dass.Tables[0].Rows[0][0].ToString());
            this.txtTotal.Text = "$ "+(dass.Tables[0].Rows[0][1].ToString());
            this.txtDate.Text = dass.Tables[0].Rows[0][3].ToString();
            this.lblSalesman.Text = dass.Tables[0].Rows[0][2].ToString();
            string sql = "select * from orderDetails where orderid=" + this.id + ";";
            var ds = this.Da.ExecuteQuery(sql);
            this.dgvOdrDetails.AutoGenerateColumns = false;
            this.dgvOdrDetails.DataSource = ds.Tables[0];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
