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
            btnSend = new Button();
            lblBack = new Label();
            lblLevel = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F);
            label1.Location = new Point(51, 40);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(119, 25);
            label1.TabIndex = 0;
            label1.Text = "To Lecturer : ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F);
            label2.Location = new Point(51, 93);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(146, 25);
            label2.TabIndex = 1;
            label2.Text = "Module Name : ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11F);
            label3.Location = new Point(51, 146);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(117, 25);
            label3.TabIndex = 2;
            label3.Text = "Class Level : ";
            // 
            // cmbLec
            // 
            cmbLec.Font = new Font("Segoe UI", 11F);
            cmbLec.FormattingEnabled = true;
            cmbLec.Location = new Point(204, 38);
            cmbLec.Margin = new Padding(2);
            cmbLec.Name = "cmbLec";
            cmbLec.Size = new Size(284, 33);
            cmbLec.TabIndex = 3;
            // 
            // cmbName
            // 
            cmbName.Font = new Font("Segoe UI", 11F);
            cmbName.FormattingEnabled = true;
            cmbName.Location = new Point(204, 90);
            cmbName.Margin = new Padding(2);
            cmbName.Name = "cmbName";
            cmbName.Size = new Size(284, 33);
            cmbName.TabIndex = 4;
            cmbName.SelectedIndexChanged += cmbName_SelectedIndexChanged;
            // 
            // btnSend
            // 
            btnSend.Font = new Font("Segoe UI", 11F);
            btnSend.Location = new Point(257, 204);
            btnSend.Margin = new Padding(2);
            btnSend.Name = "btnSend";
            btnSend.Size = new Size(170, 34);
            btnSend.TabIndex = 6;
            btnSend.Text = "Send Request";
            btnSend.UseVisualStyleBackColor = true;
            btnSend.Click += btnSend_Click;
            // 
            // lblBack
            // 
            lblBack.AutoSize = true;
            lblBack.Font = new Font("Segoe UI", 11F);
            lblBack.Location = new Point(17, 230);
            lblBack.Margin = new Padding(2, 0, 2, 0);
            lblBack.Name = "lblBack";
            lblBack.Size = new Size(74, 25);
            lblBack.TabIndex = 7;
            lblBack.Text = "< Back ";
            lblBack.Click += lblBack_Click;
            // 
            // lblLevel
            // 
            lblLevel.AutoSize = true;
            lblLevel.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblLevel.Location = new Point(204, 146);
            lblLevel.Name = "lblLevel";
            lblLevel.Size = new Size(0, 25);
            lblLevel.TabIndex = 8;
            // 
            // student_addRequest
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(550, 282);
            Controls.Add(lblLevel);
            Controls.Add(lblBack);
            Controls.Add(btnSend);
            Controls.Add(cmbName);
            Controls.Add(cmbLec);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(2);
            Name = "student_addRequest";
            Text = "addRequest";
            FormClosed += student_addRequest_FormClosed;
            Load += student_addRequest_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private ComboBox cmbLec;
        private ComboBox cmbName;
        private Button btnSend;
        private Label lblBack;
        private Label lblLevel;
    }
}