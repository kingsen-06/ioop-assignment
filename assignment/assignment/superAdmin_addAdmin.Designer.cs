namespace assignment
{
    partial class superAdmin_addAdmin
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
            lblBack = new Label();
            label7 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtContact = new TextBox();
            txtAddress = new TextBox();
            txtEmail = new TextBox();
            txtName = new TextBox();
            btnAdd = new Button();
            SuspendLayout();
            // 
            // lblBack
            // 
            lblBack.AutoSize = true;
            lblBack.Font = new Font("Segoe UI", 11F);
            lblBack.Location = new Point(32, 257);
            lblBack.Margin = new Padding(2, 0, 2, 0);
            lblBack.Name = "lblBack";
            lblBack.Size = new Size(69, 25);
            lblBack.TabIndex = 22;
            lblBack.Text = "< Back";
            lblBack.Click += lblBack_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 11F);
            label7.Location = new Point(84, 194);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(88, 25);
            label7.TabIndex = 21;
            label7.Text = "Address :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11F);
            label3.Location = new Point(84, 145);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(160, 25);
            label3.TabIndex = 20;
            label3.Text = "Contact Number :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F);
            label2.Location = new Point(84, 98);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(67, 25);
            label2.TabIndex = 19;
            label2.Text = "Email :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F);
            label1.Location = new Point(84, 50);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(71, 25);
            label1.TabIndex = 18;
            label1.Text = "Name :";
            // 
            // txtContact
            // 
            txtContact.Font = new Font("Segoe UI", 11F);
            txtContact.Location = new Point(255, 142);
            txtContact.Margin = new Padding(2);
            txtContact.Name = "txtContact";
            txtContact.Size = new Size(259, 32);
            txtContact.TabIndex = 23;
            // 
            // txtAddress
            // 
            txtAddress.Font = new Font("Segoe UI", 11F);
            txtAddress.Location = new Point(255, 191);
            txtAddress.Margin = new Padding(2);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(259, 32);
            txtAddress.TabIndex = 24;
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Segoe UI", 11F);
            txtEmail.Location = new Point(255, 95);
            txtEmail.Margin = new Padding(2);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(259, 32);
            txtEmail.TabIndex = 26;
            // 
            // txtName
            // 
            txtName.Font = new Font("Segoe UI", 11F);
            txtName.Location = new Point(255, 48);
            txtName.Margin = new Padding(2);
            txtName.Name = "txtName";
            txtName.Size = new Size(259, 32);
            txtName.TabIndex = 25;
            // 
            // btnAdd
            // 
            btnAdd.Font = new Font("Segoe UI", 11F);
            btnAdd.Location = new Point(289, 237);
            btnAdd.Margin = new Padding(2);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(190, 31);
            btnAdd.TabIndex = 27;
            btnAdd.Text = "Register New Admin";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // superAdmin_addAdmin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(602, 305);
            Controls.Add(btnAdd);
            Controls.Add(txtEmail);
            Controls.Add(txtName);
            Controls.Add(txtAddress);
            Controls.Add(txtContact);
            Controls.Add(lblBack);
            Controls.Add(label7);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(2);
            Name = "superAdmin_addAdmin";
            Text = "superAdmin_addAdmin";
            FormClosed += superAdmin_addAdmin_FormClosed;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblBack;
        private Label label7;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtContact;
        private TextBox txtAddress;
        private TextBox txtEmail;
        private TextBox txtName;
        private Button btnAdd;
    }
}