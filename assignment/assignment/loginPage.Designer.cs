namespace assignment
{
    partial class loginPage
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
            lblUsername = new Label();
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            lblPassword = new Label();
            btnLogin = new Button();
            btnRegister = new Button();
            SuspendLayout();
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Font = new Font("Segoe UI", 12F);
            lblUsername.Location = new Point(259, 127);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(108, 28);
            lblUsername.TabIndex = 0;
            lblUsername.Text = "Username :";
            // 
            // txtUsername
            // 
            txtUsername.Font = new Font("Segoe UI", 12F);
            txtUsername.Location = new Point(384, 124);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(145, 34);
            txtUsername.TabIndex = 2;
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Segoe UI", 12F);
            txtPassword.Location = new Point(384, 168);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(145, 34);
            txtPassword.TabIndex = 4;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Segoe UI", 12F);
            lblPassword.Location = new Point(259, 171);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(102, 28);
            lblPassword.TabIndex = 3;
            lblPassword.Text = "Password :";
            // 
            // btnLogin
            // 
            btnLogin.Font = new Font("Segoe UI", 12F);
            btnLogin.Location = new Point(398, 247);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(131, 43);
            btnLogin.TabIndex = 5;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            // 
            // btnRegister
            // 
            btnRegister.Font = new Font("Segoe UI", 12F);
            btnRegister.Location = new Point(259, 247);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(131, 43);
            btnRegister.TabIndex = 6;
            btnRegister.Text = "Register";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += btnRegister_Click;
            // 
            // loginPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnRegister);
            Controls.Add(btnLogin);
            Controls.Add(txtPassword);
            Controls.Add(lblPassword);
            Controls.Add(txtUsername);
            Controls.Add(lblUsername);
            Name = "loginPage";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblUsername;
        private TextBox txtUsername;
        private TextBox txtPassword;
        private Label lblPassword;
        private Button btnLogin;
        private Button btnRegister;
    }
}
