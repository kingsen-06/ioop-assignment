namespace assignment
{
    partial class lec_rejectReason
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
            txtReason = new RichTextBox();
            lblBack = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F);
            label1.Location = new Point(50, 38);
            label1.Name = "label1";
            label1.Size = new Size(159, 30);
            label1.TabIndex = 0;
            label1.Text = "Reject reason : ";
            // 
            // txtReason
            // 
            txtReason.Font = new Font("Segoe UI", 11F);
            txtReason.Location = new Point(50, 76);
            txtReason.Name = "txtReason";
            txtReason.Size = new Size(474, 234);
            txtReason.TabIndex = 1;
            txtReason.Text = "";
            // 
            // lblBack
            // 
            lblBack.AutoSize = true;
            lblBack.Font = new Font("Segoe UI", 11F);
            lblBack.Location = new Point(26, 343);
            lblBack.Name = "lblBack";
            lblBack.Size = new Size(79, 30);
            lblBack.TabIndex = 2;
            lblBack.Text = "< Back";
            lblBack.Click += lblBack_Click;
            // 
            // lec_rejectReason
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(579, 392);
            Controls.Add(lblBack);
            Controls.Add(txtReason);
            Controls.Add(label1);
            Name = "lec_rejectReason";
            Text = "lec_rejectReason";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private RichTextBox txtReason;
        private Label lblBack;
    }
}