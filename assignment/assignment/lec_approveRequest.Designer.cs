namespace assignment
{
    partial class lec_approveRequest
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
            dataGridView1 = new DataGridView();
            label2 = new Label();
            label1 = new Label();
            stuName = new DataGridViewTextBoxColumn();
            courseName = new DataGridViewTextBoxColumn();
            level = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // lblStudent
            // 
            lblStudent.AutoSize = true;
            lblStudent.BorderStyle = BorderStyle.FixedSingle;
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
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { stuName, courseName, level });
            dataGridView1.Location = new Point(115, 121);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(662, 246);
            dataGridView1.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F);
            label2.Location = new Point(15, 392);
            label2.Name = "label2";
            label2.Size = new Size(252, 30);
            label2.TabIndex = 4;
            label2.Text = "< Back to Lecturer Menu";
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
            // lec_approveRequest
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(902, 445);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(dataGridView1);
            Controls.Add(btnReject);
            Controls.Add(btnApprove);
            Controls.Add(lblStudent);
            Name = "lec_approveRequest";
            Text = "approveRequest";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblStudent;
        private Button btnApprove;
        private Button btnReject;
        private DataGridView dataGridView1;
        private Label label2;
        private DataGridViewTextBoxColumn stuName;
        private DataGridViewTextBoxColumn courseName;
        private DataGridViewTextBoxColumn level;
        private Label label1;
    }
}