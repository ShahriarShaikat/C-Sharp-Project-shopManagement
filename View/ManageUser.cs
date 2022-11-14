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
    public partial class ManageUser : MetroForm
    {
        private DataAccess Da { get; set; }
        private Dashboard dbord;
        public ManageUser()
        {
            InitializeComponent();
            this.Da = new DataAccess();
            populate_gridview();
        }
        public ManageUser(Dashboard db)
        {
            InitializeComponent();
            this.Da = new DataAccess();
            this.dbord = db;
            populate_gridview();
        }
        public void populate_gridview()
        {
            string sql = "select * from userTable;";
            var ds = this.Da.ExecuteQueryTable(sql);
            this.mgdvUser.AutoGenerateColumns = false;
            this.mgdvUser.DataSource = ds;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.dbord.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Add new
            AddUser ad = new AddUser(this);
            ad.Show();
            ad.genarateId();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string id = this.mgdvUser.CurrentRow.Cells["userid"].Value.ToString();
            AddUser ad = new AddUser(this);
            ad.Show();
            ad.showInfo(id);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*int index = 0;
            bool flag = false;
            while(index < this.mgdvUser.Rows.Count)
            {
                if (this.mgdvUser.Rows[index].Selected) { flag = true;break; }
                index++;
            }
            if (flag == true)
            {
                MessageBox.Show("Clicked!");
            }
            else if (flag == false)
            {
                MessageBox.Show("Non-Clicked!");
            }*/
            if (0 < this.mgdvUser.Rows.Count)
            {
                string id = this.mgdvUser.CurrentRow.Cells["userid"].Value.ToString();
                string sql = "delete from userTable where userid="+Convert.ToInt32(id)+";";
                var ds = this.Da.ExecuteDML(sql);
                if(ds==1)
                {
                    MessageBox.Show("User deleted!");
                    this.populate_gridview();
                }
                else{ MessageBox.Show("User deleted!"); }
            }
        }
    }
}
