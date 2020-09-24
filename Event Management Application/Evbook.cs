using Event_Management_Application.BL;
using Event_Management_Application.DAL;
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
    public partial class Evbook : Form
    {
        public Evbook()
        {
            InitializeComponent();
            FillDropdowns();
            ViewDetails();
            AllClear();
        }

        private void Evbook_Load(object sender, EventArgs e)
        {

        }
        public void FillDropdowns()
        {
            //DDL Customer Name and Mobile No
            ddlcustomers.DataSource = DataAccess.ExecuteTable("select *,Name+'('+Mobile+')' as CName from tbl_Costomer");
            ddlcustomers.DisplayMember = "Cname";
            ddlcustomers.ValueMember = "CostomerId";
            ddlcustomers.SelectedIndex = -1;
            //DDL Events
            ddleventtypes.DataSource = DataAccess.ExecuteTable("select * from tbl_Event");
            ddleventtypes.DisplayMember = "EventType";
            ddleventtypes.ValueMember = "EventTypeId";
            ddleventtypes.SelectedIndex = -1;
        }

        private void btnbooking_Click(object sender, EventArgs e)
        {
            int n = 0;
            if (string.IsNullOrEmpty(ddlcustomers.Text))
            {
                n += 1;
            }
            if (string.IsNullOrEmpty(ddleventtypes.Text))
            {
                n += 1;
            }
            if (n == 0)
            {
                BL_ScheduleEvents obj = new BL_ScheduleEvents();
                obj.CustomerId = Convert.ToInt32(ddlcustomers.SelectedValue);
                obj.EventTypeId = Convert.ToInt32(ddleventtypes.SelectedValue);
                obj.StartTime = dtpstart.Value;
                obj.EndTime = dtpend.Value;
                obj.EntryDate = DateTime.Now;
                if (obj.Save())
                {
                    MessageBox.Show("Event Booked Successfully");
                }
                else
                {
                    MessageBox.Show("Error! Please Try Again");
                }
            }
            if (n != 0)
            {
                MessageBox.Show("All Feilds Are Required");
            }
            ViewDetails();
            AllClear();
        }
        public void ViewDetails()
        {
            BL_ScheduleEvents obj = new BL_ScheduleEvents();
            DataTable dt = obj.getAllEventsSchedule();
            dataGridView1.DataSource = dt;
            //dataGridView1.Columns["BookedEventId"].Visible = false;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //if (e.ColumnIndex == 0)
            //{
            //    //delete
            //    BL_ScheduleEvents obj = new BL_ScheduleEvents();
            //    obj.DEventId = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["BookedEventId"].Value);
            //    dataGridView1.Columns["BookedEventId"].Visible = false;

            //    obj.DeleteEvent();
            //    ViewDetails();
            //}
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                ddlcustomers.SelectedValue = row.Cells[2].Value;
                ddleventtypes.SelectedValue = row.Cells[1].Value;
                dtpstart.Value= Convert.ToDateTime(row.Cells[3].Value);
                dtpend.Value = Convert.ToDateTime(row.Cells[4].Value);
                txtEventid.Text = row.Cells[0].Value.ToString();
                //txtName.Text = row.Cells[1].Value.ToString();
                //txtCountry.Text = row.Cells[2].Value.ToString();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            BL_ScheduleEvents obj = new BL_ScheduleEvents();
            obj.CustomerId = Convert.ToInt32(ddlcustomers.SelectedValue);
            obj.EventTypeId = Convert.ToInt32(ddleventtypes.SelectedValue);
            obj.StartTime = dtpstart.Value;
            obj.EndTime = dtpend.Value;
            obj.EntryDate = DateTime.Now;
            obj.BookedEventId = Convert.ToInt32(txtEventid.Text);

            if (obj.UpdateEvent())
            {
                MessageBox.Show("Event Updated Successfully");
            }
            else
            {
                MessageBox.Show("Error! Please Try Again");
            }
            ViewDetails();
            AllClear();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            BL_ScheduleEvents obj = new BL_ScheduleEvents();
            obj.DEventId= Convert.ToInt32(txtEventid.Text);
            obj.DeleteEvent();
            MessageBox.Show("Event Deleted Successfully");
            ViewDetails();
            AllClear();
        }
        private void AllClear()
        {
            ddlcustomers.SelectedIndex = -1;
            ddleventtypes.SelectedIndex = -1;
            dtpstart.Value = DateTime.Now;
            dtpend.Value = DateTime.Now;
        }
    }
}
