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
            dataTrainer = new DataGridView();
            triainer = new DataGridViewTextBoxColumn();
            income = new DataGridViewTextBoxColumn();
            btnAddTrainer = new Button();
            btnRemove = new Button();
            btnEdit = new Button();
            lblBack = new Label();
            ((System.ComponentModel.ISupportInitialize)dataTrainer).BeginInit();
            SuspendLayout();
            // 
            // dataTrainer
            // 
            dataTrainer.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataTrainer.Columns.AddRange(new DataGridViewColumn[] { triainer, income });
            dataTrainer.Location = new Point(221, 45);
            dataTrainer.Name = "dataTrainer";
            dataTrainer.RowHeadersWidth = 62;
            dataTrainer.Size = new Size(360, 225);
            dataTrainer.TabIndex = 0;
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
            btnAddTrainer.Location = new Point(44, 325);
            btnAddTrainer.Name = "btnAddTrainer";
            btnAddTrainer.Size = new Size(222, 43);
            btnAddTrainer.TabIndex = 1;
            btnAddTrainer.Text = "Add New Trainer";
            btnAddTrainer.UseVisualStyleBackColor = true;
            // 
            // btnRemove
            // 
            btnRemove.Font = new Font("Segoe UI", 11F);
            btnRemove.Location = new Point(294, 325);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(222, 43);
            btnRemove.TabIndex = 2;
            btnRemove.Text = "Remove Trainer";
            btnRemove.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            btnEdit.Font = new Font("Segoe UI", 11F);
            btnEdit.Location = new Point(540, 325);
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
            lblBack.Location = new Point(17, 394);
            lblBack.Name = "lblBack";
            lblBack.Size = new Size(304, 30);
            lblBack.TabIndex = 5;
            lblBack.Text = "< Back to Administrator Menu";
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
            Controls.Add(dataTrainer);
            Name = "admin_selectTrainer";
            Text = "selectTrainer";
            ((System.ComponentModel.ISupportInitialize)dataTrainer).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataTrainer;
        private Button btnAddTrainer;
        private Button btnRemove;
        private Button btnEdit;
        private Label lblBack;
        private DataGridViewTextBoxColumn triainer;
        private DataGridViewTextBoxColumn income;
    }
}