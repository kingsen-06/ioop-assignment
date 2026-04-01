namespace assignment
{
    partial class admin_manageLec
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
            label1 = new Label();
            lstLec = new ListBox();
            lblBack = new Label();
            btnViewDetail = new Button();
            btnRemove = new Button();
            btnAddLec = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F);
            label1.Location = new Point(88, 44);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(141, 25);
            label1.TabIndex = 15;
            label1.Text = "Select lecturer :";
            // 
            // lstLec
            // 
            lstLec.Font = new Font("Segoe UI", 11F);
            lstLec.FormattingEnabled = true;
            lstLec.ItemHeight = 25;
            lstLec.Location = new Point(76, 74);
            lstLec.Margin = new Padding(2);
            lstLec.Name = "lstLec";
            lstLec.Size = new Size(397, 154);
            lstLec.TabIndex = 14;
            // 
            // lblBack
            // 
            lblBack.AutoSize = true;
            lblBack.Font = new Font("Segoe UI", 11F);
            lblBack.Location = new Point(10, 364);
            lblBack.Margin = new Padding(2, 0, 2, 0);
            lblBack.Name = "lblBack";
            lblBack.Size = new Size(265, 25);
            lblBack.TabIndex = 12;
            lblBack.Text = "< Back to Administrator Menu";
            lblBack.Click += lblBack_Click;
            // 
            // btnViewDetail
            // 
            btnViewDetail.Font = new Font("Segoe UI", 11F);
            btnViewDetail.Location = new Point(315, 261);
            btnViewDetail.Margin = new Padding(2);
            btnViewDetail.Name = "btnViewDetail";
            btnViewDetail.Size = new Size(187, 34);
            btnViewDetail.TabIndex = 11;
            btnViewDetail.Text = "View Lecturer Detail";
            btnViewDetail.UseVisualStyleBackColor = true;
            btnViewDetail.Click += btnViewDetail_Click;
            // 
            // btnRemove
            // 
            btnRemove.BackColor = SystemColors.Window;
            btnRemove.Font = new Font("Segoe UI", 11F);
            btnRemove.ForeColor = Color.Red;
            btnRemove.Location = new Point(182, 309);
            btnRemove.Margin = new Padding(2);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(187, 34);
            btnRemove.TabIndex = 10;
            btnRemove.Text = "Remove Lecturer";
            btnRemove.UseVisualStyleBackColor = false;
            btnRemove.Click += btnRemove_Click;
            // 
            // btnAddLec
            // 
            btnAddLec.Font = new Font("Segoe UI", 11F);
            btnAddLec.Location = new Point(46, 261);
            btnAddLec.Margin = new Padding(2);
            btnAddLec.Name = "btnAddLec";
            btnAddLec.Size = new Size(187, 34);
            btnAddLec.TabIndex = 9;
            btnAddLec.Text = "Register New Lecturer";
            btnAddLec.UseVisualStyleBackColor = true;
            btnAddLec.Click += btnAddLec_Click;
            // 
            // admin_manageLec
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(566, 406);
            Controls.Add(label1);
            Controls.Add(lstLec);
            Controls.Add(lblBack);
            Controls.Add(btnViewDetail);
            Controls.Add(btnRemove);
            Controls.Add(btnAddLec);
            Margin = new Padding(2);
            Name = "admin_manageLec";
            Text = "manageLecturer";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ListBox lstLec;
        private Label lblBack;
        private Button btnViewDetail;
        private Button btnRemove;
        private Button btnAddLec;
    }
}