namespace assignment
{
    partial class admin_feedbackDetail
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
            lblDate = new Label();
            lblTrainer = new Label();
            txtFeedback = new RichTextBox();
            lblBack = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F);
            label1.Location = new Point(65, 41);
            label1.Name = "label1";
            label1.Size = new Size(150, 30);
            label1.TabIndex = 0;
            label1.Text = "From trainer : ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F);
            label2.Location = new Point(65, 93);
            label2.Name = "label2";
            label2.Size = new Size(103, 30);
            label2.TabIndex = 1;
            label2.Text = "By date : ";
            // 
            // lblDate
            // 
            lblDate.AutoSize = true;
            lblDate.BorderStyle = BorderStyle.Fixed3D;
            lblDate.Font = new Font("Segoe UI", 11F);
            lblDate.Location = new Point(224, 93);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(2, 32);
            lblDate.TabIndex = 3;
            // 
            // lblTrainer
            // 
            lblTrainer.AutoSize = true;
            lblTrainer.BorderStyle = BorderStyle.Fixed3D;
            lblTrainer.Font = new Font("Segoe UI", 11F);
            lblTrainer.Location = new Point(224, 41);
            lblTrainer.Name = "lblTrainer";
            lblTrainer.Size = new Size(2, 32);
            lblTrainer.TabIndex = 2;
            // 
            // txtFeedback
            // 
            txtFeedback.BorderStyle = BorderStyle.None;
            txtFeedback.Font = new Font("Segoe UI", 11F);
            txtFeedback.Location = new Point(65, 153);
            txtFeedback.Name = "txtFeedback";
            txtFeedback.Size = new Size(504, 229);
            txtFeedback.TabIndex = 4;
            txtFeedback.Text = "";
            // 
            // lblBack
            // 
            lblBack.AutoSize = true;
            lblBack.Font = new Font("Segoe UI", 11F);
            lblBack.Location = new Point(24, 408);
            lblBack.Name = "lblBack";
            lblBack.Size = new Size(79, 30);
            lblBack.TabIndex = 5;
            lblBack.Text = "< Back";
            lblBack.Click += lblBack_Click;
            // 
            // admin_feedbackDetail
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(642, 455);
            Controls.Add(lblBack);
            Controls.Add(txtFeedback);
            Controls.Add(lblDate);
            Controls.Add(lblTrainer);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "admin_feedbackDetail";
            Text = "feedbackDetail";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label lblDate;
        private Label lblTrainer;
        private RichTextBox txtFeedback;
        private Label lblBack;
    }
}