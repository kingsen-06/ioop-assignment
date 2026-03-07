namespace assignment
{
    partial class admin_updateProfile
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
            label6 = new Label();
            lblDelete = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtUsername = new TextBox();
            txtPw = new TextBox();
            txtEmail = new TextBox();
            txtContact = new TextBox();
            txtAddress = new TextBox();
            button1 = new Button();
            btnShow = new Button();
            SuspendLayout();
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 18F);
            label6.Location = new Point(315, 19);
            label6.Name = "label6";
            label6.Size = new Size(248, 48);
            label6.TabIndex = 29;
            label6.Text = "Update Profile";
            // 
            // lblDelete
            // 
            lblDelete.AutoSize = true;
            lblDelete.Font = new Font("Segoe UI", 11F);
            lblDelete.Location = new Point(662, 411);
            lblDelete.Name = "lblDelete";
            lblDelete.Size = new Size(181, 30);
            lblDelete.TabIndex = 23;
            lblDelete.Text = "Delete Account >";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11F);
            label5.Location = new Point(48, 337);
            label5.Name = "label5";
            label5.Size = new Size(91, 30);
            label5.TabIndex = 22;
            label5.Text = "Address";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11F);
            label4.Location = new Point(48, 274);
            label4.Name = "label4";
            label4.Size = new Size(173, 30);
            label4.TabIndex = 21;
            label4.Text = "Contact Number";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11F);
            label3.Location = new Point(48, 209);
            label3.Name = "label3";
            label3.Size = new Size(64, 30);
            label3.TabIndex = 20;
            label3.Text = "Email";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F);
            label2.Location = new Point(48, 146);
            label2.Name = "label2";
            label2.Size = new Size(103, 30);
            label2.TabIndex = 19;
            label2.Text = "Password";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F);
            label1.Location = new Point(48, 85);
            label1.Name = "label1";
            label1.Size = new Size(111, 30);
            label1.TabIndex = 18;
            label1.Text = "Username";
            // 
            // txtUsername
            // 
            txtUsername.Font = new Font("Segoe UI", 11F);
            txtUsername.Location = new Point(244, 86);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(395, 37);
            txtUsername.TabIndex = 30;
            // 
            // txtPw
            // 
            txtPw.Font = new Font("Segoe UI", 11F);
            txtPw.Location = new Point(244, 147);
            txtPw.Name = "txtPw";
            txtPw.Size = new Size(395, 37);
            txtPw.TabIndex = 31;
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Segoe UI", 11F);
            txtEmail.Location = new Point(244, 210);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(395, 37);
            txtEmail.TabIndex = 32;
            // 
            // txtContact
            // 
            txtContact.Font = new Font("Segoe UI", 11F);
            txtContact.Location = new Point(244, 275);
            txtContact.Name = "txtContact";
            txtContact.Size = new Size(395, 37);
            txtContact.TabIndex = 33;
            // 
            // txtAddress
            // 
            txtAddress.Font = new Font("Segoe UI", 11F);
            txtAddress.Location = new Point(244, 338);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(395, 37);
            txtAddress.TabIndex = 34;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 11F);
            button1.Location = new Point(361, 393);
            button1.Name = "button1";
            button1.Size = new Size(159, 38);
            button1.TabIndex = 35;
            button1.Text = "Save Change";
            button1.UseVisualStyleBackColor = true;
            // 
            // btnShow
            // 
            btnShow.Font = new Font("Segoe UI", 11F);
            btnShow.Location = new Point(662, 147);
            btnShow.Name = "btnShow";
            btnShow.Size = new Size(180, 38);
            btnShow.TabIndex = 36;
            btnShow.Text = "Show Password";
            btnShow.UseVisualStyleBackColor = true;
            btnShow.Click += btnShow_Click;
            // 
            // admin_updateProfile
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(863, 453);
            Controls.Add(btnShow);
            Controls.Add(button1);
            Controls.Add(txtAddress);
            Controls.Add(txtContact);
            Controls.Add(txtEmail);
            Controls.Add(txtPw);
            Controls.Add(txtUsername);
            Controls.Add(label6);
            Controls.Add(lblDelete);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "admin_updateProfile";
            Text = "updateProfile";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label6;
        private Label lblDelete;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtUsername;
        private TextBox txtPw;
        private TextBox txtEmail;
        private TextBox txtContact;
        private TextBox txtAddress;
        private Button button1;
        private Button btnShow;
    }
}