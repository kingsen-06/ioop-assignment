namespace assignment
{
    partial class student_payment
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
            lblID = new Label();
            label3 = new Label();
            lblDesc = new Label();
            lblAmount = new Label();
            label5 = new Label();
            lblReceiver = new Label();
            label4 = new Label();
            radCard = new RadioButton();
            radWallet = new RadioButton();
            grpPayment = new GroupBox();
            btnProceed = new Button();
            lblBack = new Label();
            grpPayment.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F);
            label1.Location = new Point(97, 22);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(230, 41);
            label1.TabIndex = 0;
            label1.Text = "Payment Details";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F);
            label2.Location = new Point(44, 90);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(121, 25);
            label2.TabIndex = 1;
            label2.Text = "Payment ID : ";
            // 
            // lblID
            // 
            lblID.AutoSize = true;
            lblID.BorderStyle = BorderStyle.Fixed3D;
            lblID.Font = new Font("Segoe UI", 11F);
            lblID.Location = new Point(213, 90);
            lblID.Margin = new Padding(2, 0, 2, 0);
            lblID.Name = "lblID";
            lblID.Size = new Size(2, 27);
            lblID.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11F);
            label3.Location = new Point(44, 130);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(122, 25);
            label3.TabIndex = 3;
            label3.Text = "Description : ";
            // 
            // lblDesc
            // 
            lblDesc.AutoSize = true;
            lblDesc.BorderStyle = BorderStyle.Fixed3D;
            lblDesc.Font = new Font("Segoe UI", 11F);
            lblDesc.Location = new Point(213, 130);
            lblDesc.Margin = new Padding(2, 0, 2, 0);
            lblDesc.Name = "lblDesc";
            lblDesc.Size = new Size(2, 27);
            lblDesc.TabIndex = 4;
            // 
            // lblAmount
            // 
            lblAmount.AutoSize = true;
            lblAmount.BorderStyle = BorderStyle.Fixed3D;
            lblAmount.Font = new Font("Segoe UI", 11F);
            lblAmount.Location = new Point(213, 210);
            lblAmount.Margin = new Padding(2, 0, 2, 0);
            lblAmount.Name = "lblAmount";
            lblAmount.Size = new Size(2, 27);
            lblAmount.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11F);
            label5.Location = new Point(44, 210);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(170, 25);
            label5.TabIndex = 7;
            label5.Text = "Payment Amount : ";
            // 
            // lblReceiver
            // 
            lblReceiver.AutoSize = true;
            lblReceiver.BorderStyle = BorderStyle.Fixed3D;
            lblReceiver.Font = new Font("Segoe UI", 11F);
            lblReceiver.Location = new Point(213, 171);
            lblReceiver.Margin = new Padding(2, 0, 2, 0);
            lblReceiver.Name = "lblReceiver";
            lblReceiver.Size = new Size(2, 27);
            lblReceiver.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11F);
            label4.Location = new Point(44, 171);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(96, 25);
            label4.TabIndex = 5;
            label4.Text = "Receiver : ";
            // 
            // radCard
            // 
            radCard.AutoSize = true;
            radCard.Font = new Font("Segoe UI", 11F);
            radCard.Location = new Point(25, 45);
            radCard.Margin = new Padding(2);
            radCard.Name = "radCard";
            radCard.Size = new Size(181, 29);
            radCard.TabIndex = 9;
            radCard.TabStop = true;
            radCard.Text = "Debit/Credit Card";
            radCard.UseVisualStyleBackColor = true;
            // 
            // radWallet
            // 
            radWallet.AutoSize = true;
            radWallet.Font = new Font("Segoe UI", 11F);
            radWallet.Location = new Point(25, 84);
            radWallet.Margin = new Padding(2);
            radWallet.Name = "radWallet";
            radWallet.Size = new Size(101, 29);
            radWallet.TabIndex = 10;
            radWallet.TabStop = true;
            radWallet.Text = "E-wallet";
            radWallet.UseVisualStyleBackColor = true;
            // 
            // grpPayment
            // 
            grpPayment.Controls.Add(radWallet);
            grpPayment.Controls.Add(radCard);
            grpPayment.Font = new Font("Segoe UI", 11F);
            grpPayment.Location = new Point(97, 270);
            grpPayment.Margin = new Padding(2);
            grpPayment.Name = "grpPayment";
            grpPayment.Padding = new Padding(2);
            grpPayment.Size = new Size(228, 134);
            grpPayment.TabIndex = 11;
            grpPayment.TabStop = false;
            grpPayment.Text = "Payment Method:";
            // 
            // btnProceed
            // 
            btnProceed.Font = new Font("Segoe UI", 11F);
            btnProceed.Location = new Point(117, 428);
            btnProceed.Margin = new Padding(2);
            btnProceed.Name = "btnProceed";
            btnProceed.Size = new Size(184, 30);
            btnProceed.TabIndex = 11;
            btnProceed.Text = "Proceed to Payment";
            btnProceed.UseVisualStyleBackColor = true;
            btnProceed.Click += btnProceed_Click;
            // 
            // lblBack
            // 
            lblBack.AutoSize = true;
            lblBack.Font = new Font("Segoe UI", 11F);
            lblBack.Location = new Point(16, 478);
            lblBack.Margin = new Padding(2, 0, 2, 0);
            lblBack.Name = "lblBack";
            lblBack.Size = new Size(69, 25);
            lblBack.TabIndex = 12;
            lblBack.Text = "< Back";
            lblBack.Click += lblBack_Click;
            // 
            // student_payment
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(423, 520);
            Controls.Add(lblBack);
            Controls.Add(btnProceed);
            Controls.Add(grpPayment);
            Controls.Add(lblAmount);
            Controls.Add(label5);
            Controls.Add(lblReceiver);
            Controls.Add(label4);
            Controls.Add(lblDesc);
            Controls.Add(label3);
            Controls.Add(lblID);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(2);
            Name = "student_payment";
            Text = "payment";
            FormClosed += student_payment_FormClosed;
            Load += student_payment_Load;
            grpPayment.ResumeLayout(false);
            grpPayment.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label lblID;
        private Label label3;
        private Label lblDesc;
        private Label lblAmount;
        private Label label5;
        private Label lblReceiver;
        private Label label4;
        private RadioButton radCard;
        private RadioButton radWallet;
        private GroupBox grpPayment;
        private Button btnProceed;
        private Label lblBack;
    }
}