namespace assignment
{
    partial class admin_selectTrainer
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
            btnAdd = new Button();
            btnRemove = new Button();
            btnEdit = new Button();
            btnBack = new Button();
            triainer = new DataGridViewTextBoxColumn();
            salary = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { triainer, salary });
            dataGridView1.Location = new Point(212, 33);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(360, 225);
            dataGridView1.TabIndex = 0;
            // 
            // btnAdd
            // 
            btnAdd.Font = new Font("Segoe UI", 11F);
            btnAdd.Location = new Point(39, 298);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(222, 43);
            btnAdd.TabIndex = 1;
            btnAdd.Text = "Add New Trainer";
            btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnRemove
            // 
            btnRemove.Font = new Font("Segoe UI", 11F);
            btnRemove.Location = new Point(289, 298);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(222, 43);
            btnRemove.TabIndex = 2;
            btnRemove.Text = "Remove Trainer";
            btnRemove.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            btnEdit.Font = new Font("Segoe UI", 11F);
            btnEdit.Location = new Point(535, 298);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(222, 43);
            btnEdit.TabIndex = 3;
            btnEdit.Text = "Edit Trainer Detail";
            btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnBack
            // 
            btnBack.Font = new Font("Segoe UI", 11F);
            btnBack.Location = new Point(12, 395);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(222, 43);
            btnBack.TabIndex = 4;
            btnBack.Text = "< Back to Menu";
            btnBack.UseVisualStyleBackColor = true;
            // 
            // triainer
            // 
            triainer.HeaderText = "Trainer";
            triainer.MinimumWidth = 8;
            triainer.Name = "triainer";
            triainer.Width = 150;
            // 
            // salary
            // 
            salary.HeaderText = "Monthly Salary";
            salary.MinimumWidth = 8;
            salary.Name = "salary";
            salary.Width = 150;
            // 
            // admin_selectTrainer
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnBack);
            Controls.Add(btnEdit);
            Controls.Add(btnRemove);
            Controls.Add(btnAdd);
            Controls.Add(dataGridView1);
            Name = "admin_selectTrainer";
            Text = "selectTrainer";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private Button btnAdd;
        private Button btnRemove;
        private Button btnEdit;
        private Button btnBack;
        private DataGridViewTextBoxColumn triainer;
        private DataGridViewTextBoxColumn salary;
    }
}