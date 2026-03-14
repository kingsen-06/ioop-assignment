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
            lblBack = new Label();
            SuspendLayout();
            // 
            // lstAdmin
            // 
            lstAdmin.Font = new Font("Segoe UI", 11F);
            lstAdmin.FormattingEnabled = true;
            lstAdmin.ItemHeight = 30;
            lstAdmin.Location = new Point(146, 58);
            lstAdmin.Name = "lstAdmin";
            lstAdmin.Size = new Size(521, 214);
            lstAdmin.TabIndex = 0;
            // 
            // btnRegister
            // 
            btnRegister.Font = new Font("Segoe UI", 11F);
            btnRegister.Location = new Point(52, 303);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(220, 39);
            btnRegister.TabIndex = 1;
            btnRegister.Text = "Register New Admin";
            btnRegister.UseVisualStyleBackColor = true;
            // 
            // btnRemove
            // 
            btnRemove.Font = new Font("Segoe UI", 11F);
            btnRemove.Location = new Point(293, 303);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(220, 39);
            btnRemove.TabIndex = 2;
            btnRemove.Text = "Remove Admin";
            btnRemove.UseVisualStyleBackColor = true;
            // 
            // btnView
            // 
            btnView.Font = new Font("Segoe UI", 11F);
            btnView.Location = new Point(536, 303);
            btnView.Name = "btnView";
            btnView.Size = new Size(220, 39);
            btnView.TabIndex = 3;
            btnView.Text = "View Admin Detail";
            btnView.UseVisualStyleBackColor = true;
            // 
            // lblBack
            // 
            lblBack.AutoSize = true;
            lblBack.Font = new Font("Segoe UI", 11F);
            lblBack.Location = new Point(12, 370);
            lblBack.Name = "lblBack";
            lblBack.Size = new Size(299, 30);
            lblBack.TabIndex = 4;
            lblBack.Text = "< Back to Super Admin Menu";
            // 
            // superAdmin_manageAdmin
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 424);
            Controls.Add(lblBack);
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
        private Label lblBack;
    }
}