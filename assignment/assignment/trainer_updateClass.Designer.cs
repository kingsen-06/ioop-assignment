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
            lblBack.Location = new Point(17, 308);
            lblBack.Margin = new Padding(2, 0, 2, 0);
            lblBack.Name = "lblBack";
            lblBack.Size = new Size(208, 25);
            lblBack.TabIndex = 10;
            lblBack.Text = "< Back to Trainer Menu";
            lblBack.Click += lblBack_Click;
            // 
            // btnEdit
            // 
            btnEdit.Font = new Font("Segoe UI", 11F);
            btnEdit.Location = new Point(450, 242);
            btnEdit.Margin = new Padding(2);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(178, 34);
            btnEdit.TabIndex = 9;
            btnEdit.Text = "Edit Class Detail";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnRemove
            // 
            btnRemove.Font = new Font("Segoe UI", 11F);
            btnRemove.Location = new Point(253, 242);
            btnRemove.Margin = new Padding(2);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(178, 34);
            btnRemove.TabIndex = 8;
            btnRemove.Text = "Remove Class";
            btnRemove.UseVisualStyleBackColor = true;
            btnRemove.Click += btnRemove_Click;
            // 
            // btnAdd
            // 
            btnAdd.Font = new Font("Segoe UI", 11F);
            btnAdd.Location = new Point(53, 242);
            btnAdd.Margin = new Padding(2);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(178, 34);
            btnAdd.TabIndex = 7;
            btnAdd.Text = "Add New Class";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // dataClass
            // 
            dataClass.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataClass.Columns.AddRange(new DataGridViewColumn[] { name, level, schedule, venue, fee });
            dataClass.Location = new Point(38, 38);
            dataClass.Margin = new Padding(2);
            dataClass.Name = "dataClass";
            dataClass.RowHeadersWidth = 62;
            dataClass.Size = new Size(606, 180);
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
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(683, 352);
            Controls.Add(lblBack);
            Controls.Add(btnEdit);
            Controls.Add(btnRemove);
            Controls.Add(btnAdd);
            Controls.Add(dataClass);
            Margin = new Padding(2);
            Name = "trainer_updateClass";
            Text = "updateClass";
            FormClosed += trainer_updateClass_FormClosed;
            Load += trainer_updateClass_Load;
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