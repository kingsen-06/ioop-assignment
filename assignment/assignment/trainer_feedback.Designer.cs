namespace assignment
{
    partial class trainer_feedback
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
            txtFeedback = new RichTextBox();
            btnSend = new Button();
            lblBack = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F);
            label1.Location = new Point(58, 26);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(105, 25);
            label1.TabIndex = 0;
            label1.Text = "Feedback : ";
            // 
            // txtFeedback
            // 
            txtFeedback.BorderStyle = BorderStyle.None;
            txtFeedback.Font = new Font("Segoe UI", 11F);
            txtFeedback.Location = new Point(58, 58);
            txtFeedback.Margin = new Padding(2);
            txtFeedback.Name = "txtFeedback";
            txtFeedback.Size = new Size(390, 198);
            txtFeedback.TabIndex = 1;
            txtFeedback.Text = "";
            // 
            // btnSend
            // 
            btnSend.Font = new Font("Segoe UI", 11F);
            btnSend.Location = new Point(162, 278);
            btnSend.Margin = new Padding(2);
            btnSend.Name = "btnSend";
            btnSend.Size = new Size(173, 31);
            btnSend.TabIndex = 2;
            btnSend.Text = "Send Feedback";
            btnSend.UseVisualStyleBackColor = true;
            btnSend.Click += btnSend_Click;
            // 
            // lblBack
            // 
            lblBack.AutoSize = true;
            lblBack.Font = new Font("Segoe UI", 11F);
            lblBack.Location = new Point(10, 322);
            lblBack.Margin = new Padding(2, 0, 2, 0);
            lblBack.Name = "lblBack";
            lblBack.Size = new Size(208, 25);
            lblBack.TabIndex = 3;
            lblBack.Text = "< Back to Trainer Menu";
            lblBack.Click += lblBack_Click;
            // 
            // trainer_feedback
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(513, 358);
            Controls.Add(lblBack);
            Controls.Add(btnSend);
            Controls.Add(txtFeedback);
            Controls.Add(label1);
            Margin = new Padding(2);
            Name = "trainer_feedback";
            Text = "feedback";
            FormClosed += trainer_feedback_FormClosed;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private RichTextBox txtFeedback;
        private Button btnSend;
        private Label lblBack;
    }
}