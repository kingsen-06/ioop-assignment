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
            lstMonth.ItemHeight = 30;
            lstMonth.Items.AddRange(new object[] { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" });
            lstMonth.Location = new Point(98, 52);
            lstMonth.Name = "lstMonth";
            lstMonth.Size = new Size(548, 244);
            lstMonth.TabIndex = 0;
            // 
            // btnConfirm
            // 
            btnConfirm.Font = new Font("Segoe UI", 11F);
            btnConfirm.Location = new Point(300, 319);
            btnConfirm.Name = "btnConfirm";
            btnConfirm.Size = new Size(112, 38);
            btnConfirm.TabIndex = 1;
            btnConfirm.Text = "Confirm";
            btnConfirm.UseVisualStyleBackColor = true;
            btnConfirm.Click += btnConfirm_Click;
            // 
            // lblBack
            // 
            lblBack.AutoSize = true;
            lblBack.Font = new Font("Segoe UI", 11F);
            lblBack.Location = new Point(35, 345);
            lblBack.Name = "lblBack";
            lblBack.Size = new Size(79, 30);
            lblBack.TabIndex = 2;
            lblBack.Text = "< Back";
            lblBack.Click += lblBack_Click;
            // 
            // admin_monthChoice
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(743, 394);
            Controls.Add(lblBack);
            Controls.Add(btnConfirm);
            Controls.Add(lstMonth);
            Name = "admin_monthChoice";
            Text = "monthChoice";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lstMonth;
        private Button btnConfirm;
        private Label lblBack;
    }
}