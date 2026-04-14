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
            dataFeedback = new DataGridView();
            feedback = new DataGridViewTextBoxColumn();
            trainer = new DataGridViewTextBoxColumn();
            date = new DataGridViewTextBoxColumn();
            lblBack = new Label();
            btnView = new Button();
            ((System.ComponentModel.ISupportInitialize)dataFeedback).BeginInit();
            SuspendLayout();
            // 
            // dataFeedback
            // 
            dataFeedback.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataFeedback.Columns.AddRange(new DataGridViewColumn[] { feedback, trainer, date });
            dataFeedback.Location = new Point(26, 30);
            dataFeedback.Margin = new Padding(2);
            dataFeedback.Name = "dataFeedback";
            dataFeedback.RowHeadersWidth = 62;
            dataFeedback.Size = new Size(586, 254);
            dataFeedback.TabIndex = 0;
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
            lblBack.Location = new Point(10, 338);
            lblBack.Margin = new Padding(2, 0, 2, 0);
            lblBack.Name = "lblBack";
            lblBack.Size = new Size(265, 25);
            lblBack.TabIndex = 1;
            lblBack.Text = "< Back to Administrator Menu";
            lblBack.Click += lblBack_Click;
            // 
            // btnView
            // 
            btnView.Font = new Font("Segoe UI", 11F);
            btnView.Location = new Point(211, 299);
            btnView.Margin = new Padding(2);
            btnView.Name = "btnView";
            btnView.Size = new Size(220, 30);
            btnView.TabIndex = 2;
            btnView.Text = "View Feedback Details";
            btnView.UseVisualStyleBackColor = true;
            btnView.Click += btnView_Click;
            // 
            // admin_viewFeedback
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(640, 374);
            Controls.Add(btnView);
            Controls.Add(lblBack);
            Controls.Add(dataFeedback);
            Margin = new Padding(2);
            Name = "admin_viewFeedback";
            Text = "viewFeedback";
            FormClosed += admin_viewFeedback_FormClosed;
            Load += admin_viewFeedback_Load;
            ((System.ComponentModel.ISupportInitialize)dataFeedback).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataFeedback;
        private DataGridViewTextBoxColumn feedback;
        private DataGridViewTextBoxColumn trainer;
        private DataGridViewTextBoxColumn date;
        private Label lblBack;
        private Button btnView;
    }
}