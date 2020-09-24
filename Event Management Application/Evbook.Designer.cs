namespace Event_Management_Application
{
    partial class Evbook
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.RagHeader = new System.Windows.Forms.Panel();
            this.userReg = new System.Windows.Forms.Label();
            this.Home = new System.Windows.Forms.LinkLabel();
            this.btnbooking = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpend = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpstart = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.ddleventtypes = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ddlcustomers = new System.Windows.Forms.ComboBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtEventid = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.RagHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // RagHeader
            // 
            this.RagHeader.BackColor = System.Drawing.Color.Firebrick;
            this.RagHeader.Controls.Add(this.userReg);
            this.RagHeader.Controls.Add(this.Home);
            this.RagHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.RagHeader.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RagHeader.Location = new System.Drawing.Point(0, 0);
            this.RagHeader.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.RagHeader.Name = "RagHeader";
            this.RagHeader.Size = new System.Drawing.Size(1771, 98);
            this.RagHeader.TabIndex = 61;
            // 
            // userReg
            // 
            this.userReg.AutoSize = true;
            this.userReg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.userReg.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userReg.ForeColor = System.Drawing.Color.White;
            this.userReg.Location = new System.Drawing.Point(228, 25);
            this.userReg.Name = "userReg";
            this.userReg.Size = new System.Drawing.Size(275, 50);
            this.userReg.TabIndex = 0;
            this.userReg.Text = "Event Booking";
            // 
            // Home
            // 
            this.Home.ActiveLinkColor = System.Drawing.Color.Black;
            this.Home.AutoSize = true;
            this.Home.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Home.LinkColor = System.Drawing.Color.White;
            this.Home.Location = new System.Drawing.Point(23, 34);
            this.Home.Name = "Home";
            this.Home.Size = new System.Drawing.Size(62, 24);
            this.Home.TabIndex = 28;
            this.Home.TabStop = true;
            this.Home.Text = "Home";
            // 
            // btnbooking
            // 
            this.btnbooking.BackColor = System.Drawing.Color.FloralWhite;
            this.btnbooking.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnbooking.Font = new System.Drawing.Font("Arial Narrow", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnbooking.ForeColor = System.Drawing.Color.Black;
            this.btnbooking.Location = new System.Drawing.Point(199, 393);
            this.btnbooking.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnbooking.Name = "btnbooking";
            this.btnbooking.Size = new System.Drawing.Size(128, 50);
            this.btnbooking.TabIndex = 60;
            this.btnbooking.Text = "Book Event";
            this.btnbooking.UseVisualStyleBackColor = false;
            this.btnbooking.Click += new System.EventHandler(this.btnbooking_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(80, 341);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 29);
            this.label5.TabIndex = 59;
            this.label5.Text = "End Time:";
            // 
            // dtpend
            // 
            this.dtpend.CalendarMonthBackground = System.Drawing.Color.LightCoral;
            this.dtpend.CustomFormat = "dd-MM-yyyy hh:mm tt";
            this.dtpend.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpend.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpend.Location = new System.Drawing.Point(199, 342);
            this.dtpend.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpend.Name = "dtpend";
            this.dtpend.Size = new System.Drawing.Size(368, 30);
            this.dtpend.TabIndex = 58;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(75, 269);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 29);
            this.label4.TabIndex = 57;
            this.label4.Text = "Start Time:";
            // 
            // dtpstart
            // 
            this.dtpstart.CalendarMonthBackground = System.Drawing.Color.LightCoral;
            this.dtpstart.CustomFormat = "dd-MM-yyyy hh:mm tt";
            this.dtpstart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpstart.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpstart.Location = new System.Drawing.Point(199, 271);
            this.dtpstart.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpstart.Name = "dtpstart";
            this.dtpstart.Size = new System.Drawing.Size(368, 30);
            this.dtpstart.TabIndex = 56;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(8, 199);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(174, 29);
            this.label3.TabIndex = 55;
            this.label3.Text = "Select Event Type:";
            // 
            // ddleventtypes
            // 
            this.ddleventtypes.BackColor = System.Drawing.Color.LightCoral;
            this.ddleventtypes.DisplayMember = "EventType";
            this.ddleventtypes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddleventtypes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ddleventtypes.FormattingEnabled = true;
            this.ddleventtypes.Location = new System.Drawing.Point(199, 202);
            this.ddleventtypes.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ddleventtypes.Name = "ddleventtypes";
            this.ddleventtypes.Size = new System.Drawing.Size(368, 33);
            this.ddleventtypes.TabIndex = 54;
            this.ddleventtypes.ValueMember = "EventTypeId";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(20, 128);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 29);
            this.label2.TabIndex = 53;
            this.label2.Text = "Select Customer:";
            // 
            // ddlcustomers
            // 
            this.ddlcustomers.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.ddlcustomers.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.ddlcustomers.BackColor = System.Drawing.Color.LightCoral;
            this.ddlcustomers.DisplayMember = "Name";
            this.ddlcustomers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ddlcustomers.FormattingEnabled = true;
            this.ddlcustomers.Location = new System.Drawing.Point(199, 130);
            this.ddlcustomers.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ddlcustomers.Name = "ddlcustomers";
            this.ddlcustomers.Size = new System.Drawing.Size(368, 33);
            this.ddlcustomers.TabIndex = 52;
            this.ddlcustomers.ValueMember = "CostomerId";
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.ForestGreen;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnUpdate.Font = new System.Drawing.Font("Arial Narrow", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.Black;
            this.btnUpdate.Location = new System.Drawing.Point(356, 393);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(91, 50);
            this.btnUpdate.TabIndex = 60;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.Location = new System.Drawing.Point(606, 149);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1152, 294);
            this.dataGridView1.TabIndex = 62;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseClick);
            // 
            // txtEventid
            // 
            this.txtEventid.Enabled = false;
            this.txtEventid.Location = new System.Drawing.Point(199, 106);
            this.txtEventid.Name = "txtEventid";
            this.txtEventid.Size = new System.Drawing.Size(100, 22);
            this.txtEventid.TabIndex = 63;
            this.txtEventid.Visible = false;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.OrangeRed;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDelete.Font = new System.Drawing.Font("Arial Narrow", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.Black;
            this.btnDelete.Location = new System.Drawing.Point(476, 393);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(91, 50);
            this.btnDelete.TabIndex = 60;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(603, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(334, 17);
            this.label1.TabIndex = 64;
            this.label1.Text = "Select Row from bellow Table for Update or Delete :";
            // 
            // Evbook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1771, 473);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtEventid);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.RagHeader);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnbooking);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dtpend);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtpstart);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ddleventtypes);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ddlcustomers);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Evbook";
            this.Text = "Evbook";
            this.Load += new System.EventHandler(this.Evbook_Load);
            this.RagHeader.ResumeLayout(false);
            this.RagHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel RagHeader;
        private System.Windows.Forms.Label userReg;
        private System.Windows.Forms.LinkLabel Home;
        private System.Windows.Forms.Button btnbooking;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpend;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpstart;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox ddleventtypes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox ddlcustomers;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtEventid;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label label1;
    }
}