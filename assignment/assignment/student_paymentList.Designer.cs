namespace assignment
{
    partial class student_paymentList
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
            lblBack = new Label();
            btnInvoice = new Button();
            btnPay = new Button();
            dataPayment = new DataGridView();
            id = new DataGridViewTextBoxColumn();
            description = new DataGridViewTextBoxColumn();
            receiver = new DataGridViewTextBoxColumn();
            amount = new DataGridViewTextBoxColumn();
            date = new DataGridViewTextBoxColumn();
            status = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataPayment).BeginInit();
            SuspendLayout();
            // 
            // lblBack
            // 
            lblBack.AutoSize = true;
            lblBack.Font = new Font("Segoe UI", 11F);
            lblBack.Location = new Point(12, 413);
            lblBack.Name = "lblBack";
            lblBack.Size = new Size(247, 30);
            lblBack.TabIndex = 0;
            lblBack.Text = "< Back to Student Menu";
            // 
            // btnInvoice
            // 
            btnInvoice.Font = new Font("Segoe UI", 11F);
            btnInvoice.Location = new Point(208, 354);
            btnInvoice.Name = "btnInvoice";
            btnInvoice.Size = new Size(215, 43);
            btnInvoice.TabIndex = 1;
            btnInvoice.Text = "View Invoice";
            btnInvoice.UseVisualStyleBackColor = true;
            // 
            // btnPay
            // 
            btnPay.Font = new Font("Segoe UI", 11F);
            btnPay.Location = new Point(512, 354);
            btnPay.Name = "btnPay";
            btnPay.Size = new Size(215, 43);
            btnPay.TabIndex = 2;
            btnPay.Text = "Make Payment";
            btnPay.UseVisualStyleBackColor = true;
            // 
            // dataPayment
            // 
            dataPayment.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataPayment.Columns.AddRange(new DataGridViewColumn[] { id, description, receiver, amount, date, status });
            dataPayment.Location = new Point(48, 42);
            dataPayment.Name = "dataPayment";
            dataPayment.RowHeadersWidth = 62;
            dataPayment.Size = new Size(836, 279);
            dataPayment.TabIndex = 3;
            // 
            // id
            // 
            id.HeaderText = "Payment ID";
            id.MinimumWidth = 8;
            id.Name = "id";
            id.Width = 130;
            // 
            // description
            // 
            description.HeaderText = "Description";
            description.MinimumWidth = 8;
            description.Name = "description";
            description.Width = 130;
            // 
            // receiver
            // 
            receiver.HeaderText = "Receiver";
            receiver.MinimumWidth = 8;
            receiver.Name = "receiver";
            receiver.Width = 130;
            // 
            // amount
            // 
            amount.HeaderText = "Payment Amount";
            amount.MinimumWidth = 8;
            amount.Name = "amount";
            amount.Width = 130;
            // 
            // date
            // 
            date.HeaderText = "Paid Date";
            date.MinimumWidth = 8;
            date.Name = "date";
            date.Width = 130;
            // 
            // status
            // 
            status.HeaderText = "Status";
            status.MinimumWidth = 8;
            status.Name = "status";
            status.Width = 130;
            // 
            // student_paymentList
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(931, 467);
            Controls.Add(dataPayment);
            Controls.Add(btnPay);
            Controls.Add(btnInvoice);
            Controls.Add(lblBack);
            Name = "student_paymentList";
            Text = "paymentList";
            ((System.ComponentModel.ISupportInitialize)dataPayment).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblBack;
        private Button btnInvoice;
        private Button btnPay;
        private DataGridView dataPayment;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn description;
        private DataGridViewTextBoxColumn receiver;
        private DataGridViewTextBoxColumn amount;
        private DataGridViewTextBoxColumn date;
        private DataGridViewTextBoxColumn status;
    }
}