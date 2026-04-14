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
            label1.Location = new Point(87, 42);
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
            label2.Location = new Point(87, 87);
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
            label3.Location = new Point(87, 138);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(151, 25);
            label3.TabIndex = 2;
            label3.Text = "Class Schedule : ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11F);
            label4.Location = new Point(87, 188);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(127, 25);
            label4.TabIndex = 3;
            label4.Text = "Class Venue : ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11F);
            label5.Location = new Point(87, 238);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(103, 25);
            label5.TabIndex = 4;
            label5.Text = "Class Fee : ";
            // 
            // txtVenue
            // 
            txtVenue.BorderStyle = BorderStyle.FixedSingle;
            txtVenue.Font = new Font("Segoe UI", 11F);
            txtVenue.Location = new Point(239, 186);
            txtVenue.Margin = new Padding(2);
            txtVenue.Name = "txtVenue";
            txtVenue.Size = new Size(240, 32);
            txtVenue.TabIndex = 8;
            // 
            // lblBack
            // 
            lblBack.AutoSize = true;
            lblBack.Font = new Font("Segoe UI", 11F);
            lblBack.Location = new Point(11, 310);
            lblBack.Margin = new Padding(2, 0, 2, 0);
            lblBack.Name = "lblBack";
            lblBack.Size = new Size(74, 25);
            lblBack.TabIndex = 10;
            lblBack.Text = "< Back ";
            lblBack.Click += lblBack_Click;
            // 
            // btnSave
            // 
            btnSave.Font = new Font("Segoe UI", 11F);
            btnSave.Location = new Point(217, 288);
            btnSave.Margin = new Padding(2);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(138, 34);
            btnSave.TabIndex = 11;
            btnSave.Text = "Save Change";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // numFee
            // 
            numFee.Font = new Font("Segoe UI", 11F);
            numFee.Location = new Point(239, 237);
            numFee.Margin = new Padding(2);
            numFee.Name = "numFee";
            numFee.Size = new Size(240, 32);
            numFee.TabIndex = 14;
            // 
            // dateSchedule
            // 
            dateSchedule.Font = new Font("Segoe UI", 11F);
            dateSchedule.Location = new Point(239, 138);
            dateSchedule.Margin = new Padding(2);
            dateSchedule.Name = "dateSchedule";
            dateSchedule.Size = new Size(241, 32);
            dateSchedule.TabIndex = 15;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.BorderStyle = BorderStyle.Fixed3D;
            lblName.Font = new Font("Segoe UI", 11F);
            lblName.Location = new Point(239, 42);
            lblName.Margin = new Padding(2, 0, 2, 0);
            lblName.Name = "lblName";
            lblName.Size = new Size(2, 27);
            lblName.TabIndex = 16;
            // 
            // lblLevel
            // 
            lblLevel.AutoSize = true;
            lblLevel.BorderStyle = BorderStyle.Fixed3D;
            lblLevel.Font = new Font("Segoe UI", 11F);
            lblLevel.Location = new Point(239, 87);
            lblLevel.Margin = new Padding(2, 0, 2, 0);
            lblLevel.Name = "lblLevel";
            lblLevel.Size = new Size(2, 27);
            lblLevel.TabIndex = 17;
            // 
            // trainer_editClass
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(582, 346);
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
            Margin = new Padding(2);
            Name = "trainer_editClass";
            Text = "editClassDetail";
            FormClosed += trainer_editClass_FormClosed;
            Load += trainer_editClass_Load;
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