namespace assignment
{
    partial class admin_menu
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
            btnManageTrainer = new Button();
            btnViewFeedback = new Button();
            label1 = new Label();
            btnUpdateProfile = new Button();
            lblBack = new Label();
            btnManageLecturer = new Button();
            btnAddModule = new Button();
            SuspendLayout();
            // 
            // btnManageTrainer
            // 
            btnManageTrainer.Font = new Font("Segoe UI", 11F);
            btnManageTrainer.Location = new Point(142, 160);
            btnManageTrainer.Margin = new Padding(2);
            btnManageTrainer.Name = "btnManageTrainer";
            btnManageTrainer.Size = new Size(232, 34);
            btnManageTrainer.TabIndex = 0;
            btnManageTrainer.Text = "Manage Trainer ";
            btnManageTrainer.UseVisualStyleBackColor = true;
            btnManageTrainer.Click += btnManageTrainer_Click;
            // 
            // btnViewFeedback
            // 
            btnViewFeedback.Font = new Font("Segoe UI", 11F);
            btnViewFeedback.Location = new Point(142, 283);
            btnViewFeedback.Margin = new Padding(2);
            btnViewFeedback.Name = "btnViewFeedback";
            btnViewFeedback.Size = new Size(232, 34);
            btnViewFeedback.TabIndex = 3;
            btnViewFeedback.Text = "View Feedback";
            btnViewFeedback.UseVisualStyleBackColor = true;
            btnViewFeedback.Click += btnViewFeedback_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F);
            label1.Location = new Point(45, 30);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(463, 41);
            label1.TabIndex = 7;
            label1.Text = "Administrator Functional Features";
            // 
            // btnUpdateProfile
            // 
            btnUpdateProfile.Font = new Font("Segoe UI", 11F);
            btnUpdateProfile.Location = new Point(142, 341);
            btnUpdateProfile.Margin = new Padding(2);
            btnUpdateProfile.Name = "btnUpdateProfile";
            btnUpdateProfile.Size = new Size(232, 34);
            btnUpdateProfile.TabIndex = 10;
            btnUpdateProfile.Text = "Update Account Profile";
            btnUpdateProfile.UseVisualStyleBackColor = true;
            btnUpdateProfile.Click += btnUpdateProfile_Click;
            // 
            // lblBack
            // 
            lblBack.AutoSize = true;
            lblBack.Font = new Font("Segoe UI", 11F);
            lblBack.Location = new Point(14, 397);
            lblBack.Margin = new Padding(2, 0, 2, 0);
            lblBack.Name = "lblBack";
            lblBack.Size = new Size(189, 25);
            lblBack.TabIndex = 12;
            lblBack.Text = "< Back to Login Page";
            lblBack.Click += lblBack_Click;
            // 
            // btnManageLecturer
            // 
            btnManageLecturer.Font = new Font("Segoe UI", 11F);
            btnManageLecturer.Location = new Point(142, 102);
            btnManageLecturer.Margin = new Padding(2);
            btnManageLecturer.Name = "btnManageLecturer";
            btnManageLecturer.Size = new Size(232, 34);
            btnManageLecturer.TabIndex = 13;
            btnManageLecturer.Text = "Manage Lecturer";
            btnManageLecturer.UseVisualStyleBackColor = true;
            btnManageLecturer.Click += btnManageLecturer_Click;
            // 
            // btnAddModule
            // 
            btnAddModule.Font = new Font("Segoe UI", 11F);
            btnAddModule.Location = new Point(142, 223);
            btnAddModule.Margin = new Padding(2);
            btnAddModule.Name = "btnAddModule";
            btnAddModule.Size = new Size(232, 34);
            btnAddModule.TabIndex = 21;
            btnAddModule.Text = "Add Module";
            btnAddModule.UseVisualStyleBackColor = true;
            btnAddModule.Click += btnAddModule_Click;
            // 
            // admin_menu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(538, 439);
            Controls.Add(btnAddModule);
            Controls.Add(btnManageLecturer);
            Controls.Add(lblBack);
            Controls.Add(btnUpdateProfile);
            Controls.Add(label1);
            Controls.Add(btnViewFeedback);
            Controls.Add(btnManageTrainer);
            Margin = new Padding(2);
            Name = "admin_menu";
            Text = "administratorMenu";
            FormClosed += admin_menu_FormClosed;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnManageTrainer;
        private Button btnViewFeedback;
        private Label label1;
        private Button btnUpdateProfile;
        private Label lblBack;
        private Button btnManageLecturer;
        private Button btnAddModule;
    }
}