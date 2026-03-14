namespace assignment
{
    partial class trainer_menu
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
            btnUpdateClass = new Button();
            btnView = new Button();
            btnFeedback = new Button();
            btnUpdate = new Button();
            label1 = new Label();
            lblBack = new Label();
            SuspendLayout();
            // 
            // btnUpdateClass
            // 
            btnUpdateClass.Font = new Font("Segoe UI", 11F);
            btnUpdateClass.Location = new Point(149, 108);
            btnUpdateClass.Name = "btnUpdateClass";
            btnUpdateClass.Size = new Size(295, 42);
            btnUpdateClass.TabIndex = 0;
            btnUpdateClass.Text = "Update Class Information";
            btnUpdateClass.UseVisualStyleBackColor = true;
            // 
            // btnView
            // 
            btnView.Font = new Font("Segoe UI", 11F);
            btnView.Location = new Point(149, 179);
            btnView.Name = "btnView";
            btnView.Size = new Size(295, 42);
            btnView.TabIndex = 1;
            btnView.Text = "View Student List";
            btnView.UseVisualStyleBackColor = true;
            // 
            // btnFeedback
            // 
            btnFeedback.Font = new Font("Segoe UI", 11F);
            btnFeedback.Location = new Point(149, 251);
            btnFeedback.Name = "btnFeedback";
            btnFeedback.Size = new Size(295, 42);
            btnFeedback.TabIndex = 2;
            btnFeedback.Text = "Send Feedback";
            btnFeedback.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            btnUpdate.Font = new Font("Segoe UI", 11F);
            btnUpdate.Location = new Point(149, 325);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(295, 42);
            btnUpdate.TabIndex = 3;
            btnUpdate.Text = "Update Profile";
            btnUpdate.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F);
            label1.Location = new Point(78, 36);
            label1.Name = "label1";
            label1.Size = new Size(446, 48);
            label1.TabIndex = 4;
            label1.Text = "Trainer Functional Features";
            // 
            // lblBack
            // 
            lblBack.AutoSize = true;
            lblBack.Font = new Font("Segoe UI", 11F);
            lblBack.Location = new Point(21, 405);
            lblBack.Name = "lblBack";
            lblBack.Size = new Size(217, 30);
            lblBack.TabIndex = 5;
            lblBack.Text = "< Back to Login Page";
            // 
            // trainer_menu
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(607, 455);
            Controls.Add(lblBack);
            Controls.Add(label1);
            Controls.Add(btnUpdate);
            Controls.Add(btnFeedback);
            Controls.Add(btnView);
            Controls.Add(btnUpdateClass);
            Name = "trainer_menu";
            Text = "trainerMenu";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnUpdateClass;
        private Button btnView;
        private Button btnFeedback;
        private Button btnUpdate;
        private Label label1;
        private Label lblBack;
    }
}