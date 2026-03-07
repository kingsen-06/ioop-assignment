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
            triainer = new DataGridViewTextBoxColumn();
            income = new DataGridViewTextBoxColumn();
            btnAddTrainer = new Button();
            btnRemove = new Button();
            btnEdit = new Button();
            lblBack = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { triainer, income });
            dataGridView1.Location = new Point(154, 70);
            dataGridView1.Margin = new Padding(2, 2, 2, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(364, 180);
            dataGridView1.TabIndex = 0;
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
            // btnAddTrainer
            // 
            btnAddTrainer.Font = new Font("Segoe UI", 11F);
            btnAddTrainer.Location = new Point(11, 293);
            btnAddTrainer.Margin = new Padding(2, 2, 2, 2);
            btnAddTrainer.Name = "btnAddTrainer";
            btnAddTrainer.Size = new Size(204, 34);
            btnAddTrainer.TabIndex = 1;
            btnAddTrainer.Text = "Register New Trainer";
            btnAddTrainer.UseVisualStyleBackColor = true;
            // 
            // btnRemove
            // 
            btnRemove.Font = new Font("Segoe UI", 11F);
            btnRemove.Location = new Point(228, 293);
            btnRemove.Margin = new Padding(2, 2, 2, 2);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(204, 34);
            btnRemove.TabIndex = 2;
            btnRemove.Text = "Remove Trainer";
            btnRemove.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            btnEdit.Font = new Font("Segoe UI", 11F);
            btnEdit.Location = new Point(445, 293);
            btnEdit.Margin = new Padding(2, 2, 2, 2);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(204, 34);
            btnEdit.TabIndex = 3;
            btnEdit.Text = "Edit Trainer Detail";
            btnEdit.UseVisualStyleBackColor = true;
            // 
            // lblBack
            // 
            lblBack.AutoSize = true;
            lblBack.Font = new Font("Segoe UI", 11F);
            lblBack.Location = new Point(11, 9);
            lblBack.Margin = new Padding(2, 0, 2, 0);
            lblBack.Name = "lblBack";
            lblBack.Size = new Size(145, 25);
            lblBack.TabIndex = 5;
            lblBack.Text = "< Back to Menu";
            // 
            // admin_selectTrainer
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(667, 366);
            Controls.Add(lblBack);
            Controls.Add(btnEdit);
            Controls.Add(btnRemove);
            Controls.Add(btnAddTrainer);
            Controls.Add(dataGridView1);
            Margin = new Padding(2, 2, 2, 2);
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