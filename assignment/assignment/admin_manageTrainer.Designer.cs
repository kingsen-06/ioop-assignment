namespace assignment
{
    partial class admin_manageTrainer
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
            btnAddTrainer = new Button();
            btnRemove = new Button();
            btnViewDetail = new Button();
            lblBack = new Label();
            btnViewReport = new Button();
            lstTrainer = new ListBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnAddTrainer
            // 
            btnAddTrainer.Font = new Font("Segoe UI", 11F);
            btnAddTrainer.Location = new Point(505, 219);
            btnAddTrainer.Name = "btnAddTrainer";
            btnAddTrainer.Size = new Size(234, 43);
            btnAddTrainer.TabIndex = 1;
            btnAddTrainer.Text = "Register New Trainer";
            btnAddTrainer.UseVisualStyleBackColor = true;
            btnAddTrainer.Click += btnAddTrainer_Click;
            // 
            // btnRemove
            // 
            btnRemove.BackColor = SystemColors.Window;
            btnRemove.Font = new Font("Segoe UI", 11F);
            btnRemove.ForeColor = Color.Red;
            btnRemove.Location = new Point(272, 372);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(234, 43);
            btnRemove.TabIndex = 2;
            btnRemove.Text = "Remove Trainer";
            btnRemove.UseVisualStyleBackColor = false;
            // 
            // btnViewDetail
            // 
            btnViewDetail.Font = new Font("Segoe UI", 11F);
            btnViewDetail.Location = new Point(419, 308);
            btnViewDetail.Name = "btnViewDetail";
            btnViewDetail.Size = new Size(339, 43);
            btnViewDetail.TabIndex = 3;
            btnViewDetail.Text = "View Trainer Detail";
            btnViewDetail.UseVisualStyleBackColor = true;
            btnViewDetail.Click += btnViewDetail_Click;
            // 
            // lblBack
            // 
            lblBack.AutoSize = true;
            lblBack.Font = new Font("Segoe UI", 11F);
            lblBack.Location = new Point(12, 438);
            lblBack.Name = "lblBack";
            lblBack.Size = new Size(304, 30);
            lblBack.TabIndex = 5;
            lblBack.Text = "< Back to Administrator Menu";
            lblBack.Click += lblBack_Click;
            // 
            // btnViewReport
            // 
            btnViewReport.Font = new Font("Segoe UI", 11F);
            btnViewReport.Location = new Point(35, 308);
            btnViewReport.Name = "btnViewReport";
            btnViewReport.Size = new Size(339, 43);
            btnViewReport.TabIndex = 6;
            btnViewReport.Text = "View Monthly Income Report";
            btnViewReport.UseVisualStyleBackColor = true;
            btnViewReport.Click += btnViewReport_Click;
            // 
            // lstTrainer
            // 
            lstTrainer.Font = new Font("Segoe UI", 11F);
            lstTrainer.FormattingEnabled = true;
            lstTrainer.ItemHeight = 30;
            lstTrainer.Location = new Point(72, 61);
            lstTrainer.Name = "lstTrainer";
            lstTrainer.Size = new Size(420, 214);
            lstTrainer.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F);
            label1.Location = new Point(77, 22);
            label1.Name = "label1";
            label1.Size = new Size(151, 30);
            label1.TabIndex = 8;
            label1.Text = "Select trainer :";
            // 
            // admin_manageTrainer
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 487);
            Controls.Add(label1);
            Controls.Add(lstTrainer);
            Controls.Add(btnViewReport);
            Controls.Add(lblBack);
            Controls.Add(btnViewDetail);
            Controls.Add(btnRemove);
            Controls.Add(btnAddTrainer);
            Name = "admin_manageTrainer";
            Text = "manageTrainer";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnAddTrainer;
        private Button btnRemove;
        private Button btnViewDetail;
        private Label lblBack;
        private Button btnViewReport;
        private ListBox lstTrainer;
        private Label label1;
    }
}