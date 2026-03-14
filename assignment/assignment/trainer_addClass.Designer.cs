namespace assignment
{
    partial class trainer_addClass
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
            label4 = new Label();
            label5 = new Label();
            cmbName = new ComboBox();
            cmbLevel = new ComboBox();
            dateSchedule = new DateTimePicker();
            txtVenue = new TextBox();
            label6 = new Label();
            lblBack = new Label();
            btnAdd = new Button();
            numFee = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)numFee).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F);
            label1.Location = new Point(84, 96);
            label1.Name = "label1";
            label1.Size = new Size(163, 30);
            label1.TabIndex = 0;
            label1.Text = "Module Name: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F);
            label2.Location = new Point(84, 150);
            label2.Name = "label2";
            label2.Size = new Size(128, 30);
            label2.TabIndex = 1;
            label2.Text = "Class Level: ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11F);
            label3.Location = new Point(84, 205);
            label3.Name = "label3";
            label3.Size = new Size(166, 30);
            label3.TabIndex = 2;
            label3.Text = "Class Schedule: ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11F);
            label4.Location = new Point(84, 255);
            label4.Name = "label4";
            label4.Size = new Size(139, 30);
            label4.TabIndex = 3;
            label4.Text = "Class Venue: ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11F);
            label5.Location = new Point(84, 310);
            label5.Name = "label5";
            label5.Size = new Size(113, 30);
            label5.TabIndex = 4;
            label5.Text = "Class Fee: ";
            // 
            // cmbName
            // 
            cmbName.Font = new Font("Segoe UI", 11F);
            cmbName.FormattingEnabled = true;
            cmbName.Location = new Point(273, 93);
            cmbName.Name = "cmbName";
            cmbName.Size = new Size(324, 38);
            cmbName.TabIndex = 5;
            // 
            // cmbLevel
            // 
            cmbLevel.Font = new Font("Segoe UI", 11F);
            cmbLevel.FormattingEnabled = true;
            cmbLevel.Items.AddRange(new object[] { "Beginner", "Intermediate", "Advance" });
            cmbLevel.Location = new Point(273, 147);
            cmbLevel.Name = "cmbLevel";
            cmbLevel.Size = new Size(324, 38);
            cmbLevel.TabIndex = 6;
            // 
            // dateSchedule
            // 
            dateSchedule.Font = new Font("Segoe UI", 11F);
            dateSchedule.Location = new Point(273, 200);
            dateSchedule.Name = "dateSchedule";
            dateSchedule.Size = new Size(324, 37);
            dateSchedule.TabIndex = 7;
            // 
            // txtVenue
            // 
            txtVenue.BorderStyle = BorderStyle.FixedSingle;
            txtVenue.Font = new Font("Segoe UI", 11F);
            txtVenue.Location = new Point(273, 252);
            txtVenue.Name = "txtVenue";
            txtVenue.Size = new Size(324, 37);
            txtVenue.TabIndex = 8;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 18F);
            label6.Location = new Point(145, 21);
            label6.Name = "label6";
            label6.Size = new Size(377, 48);
            label6.TabIndex = 10;
            label6.Text = "New Class Information";
            // 
            // lblBack
            // 
            lblBack.AutoSize = true;
            lblBack.Font = new Font("Segoe UI", 11F);
            lblBack.Location = new Point(26, 389);
            lblBack.Name = "lblBack";
            lblBack.Size = new Size(85, 30);
            lblBack.TabIndex = 11;
            lblBack.Text = "< Back ";
            // 
            // btnAdd
            // 
            btnAdd.Font = new Font("Segoe UI", 11F);
            btnAdd.Location = new Point(351, 365);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(171, 46);
            btnAdd.TabIndex = 12;
            btnAdd.Text = "Add New Class";
            btnAdd.UseVisualStyleBackColor = true;
            // 
            // numFee
            // 
            numFee.Font = new Font("Segoe UI", 11F);
            numFee.Location = new Point(273, 308);
            numFee.Name = "numFee";
            numFee.Size = new Size(324, 37);
            numFee.TabIndex = 13;
            // 
            // trainer_addClass
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(688, 439);
            Controls.Add(numFee);
            Controls.Add(btnAdd);
            Controls.Add(lblBack);
            Controls.Add(label6);
            Controls.Add(txtVenue);
            Controls.Add(dateSchedule);
            Controls.Add(cmbLevel);
            Controls.Add(cmbName);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "trainer_addClass";
            Text = "addClass";
            ((System.ComponentModel.ISupportInitialize)numFee).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private ComboBox cmbName;
        private ComboBox cmbLevel;
        private DateTimePicker dateSchedule;
        private TextBox txtVenue;
        private Label label6;
        private Label lblBack;
        private Button btnAdd;
        private NumericUpDown numFee;
    }
}