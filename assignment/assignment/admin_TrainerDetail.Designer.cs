namespace assignment
{
    partial class admin_trainerDetail
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
            btnNew = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            lblName = new Label();
            lblEmail = new Label();
            lblContact = new Label();
            label7 = new Label();
            lblAddress = new Label();
            dataClass = new DataGridView();
            name = new DataGridViewTextBoxColumn();
            level = new DataGridViewTextBoxColumn();
            label9 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataClass).BeginInit();
            SuspendLayout();
            // 
            // btnNew
            // 
            btnNew.Font = new Font("Segoe UI", 11F);
            btnNew.Location = new Point(212, 386);
            btnNew.Margin = new Padding(2, 2, 2, 2);
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(185, 35);
            btnNew.TabIndex = 0;
            btnNew.Text = "Assign New Module";
            btnNew.UseVisualStyleBackColor = true;
            btnNew.Click += btnNew_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F);
            label1.Location = new Point(62, 38);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(71, 25);
            label1.TabIndex = 1;
            label1.Text = "Name :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F);
            label2.Location = new Point(62, 90);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(67, 25);
            label2.TabIndex = 2;
            label2.Text = "Email :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11F);
            label3.Location = new Point(62, 137);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(160, 25);
            label3.TabIndex = 3;
            label3.Text = "Contact Number :";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.BorderStyle = BorderStyle.FixedSingle;
            lblName.Font = new Font("Segoe UI", 11F);
            lblName.Location = new Point(230, 38);
            lblName.Margin = new Padding(2, 0, 2, 0);
            lblName.Name = "lblName";
            lblName.Size = new Size(2, 27);
            lblName.TabIndex = 4;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.BorderStyle = BorderStyle.FixedSingle;
            lblEmail.Font = new Font("Segoe UI", 11F);
            lblEmail.Location = new Point(230, 90);
            lblEmail.Margin = new Padding(2, 0, 2, 0);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(2, 27);
            lblEmail.TabIndex = 5;
            // 
            // lblContact
            // 
            lblContact.AutoSize = true;
            lblContact.BorderStyle = BorderStyle.FixedSingle;
            lblContact.Font = new Font("Segoe UI", 11F);
            lblContact.Location = new Point(230, 137);
            lblContact.Margin = new Padding(2, 0, 2, 0);
            lblContact.Name = "lblContact";
            lblContact.Size = new Size(2, 27);
            lblContact.TabIndex = 6;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 11F);
            label7.Location = new Point(62, 186);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(88, 25);
            label7.TabIndex = 7;
            label7.Text = "Address :";
            // 
            // lblAddress
            // 
            lblAddress.AutoSize = true;
            lblAddress.BorderStyle = BorderStyle.FixedSingle;
            lblAddress.Font = new Font("Segoe UI", 11F);
            lblAddress.Location = new Point(230, 186);
            lblAddress.Margin = new Padding(2, 0, 2, 0);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(2, 27);
            lblAddress.TabIndex = 8;
            // 
            // dataClass
            // 
            dataClass.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataClass.Columns.AddRange(new DataGridViewColumn[] { name, level });
            dataClass.Location = new Point(88, 230);
            dataClass.Margin = new Padding(2, 2, 2, 2);
            dataClass.Name = "dataClass";
            dataClass.RowHeadersWidth = 62;
            dataClass.Size = new Size(451, 137);
            dataClass.TabIndex = 9;
            // 
            // name
            // 
            name.HeaderText = "Module Name";
            name.MinimumWidth = 8;
            name.Name = "name";
            name.Width = 250;
            // 
            // level
            // 
            level.HeaderText = "Class Level";
            level.MinimumWidth = 8;
            level.Name = "level";
            level.Width = 250;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 11F);
            label9.Location = new Point(25, 423);
            label9.Margin = new Padding(2, 0, 2, 0);
            label9.Name = "label9";
            label9.Size = new Size(69, 25);
            label9.TabIndex = 10;
            label9.Text = "< Back";
            // 
            // admin_trainerDetail
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(622, 462);
            Controls.Add(label9);
            Controls.Add(dataClass);
            Controls.Add(lblAddress);
            Controls.Add(label7);
            Controls.Add(lblContact);
            Controls.Add(lblEmail);
            Controls.Add(lblName);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnNew);
            Margin = new Padding(2, 2, 2, 2);
            Name = "admin_trainerDetail";
            Text = "trainerDetail";
            ((System.ComponentModel.ISupportInitialize)dataClass).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnNew;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label lblName;
        private Label lblEmail;
        private Label lblContact;
        private Label label7;
        private Label lblAddress;
        private DataGridView dataClass;
        private DataGridViewTextBoxColumn name;
        private DataGridViewTextBoxColumn level;
        private Label label9;
    }
}