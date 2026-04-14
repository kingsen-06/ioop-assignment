namespace assignment
{
    partial class trainer_viewStudent
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
            label1 = new Label();
            label2 = new Label();
            cmbName = new ComboBox();
            dataStudent = new DataGridView();
            name = new DataGridViewTextBoxColumn();
            schedule = new DataGridViewTextBoxColumn();
            venue = new DataGridViewTextBoxColumn();
            status = new DataGridViewTextBoxColumn();
            lblBack = new Label();
            lblLevel = new Label();
            ((System.ComponentModel.ISupportInitialize)dataStudent).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F);
            label1.Location = new Point(93, 24);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(146, 25);
            label1.TabIndex = 0;
            label1.Text = "Module Name : ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F);
            label2.Location = new Point(93, 64);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(112, 25);
            label2.TabIndex = 1;
            label2.Text = "Class Level :";
            // 
            // cmbName
            // 
            cmbName.Font = new Font("Segoe UI", 11F);
            cmbName.FormattingEnabled = true;
            cmbName.Location = new Point(243, 22);
            cmbName.Margin = new Padding(2);
            cmbName.Name = "cmbName";
            cmbName.Size = new Size(272, 33);
            cmbName.TabIndex = 2;
            cmbName.SelectedIndexChanged += cmbName_SelectedIndexChanged;
            // 
            // dataStudent
            // 
            dataStudent.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataStudent.Columns.AddRange(new DataGridViewColumn[] { name, schedule, venue, status });
            dataStudent.Location = new Point(50, 116);
            dataStudent.Margin = new Padding(2);
            dataStudent.Name = "dataStudent";
            dataStudent.RowHeadersWidth = 62;
            dataStudent.Size = new Size(530, 228);
            dataStudent.TabIndex = 4;
            // 
            // name
            // 
            name.HeaderText = "Student Name";
            name.MinimumWidth = 8;
            name.Name = "name";
            name.Width = 150;
            // 
            // schedule
            // 
            schedule.HeaderText = "Class Schedule";
            schedule.MinimumWidth = 8;
            schedule.Name = "schedule";
            schedule.Width = 150;
            // 
            // venue
            // 
            venue.HeaderText = "Class Venue";
            venue.MinimumWidth = 8;
            venue.Name = "venue";
            venue.Width = 150;
            // 
            // status
            // 
            status.HeaderText = "Paid Status";
            status.MinimumWidth = 8;
            status.Name = "status";
            status.Width = 150;
            // 
            // lblBack
            // 
            lblBack.AutoSize = true;
            lblBack.Font = new Font("Segoe UI", 11F);
            lblBack.Location = new Point(10, 363);
            lblBack.Margin = new Padding(2, 0, 2, 0);
            lblBack.Name = "lblBack";
            lblBack.Size = new Size(208, 25);
            lblBack.TabIndex = 5;
            lblBack.Text = "< Back to Trainer Menu";
            lblBack.Click += lblBack_Click;
            // 
            // lblLevel
            // 
            lblLevel.AutoSize = true;
            lblLevel.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblLevel.Location = new Point(243, 64);
            lblLevel.Name = "lblLevel";
            lblLevel.Size = new Size(0, 25);
            lblLevel.TabIndex = 6;
            // 
            // trainer_viewStudent
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(631, 403);
            Controls.Add(lblLevel);
            Controls.Add(lblBack);
            Controls.Add(dataStudent);
            Controls.Add(cmbName);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(2);
            Name = "trainer_viewStudent";
            Text = "viewStudent";
            Load += trainer_viewStudent_Load;
            ((System.ComponentModel.ISupportInitialize)dataStudent).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private ComboBox cmbName;
        private DataGridView dataStudent;
        private Label lblBack;
        private DataGridViewTextBoxColumn name;
        private DataGridViewTextBoxColumn schedule;
        private DataGridViewTextBoxColumn venue;
        private DataGridViewTextBoxColumn status;
        private Label lblLevel;
    }
}