namespace Lab_4.Forms
{
    partial class Form_delete_discipline
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
            this.TitleTextBox = new System.Windows.Forms.TextBox();
            this.DeleteDisciplineButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TitleTextBox
            // 
            this.TitleTextBox.Location = new System.Drawing.Point(149, 12);
            this.TitleTextBox.Name = "TitleTextBox";
            this.TitleTextBox.Size = new System.Drawing.Size(150, 31);
            this.TitleTextBox.TabIndex = 0;
            // 
            // DeleteDisciplineButton
            // 
            this.DeleteDisciplineButton.Location = new System.Drawing.Point(105, 81);
            this.DeleteDisciplineButton.Name = "DeleteDisciplineButton";
            this.DeleteDisciplineButton.Size = new System.Drawing.Size(112, 34);
            this.DeleteDisciplineButton.TabIndex = 1;
            this.DeleteDisciplineButton.Text = "Delete";
            this.DeleteDisciplineButton.UseVisualStyleBackColor = true;
            this.DeleteDisciplineButton.Click += new System.EventHandler(this.DeleteDisciplineButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Discipline title";
            // 
            // Form_delete_discipline
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(322, 127);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DeleteDisciplineButton);
            this.Controls.Add(this.TitleTextBox);
            this.Name = "Form_delete_discipline";
            this.Text = "Form_delete_discipline";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox TitleTextBox;
        private Button DeleteDisciplineButton;
        private Label label1;
    }
}