namespace assignment
{
    partial class main_loginPage
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblEmail = new Label();
            txtEmail = new TextBox();
            txtPassword = new TextBox();
            lblPassword = new Label();
            btnLogin = new Button();
            SuspendLayout();
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI", 11F);
            lblEmail.Location = new Point(114, 59);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(72, 25);
            lblEmail.TabIndex = 0;
            lblEmail.Text = "Email : ";
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Segoe UI", 11F);
            txtEmail.Location = new Point(256, 57);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(174, 32);
            txtEmail.TabIndex = 2;
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Segoe UI", 11F);
            txtPassword.Location = new Point(256, 101);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(174, 32);
            txtPassword.TabIndex = 4;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Segoe UI", 11F);
            lblPassword.Location = new Point(114, 103);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(100, 25);
            lblPassword.TabIndex = 3;
            lblPassword.Text = "Password :";
            // 
            // btnLogin
            // 
            btnLogin.Font = new Font("Segoe UI", 11F);
            btnLogin.Location = new Point(194, 163);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(131, 33);
            btnLogin.TabIndex = 5;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // main_loginPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(543, 254);
            Controls.Add(btnLogin);
            Controls.Add(txtPassword);
            Controls.Add(lblPassword);
            Controls.Add(txtEmail);
            Controls.Add(lblEmail);
            Name = "main_loginPage";
            Text = "loginPage";
            FormClosed += main_loginPage_FormClosed;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblEmail;
        private TextBox txtEmail;
        private TextBox txtPassword;
        private Label lblPassword;
        private Button btnLogin;
    }
}
