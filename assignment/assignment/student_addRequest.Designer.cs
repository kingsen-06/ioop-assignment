namespace assignment
{
    partial class student_addRequest
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
            cmbLec = new ComboBox();
            cmbName = new ComboBox();
            cmbLevel = new ComboBox();
            btnSend = new Button();
            lblBack = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F);
            label1.Location = new Point(64, 50);
            label1.Name = "label1";
            label1.Size = new Size(138, 30);
            label1.TabIndex = 0;
            label1.Text = "To Lecturer : ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F);
            label2.Location = new Point(64, 116);
            label2.Name = "label2";
            label2.Size = new Size(169, 30);
            label2.TabIndex = 1;
            label2.Text = "Module Name : ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11F);
            label3.Location = new Point(64, 183);
            label3.Name = "label3";
            label3.Size = new Size(134, 30);
            label3.TabIndex = 2;
            label3.Text = "Class Level : ";
            // 
            // cmbLec
            // 
            cmbLec.Font = new Font("Segoe UI", 11F);
            cmbLec.FormattingEnabled = true;
            cmbLec.Location = new Point(255, 47);
            cmbLec.Name = "cmbLec";
            cmbLec.Size = new Size(354, 38);
            cmbLec.TabIndex = 3;
            // 
            // cmbName
            // 
            cmbName.Font = new Font("Segoe UI", 11F);
            cmbName.FormattingEnabled = true;
            cmbName.Location = new Point(255, 113);
            cmbName.Name = "cmbName";
            cmbName.Size = new Size(354, 38);
            cmbName.TabIndex = 4;
            // 
            // cmbLevel
            // 
            cmbLevel.Font = new Font("Segoe UI", 11F);
            cmbLevel.FormattingEnabled = true;
            cmbLevel.Location = new Point(255, 180);
            cmbLevel.Name = "cmbLevel";
            cmbLevel.Size = new Size(354, 38);
            cmbLevel.TabIndex = 5;
            // 
            // btnSend
            // 
            btnSend.Font = new Font("Segoe UI", 11F);
            btnSend.Location = new Point(321, 255);
            btnSend.Name = "btnSend";
            btnSend.Size = new Size(212, 43);
            btnSend.TabIndex = 6;
            btnSend.Text = "Send Request";
            btnSend.UseVisualStyleBackColor = true;
            // 
            // lblBack
            // 
            lblBack.AutoSize = true;
            lblBack.Font = new Font("Segoe UI", 11F);
            lblBack.Location = new Point(21, 287);
            lblBack.Name = "lblBack";
            lblBack.Size = new Size(85, 30);
            lblBack.TabIndex = 7;
            lblBack.Text = "< Back ";
            lblBack.Click += lblBack_Click;
            // 
            // student_addRequest
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(687, 352);
            Controls.Add(lblBack);
            Controls.Add(btnSend);
            Controls.Add(cmbLevel);
            Controls.Add(cmbName);
            Controls.Add(cmbLec);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "student_addRequest";
            Text = "addRequest";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private ComboBox cmbLec;
        private ComboBox cmbName;
        private ComboBox cmbLevel;
        private Button btnSend;
        private Label lblBack;
    }
}