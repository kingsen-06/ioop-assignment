namespace assignment
{
    partial class admin_viewFeedback
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
            dataGridView1 = new DataGridView();
            feedback = new DataGridViewTextBoxColumn();
            trainer = new DataGridViewTextBoxColumn();
            date = new DataGridViewTextBoxColumn();
            lblBack = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { feedback, trainer, date });
            dataGridView1.Location = new Point(32, 30);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(733, 317);
            dataGridView1.TabIndex = 0;
            // 
            // feedback
            // 
            feedback.HeaderText = "Feedback";
            feedback.MinimumWidth = 8;
            feedback.Name = "feedback";
            feedback.Width = 350;
            // 
            // trainer
            // 
            trainer.HeaderText = "Trainer";
            trainer.MinimumWidth = 8;
            trainer.Name = "trainer";
            trainer.Width = 200;
            // 
            // date
            // 
            date.HeaderText = "Date";
            date.MinimumWidth = 8;
            date.Name = "date";
            date.Width = 120;
            // 
            // lblBack
            // 
            lblBack.AutoSize = true;
            lblBack.Font = new Font("Segoe UI", 11F);
            lblBack.Location = new Point(12, 376);
            lblBack.Name = "lblBack";
            lblBack.Size = new Size(167, 30);
            lblBack.TabIndex = 1;
            lblBack.Text = "< Back to Menu";
            // 
            // admin_viewFeedback
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 424);
            Controls.Add(lblBack);
            Controls.Add(dataGridView1);
            Name = "admin_viewFeedback";
            Text = "viewFeedback";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn feedback;
        private DataGridViewTextBoxColumn trainer;
        private DataGridViewTextBoxColumn date;
        private Label lblBack;
    }
}