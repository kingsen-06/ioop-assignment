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
            dataGridView1 = new DataGridView();
            stuName = new DataGridViewTextBoxColumn();
            modName = new DataGridViewTextBoxColumn();
            level = new DataGridViewTextBoxColumn();
            status = new DataGridViewTextBoxColumn();
            label2 = new Label();
            btnDel = new Button();
            btnAdd = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { stuName, modName, level, status });
            dataGridView1.Location = new Point(80, 54);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(812, 225);
            dataGridView1.TabIndex = 0;
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
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F);
            label2.Location = new Point(14, 375);
            label2.Name = "label2";
            label2.Size = new Size(252, 30);
            label2.TabIndex = 5;
            label2.Text = "< Back to Lecturer Menu";
            // 
            // btnDel
            // 
            btnDel.Font = new Font("Segoe UI", 11F);
            btnDel.Location = new Point(661, 304);
            btnDel.Name = "btnDel";
            btnDel.Size = new Size(209, 42);
            btnDel.TabIndex = 6;
            btnDel.Text = "Delete Student";
            btnDel.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            btnAdd.Font = new Font("Segoe UI", 11F);
            btnAdd.Location = new Point(101, 304);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(209, 42);
            btnAdd.TabIndex = 7;
            btnAdd.Text = "Add New Student";
            btnAdd.UseVisualStyleBackColor = true;
            // 
            // lec_viewStudent
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(979, 436);
            Controls.Add(btnAdd);
            Controls.Add(btnDel);
            Controls.Add(label2);
            Controls.Add(dataGridView1);
            Name = "lec_viewStudent";
            Text = "viewStudent";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn stuName;
        private DataGridViewTextBoxColumn modName;
        private DataGridViewTextBoxColumn level;
        private DataGridViewTextBoxColumn status;
        private Label label2;
        private Button btnDel;
        private Button btnAdd;
    }
}