namespace assignment
{
    partial class lec_editClass
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
            lblStudent = new Label();
            lblModule = new Label();
            label4 = new Label();
            lblLevel = new Label();
            label6 = new Label();
            label8 = new Label();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            label2 = new Label();
            label3 = new Label();
            btnEdit = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F);
            label1.Location = new Point(89, 64);
            label1.Name = "label1";
            label1.Size = new Size(168, 30);
            label1.TabIndex = 0;
            label1.Text = "Student Name : ";
            // 
            // lblStudent
            // 
            lblStudent.AutoSize = true;
            lblStudent.BorderStyle = BorderStyle.Fixed3D;
            lblStudent.Font = new Font("Segoe UI", 11F);
            lblStudent.Location = new Point(278, 64);
            lblStudent.Name = "lblStudent";
            lblStudent.Size = new Size(2, 32);
            lblStudent.TabIndex = 1;
            // 
            // lblModule
            // 
            lblModule.AutoSize = true;
            lblModule.BorderStyle = BorderStyle.Fixed3D;
            lblModule.Font = new Font("Segoe UI", 11F);
            lblModule.Location = new Point(278, 122);
            lblModule.Name = "lblModule";
            lblModule.Size = new Size(2, 32);
            lblModule.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11F);
            label4.Location = new Point(89, 122);
            label4.Name = "label4";
            label4.Size = new Size(169, 30);
            label4.TabIndex = 2;
            label4.Text = "Module Name : ";
            // 
            // lblLevel
            // 
            lblLevel.AutoSize = true;
            lblLevel.BorderStyle = BorderStyle.Fixed3D;
            lblLevel.Font = new Font("Segoe UI", 11F);
            lblLevel.Location = new Point(278, 178);
            lblLevel.Name = "lblLevel";
            lblLevel.Size = new Size(2, 32);
            lblLevel.TabIndex = 5;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11F);
            label6.Location = new Point(89, 178);
            label6.Name = "label6";
            label6.Size = new Size(134, 30);
            label6.TabIndex = 4;
            label6.Text = "Class Level : ";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 11F);
            label8.Location = new Point(89, 233);
            label8.Name = "label8";
            label8.Size = new Size(172, 30);
            label8.TabIndex = 6;
            label8.Text = "Class Schedule : ";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(278, 288);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(298, 33);
            comboBox1.TabIndex = 7;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(278, 234);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(298, 33);
            comboBox2.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F);
            label2.Location = new Point(89, 287);
            label2.Name = "label2";
            label2.Size = new Size(87, 30);
            label2.TabIndex = 9;
            label2.Text = "Status : ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11F);
            label3.Location = new Point(28, 383);
            label3.Name = "label3";
            label3.Size = new Size(79, 30);
            label3.TabIndex = 10;
            label3.Text = "< Back";
            // 
            // btnEdit
            // 
            btnEdit.Font = new Font("Segoe UI", 11F);
            btnEdit.Location = new Point(373, 342);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(112, 38);
            btnEdit.TabIndex = 11;
            btnEdit.Text = "Edit Detail";
            btnEdit.UseVisualStyleBackColor = true;
            // 
            // lec_editClass
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(698, 450);
            Controls.Add(btnEdit);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Controls.Add(label8);
            Controls.Add(lblLevel);
            Controls.Add(label6);
            Controls.Add(lblModule);
            Controls.Add(label4);
            Controls.Add(lblStudent);
            Controls.Add(label1);
            Name = "lec_editClass";
            Text = "editClass";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lblStudent;
        private Label lblModule;
        private Label label4;
        private Label lblLevel;
        private Label label6;
        private Label label8;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private Label label2;
        private Label label3;
        private Button btnEdit;
    }
}