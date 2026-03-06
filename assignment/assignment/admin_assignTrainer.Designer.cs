namespace assignment
{
    partial class admin_assignTrainer
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
            cmbLevel = new ComboBox();
            cmbModule = new ComboBox();
            btnAssign = new Button();
            btnBack = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F);
            label1.Location = new Point(158, 87);
            label1.Name = "label1";
            label1.Size = new Size(204, 30);
            label1.TabIndex = 0;
            label1.Text = "Coding Class Level: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F);
            label2.Location = new Point(158, 178);
            label2.Name = "label2";
            label2.Size = new Size(99, 30);
            label2.TabIndex = 1;
            label2.Text = "Module: ";
            // 
            // cmbLevel
            // 
            cmbLevel.Font = new Font("Segoe UI", 11F);
            cmbLevel.FormattingEnabled = true;
            cmbLevel.Items.AddRange(new object[] { "Beginner", "Intermediate", "Advance" });
            cmbLevel.Location = new Point(386, 84);
            cmbLevel.Name = "cmbLevel";
            cmbLevel.Size = new Size(259, 38);
            cmbLevel.TabIndex = 2;
            // 
            // cmbModule
            // 
            cmbModule.Font = new Font("Segoe UI", 11F);
            cmbModule.FormattingEnabled = true;
            cmbModule.Location = new Point(386, 175);
            cmbModule.Name = "cmbModule";
            cmbModule.Size = new Size(259, 38);
            cmbModule.TabIndex = 3;
            // 
            // btnAssign
            // 
            btnAssign.Font = new Font("Segoe UI", 11F);
            btnAssign.Location = new Point(51, 284);
            btnAssign.Name = "btnAssign";
            btnAssign.Size = new Size(321, 41);
            btnAssign.TabIndex = 4;
            btnAssign.Text = "Assign Trainer to Module";
            btnAssign.UseVisualStyleBackColor = true;
            // 
            // btnBack
            // 
            btnBack.Font = new Font("Segoe UI", 11F);
            btnBack.Location = new Point(424, 284);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(321, 41);
            btnBack.TabIndex = 5;
            btnBack.Text = "Back to Administrator Menu";
            btnBack.UseVisualStyleBackColor = true;
            // 
            // administrator_assignTrainer
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 428);
            Controls.Add(btnBack);
            Controls.Add(btnAssign);
            Controls.Add(cmbModule);
            Controls.Add(cmbLevel);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "administrator_assignTrainer";
            Text = "assignTrainer";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private ComboBox cmbLevel;
        private ComboBox cmbModule;
        private Button btnAssign;
        private Button btnBack;
    }
}