namespace assignment
{
    partial class lec_addStudent
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
            label7 = new Label();
            label8 = new Label();
            txtName = new TextBox();
            txtTPNum = new TextBox();
            txtEmail = new TextBox();
            txtAddress = new TextBox();
            txtContact = new TextBox();
            cmbModName = new ComboBox();
            lblBack = new Label();
            bnRegister = new Button();
            label6 = new Label();
            lblLevel = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F);
            label1.Location = new Point(65, 36);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(76, 25);
            label1.TabIndex = 0;
            label1.Text = "Name : ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F);
            label2.Location = new Point(65, 77);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(121, 25);
            label2.TabIndex = 1;
            label2.Text = "TP Number : ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11F);
            label3.Location = new Point(65, 158);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(165, 25);
            label3.TabIndex = 3;
            label3.Text = "Contact Number : ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11F);
            label4.Location = new Point(65, 118);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(72, 25);
            label4.TabIndex = 2;
            label4.Text = "Email : ";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 11F);
            label7.Location = new Point(65, 240);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(141, 25);
            label7.TabIndex = 5;
            label7.Text = "Module Name :";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 11F);
            label8.Location = new Point(65, 199);
            label8.Margin = new Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new Size(93, 25);
            label8.TabIndex = 4;
            label8.Text = "Address : ";
            // 
            // txtName
            // 
            txtName.Font = new Font("Segoe UI", 11F);
            txtName.Location = new Point(227, 34);
            txtName.Margin = new Padding(2);
            txtName.Name = "txtName";
            txtName.Size = new Size(234, 32);
            txtName.TabIndex = 7;
            // 
            // txtTPNum
            // 
            txtTPNum.Font = new Font("Segoe UI", 11F);
            txtTPNum.Location = new Point(227, 74);
            txtTPNum.Margin = new Padding(2);
            txtTPNum.Name = "txtTPNum";
            txtTPNum.Size = new Size(234, 32);
            txtTPNum.TabIndex = 8;
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Segoe UI", 11F);
            txtEmail.Location = new Point(227, 115);
            txtEmail.Margin = new Padding(2);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(234, 32);
            txtEmail.TabIndex = 9;
            // 
            // txtAddress
            // 
            txtAddress.Font = new Font("Segoe UI", 11F);
            txtAddress.Location = new Point(227, 197);
            txtAddress.Margin = new Padding(2);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(234, 32);
            txtAddress.TabIndex = 11;
            // 
            // txtContact
            // 
            txtContact.Font = new Font("Segoe UI", 11F);
            txtContact.Location = new Point(227, 156);
            txtContact.Margin = new Padding(2);
            txtContact.Name = "txtContact";
            txtContact.Size = new Size(234, 32);
            txtContact.TabIndex = 10;
            // 
            // cmbModName
            // 
            cmbModName.Font = new Font("Segoe UI", 11F);
            cmbModName.FormattingEnabled = true;
            cmbModName.Location = new Point(227, 238);
            cmbModName.Margin = new Padding(2);
            cmbModName.Name = "cmbModName";
            cmbModName.Size = new Size(234, 33);
            cmbModName.TabIndex = 12;
            cmbModName.SelectedIndexChanged += cmbModName_SelectedIndexChanged;
            // 
            // lblBack
            // 
            lblBack.AutoSize = true;
            lblBack.Font = new Font("Segoe UI", 11F);
            lblBack.Location = new Point(27, 344);
            lblBack.Margin = new Padding(2, 0, 2, 0);
            lblBack.Name = "lblBack";
            lblBack.Size = new Size(69, 25);
            lblBack.TabIndex = 14;
            lblBack.Text = "< Back";
            lblBack.Click += lblBack_Click;
            // 
            // bnRegister
            // 
            bnRegister.Font = new Font("Segoe UI", 11F);
            bnRegister.Location = new Point(290, 328);
            bnRegister.Margin = new Padding(2);
            bnRegister.Name = "bnRegister";
            bnRegister.Size = new Size(104, 32);
            bnRegister.TabIndex = 15;
            bnRegister.Text = "Register";
            bnRegister.UseVisualStyleBackColor = true;
            bnRegister.Click += bnRegister_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11F);
            label6.Location = new Point(65, 282);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(112, 25);
            label6.TabIndex = 6;
            label6.Text = "Class Level :";
            // 
            // lblLevel
            // 
            lblLevel.AutoSize = true;
            lblLevel.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblLevel.Location = new Point(227, 282);
            lblLevel.Name = "lblLevel";
            lblLevel.Size = new Size(0, 25);
            lblLevel.TabIndex = 16;
            // 
            // lec_addStudent
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(544, 383);
            Controls.Add(lblLevel);
            Controls.Add(bnRegister);
            Controls.Add(lblBack);
            Controls.Add(cmbModName);
            Controls.Add(txtAddress);
            Controls.Add(txtContact);
            Controls.Add(txtEmail);
            Controls.Add(txtTPNum);
            Controls.Add(txtName);
            Controls.Add(label6);
            Controls.Add(label7);
            Controls.Add(label8);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(2);
            Name = "lec_addStudent";
            Text = "addStudent";
            FormClosed += lec_addStudent_FormClosed;
            Load += lec_addStudent_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label7;
        private Label label8;
        private TextBox txtName;
        private TextBox txtTPNum;
        private TextBox txtEmail;
        private TextBox txtAddress;
        private TextBox txtContact;
        private ComboBox cmbModName;
        private Label lblBack;
        private Button bnRegister;
        private Label label6;
        private Label lblLevel;
    }
}