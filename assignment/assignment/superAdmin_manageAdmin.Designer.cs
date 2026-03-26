namespace assignment
{
    partial class superAdmin_manageAdmin
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
            lstAdmin = new ListBox();
            btnRegister = new Button();
            btnRemove = new Button();
            btnView = new Button();
            label1 = new Label();
            lblBack = new Label();
            SuspendLayout();
            // 
            // lstAdmin
            // 
            lstAdmin.Font = new Font("Segoe UI", 11F);
            lstAdmin.FormattingEnabled = true;
            lstAdmin.ItemHeight = 30;
            lstAdmin.Location = new Point(117, 86);
            lstAdmin.Name = "lstAdmin";
            lstAdmin.Size = new Size(473, 184);
            lstAdmin.TabIndex = 0;
            // 
            // btnRegister
            // 
            btnRegister.Font = new Font("Segoe UI", 11F);
            btnRegister.Location = new Point(80, 302);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(178, 40);
            btnRegister.TabIndex = 1;
            btnRegister.Text = "Register New";
            btnRegister.UseVisualStyleBackColor = true;
            // 
            // btnRemove
            // 
            btnRemove.Font = new Font("Segoe UI", 11F);
            btnRemove.Location = new Point(264, 302);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(178, 40);
            btnRemove.TabIndex = 2;
            btnRemove.Text = "Remove Admin";
            btnRemove.UseVisualStyleBackColor = true;
            // 
            // btnView
            // 
            btnView.Font = new Font("Segoe UI", 11F);
            btnView.Location = new Point(449, 302);
            btnView.Name = "btnView";
            btnView.Size = new Size(178, 40);
            btnView.TabIndex = 3;
            btnView.Text = "View Detail";
            btnView.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F);
            label1.Location = new Point(129, 47);
            label1.Name = "label1";
            label1.Size = new Size(157, 30);
            label1.TabIndex = 4;
            label1.Text = "Select Admin : ";
            // 
            // lblBack
            // 
            lblBack.AutoSize = true;
            lblBack.Font = new Font("Segoe UI", 11F);
            lblBack.Location = new Point(22, 376);
            lblBack.Name = "lblBack";
            lblBack.Size = new Size(273, 30);
            lblBack.TabIndex = 5;
            lblBack.Text = "< Back Super Admin Menu";
            // 
            // superAdmin_manageAdmin
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(717, 439);
            Controls.Add(lblBack);
            Controls.Add(label1);
            Controls.Add(btnView);
            Controls.Add(btnRemove);
            Controls.Add(btnRegister);
            Controls.Add(lstAdmin);
            Name = "superAdmin_manageAdmin";
            Text = "manageAdmin";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lstAdmin;
        private Button btnRegister;
        private Button btnRemove;
        private Button btnView;
        private Label label1;
        private Label lblBack;
    }
}