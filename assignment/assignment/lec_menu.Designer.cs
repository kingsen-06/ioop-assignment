namespace assignment
{
    partial class lec_menu
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
            btnUpdate = new Button();
            btnViewRequest = new Button();
            btnManage = new Button();
            lblBack = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnUpdate
            // 
            btnUpdate.Font = new Font("Segoe UI", 11F);
            btnUpdate.Location = new Point(119, 200);
            btnUpdate.Margin = new Padding(2, 2, 2, 2);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(344, 34);
            btnUpdate.TabIndex = 24;
            btnUpdate.Text = "Update Account Profile";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnViewRequest
            // 
            btnViewRequest.Font = new Font("Segoe UI", 11F);
            btnViewRequest.Location = new Point(118, 147);
            btnViewRequest.Margin = new Padding(2, 2, 2, 2);
            btnViewRequest.Name = "btnViewRequest";
            btnViewRequest.Size = new Size(344, 34);
            btnViewRequest.TabIndex = 23;
            btnViewRequest.Text = "View Student Request";
            btnViewRequest.UseVisualStyleBackColor = true;
            btnViewRequest.Click += btnApprove_Click;
            // 
            // btnManage
            // 
            btnManage.Font = new Font("Segoe UI", 11F);
            btnManage.Location = new Point(119, 95);
            btnManage.Margin = new Padding(2, 2, 2, 2);
            btnManage.Name = "btnManage";
            btnManage.Size = new Size(344, 34);
            btnManage.TabIndex = 21;
            btnManage.Text = "Manage Student";
            btnManage.UseVisualStyleBackColor = true;
            btnManage.Click += btnManage_Click;
            // 
            // lblBack
            // 
            lblBack.AutoSize = true;
            lblBack.Font = new Font("Segoe UI", 11F);
            lblBack.Location = new Point(20, 259);
            lblBack.Margin = new Padding(2, 0, 2, 0);
            lblBack.Name = "lblBack";
            lblBack.Size = new Size(189, 25);
            lblBack.TabIndex = 20;
            lblBack.Text = "< Back to Login Page";
            lblBack.Click += lblBack_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F);
            label1.Location = new Point(106, 37);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(390, 41);
            label1.TabIndex = 19;
            label1.Text = "Lecturer Functional Features";
            // 
            // lec_menu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(582, 301);
            Controls.Add(btnUpdate);
            Controls.Add(btnViewRequest);
            Controls.Add(btnManage);
            Controls.Add(lblBack);
            Controls.Add(label1);
            Margin = new Padding(2, 2, 2, 2);
            Name = "lec_menu";
            Text = "lecturerMenu";
            FormClosed += lec_menu_FormClosed;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnUpdate;
        private Button btnViewRequest;
        private Button btnManage;
        private Label lblBack;
        private Label label1;
    }
}