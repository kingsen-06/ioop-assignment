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
            label1.Location = new Point(52, 33);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(130, 25);
            label1.TabIndex = 0;
            label1.Text = "From trainer : ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F);
            label2.Location = new Point(52, 74);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(88, 25);
            label2.TabIndex = 1;
            label2.Text = "By date : ";
            // 
            // lblDate
            // 
            lblDate.AutoSize = true;
            lblDate.BorderStyle = BorderStyle.Fixed3D;
            lblDate.Font = new Font("Segoe UI", 11F);
            lblDate.Location = new Point(179, 74);
            lblDate.Margin = new Padding(2, 0, 2, 0);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(2, 27);
            lblDate.TabIndex = 3;
            // 
            // lblTrainer
            // 
            lblTrainer.AutoSize = true;
            lblTrainer.BorderStyle = BorderStyle.Fixed3D;
            lblTrainer.Font = new Font("Segoe UI", 11F);
            lblTrainer.Location = new Point(179, 33);
            lblTrainer.Margin = new Padding(2, 0, 2, 0);
            lblTrainer.Name = "lblTrainer";
            lblTrainer.Size = new Size(2, 27);
            lblTrainer.TabIndex = 2;
            // 
            // txtFeedback
            // 
            txtFeedback.BorderStyle = BorderStyle.None;
            txtFeedback.Font = new Font("Segoe UI", 11F);
            txtFeedback.Location = new Point(52, 122);
            txtFeedback.Margin = new Padding(2);
            txtFeedback.Name = "txtFeedback";
            txtFeedback.ReadOnly = true;
            txtFeedback.Size = new Size(403, 183);
            txtFeedback.TabIndex = 4;
            txtFeedback.Text = "";
            // 
            // lblBack
            // 
            lblBack.AutoSize = true;
            lblBack.Font = new Font("Segoe UI", 11F);
            lblBack.Location = new Point(19, 326);
            lblBack.Margin = new Padding(2, 0, 2, 0);
            lblBack.Name = "lblBack";
            lblBack.Size = new Size(69, 25);
            lblBack.TabIndex = 5;
            lblBack.Text = "< Back";
            lblBack.Click += lblBack_Click;
            // 
            // admin_feedbackDetail
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(514, 364);
            Controls.Add(lblBack);
            Controls.Add(txtFeedback);
            Controls.Add(lblDate);
            Controls.Add(lblTrainer);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(2);
            Name = "admin_feedbackDetail";
            Text = "feedbackDetail";
            Load += admin_feedbackDetail_Load;
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