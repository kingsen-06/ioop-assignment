namespace assignment
{
    partial class admin_newClass
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
            comboBox1 = new ComboBox();
            textBox1 = new TextBox();
            btnModule = new Button();
            label3 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F);
            label1.Location = new Point(47, 107);
            label1.Name = "label1";
            label1.Size = new Size(169, 30);
            label1.TabIndex = 0;
            label1.Text = "Module Name : ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F);
            label2.Location = new Point(47, 167);
            label2.Name = "label2";
            label2.Size = new Size(134, 30);
            label2.TabIndex = 1;
            label2.Text = "Class Level : ";
            // 
            // lblBack
            // 
            lblBack.AutoSize = true;
            lblBack.Font = new Font("Segoe UI", 11F);
            lblBack.Location = new Point(29, 287);
            lblBack.Name = "lblBack";
            lblBack.Size = new Size(304, 30);
            lblBack.TabIndex = 2;
            lblBack.Text = "< Back to Administrator Menu";
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Segoe UI", 11F);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(232, 164);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(416, 38);
            comboBox1.TabIndex = 3;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 11F);
            textBox1.Location = new Point(232, 104);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(416, 37);
            textBox1.TabIndex = 4;
            // 
            // btnModule
            // 
            btnModule.Font = new Font("Segoe UI", 11F);
            btnModule.Location = new Point(288, 234);
            btnModule.Name = "btnModule";
            btnModule.Size = new Size(152, 41);
            btnModule.TabIndex = 5;
            btnModule.Text = "Add Module";
            btnModule.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 18F);
            label3.Location = new Point(133, 27);
            label3.Name = "label3";
            label3.Size = new Size(457, 48);
            label3.TabIndex = 6;
            label3.Text = "Add New Module and Class";
            // 
            // admin_newClass
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(724, 332);
            Controls.Add(label3);
            Controls.Add(btnModule);
            Controls.Add(textBox1);
            Controls.Add(comboBox1);
            Controls.Add(lblBack);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "admin_newClass";
            Text = "admin_newClass";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label lblBack;
        private ComboBox comboBox1;
        private TextBox textBox1;
        private Button btnModule;
        private Label label3;
    }
}