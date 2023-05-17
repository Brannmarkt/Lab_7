namespace Lab_4.Forms
{
    partial class Form_add_discipline
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
            this.AddNewDisciplineButton = new System.Windows.Forms.Button();
            this.TitleTextBox = new System.Windows.Forms.TextBox();
            this.HoursTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // AddNewDisciplineButton
            // 
            this.AddNewDisciplineButton.Location = new System.Drawing.Point(66, 134);
            this.AddNewDisciplineButton.Name = "AddNewDisciplineButton";
            this.AddNewDisciplineButton.Size = new System.Drawing.Size(136, 54);
            this.AddNewDisciplineButton.TabIndex = 0;
            this.AddNewDisciplineButton.Text = "Add discipline";
            this.AddNewDisciplineButton.UseVisualStyleBackColor = true;
            this.AddNewDisciplineButton.Click += new System.EventHandler(this.AddNewDisciplineButton_Click);
            // 
            // TitleTextBox
            // 
            this.TitleTextBox.Location = new System.Drawing.Point(84, 12);
            this.TitleTextBox.Name = "TitleTextBox";
            this.TitleTextBox.Size = new System.Drawing.Size(150, 31);
            this.TitleTextBox.TabIndex = 1;
            // 
            // HoursTextBox
            // 
            this.HoursTextBox.Location = new System.Drawing.Point(84, 49);
            this.HoursTextBox.Name = "HoursTextBox";
            this.HoursTextBox.Size = new System.Drawing.Size(150, 31);
            this.HoursTextBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Title";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Hours";
            // 
            // Form_add_discipline
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(265, 205);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.HoursTextBox);
            this.Controls.Add(this.TitleTextBox);
            this.Controls.Add(this.AddNewDisciplineButton);
            this.Name = "Form_add_discipline";
            this.Text = "Form_add_discipline";
            this.Load += new System.EventHandler(this.Form_add_discipline_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button AddNewDisciplineButton;
        private TextBox TitleTextBox;
        private TextBox HoursTextBox;
        private Label label1;
        private Label label2;
    }
}