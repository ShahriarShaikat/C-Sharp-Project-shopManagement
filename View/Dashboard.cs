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
    public partial class Dashboard : MetroForm
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            ManageUser mn = new ManageUser(this);
            mn.Show();
            this.Hide();
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            AddProduct ap = new AddProduct(this);
            ap.Show();
            this.Hide();
        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
            session.destroy(); 
            Login newLn = new Login();
            newLn.Show();
            this.Hide(); 
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            DashboardOrder dboardOR = new DashboardOrder(this);
            dboardOR.Show();
            this.Hide();
        }
    }
}
