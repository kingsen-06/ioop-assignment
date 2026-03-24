namespace assignment
{
    partial class trainer_menu
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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            label1 = new Label();
            lblBack = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 11F);
            button1.Location = new Point(160, 103);
            button1.Name = "button1";
            button1.Size = new Size(278, 41);
            button1.TabIndex = 0;
            button1.Text = "Update Class Information";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 11F);
            button2.Location = new Point(160, 174);
            button2.Name = "button2";
            button2.Size = new Size(278, 41);
            button2.TabIndex = 1;
            button2.Text = "View Student List";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 11F);
            button3.Location = new Point(160, 246);
            button3.Name = "button3";
            button3.Size = new Size(278, 41);
            button3.TabIndex = 2;
            button3.Text = "Send Feedback";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Font = new Font("Segoe UI", 11F);
            button4.Location = new Point(160, 320);
            button4.Name = "button4";
            button4.Size = new Size(278, 41);
            button4.TabIndex = 3;
            button4.Text = "Update Profile";
            button4.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F);
            label1.Location = new Point(75, 28);
            label1.Name = "label1";
            label1.Size = new Size(446, 48);
            label1.TabIndex = 4;
            label1.Text = "Trainer Functional Features";
            // 
            // lblBack
            // 
            lblBack.AutoSize = true;
            lblBack.Font = new Font("Segoe UI", 11F);
            lblBack.Location = new Point(12, 391);
            lblBack.Name = "lblBack";
            lblBack.Size = new Size(217, 30);
            lblBack.TabIndex = 5;
            lblBack.Text = "< Back to Login Page";
            // 
            // trainer_menu
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(607, 434);
            Controls.Add(lblBack);
            Controls.Add(label1);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "trainer_menu";
            Text = "trainerMenu";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Label label1;
        private Label lblBack;
    }
}