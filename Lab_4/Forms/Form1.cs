using System;
using Lab_4.Entities;
using Lab_4.Forms;
using System.Collections;
using System.Text.Json;
using System.Linq;
using System;
using Microsoft.EntityFrameworkCore.Storage;
using Lab_4.Data;
using Microsoft.EntityFrameworkCore;

namespace Lab_4
{
    public partial class Form1 : Form
    {

        private readonly string _pathToTeachersDataFile = @"E:\Projects\Lab_4\Teachers.json";
        private readonly string _pathToDisciplinesDataFile = @"E:\Projects\Lab_4\Disciplines.json";
        private List<Teacher> _teachers;
        private List<Discipline> _disciplines;
        private readonly DataBaseContext _context;

        public Form1()
        {
            InitializeComponent();
            _context = new DataBaseContext();
        }

        int _id = 0;
        private void Form1_Load(object sender, EventArgs e)
        {
            _teachers = new List<Teacher>();
        }

        private void Add(Teacher teacher)
        {
            var Listview_item = new ListViewItem(teacher.Name);
            Listview_item.Tag = teacher;
            TeacherListView.Items.Add(Listview_item);
        }

        private void AddTeacherButton_Click(object sender, EventArgs e)
        {
            if (TeacherTextBox.Text != "" && SalaryTextBox.Text != "") 
            {
                try
                {
                    string name = TeacherTextBox.Text;
                    double salary = Convert.ToDouble(SalaryTextBox.Text);
                    string id = Guid.NewGuid().ToString();
                    _id++;
                    
                    Teacher new_teacher = new Teacher(id, name, salary);
                    Add(new_teacher);
                    _teachers.Add(new_teacher);

                }
                catch (ArgumentException exception)
                {
                    MessageBox.Show(exception.Message, "Error");
                }
            }
            else
            {
                MessageBox.Show("Name and salary can`t be empty");
            }
        }

        private void TeacherListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(TeacherListView.SelectedItems.Count > 0)
            {
                var teacher = (Teacher)TeacherListView.SelectedItems[0].Tag;

                if(teacher != null) 
                {
                    TeacherTextBox.Text = teacher.Name;
                    SalaryTextBox.Text = teacher.Salary.ToString();
                    _disciplines = teacher.Disciplines;
                    DisciplineDataGridView.DataSource = teacher.Disciplines;
                }
            }
            else
            {
                ClearText();
            }
        }

        private void ClearText()
        {
            TeacherTextBox.Text = string.Empty;
            SalaryTextBox.Text = string.Empty;
        }

        private void DeleteTeacherButton_Click(object sender, EventArgs e)
        {
            try
            {
                ListViewItem item = TeacherListView.SelectedItems[0];
                
                TeacherListView.Items[item.Index].Remove();

            }
            catch (ArgumentException exception)
            {
                MessageBox.Show(exception.Message, "Error");
            }
        }

        private async void SaveDataButton_Click(object sender, EventArgs e)
        {
            var teachers_list = new List<Teacher>();

            foreach (ListViewItem item in TeacherListView.Items)
            {
                if (item != null)
                    teachers_list.Add((Teacher)item.Tag);
            }

            await SerializeAsync(teachers_list);

            UnloadAsync();
        }

        private async Task SerializeAsync(List<Teacher> teachers)
        {
            using (var stream = new FileStream(_pathToTeachersDataFile, FileMode.OpenOrCreate))
            {
                await JsonSerializer.SerializeAsync<List<Teacher>>(stream, teachers);
            }
        }

        private async void UnloadAsync()
        {
            var disciplines = new List<Discipline>();
            foreach (ListViewItem item in TeacherListView.Items)
            {
                var teacher = (Teacher)item.Tag;

                foreach (var discipline in teacher.Disciplines)
                {
                    disciplines.Add(discipline);
                }
            }

            await SerializeDisciplinesAsync(disciplines);
        }

        private async Task SerializeDisciplinesAsync(List<Discipline> disciplines)
        {
            using (var stream = new FileStream(_pathToDisciplinesDataFile, FileMode.OpenOrCreate))
            {
                await JsonSerializer.SerializeAsync<List<Discipline>>(stream, disciplines);
            }
        }

        private async void LoadDataButton_Click(object sender, EventArgs e)
        {
            List<Teacher> teachers = await DeserializeAsync();
            _teachers = teachers;
            
            foreach(Teacher item in teachers)
            {
                ListViewItem li = new ListViewItem(item.Name);
                li.Tag = item;
                TeacherListView.Items.Add(li);
            }
        }

        private async Task<List<Teacher>> DeserializeAsync()
        {
            using (FileStream stream = new FileStream(_pathToTeachersDataFile, FileMode.OpenOrCreate))
            {
                List<Teacher> teachers_list = await JsonSerializer.DeserializeAsync<List<Teacher>>(stream);

                return teachers_list;
            }
        }

        private void AddDisciplineButton_Click(object sender, EventArgs e)
        {
            try
            {
                var current_teacher = (Teacher)TeacherListView.SelectedItems[0].Tag;

                Form_add_discipline form_discipline = new Form_add_discipline(current_teacher);
                form_discipline.ShowDialog();
            }
            catch
            {
                MessageBox.Show("Error");
            }
        }

        private void DeleteDisciplineButton_Click(object sender, EventArgs e)
        {
            if (TeacherListView.SelectedItems.Count > 0)
            {
                var current_teacher = (Teacher)TeacherListView.SelectedItems[0].Tag;

                Form_delete_discipline form_discipline = new Form_delete_discipline(current_teacher);
                form_discipline.ShowDialog();
            }
            else
            {
                MessageBox.Show("Select a teacher");
            }
        }

        private void SortDataButton_Click(object sender, EventArgs e)
        {
            if(TeacherListView.SelectedItems.Count > 0)
            {
                Teacher current_teacher = (Teacher)TeacherListView.SelectedItems[0].Tag;


                _disciplines = current_teacher.GetDisciplines().OrderBy(x => x.Title).ToList();
                DisciplineDataGridView.DataSource = _disciplines;
            }
            else
            {
                MessageBox.Show("Select a teacher");
            }
            
        }

        private void UpdateDataButton_Click(object sender, EventArgs e)
        {
            if (TeacherListView.SelectedItems.Count > 0 && (TeacherTextBox.Text != "" && SalaryTextBox.Text != ""))
            {
                string new_name = TeacherTextBox.Text;
                double new_salary = Convert.ToDouble(SalaryTextBox.Text);

                var teacher = (Teacher)TeacherListView.SelectedItems[0].Tag;
                teacher.Name = new_name;
                teacher.Salary = new_salary;

                TeacherListView.Items.Clear();

                foreach (var item in _teachers)
                {
                    Add(item);
                }
            }
            else
            {
                MessageBox.Show("Select a teacher");
            }
        }

        private void SaveDataToDbButton_Click(object sender, EventArgs e)
        {
            var teachers = new List<Teacher>();
            foreach (ListViewItem item in TeacherListView.Items)
            {
                if (item != null)
                    teachers.Add((Teacher)item.Tag);
            }

            SaveRecords(teachers);
        }

        private void LoadDataFromBdButton_Click(object sender, EventArgs e)
        {
            var teachers = LoadRecords();
            if (teachers is null) 
                throw new Exception("Failed to load from database");

            _teachers = teachers;

            foreach (Teacher item in teachers)
            {
                ListViewItem li = new ListViewItem(item.Name);
                li.Tag = item;
                TeacherListView.Items.Add(li);
            }
        }

        private void SaveRecords(IEnumerable<Teacher> teachers)
        {
            _context.Teachers.RemoveRange(_context.Teachers);
            _context.SaveChanges();

            foreach (var teacher in teachers)
            {
                _context.Teachers.Add(teacher);
            }
            
            _context.SaveChanges();
        }

        private List<Teacher>? LoadRecords()
        {
            var teachers = _context.Teachers.Include(x => x.Disciplines).ToList();

            return teachers;
        }
    }
}