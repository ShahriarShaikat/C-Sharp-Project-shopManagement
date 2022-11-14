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
    public partial class Main : MetroForm
    {
        public Main()
        {
            InitializeComponent();
            this.timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.prBarMain.Value += 20;
            if (this.prBarMain.Value >= 100) 
            {
                this.timer1.Stop();
                Login hom = new Login();
                hom.Visible = true;
                this.Visible = false;
            }
        }
    }
}
