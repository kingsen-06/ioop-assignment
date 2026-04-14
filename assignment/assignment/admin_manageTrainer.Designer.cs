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
            btnAddTrainer.Location = new Point(404, 175);
            btnAddTrainer.Margin = new Padding(2);
            btnAddTrainer.Name = "btnAddTrainer";
            btnAddTrainer.Size = new Size(187, 34);
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
            btnRemove.Location = new Point(218, 298);
            btnRemove.Margin = new Padding(2);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(187, 34);
            btnRemove.TabIndex = 2;
            btnRemove.Text = "Remove Trainer";
            btnRemove.UseVisualStyleBackColor = false;
            btnRemove.Click += btnRemove_Click;
            // 
            // btnViewDetail
            // 
            btnViewDetail.Font = new Font("Segoe UI", 11F);
            btnViewDetail.Location = new Point(335, 246);
            btnViewDetail.Margin = new Padding(2);
            btnViewDetail.Name = "btnViewDetail";
            btnViewDetail.Size = new Size(271, 34);
            btnViewDetail.TabIndex = 3;
            btnViewDetail.Text = "View Trainer Details";
            btnViewDetail.UseVisualStyleBackColor = true;
            btnViewDetail.Click += btnViewDetail_Click;
            // 
            // lblBack
            // 
            lblBack.AutoSize = true;
            lblBack.Font = new Font("Segoe UI", 11F);
            lblBack.Location = new Point(10, 350);
            lblBack.Margin = new Padding(2, 0, 2, 0);
            lblBack.Name = "lblBack";
            lblBack.Size = new Size(265, 25);
            lblBack.TabIndex = 5;
            lblBack.Text = "< Back to Administrator Menu";
            lblBack.Click += lblBack_Click;
            // 
            // btnViewReport
            // 
            btnViewReport.Font = new Font("Segoe UI", 11F);
            btnViewReport.Location = new Point(28, 246);
            btnViewReport.Margin = new Padding(2);
            btnViewReport.Name = "btnViewReport";
            btnViewReport.Size = new Size(271, 34);
            btnViewReport.TabIndex = 6;
            btnViewReport.Text = "View Monthly Income Report";
            btnViewReport.UseVisualStyleBackColor = true;
            btnViewReport.Click += btnViewReport_Click;
            // 
            // lstTrainer
            // 
            lstTrainer.Font = new Font("Segoe UI", 11F);
            lstTrainer.FormattingEnabled = true;
            lstTrainer.ItemHeight = 25;
            lstTrainer.Location = new Point(58, 49);
            lstTrainer.Margin = new Padding(2);
            lstTrainer.Name = "lstTrainer";
            lstTrainer.Size = new Size(337, 154);
            lstTrainer.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F);
            label1.Location = new Point(62, 18);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(132, 25);
            label1.TabIndex = 8;
            label1.Text = "Select trainer :";
            // 
            // admin_manageTrainer
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(640, 390);
            Controls.Add(label1);
            Controls.Add(lstTrainer);
            Controls.Add(btnViewReport);
            Controls.Add(lblBack);
            Controls.Add(btnViewDetail);
            Controls.Add(btnRemove);
            Controls.Add(btnAddTrainer);
            Margin = new Padding(2);
            Name = "admin_manageTrainer";
            Text = "manageTrainer";
            FormClosed += amind_manageTrainer_FormClosed;
            Load += admin_manageTrainer_Load;
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