namespace assignment
{
    partial class lec_viewRequest
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
            lblStudent = new Label();
            btnApprove = new Button();
            btnReject = new Button();
            dataRequest = new DataGridView();
            stuName = new DataGridViewTextBoxColumn();
            courseName = new DataGridViewTextBoxColumn();
            level = new DataGridViewTextBoxColumn();
            lblBack = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataRequest).BeginInit();
            SuspendLayout();
            // 
            // lblStudent
            // 
            lblStudent.AutoSize = true;
            lblStudent.BorderStyle = BorderStyle.Fixed3D;
            lblStudent.Font = new Font("Segoe UI", 11F);
            lblStudent.Location = new Point(150, 54);
            lblStudent.Name = "lblStudent";
            lblStudent.Size = new Size(2, 32);
            lblStudent.TabIndex = 0;
            // 
            // btnApprove
            // 
            btnApprove.Font = new Font("Segoe UI", 11F);
            btnApprove.Location = new Point(432, 50);
            btnApprove.Name = "btnApprove";
            btnApprove.Size = new Size(204, 39);
            btnApprove.TabIndex = 1;
            btnApprove.Text = "Approve Request";
            btnApprove.UseVisualStyleBackColor = true;
            btnApprove.Click += btnApprove_Click;
            // 
            // btnReject
            // 
            btnReject.Font = new Font("Segoe UI", 11F);
            btnReject.Location = new Point(659, 50);
            btnReject.Name = "btnReject";
            btnReject.Size = new Size(204, 39);
            btnReject.TabIndex = 2;
            btnReject.Text = "Reject Request";
            btnReject.UseVisualStyleBackColor = true;
            btnReject.Click += btnReject_Click;
            // 
            // dataRequest
            // 
            dataRequest.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataRequest.Columns.AddRange(new DataGridViewColumn[] { stuName, courseName, level });
            dataRequest.Location = new Point(115, 121);
            dataRequest.Name = "dataRequest";
            dataRequest.RowHeadersWidth = 62;
            dataRequest.Size = new Size(662, 246);
            dataRequest.TabIndex = 3;
            // 
            // stuName
            // 
            stuName.HeaderText = "Student Name";
            stuName.MinimumWidth = 8;
            stuName.Name = "stuName";
            stuName.Width = 300;
            // 
            // courseName
            // 
            courseName.HeaderText = "Course Name";
            courseName.MinimumWidth = 8;
            courseName.Name = "courseName";
            courseName.Width = 150;
            // 
            // level
            // 
            level.HeaderText = "Class Level";
            level.MinimumWidth = 8;
            level.Name = "level";
            level.Width = 150;
            // 
            // lblBack
            // 
            lblBack.AutoSize = true;
            lblBack.Font = new Font("Segoe UI", 11F);
            lblBack.Location = new Point(15, 392);
            lblBack.Name = "lblBack";
            lblBack.Size = new Size(252, 30);
            lblBack.TabIndex = 4;
            lblBack.Text = "< Back to Lecturer Menu";
            lblBack.Click += label2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F);
            label1.Location = new Point(40, 54);
            label1.Name = "label1";
            label1.Size = new Size(104, 30);
            label1.TabIndex = 5;
            label1.Text = "Student : ";
            // 
            // lec_viewRequest
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(902, 445);
            Controls.Add(label1);
            Controls.Add(lblBack);
            Controls.Add(dataRequest);
            Controls.Add(btnReject);
            Controls.Add(btnApprove);
            Controls.Add(lblStudent);
            Name = "lec_viewRequest";
            Text = "viewRequest";
            ((System.ComponentModel.ISupportInitialize)dataRequest).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblStudent;
        private Button btnApprove;
        private Button btnReject;
        private DataGridView dataRequest;
        private Label lblBack;
        private DataGridViewTextBoxColumn stuName;
        private DataGridViewTextBoxColumn courseName;
        private DataGridViewTextBoxColumn level;
        private Label label1;
    }
}