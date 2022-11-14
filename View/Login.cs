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
using System.Data.SqlClient;

namespace View
{
    public partial class Login : MetroForm
    {
        private DataAccess Da { get; set; }
        public Login()
        {
            InitializeComponent();
            this.Da = new DataAccess();
        }

        private void Home_FormClosed(object sender, FormClosedEventArgs e)=> Application.Exit();

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try 
            {
                string sql = "select * from userTable where username = '"+this.txtuser.Text+ "' and password = '" + this.txtpass.Text + "';";

                /*SqlConnection sqlCon = new SqlConnection(@"Data Source=LAPTOP-KHBPEBJ5\SQLEXPRESS;Initial Catalog=ShopManagement;Persist Security Info=True;User ID=sa;Password=12345678");
                sqlCon.Open();
                SqlCommand sqlCom = new SqlCommand(sql, sqlCon);
                SqlDataAdapter sdAdapter = new SqlDataAdapter(sqlCom);
                DataSet ds = new DataSet();
                sdAdapter.Fill(ds);*/
                //string sql = "select * from userTable";
                var ds = this.Da.ExecuteQuery(sql);
                if(ds.Tables[0].Rows.Count == 1)
                {
                    MessageBox.Show("Login Successful!");
                    if((ds.Tables[0].Rows[0][4].ToString()).Equals("Salesman"))
                    {
                        //session sn = new session(ds.Tables[0].Rows[0][1].ToString(), ds.Tables[0].Rows[0][2].ToString());
                        session.userid = ds.Tables[0].Rows[0][1].ToString();
                        session.username = ds.Tables[0].Rows[0][2].ToString();
                        /*session.userid = "1";
                        session.username = "shaikat920";*/
                        Home slsman = new Home();
                        this.Hide();
                        slsman.Show();
                    }
                    else if ((ds.Tables[0].Rows[0][4].ToString()).Equals("Admin"))
                    {
                        session.userid = ds.Tables[0].Rows[0][1].ToString();
                        session.username = ds.Tables[0].Rows[0][2].ToString();
                        Dashboard dbd = new Dashboard();
                        this.Hide();
                        dbd.Show();
                    }
                }
                else
                {
                    MessageBox.Show("User Invalid!");
                }
            }
            catch(Exception exc)
            {
                MessageBox.Show("error"+ exc.Message);
            }
        }

        
    }
}
