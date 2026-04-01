namespace assignment
{
    partial class admin_addLec
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
            lblBack = new Label();
            label6 = new Label();
            txtAddress = new TextBox();
            txtContact = new TextBox();
            txtEmail = new TextBox();
            txtName = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            dateDOB = new DateTimePicker();
            SuspendLayout();
            // 
            // btnRegister
            // 
            btnRegister.Font = new Font("Segoe UI", 11F);
            btnRegister.Location = new Point(331, 412);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(236, 43);
            btnRegister.TabIndex = 32;
            btnRegister.Text = "Register New Lecturer";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += btnRegister_Click;
            // 
            // lblBack
            // 
            lblBack.AutoSize = true;
            lblBack.Font = new Font("Segoe UI", 11F);
            lblBack.Location = new Point(41, 456);
            lblBack.Name = "lblBack";
            lblBack.Size = new Size(79, 30);
            lblBack.TabIndex = 31;
            lblBack.Text = "< Back";
            lblBack.Click += lblBack_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 18F);
            label6.Location = new Point(154, 35);
            label6.Name = "label6";
            label6.Size = new Size(428, 48);
            label6.TabIndex = 30;
            label6.Text = "New Lecturer Information";
            // 
            // txtAddress
            // 
            txtAddress.Font = new Font("Segoe UI", 11F);
            txtAddress.Location = new Point(301, 348);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(295, 37);
            txtAddress.TabIndex = 29;
            // 
            // txtContact
            // 
            txtContact.Font = new Font("Segoe UI", 11F);
            txtContact.Location = new Point(301, 286);
            txtContact.Name = "txtContact";
            txtContact.Size = new Size(295, 37);
            txtContact.TabIndex = 28;
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Segoe UI", 11F);
            txtEmail.Location = new Point(301, 226);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(295, 37);
            txtEmail.TabIndex = 27;
            // 
            // txtName
            // 
            txtName.Font = new Font("Segoe UI", 11F);
            txtName.Location = new Point(301, 111);
            txtName.Name = "txtName";
            txtName.Size = new Size(295, 37);
            txtName.TabIndex = 25;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11F);
            label5.Location = new Point(111, 351);
            label5.Name = "label5";
            label5.Size = new Size(102, 30);
            label5.TabIndex = 24;
            label5.Text = "Address: ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11F);
            label4.Location = new Point(111, 289);
            label4.Name = "label4";
            label4.Size = new Size(184, 30);
            label4.TabIndex = 23;
            label4.Text = "Contact Number: ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11F);
            label3.Location = new Point(111, 229);
            label3.Name = "label3";
            label3.Size = new Size(75, 30);
            label3.TabIndex = 22;
            label3.Text = "Email: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F);
            label2.Location = new Point(111, 170);
            label2.Name = "label2";
            label2.Size = new Size(146, 30);
            label2.TabIndex = 21;
            label2.Text = "Date of Birth: ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F);
            label1.Location = new Point(111, 114);
            label1.Name = "label1";
            label1.Size = new Size(121, 30);
            label1.TabIndex = 20;
            label1.Text = "Full Name: ";
            // 
            // dateDOB
            // 
            dateDOB.Font = new Font("Segoe UI", 11F);
            dateDOB.Location = new Point(301, 165);
            dateDOB.Name = "dateDOB";
            dateDOB.Size = new Size(295, 37);
            dateDOB.TabIndex = 33;
            // 
            // admin_addLec
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(715, 529);
            Controls.Add(dateDOB);
            Controls.Add(btnRegister);
            Controls.Add(lblBack);
            Controls.Add(label6);
            Controls.Add(txtAddress);
            Controls.Add(txtContact);
            Controls.Add(txtEmail);
            Controls.Add(txtName);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "admin_addLec";
            Text = "admin_addLec";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnRegister;
        private Label lblBack;
        private Label label6;
        private TextBox txtAddress;
        private TextBox txtContact;
        private TextBox txtEmail;
        private TextBox txtName;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private DateTimePicker dateDOB;
    }
}