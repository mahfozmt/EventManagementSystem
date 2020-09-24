using Event_Management_Application.BL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Event_Management_Application
{
    public partial class LogIn : Form
    {
        public LogIn()
        {
            InitializeComponent();
        }

        private void register_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SignUp signUp = new SignUp();
            this.Hide();
            signUp.Show();
        }
        
        private void SignIn_Click(object sender, EventArgs e)
        {
            BL_AddUser obj = new BL_AddUser();
            obj.UserName = txtUsername.Text;
            obj.Password = txtPassword.Text;
            DataTable dt = obj.Login();
            
            if (dt.Rows.Count > 0)
            {
                Welcome wel = new Welcome();
                wel.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid username or password");
            }

        }

        private void LogIn_Load(object sender, EventArgs e)
        {
            txtUsername.Focus();
        }

        private void Home_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Index obj = new Index();
            this.Close();
            obj.Show();
        }

        private void userBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
