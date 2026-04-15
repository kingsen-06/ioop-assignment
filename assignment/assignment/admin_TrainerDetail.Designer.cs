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
            label3 = new Label();
            label4 = new Label();
            lblName = new Label();
            lblEmail = new Label();
            lblContact = new Label();
            label5 = new Label();
            lblAddress = new Label();
            dataClass = new DataGridView();
            name = new DataGridViewTextBoxColumn();
            level = new DataGridViewTextBoxColumn();
            lblBack = new Label();
            btnRemove = new Button();
            lblDOB = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataClass).BeginInit();
            SuspendLayout();
            // 
            // btnNew
            // 
            btnNew.Font = new Font("Segoe UI", 11F);
            btnNew.Location = new Point(122, 433);
            btnNew.Margin = new Padding(2);
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
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11F);
            label3.Location = new Point(62, 137);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(67, 25);
            label3.TabIndex = 2;
            label3.Text = "Email :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11F);
            label4.Location = new Point(62, 184);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(160, 25);
            label4.TabIndex = 3;
            label4.Text = "Contact Number :";
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
            lblEmail.Location = new Point(230, 137);
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
            lblContact.Location = new Point(230, 184);
            lblContact.Margin = new Padding(2, 0, 2, 0);
            lblContact.Name = "lblContact";
            lblContact.Size = new Size(2, 27);
            lblContact.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11F);
            label5.Location = new Point(62, 233);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(88, 25);
            label5.TabIndex = 7;
            label5.Text = "Address :";
            // 
            // lblAddress
            // 
            lblAddress.AutoSize = true;
            lblAddress.BorderStyle = BorderStyle.FixedSingle;
            lblAddress.Font = new Font("Segoe UI", 11F);
            lblAddress.Location = new Point(230, 233);
            lblAddress.Margin = new Padding(2, 0, 2, 0);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(2, 27);
            lblAddress.TabIndex = 8;
            // 
            // dataClass
            // 
            dataClass.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataClass.Columns.AddRange(new DataGridViewColumn[] { name, level });
            dataClass.Location = new Point(88, 277);
            dataClass.Margin = new Padding(2);
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
            // lblBack
            // 
            lblBack.AutoSize = true;
            lblBack.Font = new Font("Segoe UI", 11F);
            lblBack.Location = new Point(25, 470);
            lblBack.Margin = new Padding(2, 0, 2, 0);
            lblBack.Name = "lblBack";
            lblBack.Size = new Size(69, 25);
            lblBack.TabIndex = 10;
            lblBack.Text = "< Back";
            lblBack.Click += lblBack_Click;
            // 
            // btnRemove
            // 
            btnRemove.Font = new Font("Segoe UI", 11F);
            btnRemove.ForeColor = Color.Red;
            btnRemove.Location = new Point(325, 433);
            btnRemove.Margin = new Padding(2);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(185, 35);
            btnRemove.TabIndex = 11;
            btnRemove.Text = "Remove Module";
            btnRemove.UseVisualStyleBackColor = true;
            btnRemove.Click += btnRemove_Click;
            // 
            // lblDOB
            // 
            lblDOB.AutoSize = true;
            lblDOB.BorderStyle = BorderStyle.FixedSingle;
            lblDOB.Font = new Font("Segoe UI", 11F);
            lblDOB.Location = new Point(230, 86);
            lblDOB.Margin = new Padding(2, 0, 2, 0);
            lblDOB.Name = "lblDOB";
            lblDOB.Size = new Size(2, 27);
            lblDOB.TabIndex = 18;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F);
            label2.Location = new Point(62, 86);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(132, 25);
            label2.TabIndex = 17;
            label2.Text = "Date of Birth : ";
            // 
            // admin_trainerDetail
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(622, 536);
            Controls.Add(lblDOB);
            Controls.Add(label2);
            Controls.Add(btnRemove);
            Controls.Add(lblBack);
            Controls.Add(dataClass);
            Controls.Add(lblAddress);
            Controls.Add(label5);
            Controls.Add(lblContact);
            Controls.Add(lblEmail);
            Controls.Add(lblName);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(btnNew);
            Margin = new Padding(2);
            Name = "admin_trainerDetail";
            Text = "trainerDetail";
            FormClosed += admin_trainerDetail_FormClosed;
            Load += admin_trainerDetail_Load;
            ((System.ComponentModel.ISupportInitialize)dataClass).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnNew;
        private Label label1;
        private Label label3;
        private Label label4;
        private Label lblName;
        private Label lblEmail;
        private Label lblContact;
        private Label label5;
        private Label lblAddress;
        private DataGridView dataClass;
        private DataGridViewTextBoxColumn name;
        private DataGridViewTextBoxColumn level;
        private Label lblBack;
        private Button btnRemove;
        private Label lblDOB;
        private Label label2;
    }
}