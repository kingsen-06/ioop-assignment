namespace assignment
{
    partial class admin_assignClass
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
            label2 = new Label();
            cmbLevel = new ComboBox();
            cmbModule = new ComboBox();
            btnAssign = new Button();
            lblBack = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F);
            label1.Location = new Point(155, 51);
            label1.Name = "label1";
            label1.Size = new Size(128, 30);
            label1.TabIndex = 0;
            label1.Text = "Class Level: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F);
            label2.Location = new Point(155, 142);
            label2.Name = "label2";
            label2.Size = new Size(163, 30);
            label2.TabIndex = 1;
            label2.Text = "Module Name: ";
            // 
            // cmbLevel
            // 
            cmbLevel.Font = new Font("Segoe UI", 11F);
            cmbLevel.FormattingEnabled = true;
            cmbLevel.Items.AddRange(new object[] { "Beginner", "Intermediate", "Advance" });
            cmbLevel.Location = new Point(383, 48);
            cmbLevel.Name = "cmbLevel";
            cmbLevel.Size = new Size(259, 38);
            cmbLevel.TabIndex = 2;
            // 
            // cmbModule
            // 
            cmbModule.Font = new Font("Segoe UI", 11F);
            cmbModule.FormattingEnabled = true;
            cmbModule.Location = new Point(383, 139);
            cmbModule.Name = "cmbModule";
            cmbModule.Size = new Size(259, 38);
            cmbModule.TabIndex = 3;
            // 
            // btnAssign
            // 
            btnAssign.Font = new Font("Segoe UI", 11F);
            btnAssign.Location = new Point(222, 235);
            btnAssign.Name = "btnAssign";
            btnAssign.Size = new Size(321, 41);
            btnAssign.TabIndex = 4;
            btnAssign.Text = "Assign Trainer to Module";
            btnAssign.UseVisualStyleBackColor = true;
            // 
            // lblBack
            // 
            lblBack.AutoSize = true;
            lblBack.Font = new Font("Segoe UI", 11F);
            lblBack.Location = new Point(9, 309);
            lblBack.Name = "lblBack";
            lblBack.Size = new Size(304, 30);
            lblBack.TabIndex = 6;
            lblBack.Text = "< Back to Administrator Menu";
            lblBack.Click += lblBack_Click;
            // 
            // admin_assignClass
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 353);
            Controls.Add(lblBack);
            Controls.Add(btnAssign);
            Controls.Add(cmbModule);
            Controls.Add(cmbLevel);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "admin_assignClass";
            Text = "assignTrainer";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private ComboBox cmbLevel;
        private ComboBox cmbModule;
        private Button btnAssign;
        private Label lblBack;
    }
}