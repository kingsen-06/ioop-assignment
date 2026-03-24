namespace assignment
{
    partial class admin_addTrainer
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
            txtName = new TextBox();
            txtDOB = new TextBox();
            txtEmail = new TextBox();
            txtContact = new TextBox();
            txtAddress = new TextBox();
            label6 = new Label();
            lblBack = new Label();
            btnRegister = new Button();
            label7 = new Label();
            label8 = new Label();
            cmbLevel = new ComboBox();
            cmbModule = new ComboBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F);
            label1.Location = new Point(83, 102);
            label1.Name = "label1";
            label1.Size = new Size(121, 30);
            label1.TabIndex = 0;
            label1.Text = "Full Name: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F);
            label2.Location = new Point(83, 158);
            label2.Name = "label2";
            label2.Size = new Size(146, 30);
            label2.TabIndex = 1;
            label2.Text = "Date of Birth: ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11F);
            label3.Location = new Point(83, 217);
            label3.Name = "label3";
            label3.Size = new Size(75, 30);
            label3.TabIndex = 2;
            label3.Text = "Email: ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11F);
            label4.Location = new Point(83, 277);
            label4.Name = "label4";
            label4.Size = new Size(184, 30);
            label4.TabIndex = 3;
            label4.Text = "Contact Number: ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11F);
            label5.Location = new Point(83, 339);
            label5.Name = "label5";
            label5.Size = new Size(102, 30);
            label5.TabIndex = 4;
            label5.Text = "Address: ";
            // 
            // txtName
            // 
            txtName.Font = new Font("Segoe UI", 11F);
            txtName.Location = new Point(273, 99);
            txtName.Name = "txtName";
            txtName.Size = new Size(295, 37);
            txtName.TabIndex = 5;
            // 
            // txtDOB
            // 
            txtDOB.Font = new Font("Segoe UI", 11F);
            txtDOB.Location = new Point(273, 155);
            txtDOB.Name = "txtDOB";
            txtDOB.Size = new Size(295, 37);
            txtDOB.TabIndex = 6;
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Segoe UI", 11F);
            txtEmail.Location = new Point(273, 214);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(295, 37);
            txtEmail.TabIndex = 7;
            // 
            // txtContact
            // 
            txtContact.Font = new Font("Segoe UI", 11F);
            txtContact.Location = new Point(273, 274);
            txtContact.Name = "txtContact";
            txtContact.Size = new Size(295, 37);
            txtContact.TabIndex = 8;
            // 
            // txtAddress
            // 
            txtAddress.Font = new Font("Segoe UI", 11F);
            txtAddress.Location = new Point(273, 336);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(295, 37);
            txtAddress.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 18F);
            label6.Location = new Point(126, 23);
            label6.Name = "label6";
            label6.Size = new Size(406, 48);
            label6.TabIndex = 10;
            label6.Text = "New Trainer Information";
            // 
            // lblBack
            // 
            lblBack.AutoSize = true;
            lblBack.Font = new Font("Segoe UI", 11F);
            lblBack.Location = new Point(29, 557);
            lblBack.Name = "lblBack";
            lblBack.Size = new Size(79, 30);
            lblBack.TabIndex = 13;
            lblBack.Text = "< Back";
            lblBack.Click += lblBack_Click;
            // 
            // btnRegister
            // 
            btnRegister.Font = new Font("Segoe UI", 11F);
            btnRegister.Location = new Point(296, 529);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(236, 43);
            btnRegister.TabIndex = 14;
            btnRegister.Text = "Register New Trainer";
            btnRegister.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 11F);
            label7.Location = new Point(83, 408);
            label7.Name = "label7";
            label7.Size = new Size(157, 30);
            label7.TabIndex = 15;
            label7.Text = "Module Name:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 11F);
            label8.Location = new Point(83, 469);
            label8.Name = "label8";
            label8.Size = new Size(122, 30);
            label8.TabIndex = 17;
            label8.Text = "Class Level:";
            // 
            // cmbLevel
            // 
            cmbLevel.Font = new Font("Segoe UI", 11F);
            cmbLevel.FormattingEnabled = true;
            cmbLevel.Items.AddRange(new object[] { "Beginner", "Intermediate", "Advance" });
            cmbLevel.Location = new Point(273, 466);
            cmbLevel.Name = "cmbLevel";
            cmbLevel.Size = new Size(295, 38);
            cmbLevel.TabIndex = 18;
            // 
            // cmbModule
            // 
            cmbModule.Font = new Font("Segoe UI", 11F);
            cmbModule.FormattingEnabled = true;
            cmbModule.Location = new Point(273, 405);
            cmbModule.Name = "cmbModule";
            cmbModule.Size = new Size(295, 38);
            cmbModule.TabIndex = 19;
            // 
            // admin_addTrainer
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(667, 614);
            Controls.Add(cmbModule);
            Controls.Add(cmbLevel);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(btnRegister);
            Controls.Add(lblBack);
            Controls.Add(label6);
            Controls.Add(txtAddress);
            Controls.Add(txtContact);
            Controls.Add(txtEmail);
            Controls.Add(txtDOB);
            Controls.Add(txtName);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "admin_addTrainer";
            Text = "addTrainer";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtName;
        private TextBox txtDOB;
        private TextBox txtEmail;
        private TextBox txtContact;
        private TextBox txtAddress;
        private Label label6;
        private Label lblBack;
        private Button btnRegister;
        private Label label7;
        private Label label8;
        private ComboBox cmbLevel;
        private ComboBox cmbModule;
    }
}