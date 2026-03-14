namespace assignment
{
    partial class student_viewSchedule
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
            dataSchedule = new DataGridView();
            name = new DataGridViewTextBoxColumn();
            level = new DataGridViewTextBoxColumn();
            trainer = new DataGridViewTextBoxColumn();
            schedule = new DataGridViewTextBoxColumn();
            Venue = new DataGridViewTextBoxColumn();
            lblBack = new Label();
            ((System.ComponentModel.ISupportInitialize)dataSchedule).BeginInit();
            SuspendLayout();
            // 
            // dataSchedule
            // 
            dataSchedule.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataSchedule.Columns.AddRange(new DataGridViewColumn[] { name, level, trainer, schedule, Venue });
            dataSchedule.Location = new Point(54, 57);
            dataSchedule.Name = "dataSchedule";
            dataSchedule.RowHeadersWidth = 62;
            dataSchedule.Size = new Size(813, 283);
            dataSchedule.TabIndex = 0;
            // 
            // name
            // 
            name.HeaderText = "Module Name";
            name.MinimumWidth = 8;
            name.Name = "name";
            name.Width = 150;
            // 
            // level
            // 
            level.HeaderText = "Class Level";
            level.MinimumWidth = 8;
            level.Name = "level";
            level.Width = 150;
            // 
            // trainer
            // 
            trainer.HeaderText = "Trainer Name";
            trainer.MinimumWidth = 8;
            trainer.Name = "trainer";
            trainer.Width = 150;
            // 
            // schedule
            // 
            schedule.HeaderText = "Class Schedule";
            schedule.MinimumWidth = 8;
            schedule.Name = "schedule";
            schedule.Width = 150;
            // 
            // Venue
            // 
            Venue.HeaderText = "Class Venue";
            Venue.MinimumWidth = 8;
            Venue.Name = "Venue";
            Venue.Width = 150;
            // 
            // lblBack
            // 
            lblBack.AutoSize = true;
            lblBack.Font = new Font("Segoe UI", 11F);
            lblBack.Location = new Point(14, 375);
            lblBack.Name = "lblBack";
            lblBack.Size = new Size(247, 30);
            lblBack.TabIndex = 1;
            lblBack.Text = "< Back to Student Menu";
            // 
            // student_viewSchedule
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(919, 425);
            Controls.Add(lblBack);
            Controls.Add(dataSchedule);
            Name = "student_viewSchedule";
            Text = "viewSchedule";
            ((System.ComponentModel.ISupportInitialize)dataSchedule).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataSchedule;
        private DataGridViewTextBoxColumn name;
        private DataGridViewTextBoxColumn level;
        private DataGridViewTextBoxColumn trainer;
        private DataGridViewTextBoxColumn schedule;
        private DataGridViewTextBoxColumn Venue;
        private Label lblBack;
    }
}