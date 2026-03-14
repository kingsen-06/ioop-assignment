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
            lblTotal = new Label();
            label8 = new Label();
            lblName = new Label();
            label10 = new Label();
            lblBack = new Label();
            label3 = new Label();
            lblAddress1 = new Label();
            lblAddress2 = new Label();
            lblEmail = new Label();
            lblAddress3 = new Label();
            dataDetail = new DataGridView();
            description = new DataGridViewTextBoxColumn();
            price = new DataGridViewTextBoxColumn();
            label4 = new Label();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataDetail).BeginInit();
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
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.BorderStyle = BorderStyle.Fixed3D;
            lblTotal.Font = new Font("Segoe UI", 10F);
            lblTotal.Location = new Point(591, 531);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(2, 30);
            lblTotal.TabIndex = 8;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 10F);
            label8.Location = new Point(504, 531);
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
            lblName.Location = new Point(159, 80);
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
            label10.Size = new Size(94, 28);
            label10.TabIndex = 9;
            label10.Text = "Student : ";
            // 
            // lblBack
            // 
            lblBack.AutoSize = true;
            lblBack.Font = new Font("Segoe UI", 11F);
            lblBack.Location = new Point(12, 569);
            lblBack.Name = "lblBack";
            lblBack.Size = new Size(79, 30);
            lblBack.TabIndex = 11;
            lblBack.Text = "< Back";
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
            lblAddress1.Location = new Point(159, 120);
            lblAddress1.Name = "lblAddress1";
            lblAddress1.Size = new Size(2, 30);
            lblAddress1.TabIndex = 13;
            // 
            // lblAddress2
            // 
            lblAddress2.AutoSize = true;
            lblAddress2.BorderStyle = BorderStyle.Fixed3D;
            lblAddress2.Font = new Font("Segoe UI", 10F);
            lblAddress2.Location = new Point(159, 160);
            lblAddress2.Name = "lblAddress2";
            lblAddress2.Size = new Size(2, 30);
            lblAddress2.TabIndex = 14;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.BorderStyle = BorderStyle.Fixed3D;
            lblEmail.Font = new Font("Segoe UI", 10F);
            lblEmail.Location = new Point(159, 239);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(2, 30);
            lblEmail.TabIndex = 16;
            // 
            // lblAddress3
            // 
            lblAddress3.AutoSize = true;
            lblAddress3.BorderStyle = BorderStyle.Fixed3D;
            lblAddress3.Font = new Font("Segoe UI", 10F);
            lblAddress3.Location = new Point(159, 199);
            lblAddress3.Name = "lblAddress3";
            lblAddress3.Size = new Size(2, 30);
            lblAddress3.TabIndex = 15;
            // 
            // dataDetail
            // 
            dataDetail.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataDetail.Columns.AddRange(new DataGridViewColumn[] { description, price });
            dataDetail.Location = new Point(40, 300);
            dataDetail.Name = "dataDetail";
            dataDetail.RowHeadersWidth = 62;
            dataDetail.Size = new Size(692, 204);
            dataDetail.TabIndex = 17;
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
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F);
            label4.Location = new Point(61, 120);
            label4.Name = "label4";
            label4.Size = new Size(96, 28);
            label4.TabIndex = 18;
            label4.Text = "Address : ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10F);
            label5.Location = new Point(61, 239);
            label5.Name = "label5";
            label5.Size = new Size(73, 28);
            label5.TabIndex = 19;
            label5.Text = "Email : ";
            // 
            // student_invoice
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(773, 619);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(dataDetail);
            Controls.Add(lblEmail);
            Controls.Add(lblAddress3);
            Controls.Add(lblAddress2);
            Controls.Add(lblAddress1);
            Controls.Add(label3);
            Controls.Add(lblBack);
            Controls.Add(lblName);
            Controls.Add(label10);
            Controls.Add(lblTotal);
            Controls.Add(label8);
            Controls.Add(lblDate);
            Controls.Add(label6);
            Controls.Add(lblID);
            Controls.Add(label2);
            Name = "student_invoice";
            Text = "invoice";
            ((System.ComponentModel.ISupportInitialize)dataDetail).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Label lblID;
        private Label lblDate;
        private Label label6;
        private Label lblTotal;
        private Label label8;
        private Label lblName;
        private Label label10;
        private Label lblBack;
        private Label label3;
        private Label lblAddress1;
        private Label lblAddress2;
        private Label lblEmail;
        private Label lblAddress3;
        private DataGridView dataDetail;
        private DataGridViewTextBoxColumn description;
        private DataGridViewTextBoxColumn price;
        private Label label4;
        private Label label5;
    }
}