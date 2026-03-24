namespace assignment
{
    partial class lec_viewStudent
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
            dataStudent = new DataGridView();
            stuName = new DataGridViewTextBoxColumn();
            modName = new DataGridViewTextBoxColumn();
            level = new DataGridViewTextBoxColumn();
            status = new DataGridViewTextBoxColumn();
            lblBack = new Label();
            btnDel = new Button();
            btnAdd = new Button();
            lblName = new Label();
            lblLevel = new Label();
            cmbName = new ComboBox();
            cmbLevel = new ComboBox();
            btnAssignClass = new Button();
            btnEdit = new Button();
            ((System.ComponentModel.ISupportInitialize)dataStudent).BeginInit();
            SuspendLayout();
            // 
            // dataStudent
            // 
            dataStudent.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataStudent.Columns.AddRange(new DataGridViewColumn[] { stuName, modName, level, status });
            dataStudent.Location = new Point(80, 160);
            dataStudent.Name = "dataStudent";
            dataStudent.RowHeadersWidth = 62;
            dataStudent.Size = new Size(812, 225);
            dataStudent.TabIndex = 0;
            // 
            // stuName
            // 
            stuName.HeaderText = "Student Name";
            stuName.MinimumWidth = 8;
            stuName.Name = "stuName";
            stuName.Width = 300;
            // 
            // modName
            // 
            modName.HeaderText = "Module Name";
            modName.MinimumWidth = 8;
            modName.Name = "modName";
            modName.Width = 150;
            // 
            // level
            // 
            level.HeaderText = "Class Level";
            level.MinimumWidth = 8;
            level.Name = "level";
            level.Width = 150;
            // 
            // status
            // 
            status.HeaderText = "Status";
            status.MinimumWidth = 8;
            status.Name = "status";
            status.Width = 150;
            // 
            // lblBack
            // 
            lblBack.AutoSize = true;
            lblBack.Font = new Font("Segoe UI", 11F);
            lblBack.Location = new Point(14, 485);
            lblBack.Name = "lblBack";
            lblBack.Size = new Size(252, 30);
            lblBack.TabIndex = 5;
            lblBack.Text = "< Back to Lecturer Menu";
            // 
            // btnDel
            // 
            btnDel.Font = new Font("Segoe UI", 11F);
            btnDel.ForeColor = Color.Red;
            btnDel.Location = new Point(381, 469);
            btnDel.Name = "btnDel";
            btnDel.Size = new Size(209, 42);
            btnDel.TabIndex = 6;
            btnDel.Text = "Delete Student";
            btnDel.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            btnAdd.Font = new Font("Segoe UI", 11F);
            btnAdd.Location = new Point(115, 410);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(198, 42);
            btnAdd.TabIndex = 7;
            btnAdd.Text = "Add New Student";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Segoe UI", 11F);
            lblName.Location = new Point(174, 46);
            lblName.Name = "lblName";
            lblName.Size = new Size(169, 30);
            lblName.TabIndex = 8;
            lblName.Text = "Module Name : ";
            // 
            // lblLevel
            // 
            lblLevel.AutoSize = true;
            lblLevel.Font = new Font("Segoe UI", 11F);
            lblLevel.Location = new Point(174, 97);
            lblLevel.Name = "lblLevel";
            lblLevel.Size = new Size(134, 30);
            lblLevel.TabIndex = 9;
            lblLevel.Text = "Class Level : ";
            // 
            // cmbName
            // 
            cmbName.Font = new Font("Segoe UI", 11F);
            cmbName.FormattingEnabled = true;
            cmbName.Location = new Point(374, 43);
            cmbName.Name = "cmbName";
            cmbName.Size = new Size(418, 38);
            cmbName.TabIndex = 10;
            // 
            // cmbLevel
            // 
            cmbLevel.Font = new Font("Segoe UI", 11F);
            cmbLevel.FormattingEnabled = true;
            cmbLevel.Items.AddRange(new object[] { "Beginner", "Intermediate", "Advance" });
            cmbLevel.Location = new Point(374, 94);
            cmbLevel.Name = "cmbLevel";
            cmbLevel.Size = new Size(418, 38);
            cmbLevel.TabIndex = 11;
            // 
            // btnAssignClass
            // 
            btnAssignClass.Font = new Font("Segoe UI", 11F);
            btnAssignClass.Location = new Point(355, 410);
            btnAssignClass.Name = "btnAssignClass";
            btnAssignClass.Size = new Size(259, 42);
            btnAssignClass.TabIndex = 12;
            btnAssignClass.Text = "Assign Student to Class";
            btnAssignClass.UseVisualStyleBackColor = true;
            btnAssignClass.Click += btnAssignClass_Click;
            // 
            // btnEdit
            // 
            btnEdit.Font = new Font("Segoe UI", 11F);
            btnEdit.Location = new Point(660, 410);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(198, 42);
            btnEdit.TabIndex = 13;
            btnEdit.Text = "Edit Class";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // lec_viewStudent
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(979, 537);
            Controls.Add(btnEdit);
            Controls.Add(btnAssignClass);
            Controls.Add(cmbLevel);
            Controls.Add(cmbName);
            Controls.Add(lblLevel);
            Controls.Add(lblName);
            Controls.Add(btnAdd);
            Controls.Add(btnDel);
            Controls.Add(lblBack);
            Controls.Add(dataStudent);
            Name = "lec_viewStudent";
            Text = "viewStudent";
            ((System.ComponentModel.ISupportInitialize)dataStudent).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataStudent;
        private DataGridViewTextBoxColumn stuName;
        private DataGridViewTextBoxColumn modName;
        private DataGridViewTextBoxColumn level;
        private DataGridViewTextBoxColumn status;
        private Label lblBack;
        private Button btnDel;
        private Button btnAdd;
        private Label lblName;
        private Label lblLevel;
        private ComboBox cmbName;
        private ComboBox cmbLevel;
        private Button btnAssignClass;
        private Button btnEdit;
    }
}