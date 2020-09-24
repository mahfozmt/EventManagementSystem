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
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
        }
        private void loginShow()
        {

            LogIn log = new LogIn();
            this.Hide();
            log.Show();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LogIn log = new LogIn();
            this.Hide();
            log.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // open file dialog   
            OpenFileDialog open = new OpenFileDialog();
            // image filters  
            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            if (open.ShowDialog() == DialogResult.OK)
            {
                // display image in picture box  
                pictureBox1.Image = new Bitmap(open.FileName);
                // image file path  
                txtPicture.Text = open.FileName;
            }

        }

        private void SignUp_Load(object sender, EventArgs e)
        {
            txtUserName.Focus();
        }

       

        private void Home_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }

        private void btnRegi_Click(object sender, EventArgs e)
        {
            int n = 0;
            int m = 0;
            if (string.IsNullOrEmpty(txtUserName.Text))
            {
                n += 1;
            }
            if (string.IsNullOrEmpty(txtEmail.Text))
            {
                n += 1;
            }

            if (string.IsNullOrEmpty(txtAddress.Text))
            {
                n += 1;
            }

            if (string.IsNullOrEmpty(txtPicture.Text))
            {
                n += 1;
            }

            if (string.IsNullOrEmpty(txtPassword.Text))
            {
                n += 1;
            }
            if (string.IsNullOrEmpty(txtConfirmPassword.Text))
            {
                n += 1;
            }
            if (txtPassword.Text != txtConfirmPassword.Text)
            {
                m += 1;
            }
            
            if (n==0 && m==0)
            {
                BL_AddUser addUser = new BL_AddUser();
                addUser.UserName = txtUserName.Text;
                addUser.Email = txtEmail.Text;
                addUser.Password = txtConfirmPassword.Text;
                addUser.Address = txtAddress.Text;
                addUser.Address = txtAddress.Text;
                addUser.UserPicture = txtPicture.Text;
                if (addUser.Save())
                {
                    MessageBox.Show("Registerd Successfully","Success!!",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    loginShow();
                }
                else
                {
                    MessageBox.Show("Please Try Again");
                }

            }
            if (n != 0)
            {
                MessageBox.Show("All Fields Are Required");
            }
            if (m != 0)
            {
                MessageBox.Show("Password Dosen't Matchs");
            }
            AllClear();


        }
        private void AllClear()
        {
            txtUserName.Clear();
            txtEmail.Clear();
            txtConfirmPassword.Clear();
            txtAddress.Clear();
            txtAddress.Clear();
            txtPicture.Clear();

        }

        private void txtConfirmPassword_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
