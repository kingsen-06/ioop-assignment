namespace assignment
{
    partial class trainer_editClass
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
            txtVenue = new TextBox();
            lblBack = new Label();
            btnSave = new Button();
            numFee = new NumericUpDown();
            dateSchedule = new DateTimePicker();
            lblName = new Label();
            lblLevel = new Label();
            ((System.ComponentModel.ISupportInitialize)numFee).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F);
            label1.Location = new Point(109, 52);
            label1.Name = "label1";
            label1.Size = new Size(169, 30);
            label1.TabIndex = 0;
            label1.Text = "Module Name : ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F);
            label2.Location = new Point(109, 109);
            label2.Name = "label2";
            label2.Size = new Size(134, 30);
            label2.TabIndex = 1;
            label2.Text = "Class Level : ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11F);
            label3.Location = new Point(109, 173);
            label3.Name = "label3";
            label3.Size = new Size(172, 30);
            label3.TabIndex = 2;
            label3.Text = "Class Schedule : ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11F);
            label4.Location = new Point(109, 235);
            label4.Name = "label4";
            label4.Size = new Size(145, 30);
            label4.TabIndex = 3;
            label4.Text = "Class Venue : ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11F);
            label5.Location = new Point(109, 298);
            label5.Name = "label5";
            label5.Size = new Size(119, 30);
            label5.TabIndex = 4;
            label5.Text = "Class Fee : ";
            // 
            // txtVenue
            // 
            txtVenue.BorderStyle = BorderStyle.FixedSingle;
            txtVenue.Font = new Font("Segoe UI", 11F);
            txtVenue.Location = new Point(299, 232);
            txtVenue.Name = "txtVenue";
            txtVenue.Size = new Size(300, 37);
            txtVenue.TabIndex = 8;
            // 
            // lblBack
            // 
            lblBack.AutoSize = true;
            lblBack.Font = new Font("Segoe UI", 11F);
            lblBack.Location = new Point(14, 387);
            lblBack.Name = "lblBack";
            lblBack.Size = new Size(85, 30);
            lblBack.TabIndex = 10;
            lblBack.Text = "< Back ";
            // 
            // btnSave
            // 
            btnSave.Font = new Font("Segoe UI", 11F);
            btnSave.Location = new Point(271, 360);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(172, 43);
            btnSave.TabIndex = 11;
            btnSave.Text = "Save Change";
            btnSave.UseVisualStyleBackColor = true;
            // 
            // numFee
            // 
            numFee.Font = new Font("Segoe UI", 11F);
            numFee.Location = new Point(299, 296);
            numFee.Name = "numFee";
            numFee.Size = new Size(300, 37);
            numFee.TabIndex = 14;
            // 
            // dateSchedule
            // 
            dateSchedule.Font = new Font("Segoe UI", 11F);
            dateSchedule.Location = new Point(299, 172);
            dateSchedule.Name = "dateSchedule";
            dateSchedule.Size = new Size(300, 37);
            dateSchedule.TabIndex = 15;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.BorderStyle = BorderStyle.Fixed3D;
            lblName.Font = new Font("Segoe UI", 11F);
            lblName.Location = new Point(299, 52);
            lblName.Name = "lblName";
            lblName.Size = new Size(2, 32);
            lblName.TabIndex = 16;
            // 
            // lblLevel
            // 
            lblLevel.AutoSize = true;
            lblLevel.BorderStyle = BorderStyle.Fixed3D;
            lblLevel.Font = new Font("Segoe UI", 11F);
            lblLevel.Location = new Point(299, 109);
            lblLevel.Name = "lblLevel";
            lblLevel.Size = new Size(2, 32);
            lblLevel.TabIndex = 17;
            // 
            // trainer_editClass
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(728, 432);
            Controls.Add(lblLevel);
            Controls.Add(lblName);
            Controls.Add(dateSchedule);
            Controls.Add(numFee);
            Controls.Add(btnSave);
            Controls.Add(lblBack);
            Controls.Add(txtVenue);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "trainer_editClass";
            Text = "editClassDetail";
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
        private TextBox txtVenue;
        private Label lblBack;
        private Button btnSave;
        private NumericUpDown numFee;
        private DateTimePicker dateSchedule;
        private Label lblName;
        private Label lblLevel;
    }
}