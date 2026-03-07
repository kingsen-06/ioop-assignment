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
            lblNext = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F);
            label1.Location = new Point(111, 107);
            label1.Name = "label1";
            label1.Size = new Size(121, 30);
            label1.TabIndex = 0;
            label1.Text = "Full Name: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F);
            label2.Location = new Point(111, 163);
            label2.Name = "label2";
            label2.Size = new Size(146, 30);
            label2.TabIndex = 1;
            label2.Text = "Date of Birth: ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11F);
            label3.Location = new Point(111, 222);
            label3.Name = "label3";
            label3.Size = new Size(75, 30);
            label3.TabIndex = 2;
            label3.Text = "Email: ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11F);
            label4.Location = new Point(111, 282);
            label4.Name = "label4";
            label4.Size = new Size(184, 30);
            label4.TabIndex = 3;
            label4.Text = "Contact Number: ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11F);
            label5.Location = new Point(111, 344);
            label5.Name = "label5";
            label5.Size = new Size(102, 30);
            label5.TabIndex = 4;
            label5.Text = "Address: ";
            // 
            // txtName
            // 
            txtName.Font = new Font("Segoe UI", 11F);
            txtName.Location = new Point(301, 104);
            txtName.Name = "txtName";
            txtName.Size = new Size(295, 37);
            txtName.TabIndex = 5;
            // 
            // txtDOB
            // 
            txtDOB.Font = new Font("Segoe UI", 11F);
            txtDOB.Location = new Point(301, 160);
            txtDOB.Name = "txtDOB";
            txtDOB.Size = new Size(295, 37);
            txtDOB.TabIndex = 6;
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Segoe UI", 11F);
            txtEmail.Location = new Point(301, 219);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(295, 37);
            txtEmail.TabIndex = 7;
            // 
            // txtContact
            // 
            txtContact.Font = new Font("Segoe UI", 11F);
            txtContact.Location = new Point(301, 279);
            txtContact.Name = "txtContact";
            txtContact.Size = new Size(295, 37);
            txtContact.TabIndex = 8;
            // 
            // txtAddress
            // 
            txtAddress.Font = new Font("Segoe UI", 11F);
            txtAddress.Location = new Point(301, 341);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(295, 37);
            txtAddress.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 18F);
            label6.Location = new Point(154, 28);
            label6.Name = "label6";
            label6.Size = new Size(406, 48);
            label6.TabIndex = 10;
            label6.Text = "New Trainer Information";
            // 
            // lblBack
            // 
            lblBack.AutoSize = true;
            lblBack.Font = new Font("Segoe UI", 11F);
            lblBack.Location = new Point(31, 417);
            lblBack.Name = "lblBack";
            lblBack.Size = new Size(79, 30);
            lblBack.TabIndex = 13;
            lblBack.Text = "< Back";
            // 
            // lblNext
            // 
            lblNext.AutoSize = true;
            lblNext.Font = new Font("Segoe UI", 11F);
            lblNext.Location = new Point(599, 417);
            lblNext.Name = "lblNext";
            lblNext.Size = new Size(79, 30);
            lblNext.TabIndex = 14;
            lblNext.Text = "Next >";
            // 
            // admin_addTrainer
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(721, 481);
            Controls.Add(lblNext);
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
        private Label lblNext;
    }
}