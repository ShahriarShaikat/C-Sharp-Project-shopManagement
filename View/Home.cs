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
    public partial class Home : MetroForm
    {
        private DataAccess Da { get; set; }
        public Home()
        {
            InitializeComponent();
            this.Da = new DataAccess();
        }

        private void salesmanHome_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnAddOrder_Click(object sender, EventArgs e)
        {
            //AddOrder  ad = new AddOrder();
            AddOrder ad = new AddOrder(this);
            ad.Show();
            this.Hide();
        }

        private void btnMngOdr_Click(object sender, EventArgs e)
        {
            ManageOrder mO = new ManageOrder(this);
            mO.Show();
            this.Hide();
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            profile pr= new profile(this);
            pr.Show();
            this.Hide();
        }
    }
}
