namespace Lab_4
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.DisciplineDataGridView = new System.Windows.Forms.DataGridView();
            this.AddTeacherButton = new System.Windows.Forms.Button();
            this.DeleteTeacherButton = new System.Windows.Forms.Button();
            this.AddDisciplineButton = new System.Windows.Forms.Button();
            this.DeleteDisciplineButton = new System.Windows.Forms.Button();
            this.SaveDataButton = new System.Windows.Forms.Button();
            this.LoadDataButton = new System.Windows.Forms.Button();
            this.TeacherListView = new System.Windows.Forms.ListView();
            this.TeacherTextBox = new System.Windows.Forms.TextBox();
            this.SalaryTextBox = new System.Windows.Forms.TextBox();
            this.SortDataButton = new System.Windows.Forms.Button();
            this.UpdateDataButton = new System.Windows.Forms.Button();
            this.SaveDataToDbButton = new System.Windows.Forms.Button();
            this.LoadDataFromBdButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DisciplineDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // DisciplineDataGridView
            // 
            this.DisciplineDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DisciplineDataGridView.Location = new System.Drawing.Point(420, 313);
            this.DisciplineDataGridView.Name = "DisciplineDataGridView";
            this.DisciplineDataGridView.RowHeadersWidth = 62;
            this.DisciplineDataGridView.RowTemplate.Height = 33;
            this.DisciplineDataGridView.Size = new System.Drawing.Size(459, 221);
            this.DisciplineDataGridView.TabIndex = 1;
            // 
            // AddTeacherButton
            // 
            this.AddTeacherButton.Location = new System.Drawing.Point(12, 12);
            this.AddTeacherButton.Name = "AddTeacherButton";
            this.AddTeacherButton.Size = new System.Drawing.Size(165, 53);
            this.AddTeacherButton.TabIndex = 2;
            this.AddTeacherButton.Text = "Add teacher";
            this.AddTeacherButton.UseVisualStyleBackColor = true;
            this.AddTeacherButton.Click += new System.EventHandler(this.AddTeacherButton_Click);
            // 
            // DeleteTeacherButton
            // 
            this.DeleteTeacherButton.Location = new System.Drawing.Point(12, 71);
            this.DeleteTeacherButton.Name = "DeleteTeacherButton";
            this.DeleteTeacherButton.Size = new System.Drawing.Size(165, 53);
            this.DeleteTeacherButton.TabIndex = 3;
            this.DeleteTeacherButton.Text = "Delete teacher";
            this.DeleteTeacherButton.UseVisualStyleBackColor = true;
            this.DeleteTeacherButton.Click += new System.EventHandler(this.DeleteTeacherButton_Click);
            // 
            // AddDisciplineButton
            // 
            this.AddDisciplineButton.Location = new System.Drawing.Point(12, 130);
            this.AddDisciplineButton.Name = "AddDisciplineButton";
            this.AddDisciplineButton.Size = new System.Drawing.Size(165, 53);
            this.AddDisciplineButton.TabIndex = 4;
            this.AddDisciplineButton.Text = "Add discipline";
            this.AddDisciplineButton.UseVisualStyleBackColor = true;
            this.AddDisciplineButton.Click += new System.EventHandler(this.AddDisciplineButton_Click);
            // 
            // DeleteDisciplineButton
            // 
            this.DeleteDisciplineButton.Location = new System.Drawing.Point(12, 189);
            this.DeleteDisciplineButton.Name = "DeleteDisciplineButton";
            this.DeleteDisciplineButton.Size = new System.Drawing.Size(165, 53);
            this.DeleteDisciplineButton.TabIndex = 5;
            this.DeleteDisciplineButton.Text = "Delete discipline";
            this.DeleteDisciplineButton.UseVisualStyleBackColor = true;
            this.DeleteDisciplineButton.Click += new System.EventHandler(this.DeleteDisciplineButton_Click);
            // 
            // SaveDataButton
            // 
            this.SaveDataButton.Location = new System.Drawing.Point(12, 248);
            this.SaveDataButton.Name = "SaveDataButton";
            this.SaveDataButton.Size = new System.Drawing.Size(165, 53);
            this.SaveDataButton.TabIndex = 6;
            this.SaveDataButton.Text = "Save data";
            this.SaveDataButton.UseVisualStyleBackColor = true;
            this.SaveDataButton.Click += new System.EventHandler(this.SaveDataButton_Click);
            // 
            // LoadDataButton
            // 
            this.LoadDataButton.Location = new System.Drawing.Point(12, 307);
            this.LoadDataButton.Name = "LoadDataButton";
            this.LoadDataButton.Size = new System.Drawing.Size(165, 53);
            this.LoadDataButton.TabIndex = 7;
            this.LoadDataButton.Text = "Load data";
            this.LoadDataButton.UseVisualStyleBackColor = true;
            this.LoadDataButton.Click += new System.EventHandler(this.LoadDataButton_Click);
            // 
            // TeacherListView
            // 
            this.TeacherListView.Alignment = System.Windows.Forms.ListViewAlignment.Left;
            this.TeacherListView.AllowDrop = true;
            this.TeacherListView.Location = new System.Drawing.Point(420, 12);
            this.TeacherListView.Name = "TeacherListView";
            this.TeacherListView.Size = new System.Drawing.Size(459, 258);
            this.TeacherListView.Sorting = System.Windows.Forms.SortOrder.Descending;
            this.TeacherListView.TabIndex = 8;
            this.TeacherListView.UseCompatibleStateImageBehavior = false;
            this.TeacherListView.View = System.Windows.Forms.View.List;
            this.TeacherListView.SelectedIndexChanged += new System.EventHandler(this.TeacherListView_SelectedIndexChanged);
            // 
            // TeacherTextBox
            // 
            this.TeacherTextBox.Location = new System.Drawing.Point(420, 276);
            this.TeacherTextBox.Name = "TeacherTextBox";
            this.TeacherTextBox.Size = new System.Drawing.Size(150, 31);
            this.TeacherTextBox.TabIndex = 9;
            // 
            // SalaryTextBox
            // 
            this.SalaryTextBox.Location = new System.Drawing.Point(729, 276);
            this.SalaryTextBox.Name = "SalaryTextBox";
            this.SalaryTextBox.Size = new System.Drawing.Size(150, 31);
            this.SalaryTextBox.TabIndex = 10;
            // 
            // SortDataButton
            // 
            this.SortDataButton.Location = new System.Drawing.Point(12, 366);
            this.SortDataButton.Name = "SortDataButton";
            this.SortDataButton.Size = new System.Drawing.Size(165, 53);
            this.SortDataButton.TabIndex = 11;
            this.SortDataButton.Text = "Sort disciplines";
            this.SortDataButton.UseVisualStyleBackColor = true;
            this.SortDataButton.Click += new System.EventHandler(this.SortDataButton_Click);
            // 
            // UpdateDataButton
            // 
            this.UpdateDataButton.Location = new System.Drawing.Point(576, 276);
            this.UpdateDataButton.Name = "UpdateDataButton";
            this.UpdateDataButton.Size = new System.Drawing.Size(147, 34);
            this.UpdateDataButton.TabIndex = 12;
            this.UpdateDataButton.Text = "Update";
            this.UpdateDataButton.UseVisualStyleBackColor = true;
            this.UpdateDataButton.Click += new System.EventHandler(this.UpdateDataButton_Click);
            // 
            // SaveDataToDbButton
            // 
            this.SaveDataToDbButton.Location = new System.Drawing.Point(183, 12);
            this.SaveDataToDbButton.Name = "SaveDataToDbButton";
            this.SaveDataToDbButton.Size = new System.Drawing.Size(165, 53);
            this.SaveDataToDbButton.TabIndex = 13;
            this.SaveDataToDbButton.Text = "Save data to db";
            this.SaveDataToDbButton.UseVisualStyleBackColor = true;
            this.SaveDataToDbButton.Click += new System.EventHandler(this.SaveDataToDbButton_Click);
            // 
            // LoadDataFromBdButton
            // 
            this.LoadDataFromBdButton.Location = new System.Drawing.Point(183, 71);
            this.LoadDataFromBdButton.Name = "LoadDataFromBdButton";
            this.LoadDataFromBdButton.Size = new System.Drawing.Size(165, 53);
            this.LoadDataFromBdButton.TabIndex = 14;
            this.LoadDataFromBdButton.Text = "Load data from db";
            this.LoadDataFromBdButton.UseVisualStyleBackColor = true;
            this.LoadDataFromBdButton.Click += new System.EventHandler(this.LoadDataFromBdButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(891, 545);
            this.Controls.Add(this.LoadDataFromBdButton);
            this.Controls.Add(this.SaveDataToDbButton);
            this.Controls.Add(this.UpdateDataButton);
            this.Controls.Add(this.SortDataButton);
            this.Controls.Add(this.SalaryTextBox);
            this.Controls.Add(this.TeacherTextBox);
            this.Controls.Add(this.TeacherListView);
            this.Controls.Add(this.LoadDataButton);
            this.Controls.Add(this.SaveDataButton);
            this.Controls.Add(this.DeleteDisciplineButton);
            this.Controls.Add(this.AddDisciplineButton);
            this.Controls.Add(this.DeleteTeacherButton);
            this.Controls.Add(this.AddTeacherButton);
            this.Controls.Add(this.DisciplineDataGridView);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DisciplineDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DataGridView DisciplineDataGridView;
        private Button AddTeacherButton;
        private Button DeleteTeacherButton;
        private Button AddDisciplineButton;
        private Button DeleteDisciplineButton;
        private Button SaveDataButton;
        private Button LoadDataButton;
        private ListView TeacherListView;
        private TextBox TeacherTextBox;
        private TextBox SalaryTextBox;
        private Button SortDataButton;
        private Button UpdateDataButton;
        private Button SaveDataToDbButton;
        private Button LoadDataFromBdButton;
    }
}