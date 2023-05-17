using Lab_4.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_4.Forms
{
    public partial class Form_delete_discipline : Form
    {
        private Teacher _teacher;
        public Form_delete_discipline()
        {
            InitializeComponent();
        }

        public Form_delete_discipline(Teacher current_teacher)
        {
            _teacher = current_teacher;
            InitializeComponent();
        }

        private void DeleteDisciplineButton_Click(object sender, EventArgs e)
        {
            try
            {
                string title = TitleTextBox.Text;

                _teacher.Disciplines.RemoveAll(x => x.Title == title);
            }
            catch (ArgumentException exception)
            {
                MessageBox.Show(exception.Message, "Error");
            }

            this.Close();
        }
    }
}
