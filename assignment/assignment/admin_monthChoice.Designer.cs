namespace assignment
{
    partial class admin_monthChoice
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
            lstMonth = new ListBox();
            btnConfirm = new Button();
            lblBack = new Label();
            SuspendLayout();
            // 
            // lstMonth
            // 
            lstMonth.Font = new Font("Segoe UI", 11F);
            lstMonth.FormattingEnabled = true;
            lstMonth.ItemHeight = 25;
            lstMonth.Items.AddRange(new object[] { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" });
            lstMonth.Location = new Point(78, 42);
            lstMonth.Margin = new Padding(2);
            lstMonth.Name = "lstMonth";
            lstMonth.Size = new Size(439, 179);
            lstMonth.TabIndex = 0;
            // 
            // btnConfirm
            // 
            btnConfirm.Font = new Font("Segoe UI", 11F);
            btnConfirm.Location = new Point(240, 255);
            btnConfirm.Margin = new Padding(2);
            btnConfirm.Name = "btnConfirm";
            btnConfirm.Size = new Size(90, 30);
            btnConfirm.TabIndex = 1;
            btnConfirm.Text = "Confirm";
            btnConfirm.UseVisualStyleBackColor = true;
            btnConfirm.Click += btnConfirm_Click;
            // 
            // lblBack
            // 
            lblBack.AutoSize = true;
            lblBack.Font = new Font("Segoe UI", 11F);
            lblBack.Location = new Point(28, 276);
            lblBack.Margin = new Padding(2, 0, 2, 0);
            lblBack.Name = "lblBack";
            lblBack.Size = new Size(69, 25);
            lblBack.TabIndex = 2;
            lblBack.Text = "< Back";
            lblBack.Click += lblBack_Click;
            // 
            // admin_monthChoice
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(594, 315);
            Controls.Add(lblBack);
            Controls.Add(btnConfirm);
            Controls.Add(lstMonth);
            Margin = new Padding(2);
            Name = "admin_monthChoice";
            Text = "monthChoice";
            FormClosed += admin_monthChoice_FormClosed;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lstMonth;
        private Button btnConfirm;
        private Label lblBack;
    }
}