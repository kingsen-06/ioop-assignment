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
            cmbStatus = new ComboBox();
            cmbSchedule = new ComboBox();
            label2 = new Label();
            lblBack = new Label();
            btnEdit = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F);
            label1.Location = new Point(71, 51);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(145, 25);
            label1.TabIndex = 0;
            label1.Text = "Student Name : ";
            // 
            // lblStudent
            // 
            lblStudent.AutoSize = true;
            lblStudent.BorderStyle = BorderStyle.Fixed3D;
            lblStudent.Font = new Font("Segoe UI", 11F);
            lblStudent.Location = new Point(222, 51);
            lblStudent.Margin = new Padding(2, 0, 2, 0);
            lblStudent.Name = "lblStudent";
            lblStudent.Size = new Size(2, 27);
            lblStudent.TabIndex = 1;
            // 
            // lblModule
            // 
            lblModule.AutoSize = true;
            lblModule.BorderStyle = BorderStyle.Fixed3D;
            lblModule.Font = new Font("Segoe UI", 11F);
            lblModule.Location = new Point(222, 98);
            lblModule.Margin = new Padding(2, 0, 2, 0);
            lblModule.Name = "lblModule";
            lblModule.Size = new Size(2, 27);
            lblModule.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11F);
            label4.Location = new Point(71, 98);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(146, 25);
            label4.TabIndex = 2;
            label4.Text = "Module Name : ";
            // 
            // lblLevel
            // 
            lblLevel.AutoSize = true;
            lblLevel.BorderStyle = BorderStyle.Fixed3D;
            lblLevel.Font = new Font("Segoe UI", 11F);
            lblLevel.Location = new Point(222, 142);
            lblLevel.Margin = new Padding(2, 0, 2, 0);
            lblLevel.Name = "lblLevel";
            lblLevel.Size = new Size(2, 27);
            lblLevel.TabIndex = 5;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11F);
            label6.Location = new Point(71, 142);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(117, 25);
            label6.TabIndex = 4;
            label6.Text = "Class Level : ";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 11F);
            label8.Location = new Point(71, 186);
            label8.Margin = new Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new Size(151, 25);
            label8.TabIndex = 6;
            label8.Text = "Class Schedule : ";
            // 
            // cmbStatus
            // 
            cmbStatus.FormattingEnabled = true;
            cmbStatus.Location = new Point(222, 230);
            cmbStatus.Margin = new Padding(2);
            cmbStatus.Name = "cmbStatus";
            cmbStatus.Size = new Size(239, 28);
            cmbStatus.TabIndex = 7;
            // 
            // cmbSchedule
            // 
            cmbSchedule.FormattingEnabled = true;
            cmbSchedule.Location = new Point(222, 187);
            cmbSchedule.Margin = new Padding(2);
            cmbSchedule.Name = "cmbSchedule";
            cmbSchedule.Size = new Size(239, 28);
            cmbSchedule.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F);
            label2.Location = new Point(71, 230);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(76, 25);
            label2.TabIndex = 9;
            label2.Text = "Status : ";
            // 
            // lblBack
            // 
            lblBack.AutoSize = true;
            lblBack.Font = new Font("Segoe UI", 11F);
            lblBack.Location = new Point(22, 306);
            lblBack.Margin = new Padding(2, 0, 2, 0);
            lblBack.Name = "lblBack";
            lblBack.Size = new Size(69, 25);
            lblBack.TabIndex = 10;
            lblBack.Text = "< Back";
            lblBack.Click += lblBack_Click;
            // 
            // btnEdit
            // 
            btnEdit.Font = new Font("Segoe UI", 11F);
            btnEdit.Location = new Point(298, 274);
            btnEdit.Margin = new Padding(2);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(90, 30);
            btnEdit.TabIndex = 11;
            btnEdit.Text = "Edit Detail";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // lec_editClass
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(558, 360);
            Controls.Add(btnEdit);
            Controls.Add(lblBack);
            Controls.Add(label2);
            Controls.Add(cmbSchedule);
            Controls.Add(cmbStatus);
            Controls.Add(label8);
            Controls.Add(lblLevel);
            Controls.Add(label6);
            Controls.Add(lblModule);
            Controls.Add(label4);
            Controls.Add(lblStudent);
            Controls.Add(label1);
            Margin = new Padding(2);
            Name = "lec_editClass";
            Text = "editClass";
            FormClosed += lec_editClass_FormClosed;
            Load += lec_editClass_Load;
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
        private ComboBox cmbStatus;
        private ComboBox cmbSchedule;
        private Label label2;
        private Label lblBack;
        private Button btnEdit;
    }
}