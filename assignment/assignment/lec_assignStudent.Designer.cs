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
            cmbModule = new ComboBox();
            cmbTrainer = new ComboBox();
            cmbSchedule = new ComboBox();
            label4 = new Label();
            lblBack = new Label();
            btnAssign = new Button();
            lblLevel = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F);
            label1.Location = new Point(69, 59);
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
            label2.Location = new Point(69, 110);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(117, 25);
            label2.TabIndex = 1;
            label2.Text = "Class Level : ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11F);
            label3.Location = new Point(69, 162);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(84, 25);
            label3.TabIndex = 2;
            label3.Text = "Trainer : ";
            // 
            // cmbModule
            // 
            cmbModule.Font = new Font("Segoe UI", 11F);
            cmbModule.FormattingEnabled = true;
            cmbModule.Location = new Point(220, 57);
            cmbModule.Margin = new Padding(2);
            cmbModule.Name = "cmbModule";
            cmbModule.Size = new Size(294, 33);
            cmbModule.TabIndex = 3;
            cmbModule.SelectedIndexChanged += cmbModule_SelectedIndexChanged;
            // 
            // cmbTrainer
            // 
            cmbTrainer.Font = new Font("Segoe UI", 11F);
            cmbTrainer.FormattingEnabled = true;
            cmbTrainer.Location = new Point(220, 160);
            cmbTrainer.Margin = new Padding(2);
            cmbTrainer.Name = "cmbTrainer";
            cmbTrainer.Size = new Size(294, 33);
            cmbTrainer.TabIndex = 5;
            cmbTrainer.SelectedIndexChanged += cmbTrainer_SelectedIndexChanged;
            // 
            // cmbSchedule
            // 
            cmbSchedule.Font = new Font("Segoe UI", 11F);
            cmbSchedule.FormattingEnabled = true;
            cmbSchedule.Location = new Point(220, 210);
            cmbSchedule.Margin = new Padding(2);
            cmbSchedule.Name = "cmbSchedule";
            cmbSchedule.Size = new Size(294, 33);
            cmbSchedule.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11F);
            label4.Location = new Point(69, 212);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(151, 25);
            label4.TabIndex = 6;
            label4.Text = "Class Schedule : ";
            // 
            // lblBack
            // 
            lblBack.AutoSize = true;
            lblBack.Font = new Font("Segoe UI", 11F);
            lblBack.Location = new Point(22, 286);
            lblBack.Margin = new Padding(2, 0, 2, 0);
            lblBack.Name = "lblBack";
            lblBack.Size = new Size(69, 25);
            lblBack.TabIndex = 8;
            lblBack.Text = "< Back";
            lblBack.Click += lblBack_Click;
            // 
            // btnAssign
            // 
            btnAssign.Font = new Font("Segoe UI", 11F);
            btnAssign.Location = new Point(287, 257);
            btnAssign.Margin = new Padding(2);
            btnAssign.Name = "btnAssign";
            btnAssign.Size = new Size(151, 33);
            btnAssign.TabIndex = 9;
            btnAssign.Text = "Assign to Class";
            btnAssign.UseVisualStyleBackColor = true;
            btnAssign.Click += btnAssign_Click;
            // 
            // lblLevel
            // 
            lblLevel.AutoSize = true;
            lblLevel.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblLevel.Location = new Point(220, 110);
            lblLevel.Name = "lblLevel";
            lblLevel.Size = new Size(0, 25);
            lblLevel.TabIndex = 10;
            // 
            // lec_assignStudent
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(597, 322);
            Controls.Add(lblLevel);
            Controls.Add(btnAssign);
            Controls.Add(lblBack);
            Controls.Add(cmbSchedule);
            Controls.Add(label4);
            Controls.Add(cmbTrainer);
            Controls.Add(cmbModule);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(2);
            Name = "lec_assignStudent";
            Text = "assignStudent";
            FormClosed += lec_assignStudent_FormClosed;
            Load += lec_assignStudent_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private ComboBox cmbModule;
        private ComboBox cmbTrainer;
        private ComboBox cmbSchedule;
        private Label label4;
        private Label lblBack;
        private Button btnAssign;
        private Label lblLevel;
    }
}