namespace assignment
{
    partial class admin_assignModule
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
            label1.Location = new Point(124, 41);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(112, 25);
            label1.TabIndex = 0;
            label1.Text = "Class Level: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F);
            label2.Location = new Point(124, 114);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(141, 25);
            label2.TabIndex = 1;
            label2.Text = "Module Name: ";
            // 
            // cmbLevel
            // 
            cmbLevel.Font = new Font("Segoe UI", 11F);
            cmbLevel.FormattingEnabled = true;
            cmbLevel.Items.AddRange(new object[] { "Beginner", "Intermediate", "Advance" });
            cmbLevel.Location = new Point(306, 38);
            cmbLevel.Margin = new Padding(2, 2, 2, 2);
            cmbLevel.Name = "cmbLevel";
            cmbLevel.Size = new Size(208, 33);
            cmbLevel.TabIndex = 2;
            // 
            // cmbModule
            // 
            cmbModule.Font = new Font("Segoe UI", 11F);
            cmbModule.FormattingEnabled = true;
            cmbModule.Location = new Point(306, 111);
            cmbModule.Margin = new Padding(2, 2, 2, 2);
            cmbModule.Name = "cmbModule";
            cmbModule.Size = new Size(208, 33);
            cmbModule.TabIndex = 3;
            // 
            // btnAssign
            // 
            btnAssign.Font = new Font("Segoe UI", 11F);
            btnAssign.Location = new Point(178, 188);
            btnAssign.Margin = new Padding(2, 2, 2, 2);
            btnAssign.Name = "btnAssign";
            btnAssign.Size = new Size(257, 33);
            btnAssign.TabIndex = 4;
            btnAssign.Text = "Assign Trainer to Module";
            btnAssign.UseVisualStyleBackColor = true;
            btnAssign.Click += this.btnAssign_Click;
            // 
            // lblBack
            // 
            lblBack.AutoSize = true;
            lblBack.Font = new Font("Segoe UI", 11F);
            lblBack.Location = new Point(7, 247);
            lblBack.Margin = new Padding(2, 0, 2, 0);
            lblBack.Name = "lblBack";
            lblBack.Size = new Size(69, 25);
            lblBack.TabIndex = 6;
            lblBack.Text = "< Back";
            lblBack.Click += lblBack_Click;
            // 
            // admin_assignModule
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(640, 282);
            Controls.Add(lblBack);
            Controls.Add(btnAssign);
            Controls.Add(cmbModule);
            Controls.Add(cmbLevel);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(2, 2, 2, 2);
            Name = "admin_assignModule";
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