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
            btnAddTrainer = new Button();
            btnRemove = new Button();
            btnEdit = new Button();
            lblBack = new Label();
            triainer = new DataGridViewTextBoxColumn();
            income = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { triainer, income });
            dataGridView1.Location = new Point(210, 87);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(360, 225);
            dataGridView1.TabIndex = 0;
            // 
            // btnAddTrainer
            // 
            btnAddTrainer.Font = new Font("Segoe UI", 11F);
            btnAddTrainer.Location = new Point(33, 367);
            btnAddTrainer.Name = "btnAddTrainer";
            btnAddTrainer.Size = new Size(222, 43);
            btnAddTrainer.TabIndex = 1;
            btnAddTrainer.Text = "Add New Trainer";
            btnAddTrainer.UseVisualStyleBackColor = true;
            // 
            // btnRemove
            // 
            btnRemove.Font = new Font("Segoe UI", 11F);
            btnRemove.Location = new Point(283, 367);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(222, 43);
            btnRemove.TabIndex = 2;
            btnRemove.Text = "Remove Trainer";
            btnRemove.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            btnEdit.Font = new Font("Segoe UI", 11F);
            btnEdit.Location = new Point(529, 367);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(222, 43);
            btnEdit.TabIndex = 3;
            btnEdit.Text = "Edit Trainer Detail";
            btnEdit.UseVisualStyleBackColor = true;
            // 
            // lblBack
            // 
            lblBack.AutoSize = true;
            lblBack.Font = new Font("Segoe UI", 11F);
            lblBack.Location = new Point(33, 25);
            lblBack.Name = "lblBack";
            lblBack.Size = new Size(167, 30);
            lblBack.TabIndex = 5;
            lblBack.Text = "< Back to Menu";
            // 
            // triainer
            // 
            triainer.HeaderText = "Trainer";
            triainer.MinimumWidth = 8;
            triainer.Name = "triainer";
            triainer.Width = 150;
            // 
            // income
            // 
            income.HeaderText = "Monthly Income";
            income.MinimumWidth = 8;
            income.Name = "income";
            income.Width = 150;
            // 
            // admin_selectTrainer
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 458);
            Controls.Add(lblBack);
            Controls.Add(btnEdit);
            Controls.Add(btnRemove);
            Controls.Add(btnAddTrainer);
            Controls.Add(dataGridView1);
            Name = "admin_selectTrainer";
            Text = "selectTrainer";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button btnAddTrainer;
        private Button btnRemove;
        private Button btnEdit;
        private Label lblBack;
        private DataGridViewTextBoxColumn triainer;
        private DataGridViewTextBoxColumn income;
    }
}