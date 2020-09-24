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
    public partial class ViewAllEvent : Form
    {
        public ViewAllEvent()
        {
            InitializeComponent();
            ViewDetails();
        }


        public void ViewDetails()
        {
            BL_ScheduleEvents obj = new BL_ScheduleEvents();
            DataTable dt = obj.getScheduleDetail();
            dataGridView1.DataSource = dt;
            dataGridView1.Columns["BookedEventId"].Visible = false;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                //delete
                BL_ScheduleEvents obj = new BL_ScheduleEvents();
                obj.DEventId = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["BookedEventId"].Value);
                dataGridView1.Columns["BookedEventId"].Visible = false;

                obj.DeleteEvent();
                ViewDetails();
            }
        }

        private void ViewAllEvent_Load(object sender, EventArgs e)
        {

            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridView1.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            dataGridView1.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridView1.AutoResizeRows();
            dataGridView1.AutoResizeColumns();
            
        }

        private void Home_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }
    }
}
