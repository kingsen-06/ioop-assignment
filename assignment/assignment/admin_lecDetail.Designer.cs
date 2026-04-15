namespace assignment
{
    partial class admin_lecDetail
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
            lblAddress = new Label();
            label5 = new Label();
            lblContact = new Label();
            lblDOB = new Label();
            lblName = new Label();
            label4 = new Label();
            label2 = new Label();
            label1 = new Label();
            lblEmail = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // lblBack
            // 
            lblBack.AutoSize = true;
            lblBack.Font = new Font("Segoe UI", 11F);
            lblBack.Location = new Point(37, 294);
            lblBack.Margin = new Padding(2, 0, 2, 0);
            lblBack.Name = "lblBack";
            lblBack.Size = new Size(69, 25);
            lblBack.TabIndex = 21;
            lblBack.Text = "< Back";
            lblBack.Click += lblBack_Click;
            // 
            // lblAddress
            // 
            lblAddress.AutoSize = true;
            lblAddress.BorderStyle = BorderStyle.FixedSingle;
            lblAddress.Font = new Font("Segoe UI", 11F);
            lblAddress.Location = new Point(251, 241);
            lblAddress.Margin = new Padding(2, 0, 2, 0);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(2, 27);
            lblAddress.TabIndex = 19;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11F);
            label5.Location = new Point(82, 241);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(88, 25);
            label5.TabIndex = 18;
            label5.Text = "Address :";
            // 
            // lblContact
            // 
            lblContact.AutoSize = true;
            lblContact.BorderStyle = BorderStyle.FixedSingle;
            lblContact.Font = new Font("Segoe UI", 11F);
            lblContact.Location = new Point(251, 192);
            lblContact.Margin = new Padding(2, 0, 2, 0);
            lblContact.Name = "lblContact";
            lblContact.Size = new Size(2, 27);
            lblContact.TabIndex = 17;
            // 
            // lblDOB
            // 
            lblDOB.AutoSize = true;
            lblDOB.BorderStyle = BorderStyle.FixedSingle;
            lblDOB.Font = new Font("Segoe UI", 11F);
            lblDOB.Location = new Point(251, 95);
            lblDOB.Margin = new Padding(2, 0, 2, 0);
            lblDOB.Name = "lblDOB";
            lblDOB.Size = new Size(2, 27);
            lblDOB.TabIndex = 16;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.BorderStyle = BorderStyle.FixedSingle;
            lblName.Font = new Font("Segoe UI", 11F);
            lblName.Location = new Point(251, 44);
            lblName.Margin = new Padding(2, 0, 2, 0);
            lblName.Name = "lblName";
            lblName.Size = new Size(2, 27);
            lblName.TabIndex = 15;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11F);
            label4.Location = new Point(82, 192);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(160, 25);
            label4.TabIndex = 14;
            label4.Text = "Contact Number :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F);
            label2.Location = new Point(82, 95);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(132, 25);
            label2.TabIndex = 13;
            label2.Text = "Date of Birth : ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F);
            label1.Location = new Point(82, 44);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(71, 25);
            label1.TabIndex = 12;
            label1.Text = "Name :";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.BorderStyle = BorderStyle.FixedSingle;
            lblEmail.Font = new Font("Segoe UI", 11F);
            lblEmail.Location = new Point(251, 145);
            lblEmail.Margin = new Padding(2, 0, 2, 0);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(2, 27);
            lblEmail.TabIndex = 23;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11F);
            label3.Location = new Point(82, 145);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(67, 25);
            label3.TabIndex = 22;
            label3.Text = "Email :";
            // 
            // admin_lecDetail
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(592, 372);
            Controls.Add(lblEmail);
            Controls.Add(label3);
            Controls.Add(lblBack);
            Controls.Add(lblAddress);
            Controls.Add(label5);
            Controls.Add(lblContact);
            Controls.Add(lblDOB);
            Controls.Add(lblName);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(2);
            Name = "admin_lecDetail";
            Text = "lecturerDetail";
            FormClosed += admin_lecDetail_FormClosed;
            Load += admin_lecDetail_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblBack;
        private Label lblAddress;
        private Label label5;
        private Label lblContact;
        private Label lblDOB;
        private Label lblName;
        private Label label4;
        private Label label2;
        private Label label1;
        private Label lblEmail;
        private Label label3;
    }
}