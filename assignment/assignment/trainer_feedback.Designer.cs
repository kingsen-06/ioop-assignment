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
            label1.Location = new Point(73, 33);
            label1.Name = "label1";
            label1.Size = new Size(123, 30);
            label1.TabIndex = 0;
            label1.Text = "Feedback : ";
            // 
            // txtFeedback
            // 
            txtFeedback.BorderStyle = BorderStyle.None;
            txtFeedback.Font = new Font("Segoe UI", 11F);
            txtFeedback.Location = new Point(73, 72);
            txtFeedback.Name = "txtFeedback";
            txtFeedback.Size = new Size(487, 247);
            txtFeedback.TabIndex = 1;
            txtFeedback.Text = "";
            // 
            // btnSend
            // 
            btnSend.Font = new Font("Segoe UI", 11F);
            btnSend.Location = new Point(202, 347);
            btnSend.Name = "btnSend";
            btnSend.Size = new Size(216, 39);
            btnSend.TabIndex = 2;
            btnSend.Text = "Send Feedback";
            btnSend.UseVisualStyleBackColor = true;
            // 
            // lblBack
            // 
            lblBack.AutoSize = true;
            lblBack.Font = new Font("Segoe UI", 11F);
            lblBack.Location = new Point(12, 402);
            lblBack.Name = "lblBack";
            lblBack.Size = new Size(239, 30);
            lblBack.TabIndex = 3;
            lblBack.Text = "< Back to Trainer Menu";
            lblBack.Click += lblBack_Click;
            // 
            // trainer_feedback
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(641, 447);
            Controls.Add(lblBack);
            Controls.Add(btnSend);
            Controls.Add(txtFeedback);
            Controls.Add(label1);
            Name = "trainer_feedback";
            Text = "feedback";
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