namespace assignment
{
    partial class trainer_updateClass
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
            btnEdit = new Button();
            btnRemove = new Button();
            btnAdd = new Button();
            dataClass = new DataGridView();
            name = new DataGridViewTextBoxColumn();
            level = new DataGridViewTextBoxColumn();
            schedule = new DataGridViewTextBoxColumn();
            venue = new DataGridViewTextBoxColumn();
            fee = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataClass).BeginInit();
            SuspendLayout();
            // 
            // lblBack
            // 
            lblBack.AutoSize = true;
            lblBack.Font = new Font("Segoe UI", 11F);
            lblBack.Location = new Point(21, 385);
            lblBack.Name = "lblBack";
            lblBack.Size = new Size(239, 30);
            lblBack.TabIndex = 10;
            lblBack.Text = "< Back to Trainer Menu";
            // 
            // btnEdit
            // 
            btnEdit.Font = new Font("Segoe UI", 11F);
            btnEdit.Location = new Point(563, 305);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(222, 43);
            btnEdit.TabIndex = 9;
            btnEdit.Text = "Edit Class Detail";
            btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnRemove
            // 
            btnRemove.Font = new Font("Segoe UI", 11F);
            btnRemove.Location = new Point(317, 305);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(222, 43);
            btnRemove.TabIndex = 8;
            btnRemove.Text = "Remove Class";
            btnRemove.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            btnAdd.Font = new Font("Segoe UI", 11F);
            btnAdd.Location = new Point(67, 305);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(222, 43);
            btnAdd.TabIndex = 7;
            btnAdd.Text = "Add New Class";
            btnAdd.UseVisualStyleBackColor = true;
            // 
            // dataClass
            // 
            dataClass.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataClass.Columns.AddRange(new DataGridViewColumn[] { name, level, schedule, venue, fee });
            dataClass.Location = new Point(48, 47);
            dataClass.Name = "dataClass";
            dataClass.RowHeadersWidth = 62;
            dataClass.Size = new Size(758, 225);
            dataClass.TabIndex = 6;
            // 
            // name
            // 
            name.HeaderText = "Module Name";
            name.MinimumWidth = 8;
            name.Name = "name";
            name.Width = 150;
            // 
            // level
            // 
            level.HeaderText = "Class Level";
            level.MinimumWidth = 8;
            level.Name = "level";
            level.Width = 150;
            // 
            // schedule
            // 
            schedule.HeaderText = "Class Schedule";
            schedule.MinimumWidth = 8;
            schedule.Name = "schedule";
            schedule.Width = 150;
            // 
            // venue
            // 
            venue.HeaderText = "Class Venue";
            venue.MinimumWidth = 8;
            venue.Name = "venue";
            venue.Width = 150;
            // 
            // fee
            // 
            fee.HeaderText = "Fee";
            fee.MinimumWidth = 8;
            fee.Name = "fee";
            fee.Width = 150;
            // 
            // trainer_updateClass
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(854, 440);
            Controls.Add(lblBack);
            Controls.Add(btnEdit);
            Controls.Add(btnRemove);
            Controls.Add(btnAdd);
            Controls.Add(dataClass);
            Name = "trainer_updateClass";
            Text = "updateClass";
            ((System.ComponentModel.ISupportInitialize)dataClass).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblBack;
        private Button btnEdit;
        private Button btnRemove;
        private Button btnAdd;
        private DataGridView dataClass;
        private DataGridViewTextBoxColumn name;
        private DataGridViewTextBoxColumn level;
        private DataGridViewTextBoxColumn schedule;
        private DataGridViewTextBoxColumn venue;
        private DataGridViewTextBoxColumn fee;
    }
}