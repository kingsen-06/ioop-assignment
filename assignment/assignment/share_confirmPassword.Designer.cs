namespace assignment
{
    partial class share_confirmPassword
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
            txtPassword = new TextBox();
            label1 = new Label();
            lblBack = new Label();
            lblNext = new Label();
            SuspendLayout();
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Segoe UI", 11F);
            txtPassword.Location = new Point(178, 85);
            txtPassword.Margin = new Padding(2, 2, 2, 2);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(236, 32);
            txtPassword.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F);
            label1.Location = new Point(52, 87);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(105, 25);
            label1.TabIndex = 1;
            label1.Text = "Password : ";
            // 
            // lblBack
            // 
            lblBack.AutoSize = true;
            lblBack.Font = new Font("Segoe UI", 11F);
            lblBack.Location = new Point(11, 174);
            lblBack.Margin = new Padding(2, 0, 2, 0);
            lblBack.Name = "lblBack";
            lblBack.Size = new Size(145, 25);
            lblBack.TabIndex = 2;
            lblBack.Text = "< Back to Menu";
            lblBack.Click += lblBack_Click;
            // 
            // lblNext
            // 
            lblNext.AutoSize = true;
            lblNext.Font = new Font("Segoe UI", 11F);
            lblNext.Location = new Point(402, 174);
            lblNext.Margin = new Padding(2, 0, 2, 0);
            lblNext.Name = "lblNext";
            lblNext.Size = new Size(69, 25);
            lblNext.TabIndex = 3;
            lblNext.Text = "Next >";
            lblNext.Click += lblNext_Click;
            // 
            // share_confirmPassword
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(479, 216);
            Controls.Add(lblNext);
            Controls.Add(lblBack);
            Controls.Add(label1);
            Controls.Add(txtPassword);
            Margin = new Padding(2, 2, 2, 2);
            Name = "share_confirmPassword";
            Text = "confirmPassword";
            FormClosed += share_confirmPassword_FormClosed;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtPassword;
        private Label label1;
        private Label lblBack;
        private Label lblNext;
    }
}