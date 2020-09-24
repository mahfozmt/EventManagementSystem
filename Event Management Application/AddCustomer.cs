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
    public partial class AddCustomer : Form
    {
        public AddCustomer()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void AddCustomer_Load(object sender, EventArgs e)
        {
            txtname.Focus();
        }

        private void btnsubmit_Click(object sender, EventArgs e)
        {
            int n = 0;
            if (string.IsNullOrEmpty(txtname.Text))
            {
                n += 1;
            }
            if (string.IsNullOrEmpty(txtFatherName.Text))
            {
                n += 1;

            }
            if (string.IsNullOrEmpty(txtAddress.Text))
            {
                n += 1;

            }
            if (string.IsNullOrEmpty(txtEmail.Text))
            {
                n += 1;
            }
            if (string.IsNullOrEmpty(txtMask.Text))
            {
                n += 1;
            }

            if (n == 0)
            {
                BL_AddCustomer obj = new BL_AddCustomer();
                obj.Name = txtname.Text;
                obj.FatherName = txtFatherName.Text;
                obj.Address = txtAddress.Text;
                obj.Mobile = txtMask.Text;
                obj.Email = txtEmail.Text;
                if (obj.Save())
                {

                    MessageBox.Show("Registerd Successfully");

                }
                else
                {
                    MessageBox.Show("UnExpected Error! Try Againy");

                }
            }
            if (n != 0)
            {
                MessageBox.Show("All Fileds are Requered");
            }
            AllClear();
        }
        private void AllClear()
        {

            txtname.Clear();
            txtFatherName.Clear();
            txtAddress.Clear();
            txtMask.Clear();
            txtEmail.Clear();


        }

        private void txtMask_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Home_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
            this.Close();
            
        }
    }
}
