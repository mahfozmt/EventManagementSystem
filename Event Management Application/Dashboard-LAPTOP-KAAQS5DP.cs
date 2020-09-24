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
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void btncustomer_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            AddCustomer obj = new AddCustomer();
            obj.WindowState = FormWindowState.Maximized;
            obj.TopLevel = false;
            panel1.Controls.Add(obj);
            obj.Show();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void RegisterUser_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            SignUp obj = new SignUp();
            obj.WindowState = FormWindowState.Maximized;
            obj.TopLevel = false;
            panel1.Controls.Add(obj);
            obj.Show();
        }

        private void close_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
