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
            lstAdmin.ItemHeight = 25;
            lstAdmin.Location = new Point(94, 69);
            lstAdmin.Margin = new Padding(2);
            lstAdmin.Name = "lstAdmin";
            lstAdmin.Size = new Size(379, 129);
            lstAdmin.TabIndex = 0;
            // 
            // btnRegister
            // 
            btnRegister.Font = new Font("Segoe UI", 11F);
            btnRegister.Location = new Point(64, 242);
            btnRegister.Margin = new Padding(2);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(142, 32);
            btnRegister.TabIndex = 1;
            btnRegister.Text = "Register New";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += btnRegister_Click;
            // 
            // btnRemove
            // 
            btnRemove.Font = new Font("Segoe UI", 11F);
            btnRemove.Location = new Point(211, 242);
            btnRemove.Margin = new Padding(2);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(142, 32);
            btnRemove.TabIndex = 2;
            btnRemove.Text = "Remove Admin";
            btnRemove.UseVisualStyleBackColor = true;
            btnRemove.Click += btnRemove_Click;
            // 
            // btnView
            // 
            btnView.Font = new Font("Segoe UI", 11F);
            btnView.Location = new Point(359, 242);
            btnView.Margin = new Padding(2);
            btnView.Name = "btnView";
            btnView.Size = new Size(142, 32);
            btnView.TabIndex = 3;
            btnView.Text = "View Detail";
            btnView.UseVisualStyleBackColor = true;
            btnView.Click += btnView_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F);
            label1.Location = new Point(103, 38);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(136, 25);
            label1.TabIndex = 4;
            label1.Text = "Select Admin : ";
            // 
            // lblBack
            // 
            lblBack.AutoSize = true;
            lblBack.Font = new Font("Segoe UI", 11F);
            lblBack.Location = new Point(18, 301);
            lblBack.Margin = new Padding(2, 0, 2, 0);
            lblBack.Name = "lblBack";
            lblBack.Size = new Size(237, 25);
            lblBack.TabIndex = 5;
            lblBack.Text = "< Back Super Admin Menu";
            lblBack.Click += lblBack_Click;
            // 
            // superAdmin_manageAdmin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(574, 351);
            Controls.Add(lblBack);
            Controls.Add(label1);
            Controls.Add(btnView);
            Controls.Add(btnRemove);
            Controls.Add(btnRegister);
            Controls.Add(lstAdmin);
            Margin = new Padding(2);
            Name = "superAdmin_manageAdmin";
            Text = "manageAdmin";
            FormClosed += superAdmin_manageAdmin_FormClosed;
            Load += superAdmin_manageAdmin_Load;
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