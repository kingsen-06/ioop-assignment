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
            dataFeedback.Location = new Point(32, 38);
            dataFeedback.Name = "dataFeedback";
            dataFeedback.RowHeadersWidth = 62;
            dataFeedback.Size = new Size(733, 317);
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
            lblBack.Location = new Point(12, 423);
            lblBack.Name = "lblBack";
            lblBack.Size = new Size(304, 30);
            lblBack.TabIndex = 1;
            lblBack.Text = "< Back to Administrator Menu";
            lblBack.Click += lblBack_Click_1;
            // 
            // btnView
            // 
            btnView.Font = new Font("Segoe UI", 11F);
            btnView.Location = new Point(254, 374);
            btnView.Name = "btnView";
            btnView.Size = new Size(255, 38);
            btnView.TabIndex = 2;
            btnView.Text = "View Feedback Detail";
            btnView.UseVisualStyleBackColor = true;
            btnView.Click += btnView_Click;
            // 
            // admin_viewFeedback
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 468);
            Controls.Add(btnView);
            Controls.Add(lblBack);
            Controls.Add(dataFeedback);
            Name = "admin_viewFeedback";
            Text = "viewFeedback";
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