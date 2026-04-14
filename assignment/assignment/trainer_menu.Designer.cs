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
            btnUpdateClass.Location = new Point(119, 86);
            btnUpdateClass.Margin = new Padding(2, 2, 2, 2);
            btnUpdateClass.Name = "btnUpdateClass";
            btnUpdateClass.Size = new Size(236, 34);
            btnUpdateClass.TabIndex = 0;
            btnUpdateClass.Text = "Update Class Information";
            btnUpdateClass.UseVisualStyleBackColor = true;
            btnUpdateClass.Click += btnUpdateClass_Click;
            // 
            // btnView
            // 
            btnView.Font = new Font("Segoe UI", 11F);
            btnView.Location = new Point(119, 143);
            btnView.Margin = new Padding(2, 2, 2, 2);
            btnView.Name = "btnView";
            btnView.Size = new Size(236, 34);
            btnView.TabIndex = 1;
            btnView.Text = "View Student List";
            btnView.UseVisualStyleBackColor = true;
            btnView.Click += btnView_Click;
            // 
            // btnFeedback
            // 
            btnFeedback.Font = new Font("Segoe UI", 11F);
            btnFeedback.Location = new Point(119, 201);
            btnFeedback.Margin = new Padding(2, 2, 2, 2);
            btnFeedback.Name = "btnFeedback";
            btnFeedback.Size = new Size(236, 34);
            btnFeedback.TabIndex = 2;
            btnFeedback.Text = "Send Feedback";
            btnFeedback.UseVisualStyleBackColor = true;
            btnFeedback.Click += btnFeedback_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Font = new Font("Segoe UI", 11F);
            btnUpdate.Location = new Point(119, 260);
            btnUpdate.Margin = new Padding(2, 2, 2, 2);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(236, 34);
            btnUpdate.TabIndex = 3;
            btnUpdate.Text = "Update Profile";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F);
            label1.Location = new Point(62, 29);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(371, 41);
            label1.TabIndex = 4;
            label1.Text = "Trainer Functional Features";
            // 
            // lblBack
            // 
            lblBack.AutoSize = true;
            lblBack.Font = new Font("Segoe UI", 11F);
            lblBack.Location = new Point(17, 324);
            lblBack.Margin = new Padding(2, 0, 2, 0);
            lblBack.Name = "lblBack";
            lblBack.Size = new Size(189, 25);
            lblBack.TabIndex = 5;
            lblBack.Text = "< Back to Login Page";
            lblBack.Click += lblBack_Click;
            // 
            // trainer_menu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(486, 364);
            Controls.Add(lblBack);
            Controls.Add(label1);
            Controls.Add(btnUpdate);
            Controls.Add(btnFeedback);
            Controls.Add(btnView);
            Controls.Add(btnUpdateClass);
            Margin = new Padding(2, 2, 2, 2);
            Name = "trainer_menu";
            Text = "trainerMenu";
            FormClosed += trainer_menu_FormClosed;
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