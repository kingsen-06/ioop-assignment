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
            txtEmail = new TextBox();
            txtContact = new TextBox();
            txtAddress = new TextBox();
            label8 = new Label();
            lblBack = new Label();
            btnRegister = new Button();
            label6 = new Label();
            label7 = new Label();
            cmbModule = new ComboBox();
            dateDOB = new DateTimePicker();
            lblLevel = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F);
            label1.Location = new Point(67, 80);
            label1.Name = "label1";
            label1.Size = new Size(106, 25);
            label1.TabIndex = 0;
            label1.Text = "Full Name: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F);
            label2.Location = new Point(66, 126);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(127, 25);
            label2.TabIndex = 1;
            label2.Text = "Date of Birth: ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11F);
            label3.Location = new Point(66, 174);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(67, 25);
            label3.TabIndex = 2;
            label3.Text = "Email: ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11F);
            label4.Location = new Point(66, 222);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(160, 25);
            label4.TabIndex = 3;
            label4.Text = "Contact Number: ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11F);
            label5.Location = new Point(66, 271);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(88, 25);
            label5.TabIndex = 4;
            label5.Text = "Address: ";
            // 
            // txtName
            // 
            txtName.Font = new Font("Segoe UI", 11F);
            txtName.Location = new Point(218, 77);
            txtName.Name = "txtName";
            txtName.Size = new Size(237, 32);
            txtName.TabIndex = 5;
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Segoe UI", 11F);
            txtEmail.Location = new Point(218, 171);
            txtEmail.Margin = new Padding(2);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(237, 32);
            txtEmail.TabIndex = 7;
            // 
            // txtContact
            // 
            txtContact.Font = new Font("Segoe UI", 11F);
            txtContact.Location = new Point(218, 219);
            txtContact.Margin = new Padding(2);
            txtContact.Name = "txtContact";
            txtContact.Size = new Size(237, 32);
            txtContact.TabIndex = 8;
            // 
            // txtAddress
            // 
            txtAddress.Font = new Font("Segoe UI", 11F);
            txtAddress.Location = new Point(218, 269);
            txtAddress.Margin = new Padding(2);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(237, 32);
            txtAddress.TabIndex = 9;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 18F);
            label8.Location = new Point(101, 18);
            label8.Margin = new Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new Size(337, 41);
            label8.TabIndex = 10;
            label8.Text = "New Trainer Information";
            // 
            // lblBack
            // 
            lblBack.AutoSize = true;
            lblBack.Font = new Font("Segoe UI", 11F);
            lblBack.Location = new Point(24, 459);
            lblBack.Margin = new Padding(2, 0, 2, 0);
            lblBack.Name = "lblBack";
            lblBack.Size = new Size(69, 25);
            lblBack.TabIndex = 13;
            lblBack.Text = "< Back";
            lblBack.Click += lblBack_Click;
            // 
            // btnRegister
            // 
            btnRegister.Font = new Font("Segoe UI", 11F);
            btnRegister.Location = new Point(242, 424);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(189, 34);
            btnRegister.TabIndex = 14;
            btnRegister.Text = "Register New Trainer";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += btnRegister_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11F);
            label6.Location = new Point(66, 324);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(136, 25);
            label6.TabIndex = 15;
            label6.Text = "Module Name:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 11F);
            label7.Location = new Point(66, 375);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(107, 25);
            label7.TabIndex = 17;
            label7.Text = "Class Level:";
            // 
            // cmbModule
            // 
            cmbModule.Font = new Font("Segoe UI", 11F);
            cmbModule.FormattingEnabled = true;
            cmbModule.Location = new Point(218, 322);
            cmbModule.Margin = new Padding(2);
            cmbModule.Name = "cmbModule";
            cmbModule.Size = new Size(237, 33);
            cmbModule.TabIndex = 19;
            cmbModule.SelectedIndexChanged += cmbModule_SelectedIndexChanged;
            // 
            // dateDOB
            // 
            dateDOB.CalendarFont = new Font("Segoe UI", 11F);
            dateDOB.Font = new Font("Segoe UI", 11F);
            dateDOB.Location = new Point(218, 126);
            dateDOB.Name = "dateDOB";
            dateDOB.Size = new Size(237, 32);
            dateDOB.TabIndex = 20;
            // 
            // lblLevel
            // 
            lblLevel.AutoSize = true;
            lblLevel.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblLevel.Location = new Point(218, 375);
            lblLevel.Name = "lblLevel";
            lblLevel.Size = new Size(0, 25);
            lblLevel.TabIndex = 21;
            // 
            // admin_addTrainer
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(531, 510);
            Controls.Add(lblLevel);
            Controls.Add(dateDOB);
            Controls.Add(cmbModule);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(btnRegister);
            Controls.Add(lblBack);
            Controls.Add(label8);
            Controls.Add(txtAddress);
            Controls.Add(txtContact);
            Controls.Add(txtEmail);
            Controls.Add(txtName);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(2);
            Name = "admin_addTrainer";
            Text = "addTrainer";
            FormClosed += admin_addTrainer_FormClosed;
            Load += admin_addTrainer_Load;
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
        private TextBox txtEmail;
        private TextBox txtContact;
        private TextBox txtAddress;
        private Label label8;
        private Label lblBack;
        private Button btnRegister;
        private Label label6;
        private Label label7;
        private ComboBox cmbModule;
        private DateTimePicker dateDOB;
        private Label lblLevel;
    }
}