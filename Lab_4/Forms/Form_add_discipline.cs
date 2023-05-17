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
    public partial class Form_add_discipline : Form
    {
        private Teacher _teacher;
        
        public Form_add_discipline()
        {
            InitializeComponent();
        }

        public Form_add_discipline(Teacher current_teacher)
        {
            _teacher = current_teacher;
            InitializeComponent();
        }

        private void Form_add_discipline_Load(object sender, EventArgs e)
        {

        }

        private void AddNewDisciplineButton_Click(object sender, EventArgs e)
        {
            try
            {
                string title = TitleTextBox.Text;
                int hours = Convert.ToInt32(HoursTextBox.Text);
                string id = Guid.NewGuid().ToString();
                string teacherid = _teacher.Id;


                Discipline new_discipline = new Discipline(id, title, hours, teacherid);
                _teacher.Add_Discipline(new_discipline);
            }
            catch (ArgumentException exception)
            {
                MessageBox.Show(exception.Message, "Error");
            }

            this.Close();
        }
    }
}
