namespace assignment
{
    partial class superAdmin_menu
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
            btnUpdate = new Button();
            label1 = new Label();
            btnViewFeedback = new Button();
            btnManageTrainer = new Button();
            btnManageAdmin = new Button();
            btnManageLecturer = new Button();
            btnAddModule = new Button();
            SuspendLayout();
            // 
            // lblBack
            // 
            lblBack.AutoSize = true;
            lblBack.Font = new Font("Segoe UI", 11F);
            lblBack.Location = new Point(30, 421);
            lblBack.Margin = new Padding(2, 0, 2, 0);
            lblBack.Name = "lblBack";
            lblBack.Size = new Size(189, 25);
            lblBack.TabIndex = 17;
            lblBack.Text = "< Back to Login Page";
            lblBack.Click += lblBack_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Font = new Font("Segoe UI", 11F);
            btnUpdate.Location = new Point(198, 370);
            btnUpdate.Margin = new Padding(2);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(232, 34);
            btnUpdate.TabIndex = 16;
            btnUpdate.Text = "Update Account Profile";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F);
            label1.Location = new Point(50, 18);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(548, 41);
            label1.TabIndex = 15;
            label1.Text = "Super Administrator Functional Features";
            // 
            // btnViewFeedback
            // 
            btnViewFeedback.Font = new Font("Segoe UI", 11F);
            btnViewFeedback.Location = new Point(198, 310);
            btnViewFeedback.Margin = new Padding(2);
            btnViewFeedback.Name = "btnViewFeedback";
            btnViewFeedback.Size = new Size(232, 34);
            btnViewFeedback.TabIndex = 14;
            btnViewFeedback.Text = "View Feedback";
            btnViewFeedback.UseVisualStyleBackColor = true;
            btnViewFeedback.Click += btnViewFeedback_Click;
            // 
            // btnManageTrainer
            // 
            btnManageTrainer.Font = new Font("Segoe UI", 11F);
            btnManageTrainer.Location = new Point(198, 191);
            btnManageTrainer.Margin = new Padding(2);
            btnManageTrainer.Name = "btnManageTrainer";
            btnManageTrainer.Size = new Size(232, 34);
            btnManageTrainer.TabIndex = 13;
            btnManageTrainer.Text = "Manage Trainer ";
            btnManageTrainer.UseVisualStyleBackColor = true;
            btnManageTrainer.Click += btnManageTrainer_Click;
            // 
            // btnManageAdmin
            // 
            btnManageAdmin.Font = new Font("Segoe UI", 11F);
            btnManageAdmin.Location = new Point(198, 78);
            btnManageAdmin.Margin = new Padding(2);
            btnManageAdmin.Name = "btnManageAdmin";
            btnManageAdmin.Size = new Size(232, 34);
            btnManageAdmin.TabIndex = 18;
            btnManageAdmin.Text = "Manage Administrator";
            btnManageAdmin.UseVisualStyleBackColor = true;
            btnManageAdmin.Click += btnManageAdmin_Click;
            // 
            // btnManageLecturer
            // 
            btnManageLecturer.Font = new Font("Segoe UI", 11F);
            btnManageLecturer.Location = new Point(198, 133);
            btnManageLecturer.Margin = new Padding(2);
            btnManageLecturer.Name = "btnManageLecturer";
            btnManageLecturer.Size = new Size(232, 34);
            btnManageLecturer.TabIndex = 19;
            btnManageLecturer.Text = "Manage Lecturer";
            btnManageLecturer.UseVisualStyleBackColor = true;
            btnManageLecturer.Click += btnManageLecturer_Click;
            // 
            // btnAddModule
            // 
            btnAddModule.Font = new Font("Segoe UI", 11F);
            btnAddModule.Location = new Point(198, 250);
            btnAddModule.Margin = new Padding(2);
            btnAddModule.Name = "btnAddModule";
            btnAddModule.Size = new Size(232, 34);
            btnAddModule.TabIndex = 20;
            btnAddModule.Text = "Add Module";
            btnAddModule.UseVisualStyleBackColor = true;
            btnAddModule.Click += btnAddModule_Click;
            // 
            // superAdmin_menu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(619, 464);
            Controls.Add(btnAddModule);
            Controls.Add(btnManageLecturer);
            Controls.Add(btnManageAdmin);
            Controls.Add(lblBack);
            Controls.Add(btnUpdate);
            Controls.Add(label1);
            Controls.Add(btnViewFeedback);
            Controls.Add(btnManageTrainer);
            Margin = new Padding(2);
            Name = "superAdmin_menu";
            Text = "superAdminMenu";
            FormClosed += superAdmin_menu_FormClosed;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblBack;
        private Button btnUpdate;
        private Label label1;
        private Button btnViewFeedback;
        private Button btnManageTrainer;
        private Button btnManageAdmin;
        private Button btnManageLecturer;
        private Button btnAddModule;
    }
}