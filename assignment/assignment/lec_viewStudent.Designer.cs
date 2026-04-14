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
            status = new DataGridViewTextBoxColumn();
            lblBack = new Label();
            btnDel = new Button();
            btnAdd = new Button();
            lblName = new Label();
            lblLevel = new Label();
            cmbName = new ComboBox();
            btnAssignClass = new Button();
            btnEdit = new Button();
            lblClassLevel = new Label();
            ((System.ComponentModel.ISupportInitialize)dataStudent).BeginInit();
            SuspendLayout();
            // 
            // dataStudent
            // 
            dataStudent.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataStudent.Columns.AddRange(new DataGridViewColumn[] { stuName, modName, status });
            dataStudent.Location = new Point(64, 128);
            dataStudent.Margin = new Padding(2);
            dataStudent.Name = "dataStudent";
            dataStudent.RowHeadersWidth = 62;
            dataStudent.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataStudent.Size = new Size(650, 180);
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
            lblBack.Location = new Point(11, 388);
            lblBack.Margin = new Padding(2, 0, 2, 0);
            lblBack.Name = "lblBack";
            lblBack.Size = new Size(219, 25);
            lblBack.TabIndex = 5;
            lblBack.Text = "< Back to Lecturer Menu";
            lblBack.Click += lblBack_Click;
            // 
            // btnDel
            // 
            btnDel.Font = new Font("Segoe UI", 11F);
            btnDel.ForeColor = Color.Red;
            btnDel.Location = new Point(305, 375);
            btnDel.Margin = new Padding(2);
            btnDel.Name = "btnDel";
            btnDel.Size = new Size(167, 34);
            btnDel.TabIndex = 6;
            btnDel.Text = "Delete Student";
            btnDel.UseVisualStyleBackColor = true;
            btnDel.Click += btnDel_Click;
            // 
            // btnAdd
            // 
            btnAdd.Font = new Font("Segoe UI", 11F);
            btnAdd.Location = new Point(82, 328);
            btnAdd.Margin = new Padding(2);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(168, 34);
            btnAdd.TabIndex = 7;
            btnAdd.Text = "Add New Student";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Segoe UI", 11F);
            lblName.Location = new Point(139, 37);
            lblName.Margin = new Padding(2, 0, 2, 0);
            lblName.Name = "lblName";
            lblName.Size = new Size(146, 25);
            lblName.TabIndex = 8;
            lblName.Text = "Module Name : ";
            // 
            // lblLevel
            // 
            lblLevel.AutoSize = true;
            lblLevel.Font = new Font("Segoe UI", 11F);
            lblLevel.Location = new Point(139, 78);
            lblLevel.Margin = new Padding(2, 0, 2, 0);
            lblLevel.Name = "lblLevel";
            lblLevel.Size = new Size(117, 25);
            lblLevel.TabIndex = 9;
            lblLevel.Text = "Class Level : ";
            // 
            // cmbName
            // 
            cmbName.Font = new Font("Segoe UI", 11F);
            cmbName.FormattingEnabled = true;
            cmbName.Location = new Point(299, 34);
            cmbName.Margin = new Padding(2);
            cmbName.Name = "cmbName";
            cmbName.Size = new Size(335, 33);
            cmbName.TabIndex = 10;
            cmbName.SelectedIndexChanged += cmbName_SelectedIndexChanged;
            // 
            // btnAssignClass
            // 
            btnAssignClass.Font = new Font("Segoe UI", 11F);
            btnAssignClass.Location = new Point(284, 328);
            btnAssignClass.Margin = new Padding(2);
            btnAssignClass.Name = "btnAssignClass";
            btnAssignClass.Size = new Size(207, 34);
            btnAssignClass.TabIndex = 12;
            btnAssignClass.Text = "Assign Student to Class";
            btnAssignClass.UseVisualStyleBackColor = true;
            btnAssignClass.Click += btnAssignClass_Click;
            // 
            // btnEdit
            // 
            btnEdit.Font = new Font("Segoe UI", 11F);
            btnEdit.Location = new Point(526, 328);
            btnEdit.Margin = new Padding(2);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(168, 34);
            btnEdit.TabIndex = 13;
            btnEdit.Text = "Edit Class";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // lblClassLevel
            // 
            lblClassLevel.AutoSize = true;
            lblClassLevel.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblClassLevel.Location = new Point(299, 78);
            lblClassLevel.Name = "lblClassLevel";
            lblClassLevel.Size = new Size(0, 25);
            lblClassLevel.TabIndex = 14;
            // 
            // lec_viewStudent
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(783, 430);
            Controls.Add(lblClassLevel);
            Controls.Add(btnEdit);
            Controls.Add(btnAssignClass);
            Controls.Add(cmbName);
            Controls.Add(lblLevel);
            Controls.Add(lblName);
            Controls.Add(btnAdd);
            Controls.Add(btnDel);
            Controls.Add(lblBack);
            Controls.Add(dataStudent);
            Margin = new Padding(2);
            Name = "lec_viewStudent";
            Text = "viewStudent";
            FormClosed += lec_viewStudent_FormClosed;
            Load += lec_viewStudent_Load;
            ((System.ComponentModel.ISupportInitialize)dataStudent).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataStudent;
        private Label lblBack;
        private Button btnDel;
        private Button btnAdd;
        private Label lblName;
        private Label lblLevel;
        private ComboBox cmbName;
        private Button btnAssignClass;
        private Button btnEdit;
        private DataGridViewTextBoxColumn stuName;
        private DataGridViewTextBoxColumn modName;
        private DataGridViewTextBoxColumn status;
        private Label lblClassLevel;
    }
}