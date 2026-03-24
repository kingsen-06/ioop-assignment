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
            btnTrainers = new Button();
            btnViewFeedback = new Button();
            label1 = new Label();
            btnUpdate = new Button();
            lblBack = new Label();
            btnLecturers = new Button();
            SuspendLayout();
            // 
            // btnTrainers
            // 
            btnTrainers.Font = new Font("Segoe UI", 11F);
            btnTrainers.Location = new Point(113, 144);
            btnTrainers.Margin = new Padding(2);
            btnTrainers.Name = "btnTrainers";
            btnTrainers.Size = new Size(296, 34);
            btnTrainers.TabIndex = 0;
            btnTrainers.Text = "Manage Trainers";
            btnTrainers.UseVisualStyleBackColor = true;
            // 
            // btnViewFeedback
            // 
            btnViewFeedback.Font = new Font("Segoe UI", 11F);
            btnViewFeedback.Location = new Point(113, 254);
            btnViewFeedback.Margin = new Padding(2);
            btnViewFeedback.Name = "btnViewFeedback";
            btnViewFeedback.Size = new Size(296, 34);
            btnViewFeedback.TabIndex = 3;
            btnViewFeedback.Text = "View Feedback";
            btnViewFeedback.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F);
            label1.Location = new Point(48, 69);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(463, 41);
            label1.TabIndex = 7;
            label1.Text = "Administrator Functional Features";
            // 
            // btnUpdate
            // 
            btnUpdate.Font = new Font("Segoe UI", 11F);
            btnUpdate.Location = new Point(113, 309);
            btnUpdate.Margin = new Padding(2);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(296, 34);
            btnUpdate.TabIndex = 10;
            btnUpdate.Text = "Update Profile";
            btnUpdate.UseVisualStyleBackColor = true;
            // 
            // lblBack
            // 
            lblBack.AutoSize = true;
            lblBack.Font = new Font("Segoe UI", 11F);
            lblBack.Location = new Point(11, 9);
            lblBack.Margin = new Padding(2, 0, 2, 0);
            lblBack.Name = "lblBack";
            lblBack.Size = new Size(189, 25);
            lblBack.TabIndex = 12;
            lblBack.Text = "< Back to Login Page";
            // 
            // btnLecturers
            // 
            btnLecturers.Font = new Font("Segoe UI", 11F);
            btnLecturers.Location = new Point(113, 199);
            btnLecturers.Margin = new Padding(2);
            btnLecturers.Name = "btnLecturers";
            btnLecturers.Size = new Size(296, 34);
            btnLecturers.TabIndex = 13;
            btnLecturers.Text = "Manage Lecturers";
            btnLecturers.UseVisualStyleBackColor = true;
            // 
            // admin_menu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(556, 390);
            Controls.Add(btnLecturers);
            Controls.Add(lblBack);
            Controls.Add(btnUpdate);
            Controls.Add(label1);
            Controls.Add(btnViewFeedback);
            Controls.Add(btnTrainers);
            Margin = new Padding(2);
            Name = "admin_menu";
            Text = "administratorMenu";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnTrainers;
        private Button btnViewFeedback;
        private Label label1;
        private Button btnUpdate;
        private Label lblBack;
        private Button btnLecturers;
    }
}