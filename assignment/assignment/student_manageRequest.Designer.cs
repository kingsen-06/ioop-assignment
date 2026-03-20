namespace assignment
{
    partial class student_manageRequest
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
            dataRequest = new DataGridView();
            lblBack = new Label();
            btnAdd = new Button();
            btnCancel = new Button();
            name = new DataGridViewTextBoxColumn();
            level = new DataGridViewTextBoxColumn();
            lecturer = new DataGridViewTextBoxColumn();
            status = new DataGridViewTextBoxColumn();
            reason = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataRequest).BeginInit();
            SuspendLayout();
            // 
            // dataRequest
            // 
            dataRequest.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataRequest.Columns.AddRange(new DataGridViewColumn[] { name, level, lecturer, status, reason });
            dataRequest.Location = new Point(63, 43);
            dataRequest.Name = "dataRequest";
            dataRequest.RowHeadersWidth = 62;
            dataRequest.Size = new Size(812, 291);
            dataRequest.TabIndex = 0;
            // 
            // lblBack
            // 
            lblBack.AutoSize = true;
            lblBack.Font = new Font("Segoe UI", 11F);
            lblBack.Location = new Point(13, 436);
            lblBack.Name = "lblBack";
            lblBack.Size = new Size(247, 30);
            lblBack.TabIndex = 1;
            lblBack.Text = "< Back to Student Menu";
            lblBack.Click += lblBack_Click;
            // 
            // btnAdd
            // 
            btnAdd.Font = new Font("Segoe UI", 11F);
            btnAdd.Location = new Point(219, 368);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(202, 43);
            btnAdd.TabIndex = 2;
            btnAdd.Text = "Add New Request";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnCancel
            // 
            btnCancel.Font = new Font("Segoe UI", 11F);
            btnCancel.Location = new Point(500, 368);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(202, 43);
            btnCancel.TabIndex = 3;
            btnCancel.Text = "Cancel Request";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // name
            // 
            name.HeaderText = "Module Name";
            name.MinimumWidth = 8;
            name.Name = "name";
            name.Width = 150;
            // 
            // level
            // 
            level.HeaderText = "Class Level";
            level.MinimumWidth = 8;
            level.Name = "level";
            level.Width = 150;
            // 
            // lecturer
            // 
            lecturer.HeaderText = "Lecturer";
            lecturer.MinimumWidth = 8;
            lecturer.Name = "lecturer";
            lecturer.Width = 150;
            // 
            // status
            // 
            status.HeaderText = "Status";
            status.MinimumWidth = 8;
            status.Name = "status";
            status.Width = 150;
            // 
            // reason
            // 
            reason.HeaderText = "Reject Reason";
            reason.MinimumWidth = 8;
            reason.Name = "reason";
            reason.Width = 150;
            // 
            // student_manageRequest
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(942, 488);
            Controls.Add(btnCancel);
            Controls.Add(btnAdd);
            Controls.Add(lblBack);
            Controls.Add(dataRequest);
            Name = "student_manageRequest";
            Text = "manageRequest";
            ((System.ComponentModel.ISupportInitialize)dataRequest).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataRequest;
        private Label lblBack;
        private Button btnAdd;
        private Button btnCancel;
        private DataGridViewTextBoxColumn name;
        private DataGridViewTextBoxColumn level;
        private DataGridViewTextBoxColumn lecturer;
        private DataGridViewTextBoxColumn status;
        private DataGridViewTextBoxColumn reason;
    }
}