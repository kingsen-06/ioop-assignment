namespace assignment
{
    partial class student_menu
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
            label1 = new Label();
            lblBack = new Label();
            btnSchedule = new Button();
            btnPayment = new Button();
            btnManage = new Button();
            btnUpdate = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F);
            label1.Location = new Point(90, 28);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(386, 41);
            label1.TabIndex = 8;
            label1.Text = "Student Functional Features";
            // 
            // lblBack
            // 
            lblBack.AutoSize = true;
            lblBack.Font = new Font("Segoe UI", 11F);
            lblBack.Location = new Point(10, 299);
            lblBack.Margin = new Padding(2, 0, 2, 0);
            lblBack.Name = "lblBack";
            lblBack.Size = new Size(189, 25);
            lblBack.TabIndex = 13;
            lblBack.Text = "< Back to Login Page";
            lblBack.Click += lblBack_Click;
            // 
            // btnSchedule
            // 
            btnSchedule.Font = new Font("Segoe UI", 11F);
            btnSchedule.Location = new Point(102, 86);
            btnSchedule.Margin = new Padding(2, 2, 2, 2);
            btnSchedule.Name = "btnSchedule";
            btnSchedule.Size = new Size(344, 34);
            btnSchedule.TabIndex = 14;
            btnSchedule.Text = "View Schedule";
            btnSchedule.UseVisualStyleBackColor = true;
            btnSchedule.Click += btnSchedule_Click;
            // 
            // btnPayment
            // 
            btnPayment.Font = new Font("Segoe UI", 11F);
            btnPayment.Location = new Point(102, 190);
            btnPayment.Margin = new Padding(2, 2, 2, 2);
            btnPayment.Name = "btnPayment";
            btnPayment.Size = new Size(344, 34);
            btnPayment.TabIndex = 16;
            btnPayment.Text = "Make Payment and View Invoice";
            btnPayment.UseVisualStyleBackColor = true;
            btnPayment.Click += btnPayment_Click;
            // 
            // btnManage
            // 
            btnManage.Font = new Font("Segoe UI", 11F);
            btnManage.Location = new Point(102, 138);
            btnManage.Margin = new Padding(2, 2, 2, 2);
            btnManage.Name = "btnManage";
            btnManage.Size = new Size(344, 34);
            btnManage.TabIndex = 17;
            btnManage.Text = "Manage Class Request";
            btnManage.UseVisualStyleBackColor = true;
            btnManage.Click += btnManage_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Font = new Font("Segoe UI", 11F);
            btnUpdate.Location = new Point(102, 243);
            btnUpdate.Margin = new Padding(2, 2, 2, 2);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(344, 34);
            btnUpdate.TabIndex = 18;
            btnUpdate.Text = "Update Account Profile";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // student_menu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(545, 341);
            Controls.Add(btnUpdate);
            Controls.Add(btnManage);
            Controls.Add(btnPayment);
            Controls.Add(btnSchedule);
            Controls.Add(lblBack);
            Controls.Add(label1);
            Margin = new Padding(2, 2, 2, 2);
            Name = "student_menu";
            Text = "studentMenu";
            FormClosed += student_menu_FormClosed;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lblBack;
        private Button btnSchedule;
        private Button btnPayment;
        private Button btnManage;
        private Button btnUpdate;
    }
}