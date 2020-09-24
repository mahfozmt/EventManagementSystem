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
    public partial class View_User : Form
    {
        public View_User()
        {
            InitializeComponent();
            
        }

        private void View_User_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'eventMgt2DataSet.tblUser' table. You can move, or remove it, as needed.
            this.tblUserTableAdapter1.Fill(this.eventMgt2DataSet.tblUser);
            // TODO: This line of code loads data into the 'eventMgt1DataSet.tblUser' table. You can move, or remove it, as needed.
            this.tblUserTableAdapter.Fill(this.eventMgt1DataSet.tblUser);
            this.dataGridView1.AutoGenerateColumns = false;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Home_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }
    }
}
