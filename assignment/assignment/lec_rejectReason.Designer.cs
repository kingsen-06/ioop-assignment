namespace assignment
{
    partial class lec_rejectReason
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
            txtReason = new RichTextBox();
            lblBack = new Label();
            btnSubmit = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F);
            label1.Location = new Point(40, 30);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(138, 25);
            label1.TabIndex = 0;
            label1.Text = "Reject reason : ";
            // 
            // txtReason
            // 
            txtReason.Font = new Font("Segoe UI", 11F);
            txtReason.Location = new Point(40, 61);
            txtReason.Margin = new Padding(2);
            txtReason.Name = "txtReason";
            txtReason.Size = new Size(380, 188);
            txtReason.TabIndex = 1;
            txtReason.Text = "";
            // 
            // lblBack
            // 
            lblBack.AutoSize = true;
            lblBack.Font = new Font("Segoe UI", 11F);
            lblBack.Location = new Point(21, 274);
            lblBack.Margin = new Padding(2, 0, 2, 0);
            lblBack.Name = "lblBack";
            lblBack.Size = new Size(69, 25);
            lblBack.TabIndex = 2;
            lblBack.Text = "< Back";
            lblBack.Click += lblBack_Click;
            // 
            // btnSubmit
            // 
            btnSubmit.Font = new Font("Segoe UI", 11F);
            btnSubmit.Location = new Point(347, 271);
            btnSubmit.Margin = new Padding(2);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(90, 30);
            btnSubmit.TabIndex = 12;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // lec_rejectReason
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(463, 314);
            Controls.Add(btnSubmit);
            Controls.Add(lblBack);
            Controls.Add(txtReason);
            Controls.Add(label1);
            Margin = new Padding(2);
            Name = "lec_rejectReason";
            Text = "rejectReason";
            FormClosed += lec_rejectReason_FormClosed;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private RichTextBox txtReason;
        private Label lblBack;
        private Button btnSubmit;
    }
}