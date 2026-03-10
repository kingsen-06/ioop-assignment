namespace assignment
{
    partial class student_invoice
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
            label2 = new Label();
            lblID = new Label();
            lblDate = new Label();
            label6 = new Label();
            lblAmount = new Label();
            label8 = new Label();
            lblName = new Label();
            label10 = new Label();
            label1 = new Label();
            label3 = new Label();
            lblAddress1 = new Label();
            lblAddress2 = new Label();
            lblEmail = new Label();
            lblAddress3 = new Label();
            dataGridView1 = new DataGridView();
            description = new DataGridViewTextBoxColumn();
            price = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F);
            label2.Location = new Point(439, 80);
            label2.Name = "label2";
            label2.Size = new Size(125, 28);
            label2.TabIndex = 1;
            label2.Text = "Payment ID : ";
            // 
            // lblID
            // 
            lblID.AutoSize = true;
            lblID.BorderStyle = BorderStyle.Fixed3D;
            lblID.Font = new Font("Segoe UI", 10F);
            lblID.Location = new Point(439, 120);
            lblID.Name = "lblID";
            lblID.Size = new Size(2, 30);
            lblID.TabIndex = 2;
            // 
            // lblDate
            // 
            lblDate.AutoSize = true;
            lblDate.BorderStyle = BorderStyle.Fixed3D;
            lblDate.Font = new Font("Segoe UI", 10F);
            lblDate.Location = new Point(439, 239);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(2, 30);
            lblDate.TabIndex = 6;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10F);
            label6.Location = new Point(439, 199);
            label6.Name = "label6";
            label6.Size = new Size(170, 28);
            label6.TabIndex = 5;
            label6.Text = "Transaction Date : ";
            // 
            // lblAmount
            // 
            lblAmount.AutoSize = true;
            lblAmount.BorderStyle = BorderStyle.Fixed3D;
            lblAmount.Font = new Font("Segoe UI", 10F);
            lblAmount.Location = new Point(603, 531);
            lblAmount.Name = "lblAmount";
            lblAmount.Size = new Size(2, 30);
            lblAmount.TabIndex = 8;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 10F);
            label8.Location = new Point(516, 531);
            label8.Name = "label8";
            label8.Size = new Size(68, 28);
            label8.TabIndex = 7;
            label8.Text = "Total : ";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.BorderStyle = BorderStyle.Fixed3D;
            lblName.Font = new Font("Segoe UI", 10F);
            lblName.Location = new Point(142, 80);
            lblName.Name = "lblName";
            lblName.Size = new Size(2, 30);
            lblName.TabIndex = 10;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 10F);
            label10.Location = new Point(61, 80);
            label10.Name = "label10";
            label10.Size = new Size(75, 28);
            label10.TabIndex = 9;
            label10.Text = "Buyer : ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F);
            label1.Location = new Point(12, 576);
            label1.Name = "label1";
            label1.Size = new Size(79, 30);
            label1.TabIndex = 11;
            label1.Text = "< Back";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 18F);
            label3.Location = new Point(279, 23);
            label3.Name = "label3";
            label3.Size = new Size(133, 48);
            label3.TabIndex = 12;
            label3.Text = "Invoice";
            // 
            // lblAddress1
            // 
            lblAddress1.AutoSize = true;
            lblAddress1.BorderStyle = BorderStyle.Fixed3D;
            lblAddress1.Font = new Font("Segoe UI", 10F);
            lblAddress1.Location = new Point(142, 120);
            lblAddress1.Name = "lblAddress1";
            lblAddress1.Size = new Size(2, 30);
            lblAddress1.TabIndex = 13;
            // 
            // lblAddress2
            // 
            lblAddress2.AutoSize = true;
            lblAddress2.BorderStyle = BorderStyle.Fixed3D;
            lblAddress2.Font = new Font("Segoe UI", 10F);
            lblAddress2.Location = new Point(142, 160);
            lblAddress2.Name = "lblAddress2";
            lblAddress2.Size = new Size(2, 30);
            lblAddress2.TabIndex = 14;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.BorderStyle = BorderStyle.Fixed3D;
            lblEmail.Font = new Font("Segoe UI", 10F);
            lblEmail.Location = new Point(142, 239);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(2, 30);
            lblEmail.TabIndex = 16;
            // 
            // lblAddress3
            // 
            lblAddress3.AutoSize = true;
            lblAddress3.BorderStyle = BorderStyle.Fixed3D;
            lblAddress3.Font = new Font("Segoe UI", 10F);
            lblAddress3.Location = new Point(142, 199);
            lblAddress3.Name = "lblAddress3";
            lblAddress3.Size = new Size(2, 30);
            lblAddress3.TabIndex = 15;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { description, price });
            dataGridView1.Location = new Point(40, 300);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(692, 204);
            dataGridView1.TabIndex = 17;
            // 
            // description
            // 
            description.HeaderText = "Description";
            description.MinimumWidth = 8;
            description.Name = "description";
            description.Width = 500;
            // 
            // price
            // 
            price.HeaderText = "Price";
            price.MinimumWidth = 8;
            price.Name = "price";
            price.Width = 130;
            // 
            // student_invoice
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(773, 619);
            Controls.Add(dataGridView1);
            Controls.Add(lblEmail);
            Controls.Add(lblAddress3);
            Controls.Add(lblAddress2);
            Controls.Add(lblAddress1);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(lblName);
            Controls.Add(label10);
            Controls.Add(lblAmount);
            Controls.Add(label8);
            Controls.Add(lblDate);
            Controls.Add(label6);
            Controls.Add(lblID);
            Controls.Add(label2);
            Name = "student_invoice";
            Text = "invoice";
            Load += this.student_invoice_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Label lblID;
        private Label lblDate;
        private Label label6;
        private Label lblAmount;
        private Label label8;
        private Label lblName;
        private Label label10;
        private Label label1;
        private Label label3;
        private Label lblAddress1;
        private Label lblAddress2;
        private Label lblEmail;
        private Label lblAddress3;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn description;
        private DataGridViewTextBoxColumn price;
    }
}