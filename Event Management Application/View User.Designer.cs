namespace Event_Management_Application
{
    partial class View_User
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tblUserBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.eventMgt1DataSet = new Event_Management_Application.EvCrys();
            this.tblUserTableAdapter = new Event_Management_Application.EventMgt1DataSetTableAdapters.tblUserTableAdapter();
            this.userReg = new System.Windows.Forms.Label();
            this.Home = new System.Windows.Forms.LinkLabel();
            this.RagHeader = new System.Windows.Forms.Panel();
            this.eventMgt2DataSet = new Event_Management_Application.EventMgt2DataSet();
            this.tblUserBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tblUserTableAdapter1 = new Event_Management_Application.EventMgt2DataSetTableAdapters.tblUserTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userAddressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userPictureDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblUserBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventMgt1DataSet)).BeginInit();
            this.RagHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eventMgt2DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblUserBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.userNameDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.userAddressDataGridViewTextBoxColumn,
            this.userPictureDataGridViewImageColumn});
            this.dataGridView1.DataSource = this.tblUserBindingSource1;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(1);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.Location = new System.Drawing.Point(0, 94);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 150;
            this.dataGridView1.Size = new System.Drawing.Size(1577, 412);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // tblUserBindingSource
            // 
            this.tblUserBindingSource.DataMember = "tblUser";
            this.tblUserBindingSource.DataSource = this.eventMgt1DataSet;
            // 
            // eventMgt1DataSet
            // 
            this.eventMgt1DataSet.DataSetName = "EventMgt1DataSet";
            this.eventMgt1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblUserTableAdapter
            // 
            this.tblUserTableAdapter.ClearBeforeFill = true;
            // 
            // userReg
            // 
            this.userReg.AutoSize = true;
            this.userReg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.userReg.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userReg.ForeColor = System.Drawing.Color.White;
            this.userReg.Location = new System.Drawing.Point(601, 22);
            this.userReg.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.userReg.Name = "userReg";
            this.userReg.Size = new System.Drawing.Size(287, 50);
            this.userReg.TabIndex = 0;
            this.userReg.Text = "All User Details";
            // 
            // Home
            // 
            this.Home.ActiveLinkColor = System.Drawing.Color.Black;
            this.Home.AutoSize = true;
            this.Home.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Home.LinkColor = System.Drawing.Color.White;
            this.Home.Location = new System.Drawing.Point(31, 32);
            this.Home.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Home.Name = "Home";
            this.Home.Size = new System.Drawing.Size(62, 24);
            this.Home.TabIndex = 28;
            this.Home.TabStop = true;
            this.Home.Text = "Home";
            this.Home.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Home_LinkClicked);
            // 
            // RagHeader
            // 
            this.RagHeader.BackColor = System.Drawing.Color.Firebrick;
            this.RagHeader.Controls.Add(this.userReg);
            this.RagHeader.Controls.Add(this.Home);
            this.RagHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.RagHeader.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RagHeader.Location = new System.Drawing.Point(0, 0);
            this.RagHeader.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.RagHeader.Name = "RagHeader";
            this.RagHeader.Size = new System.Drawing.Size(1577, 85);
            this.RagHeader.TabIndex = 18;
            // 
            // eventMgt2DataSet
            // 
            this.eventMgt2DataSet.DataSetName = "EventMgt2DataSet";
            this.eventMgt2DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblUserBindingSource1
            // 
            this.tblUserBindingSource1.DataMember = "tblUser";
            this.tblUserBindingSource1.DataSource = this.eventMgt2DataSet;
            // 
            // tblUserTableAdapter1
            // 
            this.tblUserTableAdapter1.ClearBeforeFill = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "ID";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // userNameDataGridViewTextBoxColumn
            // 
            this.userNameDataGridViewTextBoxColumn.DataPropertyName = "userName";
            this.userNameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.userNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.userNameDataGridViewTextBoxColumn.Name = "userNameDataGridViewTextBoxColumn";
            this.userNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // userAddressDataGridViewTextBoxColumn
            // 
            this.userAddressDataGridViewTextBoxColumn.DataPropertyName = "userAddress";
            this.userAddressDataGridViewTextBoxColumn.HeaderText = "Address";
            this.userAddressDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.userAddressDataGridViewTextBoxColumn.Name = "userAddressDataGridViewTextBoxColumn";
            this.userAddressDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // userPictureDataGridViewImageColumn
            // 
            this.userPictureDataGridViewImageColumn.DataPropertyName = "userPicture";
            this.userPictureDataGridViewImageColumn.HeaderText = "Picture";
            this.userPictureDataGridViewImageColumn.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.userPictureDataGridViewImageColumn.MinimumWidth = 6;
            this.userPictureDataGridViewImageColumn.Name = "userPictureDataGridViewImageColumn";
            this.userPictureDataGridViewImageColumn.ReadOnly = true;
            // 
            // View_User
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1577, 506);
            this.Controls.Add(this.RagHeader);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "View_User";
            this.Text = "View_User";
            this.Load += new System.EventHandler(this.View_User_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblUserBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventMgt1DataSet)).EndInit();
            this.RagHeader.ResumeLayout(false);
            this.RagHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eventMgt2DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblUserBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private EvCrys eventMgt1DataSet;
        private System.Windows.Forms.BindingSource tblUserBindingSource;
        private EventMgt1DataSetTableAdapters.tblUserTableAdapter tblUserTableAdapter;
        private System.Windows.Forms.Label userReg;
        private System.Windows.Forms.LinkLabel Home;
        private System.Windows.Forms.Panel RagHeader;
        private EventMgt2DataSet eventMgt2DataSet;
        private System.Windows.Forms.BindingSource tblUserBindingSource1;
        private EventMgt2DataSetTableAdapters.tblUserTableAdapter tblUserTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userAddressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn userPictureDataGridViewImageColumn;
    }
}