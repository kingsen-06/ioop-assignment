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
            label2 = new Label();
            cmbModule = new ComboBox();
            btnAssign = new Button();
            lblBack = new Label();
            label3 = new Label();
            lblLevel = new Label();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F);
            label2.Location = new Point(124, 45);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(141, 25);
            label2.TabIndex = 1;
            label2.Text = "Module Name: ";
            // 
            // cmbModule
            // 
            cmbModule.Font = new Font("Segoe UI", 11F);
            cmbModule.FormattingEnabled = true;
            cmbModule.Location = new Point(306, 42);
            cmbModule.Margin = new Padding(2);
            cmbModule.Name = "cmbModule";
            cmbModule.Size = new Size(208, 33);
            cmbModule.TabIndex = 3;
            cmbModule.SelectedIndexChanged += cmbModule_SelectedIndexChanged;
            // 
            // btnAssign
            // 
            btnAssign.Font = new Font("Segoe UI", 11F);
            btnAssign.Location = new Point(178, 188);
            btnAssign.Margin = new Padding(2);
            btnAssign.Name = "btnAssign";
            btnAssign.Size = new Size(257, 33);
            btnAssign.TabIndex = 4;
            btnAssign.Text = "Assign Trainer to Module";
            btnAssign.UseVisualStyleBackColor = true;
            btnAssign.Click += btnAssign_Click;
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
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11F);
            label3.Location = new Point(124, 123);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(112, 25);
            label3.TabIndex = 0;
            label3.Text = "Class Level: ";
            // 
            // lblLevel
            // 
            lblLevel.AutoSize = true;
            lblLevel.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblLevel.Location = new Point(306, 123);
            lblLevel.Name = "lblLevel";
            lblLevel.Size = new Size(0, 25);
            lblLevel.TabIndex = 7;
            // 
            // admin_assignModule
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(640, 282);
            Controls.Add(lblLevel);
            Controls.Add(lblBack);
            Controls.Add(btnAssign);
            Controls.Add(cmbModule);
            Controls.Add(label3);
            Controls.Add(label2);
            Margin = new Padding(2);
            Name = "admin_assignModule";
            Text = "assignModule";
            FormClosed += admin_assignModule_FormClosed;
            Load += admin_assignModule_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private ComboBox cmbModule;
        private Button btnAssign;
        private Label lblBack;
        private Label label3;
        private Label lblLevel;
    }
}