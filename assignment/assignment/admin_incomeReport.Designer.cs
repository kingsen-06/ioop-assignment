namespace assignment
{
    partial class admin_incomeReport
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
            dataReport = new DataGridView();
            earn = new DataGridViewTextBoxColumn();
            rmEarn = new DataGridViewTextBoxColumn();
            deduct = new DataGridViewTextBoxColumn();
            rmDeduct = new DataGridViewTextBoxColumn();
            lblTotal = new Label();
            lblTotal2 = new Label();
            lblTotalEarn = new Label();
            lblTotalDeduct = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            lblAddress1 = new Label();
            lblAddress2 = new Label();
            lblAddress3 = new Label();
            lblName = new Label();
            lblDate = new Label();
            lblPeriod = new Label();
            lblJob = new Label();
            label16 = new Label();
            lblNet = new Label();
            lblBack = new Label();
            ((System.ComponentModel.ISupportInitialize)dataReport).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F);
            label1.Location = new Point(106, 98);
            label1.Name = "label1";
            label1.Size = new Size(88, 30);
            label1.TabIndex = 0;
            label1.Text = "Name : ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F);
            label2.Location = new Point(528, 98);
            label2.Name = "label2";
            label2.Size = new Size(111, 30);
            label2.TabIndex = 1;
            label2.Text = "Job Title : ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11F);
            label3.Location = new Point(106, 144);
            label3.Name = "label3";
            label3.Size = new Size(102, 30);
            label3.TabIndex = 2;
            label3.Text = "Address :";
            // 
            // dataReport
            // 
            dataReport.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataReport.Columns.AddRange(new DataGridViewColumn[] { earn, rmEarn, deduct, rmDeduct });
            dataReport.Location = new Point(53, 292);
            dataReport.Name = "dataReport";
            dataReport.RowHeadersWidth = 62;
            dataReport.Size = new Size(864, 235);
            dataReport.TabIndex = 3;
            // 
            // earn
            // 
            earn.HeaderText = "Earnings";
            earn.MinimumWidth = 8;
            earn.Name = "earn";
            earn.Width = 300;
            // 
            // rmEarn
            // 
            rmEarn.HeaderText = "RM";
            rmEarn.MinimumWidth = 8;
            rmEarn.Name = "rmEarn";
            rmEarn.Width = 150;
            // 
            // deduct
            // 
            deduct.HeaderText = "Deductions";
            deduct.MinimumWidth = 8;
            deduct.Name = "deduct";
            deduct.Width = 300;
            // 
            // rmDeduct
            // 
            rmDeduct.HeaderText = "RM";
            rmDeduct.MinimumWidth = 8;
            rmDeduct.Name = "rmDeduct";
            rmDeduct.Width = 150;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Segoe UI", 11F);
            lblTotal.Location = new Point(280, 542);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(129, 30);
            lblTotal.TabIndex = 4;
            lblTotal.Text = "Total (RM) : ";
            // 
            // lblTotal2
            // 
            lblTotal2.AutoSize = true;
            lblTotal2.Font = new Font("Segoe UI", 11F);
            lblTotal2.Location = new Point(682, 542);
            lblTotal2.Name = "lblTotal2";
            lblTotal2.Size = new Size(129, 30);
            lblTotal2.TabIndex = 5;
            lblTotal2.Text = "Total (RM) : ";
            // 
            // lblTotalEarn
            // 
            lblTotalEarn.AutoSize = true;
            lblTotalEarn.BorderStyle = BorderStyle.Fixed3D;
            lblTotalEarn.Font = new Font("Segoe UI", 11F);
            lblTotalEarn.Location = new Point(415, 542);
            lblTotalEarn.Name = "lblTotalEarn";
            lblTotalEarn.Size = new Size(2, 32);
            lblTotalEarn.TabIndex = 6;
            lblTotalEarn.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblTotalDeduct
            // 
            lblTotalDeduct.AutoSize = true;
            lblTotalDeduct.BorderStyle = BorderStyle.Fixed3D;
            lblTotalDeduct.Font = new Font("Segoe UI", 11F);
            lblTotalDeduct.Location = new Point(817, 542);
            lblTotalDeduct.Name = "lblTotalDeduct";
            lblTotalDeduct.Size = new Size(2, 32);
            lblTotalDeduct.TabIndex = 7;
            lblTotalDeduct.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 18F);
            label6.Location = new Point(308, 24);
            label6.Name = "label6";
            label6.Size = new Size(373, 48);
            label6.TabIndex = 8;
            label6.Text = "Trainer Income Report";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 11F);
            label7.Location = new Point(528, 192);
            label7.Name = "label7";
            label7.Size = new Size(131, 30);
            label7.TabIndex = 9;
            label7.Text = "Pay Period : ";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 11F);
            label8.Location = new Point(528, 240);
            label8.Name = "label8";
            label8.Size = new Size(164, 30);
            label8.TabIndex = 10;
            label8.Text = "Payment Date : ";
            // 
            // lblAddress1
            // 
            lblAddress1.AutoSize = true;
            lblAddress1.BorderStyle = BorderStyle.Fixed3D;
            lblAddress1.Font = new Font("Segoe UI", 11F);
            lblAddress1.Location = new Point(214, 144);
            lblAddress1.Name = "lblAddress1";
            lblAddress1.Size = new Size(2, 32);
            lblAddress1.TabIndex = 11;
            // 
            // lblAddress2
            // 
            lblAddress2.AutoSize = true;
            lblAddress2.BorderStyle = BorderStyle.Fixed3D;
            lblAddress2.Font = new Font("Segoe UI", 11F);
            lblAddress2.Location = new Point(214, 192);
            lblAddress2.Name = "lblAddress2";
            lblAddress2.Size = new Size(2, 32);
            lblAddress2.TabIndex = 12;
            // 
            // lblAddress3
            // 
            lblAddress3.AutoSize = true;
            lblAddress3.BorderStyle = BorderStyle.Fixed3D;
            lblAddress3.Font = new Font("Segoe UI", 11F);
            lblAddress3.Location = new Point(214, 238);
            lblAddress3.Name = "lblAddress3";
            lblAddress3.Size = new Size(2, 32);
            lblAddress3.TabIndex = 13;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.BorderStyle = BorderStyle.Fixed3D;
            lblName.Font = new Font("Segoe UI", 11F);
            lblName.Location = new Point(214, 98);
            lblName.Name = "lblName";
            lblName.Size = new Size(2, 32);
            lblName.TabIndex = 14;
            // 
            // lblDate
            // 
            lblDate.AutoSize = true;
            lblDate.BorderStyle = BorderStyle.Fixed3D;
            lblDate.Font = new Font("Segoe UI", 11F);
            lblDate.Location = new Point(698, 240);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(2, 32);
            lblDate.TabIndex = 15;
            // 
            // lblPeriod
            // 
            lblPeriod.AutoSize = true;
            lblPeriod.BorderStyle = BorderStyle.Fixed3D;
            lblPeriod.Font = new Font("Segoe UI", 11F);
            lblPeriod.Location = new Point(698, 192);
            lblPeriod.Name = "lblPeriod";
            lblPeriod.Size = new Size(2, 32);
            lblPeriod.TabIndex = 16;
            // 
            // lblJob
            // 
            lblJob.AutoSize = true;
            lblJob.BorderStyle = BorderStyle.Fixed3D;
            lblJob.Font = new Font("Segoe UI", 11F);
            lblJob.Location = new Point(698, 98);
            lblJob.Name = "lblJob";
            lblJob.Size = new Size(2, 32);
            lblJob.TabIndex = 17;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI", 11F);
            label16.Location = new Point(615, 603);
            label16.Name = "label16";
            label16.Size = new Size(196, 30);
            label16.TabIndex = 18;
            label16.Text = "Net Income (RM) : ";
            // 
            // lblNet
            // 
            lblNet.AutoSize = true;
            lblNet.BorderStyle = BorderStyle.Fixed3D;
            lblNet.Font = new Font("Segoe UI", 11F);
            lblNet.Location = new Point(817, 603);
            lblNet.Name = "lblNet";
            lblNet.Size = new Size(2, 32);
            lblNet.TabIndex = 19;
            lblNet.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblBack
            // 
            lblBack.AutoSize = true;
            lblBack.Font = new Font("Segoe UI", 11F);
            lblBack.Location = new Point(22, 657);
            lblBack.Name = "lblBack";
            lblBack.Size = new Size(79, 30);
            lblBack.TabIndex = 20;
            lblBack.Text = "< Back";
            // 
            // admin_incomeReport
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(978, 699);
            Controls.Add(lblBack);
            Controls.Add(lblNet);
            Controls.Add(label16);
            Controls.Add(lblJob);
            Controls.Add(lblPeriod);
            Controls.Add(lblDate);
            Controls.Add(lblName);
            Controls.Add(lblAddress3);
            Controls.Add(lblAddress2);
            Controls.Add(lblAddress1);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(lblTotalDeduct);
            Controls.Add(lblTotalEarn);
            Controls.Add(lblTotal2);
            Controls.Add(lblTotal);
            Controls.Add(dataReport);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "admin_incomeReport";
            Text = "incomeReport";
            ((System.ComponentModel.ISupportInitialize)dataReport).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private DataGridView dataReport;
        private DataGridViewTextBoxColumn earn;
        private DataGridViewTextBoxColumn rmEarn;
        private DataGridViewTextBoxColumn deduct;
        private DataGridViewTextBoxColumn rmDeduct;
        private Label lblTotal;
        private Label lblTotal2;
        private Label lblTotalEarn;
        private Label lblTotalDeduct;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label lblAddress1;
        private Label lblAddress2;
        private Label lblAddress3;
        private Label lblName;
        private Label lblDate;
        private Label lblPeriod;
        private Label lblJob;
        private Label label16;
        private Label lblNet;
        private Label lblBack;
    }
}