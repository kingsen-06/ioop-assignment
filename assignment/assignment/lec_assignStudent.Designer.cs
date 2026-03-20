namespace assignment
{
    partial class lec_assignStudent
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
            label3 = new Label();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            comboBox3 = new ComboBox();
            comboBox4 = new ComboBox();
            label4 = new Label();
            label5 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F);
            label1.Location = new Point(86, 74);
            label1.Name = "label1";
            label1.Size = new Size(169, 30);
            label1.TabIndex = 0;
            label1.Text = "Module Name : ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F);
            label2.Location = new Point(86, 137);
            label2.Name = "label2";
            label2.Size = new Size(134, 30);
            label2.TabIndex = 1;
            label2.Text = "Class Level : ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11F);
            label3.Location = new Point(86, 203);
            label3.Name = "label3";
            label3.Size = new Size(96, 30);
            label3.TabIndex = 2;
            label3.Text = "Trainer : ";
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Segoe UI", 11F);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(275, 71);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(366, 38);
            comboBox1.TabIndex = 3;
            // 
            // comboBox2
            // 
            comboBox2.Font = new Font("Segoe UI", 11F);
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(275, 134);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(366, 38);
            comboBox2.TabIndex = 4;
            // 
            // comboBox3
            // 
            comboBox3.Font = new Font("Segoe UI", 11F);
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new Point(275, 200);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(366, 38);
            comboBox3.TabIndex = 5;
            // 
            // comboBox4
            // 
            comboBox4.Font = new Font("Segoe UI", 11F);
            comboBox4.FormattingEnabled = true;
            comboBox4.Location = new Point(275, 262);
            comboBox4.Name = "comboBox4";
            comboBox4.Size = new Size(366, 38);
            comboBox4.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11F);
            label4.Location = new Point(86, 265);
            label4.Name = "label4";
            label4.Size = new Size(172, 30);
            label4.TabIndex = 6;
            label4.Text = "Class Schedule : ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11F);
            label5.Location = new Point(27, 357);
            label5.Name = "label5";
            label5.Size = new Size(79, 30);
            label5.TabIndex = 8;
            label5.Text = "< Back";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 11F);
            button1.Location = new Point(359, 321);
            button1.Name = "button1";
            button1.Size = new Size(189, 41);
            button1.TabIndex = 9;
            button1.Text = "Assign to Class";
            button1.UseVisualStyleBackColor = true;
            // 
            // lec_assignStudent
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(746, 403);
            Controls.Add(button1);
            Controls.Add(label5);
            Controls.Add(comboBox4);
            Controls.Add(label4);
            Controls.Add(comboBox3);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "lec_assignStudent";
            Text = "assignStudent";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private ComboBox comboBox3;
        private ComboBox comboBox4;
        private Label label4;
        private Label label5;
        private Button button1;
    }
}