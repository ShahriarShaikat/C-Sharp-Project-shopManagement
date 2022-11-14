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
    public partial class profile : MetroForm
    {
        private DataAccess Da { get; set; }
        private Home obj;
        public profile()
        {
            InitializeComponent();
            this.Da = new DataAccess();
            this.displayUserValue();
        }
        
        public profile(Home obj)
        {
            
            InitializeComponent();
            this.Da = new DataAccess();
            this.obj = obj;
            this.displayUserValue();
            
        }
        public void displayUserValue()
        {
            try
            {
                string sql = @"select * from userTable where userid=" + Convert.ToInt32(session.userid) + " and username='" + session.username+"';";
                //string sql = "select * from userTable;"; 
                var ds = this.Da.ExecuteQuery(sql);
                if(ds.Tables[0].Rows.Count==1)
                {
                    this.txtUid.Text = ds.Tables[0].Rows[0][1].ToString();
                    this.txtUname.Text = ds.Tables[0].Rows[0][2].ToString();
                    this.txtUpass.Text = ds.Tables[0].Rows[0][3].ToString();
                    this.txtUrole.Text = ds.Tables[0].Rows[0][4].ToString();
                    //this.dtpBirth.Text = ds.Tables[0].Rows[0][4].ToString();
                    string dt = ds.Tables[0].Rows[0][5].ToString();
                    //this.txtUid.Text = dt.Substring(0,10);
                    this.dtpBirth.Text = dt.Substring(0,10);
                    var gender = ds.Tables[0].Rows[0][6].ToString();
                    if(gender.Equals("Male"))
                    {
                        this.rbMale.Checked = true;
                    }
                    else
                    {
                        this.rbFemale.Checked = true;
                    }
                    this.txtUmail.Text = ds.Tables[0].Rows[0][7].ToString();
                    this.txtUphone.Text = ds.Tables[0].Rows[0][8].ToString();
                }
                else
                {
                    MessageBox.Show("Multiple Row!");
                }
            }
            catch(Exception exc)
            {
                MessageBox.Show("Error "+ exc);
            }
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            this.obj.Show();
            this.Hide();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(this.dtpBirth.Text);
            string gender;
            if (this.rbMale.Checked == true)
            {
                gender = "Male";
            }
            else
            {
                gender = "Female";
            }
            //MessageBox.Show(date);
            
            try
            {
                string sql = @"update  userTable set password='"+ this.txtUpass.Text + "' , birthday='"+ this.dtpBirth.Text + "', gender='"+ gender + "', email='"+ this.txtUmail.Text + "', phone='"+ this.txtUphone.Text + "' where username='"+this.txtUname.Text+"';";
                var result = this.Da.ExecuteDML(sql);
                if(result == 1)
                {
                    MessageBox.Show("Date Updated!");
                    this.displayUserValue();
                }
                else MessageBox.Show("Date Updated failed!");
            }
            catch (Exception exc)
            {
                MessageBox.Show("Error " + exc);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Login lg = new Login();
            session.destroy();
            lg.Show();
            this.Hide();
        }
    }
}
