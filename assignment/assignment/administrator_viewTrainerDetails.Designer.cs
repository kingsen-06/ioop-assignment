namespace assignment
{
    partial class administrator_viewTrainerDetails
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
            dataTrainerDetails = new DataGridView();
            btnRegister = new Button();
            btnRemove = new Button();
            btnEdit = new Button();
            btnBack = new Button();
            ((System.ComponentModel.ISupportInitialize)dataTrainerDetails).BeginInit();
            SuspendLayout();
            // 
            // dataTrainerDetails
            // 
            dataTrainerDetails.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataTrainerDetails.Location = new Point(184, 62);
            dataTrainerDetails.Name = "dataTrainerDetails";
            dataTrainerDetails.RowHeadersWidth = 51;
            dataTrainerDetails.Size = new Size(405, 224);
            dataTrainerDetails.TabIndex = 0;
            // 
            // btnRegister
            // 
            btnRegister.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRegister.Location = new Point(184, 313);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(123, 39);
            btnRegister.TabIndex = 1;
            btnRegister.Text = "Register";
            btnRegister.UseVisualStyleBackColor = true;
            // 
            // btnRemove
            // 
            btnRemove.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRemove.Location = new Point(325, 313);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(123, 39);
            btnRemove.TabIndex = 2;
            btnRemove.Text = "Remove";
            btnRemove.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            btnEdit.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEdit.Location = new Point(466, 313);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(123, 39);
            btnEdit.TabIndex = 3;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(12, 12);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(94, 29);
            btnBack.TabIndex = 4;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            // 
            // administrator_viewTrainerDetails
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnBack);
            Controls.Add(btnEdit);
            Controls.Add(btnRemove);
            Controls.Add(btnRegister);
            Controls.Add(dataTrainerDetails);
            Name = "administrator_viewTrainerDetails";
            Text = "administrator_viewTrainerDetails";
            ((System.ComponentModel.ISupportInitialize)dataTrainerDetails).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataTrainerDetails;
        private Button btnRegister;
        private Button btnRemove;
        private Button btnEdit;
        private Button btnBack;
    }
}