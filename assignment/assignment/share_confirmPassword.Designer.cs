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
            txtPassword.Location = new Point(222, 106);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(294, 37);
            txtPassword.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F);
            label1.Location = new Point(65, 109);
            label1.Name = "label1";
            label1.Size = new Size(120, 30);
            label1.TabIndex = 1;
            label1.Text = "Password : ";
            // 
            // lblBack
            // 
            lblBack.AutoSize = true;
            lblBack.Font = new Font("Segoe UI", 11F);
            lblBack.Location = new Point(14, 217);
            lblBack.Name = "lblBack";
            lblBack.Size = new Size(167, 30);
            lblBack.TabIndex = 2;
            lblBack.Text = "< Back to Menu";
            lblBack.Click += lblBack_Click;
            // 
            // lblNext
            // 
            lblNext.AutoSize = true;
            lblNext.Font = new Font("Segoe UI", 11F);
            lblNext.Location = new Point(502, 217);
            lblNext.Name = "lblNext";
            lblNext.Size = new Size(79, 30);
            lblNext.TabIndex = 3;
            lblNext.Text = "Next >";
            lblNext.Click += lblNext_Click;
            // 
            // share_confirmPassword
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(599, 270);
            Controls.Add(lblNext);
            Controls.Add(lblBack);
            Controls.Add(label1);
            Controls.Add(txtPassword);
            Name = "share_confirmPassword";
            Text = "confirmPassword";
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