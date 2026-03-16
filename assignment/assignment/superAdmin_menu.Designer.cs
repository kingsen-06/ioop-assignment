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
            SuspendLayout();
            // 
            // lblBack
            // 
            lblBack.AutoSize = true;
            lblBack.Font = new Font("Segoe UI", 11F);
            lblBack.Location = new Point(48, 414);
            lblBack.Name = "lblBack";
            lblBack.Size = new Size(217, 30);
            lblBack.TabIndex = 17;
            lblBack.Text = "< Back to Login Page";
            lblBack.Click += lblBack_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Font = new Font("Segoe UI", 11F);
            btnUpdate.Location = new Point(247, 350);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(290, 42);
            btnUpdate.TabIndex = 16;
            btnUpdate.Text = "Update Account Profile";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F);
            label1.Location = new Point(63, 47);
            label1.Name = "label1";
            label1.Size = new Size(657, 48);
            label1.TabIndex = 15;
            label1.Text = "Super Administrator Functional Features";
            // 
            // btnViewFeedback
            // 
            btnViewFeedback.Font = new Font("Segoe UI", 11F);
            btnViewFeedback.Location = new Point(247, 271);
            btnViewFeedback.Name = "btnViewFeedback";
            btnViewFeedback.Size = new Size(290, 42);
            btnViewFeedback.TabIndex = 14;
            btnViewFeedback.Text = "View Feedback";
            btnViewFeedback.UseVisualStyleBackColor = true;
            btnViewFeedback.Click += btnViewFeedback_Click;
            // 
            // btnManageTrainer
            // 
            btnManageTrainer.Font = new Font("Segoe UI", 11F);
            btnManageTrainer.Location = new Point(247, 197);
            btnManageTrainer.Name = "btnManageTrainer";
            btnManageTrainer.Size = new Size(290, 42);
            btnManageTrainer.TabIndex = 13;
            btnManageTrainer.Text = "Manage Trainer ";
            btnManageTrainer.UseVisualStyleBackColor = true;
            btnManageTrainer.Click += btnManageTrainer_Click;
            // 
            // btnManageAdmin
            // 
            btnManageAdmin.Font = new Font("Segoe UI", 11F);
            btnManageAdmin.Location = new Point(247, 121);
            btnManageAdmin.Name = "btnManageAdmin";
            btnManageAdmin.Size = new Size(290, 42);
            btnManageAdmin.TabIndex = 18;
            btnManageAdmin.Text = "Manage Administrator";
            btnManageAdmin.UseVisualStyleBackColor = true;
            btnManageAdmin.Click += btnManageAdmin_Click;
            // 
            // superAdmin_menu
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(774, 464);
            Controls.Add(btnManageAdmin);
            Controls.Add(lblBack);
            Controls.Add(btnUpdate);
            Controls.Add(label1);
            Controls.Add(btnViewFeedback);
            Controls.Add(btnManageTrainer);
            Name = "superAdmin_menu";
            Text = "superAdminMenu";
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
    }
}