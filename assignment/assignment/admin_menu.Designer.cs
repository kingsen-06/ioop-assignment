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
            btnRegisterTrainer = new Button();
            btnViewFeedback = new Button();
            label1 = new Label();
            btnUpdate = new Button();
            lblBack = new Label();
            SuspendLayout();
            // 
            // btnRegisterTrainer
            // 
            btnRegisterTrainer.Font = new Font("Segoe UI", 11F);
            btnRegisterTrainer.Location = new Point(137, 131);
            btnRegisterTrainer.Name = "btnRegisterTrainer";
            btnRegisterTrainer.Size = new Size(370, 42);
            btnRegisterTrainer.TabIndex = 0;
            btnRegisterTrainer.Text = "Add / Remove / View Trainer Details";
            btnRegisterTrainer.UseVisualStyleBackColor = true;
            // 
            // btnViewFeedback
            // 
            btnViewFeedback.Font = new Font("Segoe UI", 11F);
            btnViewFeedback.Location = new Point(137, 205);
            btnViewFeedback.Name = "btnViewFeedback";
            btnViewFeedback.Size = new Size(370, 42);
            btnViewFeedback.TabIndex = 3;
            btnViewFeedback.Text = "View Feedback";
            btnViewFeedback.UseVisualStyleBackColor = true;
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
            // btnUpdate
            // 
            btnUpdate.Font = new Font("Segoe UI", 11F);
            btnUpdate.Location = new Point(137, 284);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(370, 42);
            btnUpdate.TabIndex = 10;
            btnUpdate.Text = "Update Account Profile";
            btnUpdate.UseVisualStyleBackColor = true;
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
            // 
            // admin_menu
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(672, 419);
            Controls.Add(lblBack);
            Controls.Add(btnUpdate);
            Controls.Add(label1);
            Controls.Add(btnViewFeedback);
            Controls.Add(btnRegisterTrainer);
            Name = "admin_menu";
            Text = "administratorMenu";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnRegisterTrainer;
        private Button btnViewFeedback;
        private Label label1;
        private Button btnUpdate;
        private Label lblBack;
    }
}