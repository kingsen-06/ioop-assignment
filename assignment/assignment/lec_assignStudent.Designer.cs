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
            cmbLevel = new ComboBox();
            cmbTrainer = new ComboBox();
            cmbSchedule = new ComboBox();
            label4 = new Label();
            label5 = new Label();
            btnAssign = new Button();
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
            // cmbModule
            // 
            cmbModule.Font = new Font("Segoe UI", 11F);
            cmbModule.FormattingEnabled = true;
            cmbModule.Location = new Point(275, 71);
            cmbModule.Name = "cmbModule";
            cmbModule.Size = new Size(366, 38);
            cmbModule.TabIndex = 3;
            // 
            // cmbLevel
            // 
            cmbLevel.Font = new Font("Segoe UI", 11F);
            cmbLevel.FormattingEnabled = true;
            cmbLevel.Location = new Point(275, 134);
            cmbLevel.Name = "cmbLevel";
            cmbLevel.Size = new Size(366, 38);
            cmbLevel.TabIndex = 4;
            // 
            // cmbTrainer
            // 
            cmbTrainer.Font = new Font("Segoe UI", 11F);
            cmbTrainer.FormattingEnabled = true;
            cmbTrainer.Location = new Point(275, 200);
            cmbTrainer.Name = "cmbTrainer";
            cmbTrainer.Size = new Size(366, 38);
            cmbTrainer.TabIndex = 5;
            // 
            // cmbSchedule
            // 
            cmbSchedule.Font = new Font("Segoe UI", 11F);
            cmbSchedule.FormattingEnabled = true;
            cmbSchedule.Location = new Point(275, 262);
            cmbSchedule.Name = "cmbSchedule";
            cmbSchedule.Size = new Size(366, 38);
            cmbSchedule.TabIndex = 7;
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
            // btnAssign
            // 
            btnAssign.Font = new Font("Segoe UI", 11F);
            btnAssign.Location = new Point(359, 321);
            btnAssign.Name = "btnAssign";
            btnAssign.Size = new Size(189, 41);
            btnAssign.TabIndex = 9;
            btnAssign.Text = "Assign to Class";
            btnAssign.UseVisualStyleBackColor = true;
            // 
            // lec_assignStudent
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(746, 403);
            Controls.Add(btnAssign);
            Controls.Add(label5);
            Controls.Add(cmbSchedule);
            Controls.Add(label4);
            Controls.Add(cmbTrainer);
            Controls.Add(cmbLevel);
            Controls.Add(cmbModule);
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
        private ComboBox cmbModule;
        private ComboBox cmbLevel;
        private ComboBox cmbTrainer;
        private ComboBox cmbSchedule;
        private Label label4;
        private Label label5;
        private Button btnAssign;
    }
}