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
    public partial class AddUser : MetroForm
    {
        private DataAccess Da { get; set; }
        private ManageUser obj;
        public AddUser()
        {
            InitializeComponent();
            this.Da = new DataAccess();
        }
        public AddUser(ManageUser obj)
        {
            InitializeComponent();
            this.obj = obj;
            this.Da = new DataAccess();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        public void genarateId()
        {
            string sql = "select MAX(userid) from userTable;";
            var ds = this.Da.ExecuteQueryTable(sql);
            this.tbxUserId.Text = ((Convert.ToInt32(ds.Rows[0][0]))+1).ToString();
            this.tbxUserId.Enabled = false;
            this.btnSave.Visible = true;
            this.saveEdit.Visible = false;
            this.lblTitle.Text = "Add New User";

        }
        public void showInfo(string id)
        {
            string sql = "select * from userTable where userid="+Convert.ToInt32(id)+";";
            var ds = this.Da.ExecuteQueryTable(sql);
            if(ds.Rows.Count == 1)
            {
                
                this.tbxUserId.Text = ds.Rows[0][1].ToString();
                this.tbxUname.Text = ds.Rows[0][2].ToString();
                this.txtUpass.Text = ds.Rows[0][3].ToString();
                this.cbRole.Text = ds.Rows[0][4].ToString();
                string dt = ds.Rows[0][5].ToString();
                this.dtpUBirth.Text = dt.Substring(0, 9);
                string gender = ds.Rows[0][6].ToString();
                if (gender.Equals("Male")) { this.rbMale.Checked = true; }
                else { this.rbFemale.Checked = true; }
                this.txtUmail.Text = ds.Rows[0][7].ToString();
                this.txtUphone.Text = ds.Rows[0][8].ToString();
                this.btnSave.Visible = false;
                this.saveEdit.Visible = true;
                this.tbxUserId.Enabled = false;
                this.lblTitle.Text = "Update User";
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string gender;
            if(this.rbMale.Checked==true)
            { gender = "Male"; }
            else { gender = "Female"; }
            string sql = "insert into userTable (userid,username,password,role,birthday,gender,email,phone) values("+Convert.ToInt32(this.tbxUserId.Text) +",'"+this.tbxUname.Text+ "','" + this.txtUpass.Text + "','"+this.cbRole.Text+"','"+this.dtpUBirth.Text+"','"+gender+"','"+this.txtUmail.Text+"','"+this.txtUphone.Text+"');";
            var ds = this.Da.ExecuteDML(sql);
            if(ds==1)
            {
                MessageBox.Show("New user created!");
                obj.populate_gridview();
                this.Hide();
            }
            else
            {
                MessageBox.Show("User created failed!");
            }
        }

        private void saveEdit_Click(object sender, EventArgs e)
        {
            string gender;
            if (this.rbMale.Checked == true)
            {
                gender = "Male";
            }
            else
            {
                gender = "Female";
            }

            try
            {
                string sql = @"update  userTable set username='" + this.tbxUname.Text + "', password='" + this.txtUpass.Text + "' , role='" + this.cbRole.Text + "', birthday='" + this.dtpUBirth.Text + "', gender='" + gender + "', email='" + this.txtUmail.Text + "', phone='" + this.txtUphone.Text + "' where userid='" + this.tbxUserId.Text + "';";
                var result = this.Da.ExecuteDML(sql);
                if (result == 1)
                {
                    MessageBox.Show("Date Updated!");
                    obj.populate_gridview();
                    this.Hide();
                }
                else MessageBox.Show("Date Updated failed!");
            }
            catch (Exception exc)
            {
                MessageBox.Show("Error " + exc);
            }
        }
    }
}
