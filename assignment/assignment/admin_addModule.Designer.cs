namespace assignment
{
    partial class admin_addModule
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
            lblBack = new Label();
            cmbLevel = new ComboBox();
            btnModule = new Button();
            label3 = new Label();
            txtModule = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F);
            label1.Location = new Point(38, 86);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(146, 25);
            label1.TabIndex = 0;
            label1.Text = "Module Name : ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F);
            label2.Location = new Point(38, 134);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(117, 25);
            label2.TabIndex = 1;
            label2.Text = "Class Level : ";
            // 
            // lblBack
            // 
            lblBack.AutoSize = true;
            lblBack.Font = new Font("Segoe UI", 11F);
            lblBack.Location = new Point(23, 230);
            lblBack.Margin = new Padding(2, 0, 2, 0);
            lblBack.Name = "lblBack";
            lblBack.Size = new Size(265, 25);
            lblBack.TabIndex = 2;
            lblBack.Text = "< Back to Administrator Menu";
            lblBack.Click += lblBack_Click;
            // 
            // cmbLevel
            // 
            cmbLevel.Font = new Font("Segoe UI", 11F);
            cmbLevel.FormattingEnabled = true;
            cmbLevel.Items.AddRange(new object[] { "Beginner", "Intermediate", "Advanced" });
            cmbLevel.Location = new Point(186, 131);
            cmbLevel.Margin = new Padding(2);
            cmbLevel.Name = "cmbLevel";
            cmbLevel.Size = new Size(334, 33);
            cmbLevel.TabIndex = 3;
            // 
            // btnModule
            // 
            btnModule.Font = new Font("Segoe UI", 11F);
            btnModule.Location = new Point(230, 187);
            btnModule.Margin = new Padding(2);
            btnModule.Name = "btnModule";
            btnModule.Size = new Size(122, 33);
            btnModule.TabIndex = 5;
            btnModule.Text = "Add Module";
            btnModule.UseVisualStyleBackColor = true;
            btnModule.Click += btnModule_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 18F);
            label3.Location = new Point(166, 24);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(252, 41);
            label3.TabIndex = 6;
            label3.Text = "Add New Module";
            // 
            // txtModule
            // 
            txtModule.Font = new Font("Segoe UI", 11F);
            txtModule.Location = new Point(186, 83);
            txtModule.Margin = new Padding(2);
            txtModule.Name = "txtModule";
            txtModule.Size = new Size(334, 32);
            txtModule.TabIndex = 4;
            // 
            // admin_addModule
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(579, 266);
            Controls.Add(label3);
            Controls.Add(btnModule);
            Controls.Add(txtModule);
            Controls.Add(cmbLevel);
            Controls.Add(lblBack);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(2);
            Name = "admin_addModule";
            Text = "addModule";
            FormClosed += admin_newModule_FormClosed;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label lblBack;
        private ComboBox cmbLevel;
        private Button btnModule;
        private Label label3;
        private TextBox txtModule;
    }
}