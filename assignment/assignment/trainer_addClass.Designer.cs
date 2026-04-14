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
            dateSchedule = new DateTimePicker();
            txtVenue = new TextBox();
            label6 = new Label();
            lblBack = new Label();
            btnAdd = new Button();
            numFee = new NumericUpDown();
            lblLevel = new Label();
            ((System.ComponentModel.ISupportInitialize)numFee).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F);
            label1.Location = new Point(67, 77);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(141, 25);
            label1.TabIndex = 0;
            label1.Text = "Module Name: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F);
            label2.Location = new Point(67, 120);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(112, 25);
            label2.TabIndex = 1;
            label2.Text = "Class Level: ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11F);
            label3.Location = new Point(67, 164);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(146, 25);
            label3.TabIndex = 2;
            label3.Text = "Class Schedule: ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11F);
            label4.Location = new Point(67, 204);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(122, 25);
            label4.TabIndex = 3;
            label4.Text = "Class Venue: ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11F);
            label5.Location = new Point(67, 248);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(98, 25);
            label5.TabIndex = 4;
            label5.Text = "Class Fee: ";
            // 
            // cmbName
            // 
            cmbName.Font = new Font("Segoe UI", 11F);
            cmbName.FormattingEnabled = true;
            cmbName.Location = new Point(218, 74);
            cmbName.Margin = new Padding(2);
            cmbName.Name = "cmbName";
            cmbName.Size = new Size(260, 33);
            cmbName.TabIndex = 5;
            cmbName.SelectedIndexChanged += cmbName_SelectedIndexChanged;
            // 
            // dateSchedule
            // 
            dateSchedule.Font = new Font("Segoe UI", 11F);
            dateSchedule.Location = new Point(218, 160);
            dateSchedule.Margin = new Padding(2);
            dateSchedule.Name = "dateSchedule";
            dateSchedule.Size = new Size(260, 32);
            dateSchedule.TabIndex = 7;
            // 
            // txtVenue
            // 
            txtVenue.BorderStyle = BorderStyle.FixedSingle;
            txtVenue.Font = new Font("Segoe UI", 11F);
            txtVenue.Location = new Point(218, 202);
            txtVenue.Margin = new Padding(2);
            txtVenue.Name = "txtVenue";
            txtVenue.Size = new Size(260, 32);
            txtVenue.TabIndex = 8;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 18F);
            label6.Location = new Point(116, 17);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(316, 41);
            label6.TabIndex = 10;
            label6.Text = "New Class Information";
            // 
            // lblBack
            // 
            lblBack.AutoSize = true;
            lblBack.Font = new Font("Segoe UI", 11F);
            lblBack.Location = new Point(21, 311);
            lblBack.Margin = new Padding(2, 0, 2, 0);
            lblBack.Name = "lblBack";
            lblBack.Size = new Size(74, 25);
            lblBack.TabIndex = 11;
            lblBack.Text = "< Back ";
            lblBack.Click += lblBack_Click;
            // 
            // btnAdd
            // 
            btnAdd.Font = new Font("Segoe UI", 11F);
            btnAdd.Location = new Point(281, 292);
            btnAdd.Margin = new Padding(2);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(137, 37);
            btnAdd.TabIndex = 12;
            btnAdd.Text = "Add New Class";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // numFee
            // 
            numFee.Font = new Font("Segoe UI", 11F);
            numFee.Location = new Point(218, 246);
            numFee.Margin = new Padding(2);
            numFee.Name = "numFee";
            numFee.Size = new Size(259, 32);
            numFee.TabIndex = 13;
            // 
            // lblLevel
            // 
            lblLevel.AutoSize = true;
            lblLevel.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblLevel.Location = new Point(218, 120);
            lblLevel.Name = "lblLevel";
            lblLevel.Size = new Size(0, 25);
            lblLevel.TabIndex = 14;
            // 
            // trainer_addClass
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(550, 351);
            Controls.Add(lblLevel);
            Controls.Add(numFee);
            Controls.Add(btnAdd);
            Controls.Add(lblBack);
            Controls.Add(label6);
            Controls.Add(txtVenue);
            Controls.Add(dateSchedule);
            Controls.Add(cmbName);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(2);
            Name = "trainer_addClass";
            Text = "addClass";
            FormClosed += trainer_addClass_FormClosed;
            Load += trainer_addClass_Load;
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
        private DateTimePicker dateSchedule;
        private TextBox txtVenue;
        private Label label6;
        private Label lblBack;
        private Button btnAdd;
        private NumericUpDown numFee;
        private Label lblLevel;
    }
}