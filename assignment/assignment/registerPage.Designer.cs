namespace assignment
{
    partial class registerPage
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
            btnRegister = new Button();
            txtPassword = new TextBox();
            lblPassword = new Label();
            txtUsername = new TextBox();
            lblUsername = new Label();
            btnBack = new Button();
            SuspendLayout();
            // 
            // btnRegister
            // 
            btnRegister.Font = new Font("Segoe UI", 12F);
            btnRegister.Location = new Point(404, 265);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(131, 43);
            btnRegister.TabIndex = 12;
            btnRegister.Text = "Register";
            btnRegister.UseVisualStyleBackColor = true;
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Segoe UI", 12F);
            txtPassword.Location = new Point(390, 186);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(145, 34);
            txtPassword.TabIndex = 10;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Segoe UI", 12F);
            lblPassword.Location = new Point(265, 189);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(102, 28);
            lblPassword.TabIndex = 9;
            lblPassword.Text = "Password :";
            // 
            // txtUsername
            // 
            txtUsername.Font = new Font("Segoe UI", 12F);
            txtUsername.Location = new Point(390, 142);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(145, 34);
            txtUsername.TabIndex = 8;
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Font = new Font("Segoe UI", 12F);
            lblUsername.Location = new Point(265, 145);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(108, 28);
            lblUsername.TabIndex = 7;
            lblUsername.Text = "Username :";
            // 
            // btnBack
            // 
            btnBack.Font = new Font("Segoe UI", 12F);
            btnBack.Location = new Point(265, 265);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(131, 43);
            btnBack.TabIndex = 11;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // registerPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnRegister);
            Controls.Add(btnBack);
            Controls.Add(txtPassword);
            Controls.Add(lblPassword);
            Controls.Add(txtUsername);
            Controls.Add(lblUsername);
            Name = "registerPage";
            Text = "registerPage";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnRegister;
        private TextBox txtPassword;
        private Label lblPassword;
        private TextBox txtUsername;
        private Label lblUsername;
        private Button btnBack;
    }
}