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
            SuspendLayout();
            // 
            // btnManageTrainer
            // 
            btnManageTrainer.Font = new Font("Segoe UI", 11F);
            btnManageTrainer.Location = new Point(172, 126);
            btnManageTrainer.Name = "btnManageTrainer";
            btnManageTrainer.Size = new Size(290, 42);
            btnManageTrainer.TabIndex = 0;
            btnManageTrainer.Text = "Manage Trainer ";
            btnManageTrainer.UseVisualStyleBackColor = true;
            btnManageTrainer.Click += btnManageTrainer_Click;
            // 
            // btnViewFeedback
            // 
            btnViewFeedback.Font = new Font("Segoe UI", 11F);
            btnViewFeedback.Location = new Point(172, 200);
            btnViewFeedback.Name = "btnViewFeedback";
            btnViewFeedback.Size = new Size(290, 42);
            btnViewFeedback.TabIndex = 3;
            btnViewFeedback.Text = "View Feedback";
            btnViewFeedback.UseVisualStyleBackColor = true;
            btnViewFeedback.Click += btnViewFeedback_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F);
            label1.Location = new Point(56, 38);
            label1.Name = "label1";
            label1.Size = new Size(555, 48);
            label1.TabIndex = 7;
            label1.Text = "Administrator Functional Features";
            // 
            // btnUpdateProfile
            // 
            btnUpdateProfile.Font = new Font("Segoe UI", 11F);
            btnUpdateProfile.Location = new Point(172, 279);
            btnUpdateProfile.Name = "btnUpdateProfile";
            btnUpdateProfile.Size = new Size(290, 42);
            btnUpdateProfile.TabIndex = 10;
            btnUpdateProfile.Text = "Update Account Profile";
            btnUpdateProfile.UseVisualStyleBackColor = true;
            btnUpdateProfile.Click += btnUpdateProfile_Click;
            // 
            // lblBack
            // 
            lblBack.AutoSize = true;
            lblBack.Font = new Font("Segoe UI", 11F);
            lblBack.Location = new Point(12, 370);
            lblBack.Name = "lblBack";
            lblBack.Size = new Size(217, 30);
            lblBack.TabIndex = 12;
            lblBack.Text = "< Back to Login Page";
            lblBack.Click += lblBack_Click;
            // 
            // admin_menu
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(672, 419);
            Controls.Add(lblBack);
            Controls.Add(btnUpdateProfile);
            Controls.Add(label1);
            Controls.Add(btnViewFeedback);
            Controls.Add(btnManageTrainer);
            Name = "admin_menu";
            Text = "administratorMenu";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnManageTrainer;
        private Button btnViewFeedback;
        private Label label1;
        private Button btnUpdateProfile;
        private Label lblBack;
    }
}