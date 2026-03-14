namespace assignment
{
    partial class superAdmin_adminDetail
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
            lblAddress = new Label();
            label7 = new Label();
            lblContact = new Label();
            lblEmail = new Label();
            lblName = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            lblBack = new Label();
            SuspendLayout();
            // 
            // lblAddress
            // 
            lblAddress.AutoSize = true;
            lblAddress.BorderStyle = BorderStyle.Fixed3D;
            lblAddress.Font = new Font("Segoe UI", 11F);
            lblAddress.Location = new Point(337, 236);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(2, 32);
            lblAddress.TabIndex = 16;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 11F);
            label7.Location = new Point(126, 236);
            label7.Name = "label7";
            label7.Size = new Size(102, 30);
            label7.TabIndex = 15;
            label7.Text = "Address :";
            // 
            // lblContact
            // 
            lblContact.AutoSize = true;
            lblContact.BorderStyle = BorderStyle.Fixed3D;
            lblContact.Font = new Font("Segoe UI", 11F);
            lblContact.Location = new Point(337, 175);
            lblContact.Name = "lblContact";
            lblContact.Size = new Size(2, 32);
            lblContact.TabIndex = 14;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.BorderStyle = BorderStyle.Fixed3D;
            lblEmail.Font = new Font("Segoe UI", 11F);
            lblEmail.Location = new Point(337, 116);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(2, 32);
            lblEmail.TabIndex = 13;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.BorderStyle = BorderStyle.Fixed3D;
            lblName.Font = new Font("Segoe UI", 11F);
            lblName.Location = new Point(337, 57);
            lblName.Name = "lblName";
            lblName.Size = new Size(2, 32);
            lblName.TabIndex = 12;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11F);
            label3.Location = new Point(126, 175);
            label3.Name = "label3";
            label3.Size = new Size(184, 30);
            label3.TabIndex = 11;
            label3.Text = "Contact Number :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F);
            label2.Location = new Point(126, 116);
            label2.Name = "label2";
            label2.Size = new Size(75, 30);
            label2.TabIndex = 10;
            label2.Text = "Email :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F);
            label1.Location = new Point(126, 57);
            label1.Name = "label1";
            label1.Size = new Size(82, 30);
            label1.TabIndex = 9;
            label1.Text = "Name :";
            // 
            // lblBack
            // 
            lblBack.AutoSize = true;
            lblBack.Font = new Font("Segoe UI", 11F);
            lblBack.Location = new Point(61, 304);
            lblBack.Name = "lblBack";
            lblBack.Size = new Size(79, 30);
            lblBack.TabIndex = 17;
            lblBack.Text = "< Back";
            lblBack.Click += lblBack_Click;
            // 
            // superAdmin_adminDetail
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 357);
            Controls.Add(lblBack);
            Controls.Add(lblAddress);
            Controls.Add(label7);
            Controls.Add(lblContact);
            Controls.Add(lblEmail);
            Controls.Add(lblName);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "superAdmin_adminDetail";
            Text = "adminDetail";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblAddress;
        private Label label7;
        private Label lblContact;
        private Label lblEmail;
        private Label lblName;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label lblBack;
    }
}