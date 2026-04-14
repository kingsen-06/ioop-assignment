namespace assignment
{
    partial class student_registerPage
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
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtEmail = new TextBox();
            txtPassword = new TextBox();
            txtConfirmPassword = new TextBox();
            txtName = new TextBox();
            txtTPNum = new TextBox();
            label6 = new Label();
            btnRegister = new Button();
            lblBack = new Label();
            txtContact = new TextBox();
            txtAddress = new TextBox();
            label8 = new Label();
            label9 = new Label();
            btnShowPw = new Button();
            btnShowConfPw = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F);
            label1.Location = new Point(72, 78);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(72, 25);
            label1.TabIndex = 0;
            label1.Text = "Email : ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F);
            label2.Location = new Point(72, 128);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(105, 25);
            label2.TabIndex = 1;
            label2.Text = "Password : ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11F);
            label3.Location = new Point(72, 179);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(178, 25);
            label3.TabIndex = 3;
            label3.Text = "Confirm Password : ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11F);
            label4.Location = new Point(72, 230);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(76, 25);
            label4.TabIndex = 2;
            label4.Text = "Name : ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11F);
            label5.Location = new Point(72, 280);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(121, 25);
            label5.TabIndex = 4;
            label5.Text = "TP Number : ";
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Segoe UI", 11F);
            txtEmail.Location = new Point(240, 75);
            txtEmail.Margin = new Padding(2);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(279, 32);
            txtEmail.TabIndex = 5;
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Segoe UI", 11F);
            txtPassword.Location = new Point(240, 126);
            txtPassword.Margin = new Padding(2);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(279, 32);
            txtPassword.TabIndex = 6;
            // 
            // txtConfirmPassword
            // 
            txtConfirmPassword.Font = new Font("Segoe UI", 11F);
            txtConfirmPassword.Location = new Point(240, 177);
            txtConfirmPassword.Margin = new Padding(2);
            txtConfirmPassword.Name = "txtConfirmPassword";
            txtConfirmPassword.Size = new Size(279, 32);
            txtConfirmPassword.TabIndex = 7;
            // 
            // txtName
            // 
            txtName.Font = new Font("Segoe UI", 11F);
            txtName.Location = new Point(240, 227);
            txtName.Margin = new Padding(2);
            txtName.Name = "txtName";
            txtName.Size = new Size(279, 32);
            txtName.TabIndex = 8;
            // 
            // txtTPNum
            // 
            txtTPNum.Font = new Font("Segoe UI", 11F);
            txtTPNum.Location = new Point(240, 278);
            txtTPNum.Margin = new Padding(2);
            txtTPNum.Name = "txtTPNum";
            txtTPNum.Size = new Size(279, 32);
            txtTPNum.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 18F);
            label6.Location = new Point(202, 14);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(242, 41);
            label6.TabIndex = 10;
            label6.Text = "Register Account";
            // 
            // btnRegister
            // 
            btnRegister.Font = new Font("Segoe UI", 11F);
            btnRegister.Location = new Point(226, 434);
            btnRegister.Margin = new Padding(2);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(169, 34);
            btnRegister.TabIndex = 11;
            btnRegister.Text = "Register Account";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += btnRegister_Click;
            // 
            // lblBack
            // 
            lblBack.AutoSize = true;
            lblBack.Font = new Font("Segoe UI", 11F);
            lblBack.Location = new Point(22, 451);
            lblBack.Margin = new Padding(2, 0, 2, 0);
            lblBack.Name = "lblBack";
            lblBack.Size = new Size(191, 25);
            lblBack.TabIndex = 12;
            lblBack.Text = "< Back To Login Page";
            lblBack.Click += lblBack_Click;
            // 
            // txtContact
            // 
            txtContact.Font = new Font("Segoe UI", 11F);
            txtContact.Location = new Point(240, 330);
            txtContact.Margin = new Padding(2);
            txtContact.Name = "txtContact";
            txtContact.Size = new Size(279, 32);
            txtContact.TabIndex = 16;
            // 
            // txtAddress
            // 
            txtAddress.Font = new Font("Segoe UI", 11F);
            txtAddress.Location = new Point(240, 384);
            txtAddress.Margin = new Padding(2);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(279, 32);
            txtAddress.TabIndex = 15;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 11F);
            label8.Location = new Point(72, 333);
            label8.Margin = new Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new Size(165, 25);
            label8.TabIndex = 14;
            label8.Text = "Contact Number : ";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 11F);
            label9.Location = new Point(72, 386);
            label9.Margin = new Padding(2, 0, 2, 0);
            label9.Name = "label9";
            label9.Size = new Size(93, 25);
            label9.TabIndex = 13;
            label9.Text = "Address : ";
            // 
            // btnShowPw
            // 
            btnShowPw.Font = new Font("Segoe UI", 11F);
            btnShowPw.Location = new Point(535, 126);
            btnShowPw.Margin = new Padding(2);
            btnShowPw.Name = "btnShowPw";
            btnShowPw.Size = new Size(78, 29);
            btnShowPw.TabIndex = 17;
            btnShowPw.Text = "Show";
            btnShowPw.UseVisualStyleBackColor = true;
            btnShowPw.Click += btnShowPw_Click;
            // 
            // btnShowConfPw
            // 
            btnShowConfPw.Font = new Font("Segoe UI", 11F);
            btnShowConfPw.Location = new Point(535, 177);
            btnShowConfPw.Margin = new Padding(2);
            btnShowConfPw.Name = "btnShowConfPw";
            btnShowConfPw.Size = new Size(78, 29);
            btnShowConfPw.TabIndex = 18;
            btnShowConfPw.Text = "Show";
            btnShowConfPw.UseVisualStyleBackColor = true;
            btnShowConfPw.Click += btnShowConfPw_Click;
            // 
            // student_registerPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(633, 491);
            Controls.Add(btnShowConfPw);
            Controls.Add(btnShowPw);
            Controls.Add(txtContact);
            Controls.Add(txtAddress);
            Controls.Add(label8);
            Controls.Add(label9);
            Controls.Add(lblBack);
            Controls.Add(btnRegister);
            Controls.Add(label6);
            Controls.Add(txtTPNum);
            Controls.Add(txtName);
            Controls.Add(txtConfirmPassword);
            Controls.Add(txtPassword);
            Controls.Add(txtEmail);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(2);
            Name = "student_registerPage";
            Text = "registerPage";
            FormClosed += student_registerPage_FormClosed;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtEmail;
        private TextBox txtPassword;
        private TextBox txtConfirmPassword;
        private TextBox txtName;
        private TextBox txtTPNum;
        private Label label6;
        private Button btnRegister;
        private Label lblBack;
        private TextBox txtContact;
        private TextBox txtAddress;
        private Label label8;
        private Label label9;
        private Button btnShowPw;
        private Button btnShowConfPw;
    }
}