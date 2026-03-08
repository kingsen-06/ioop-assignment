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
            cmbLevel = new ComboBox();
            dataStudent = new DataGridView();
            label3 = new Label();
            name = new DataGridViewTextBoxColumn();
            schedule = new DataGridViewTextBoxColumn();
            venue = new DataGridViewTextBoxColumn();
            status = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataStudent).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F);
            label1.Location = new Point(116, 30);
            label1.Name = "label1";
            label1.Size = new Size(169, 30);
            label1.TabIndex = 0;
            label1.Text = "Module Name : ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F);
            label2.Location = new Point(116, 80);
            label2.Name = "label2";
            label2.Size = new Size(128, 30);
            label2.TabIndex = 1;
            label2.Text = "Class Level :";
            // 
            // cmbName
            // 
            cmbName.Font = new Font("Segoe UI", 11F);
            cmbName.FormattingEnabled = true;
            cmbName.Location = new Point(304, 27);
            cmbName.Name = "cmbName";
            cmbName.Size = new Size(339, 38);
            cmbName.TabIndex = 2;
            // 
            // cmbLevel
            // 
            cmbLevel.Font = new Font("Segoe UI", 11F);
            cmbLevel.FormattingEnabled = true;
            cmbLevel.Location = new Point(304, 77);
            cmbLevel.Name = "cmbLevel";
            cmbLevel.Size = new Size(339, 38);
            cmbLevel.TabIndex = 3;
            // 
            // dataStudent
            // 
            dataStudent.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataStudent.Columns.AddRange(new DataGridViewColumn[] { name, schedule, venue, status });
            dataStudent.Location = new Point(63, 145);
            dataStudent.Name = "dataStudent";
            dataStudent.RowHeadersWidth = 62;
            dataStudent.Size = new Size(663, 285);
            dataStudent.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11F);
            label3.Location = new Point(12, 447);
            label3.Name = "label3";
            label3.Size = new Size(239, 30);
            label3.TabIndex = 5;
            label3.Text = "< Back to Trainer Menu";
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
            // trainer_viewStudent
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(789, 489);
            Controls.Add(label3);
            Controls.Add(dataStudent);
            Controls.Add(cmbLevel);
            Controls.Add(cmbName);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "trainer_viewStudent";
            Text = "viewStudent";
            ((System.ComponentModel.ISupportInitialize)dataStudent).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private ComboBox cmbName;
        private ComboBox cmbLevel;
        private DataGridView dataStudent;
        private Label label3;
        private DataGridViewTextBoxColumn name;
        private DataGridViewTextBoxColumn schedule;
        private DataGridViewTextBoxColumn venue;
        private DataGridViewTextBoxColumn status;
    }
}