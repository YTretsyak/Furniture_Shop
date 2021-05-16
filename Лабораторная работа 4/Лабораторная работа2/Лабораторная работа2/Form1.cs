using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Xml.Serialization;
using System.IO;
using System.ComponentModel.DataAnnotations;
using System.Collections.ObjectModel;
using Newtonsoft.Json;
using System.Security.Cryptography.X509Certificates;
using System.Collections.Specialized;

namespace Лабораторная_работа2
{

    public partial class Form1 : Form
    {
        // Лекторы
        List<ILecturer> Lectures { get; }
        // Кнопки лекторов
        List<RadioButton> RadioButtons { get; }

        public bool correct = true;
        public ObservableCollection<Discipline> disciplines;
        Dictionary<ListViewItem, Discipline> keys;
        public Discipline currentDiscipline;
        Discipline snapshot;

        private ProfessorFactory professorFactory;
        private AssociateLecturerFactory associateLecturerFactory;
        private DisciplineBuilder disciplineBuilder;

        public Form1()
        {
            InitializeComponent();
            Font = Singleton.GetInstance().Config.FontType;
            BackColor = Singleton.GetInstance().Config.FontColor;
            disciplines = new ObservableCollection<Discipline>();
            keys = new Dictionary<ListViewItem, Discipline>();

            professorFactory = new ProfessorFactory();
            associateLecturerFactory = new AssociateLecturerFactory();
            disciplineBuilder = new DisciplineBuilder();

            Lectures = new List<ILecturer>() {
                professorFactory.CreateLecturer("ИСиТ", "Урбанович Павел Павлович"),
                associateLecturerFactory.CreateLecturer("ИСиТ", "Жиляк Надежда Александровна"),
                associateLecturerFactory.CreateLecturer("ИСиТ", "Пустовалова Наталья Николаевна"),
                associateLecturerFactory.CreateLecturer("ИСиТ", "Смелов Владимир Владиславович"),
                professorFactory.CreateLecturer("ИСиТ", "Колесников Виталий Леонидович")
            };

            disciplines.CollectionChanged += Disciplines_CollectionChanged;

            RadioButtons = new List<RadioButton>()
            {
                radioButton1, radioButton2, radioButton3, radioButton4, radioButton5
            };
            Disciplines_ListView.Items.Clear();
        }
        private void Log(string text)
        {
            label2.Text = $"Количество элементов : {Convert.ToString(Disciplines_ListView.Items.Count)}";
        }
        public void CheckFields()
        {
            string str = Specialization_ComboBox.Text.ToUpper();
            correct = true;
            if ((Sem1_CheckBox.Checked && Sem2_CheckBox.Checked) || (!Sem1_CheckBox.Checked && !Sem2_CheckBox.Checked))
            {
                errorProvider1.SetError(Sem1_CheckBox, "Укажите семестр");
                correct = false;
            }
            else
                errorProvider1.Clear();
            if (Course_ComboBox.Text == "")
            {
                errorProvider1.SetError(Course_ComboBox, "Укажите курс");
                correct = false;
            }
            else if (Course_ComboBox.Text != "1" && Course_ComboBox.Text != "2" && Course_ComboBox.Text != "3" && Course_ComboBox.Text != "4")
            {
                errorProvider1.SetError(Course_ComboBox, "Не верно указан курс");
                correct = false;
            }
            if (Specialization_ComboBox.Text == "")
            {
                errorProvider1.SetError(Specialization_ComboBox, "Не указана специальность");
                correct = false;
            }
            else if (str != "ПОИТ" && str != "ДЭИВИ" && str != "ПОИБМС" && str != "ИСИТ")
            {
                errorProvider1.SetError(Specialization_ComboBox, "Не верно указана специальность");
                correct = false;
            }

            if (LecturesAmt_TextBox.Text != "")
            {
                if (!int.TryParse(LecturesAmt_TextBox.Text, out int amt) || amt <= 0 || amt > 30)
                {
                    errorProvider1.SetError(LecturesAmt_TextBox, "Не верное количество лекций");
                    correct = false;
                }
            }

            if (LabsAmt_TextBox.Text != "")
            {
                if (!int.TryParse(LabsAmt_TextBox.Text, out int amt) || amt <= 0 || amt > 30)
                {
                    errorProvider1.SetError(LabsAmt_TextBox, "Не верное количество лекций");
                    correct = false;
                }
            }

            if (Test_ListBox.SelectedIndex == -1)
            {
                errorProvider1.SetError(Test_ListBox, "Не указан тип дисциплины");
                correct = false;
            }

            if (Name_TextBox.Text == "")
            {
                errorProvider1.SetError(Name_TextBox, "Не указано название дисциплины");
                correct = false;
            }
        }

        private void Disciplines_CollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
        {
            switch (e.Action)
            {
                case NotifyCollectionChangedAction.Add:
                    AddToTableRange(e.NewItems.Cast<Discipline>());
                    break;
                case NotifyCollectionChangedAction.Remove:
                    foreach (Discipline item in e.OldItems)
                        foreach (var pair in keys)
                            if (pair.Value.Equals(item))
                                Disciplines_ListView.Items.Remove(pair.Key);
                    break;
                case NotifyCollectionChangedAction.Replace:
                    break;
                case NotifyCollectionChangedAction.Move:
                    break;
                case NotifyCollectionChangedAction.Reset:
                    Disciplines_ListView.Items.Clear();
                    break;
                default:
                    break;
            }
            Log(label2.Text);
        }

        private void Clock_Timer_Tick(object sender, EventArgs e)
        {
            Data_label.Text = DateTime.Now.ToString("G");
        }



        private void Add_Button_Click(object sender, EventArgs e)
        {
            bool Check(object o)
            {
                var results = new List<ValidationResult>();
                var context = new ValidationContext(o);
                var discipline = o as Discipline;
                if (!Validator.TryValidateObject(o, context, results, true) || (discipline.LecturesAmt < 0 ||
                    discipline.LecturesAmt > 30 || discipline.LabsAmt < 0 || discipline.LabsAmt > 30)
)
                {
                    string strWithError = "";
                    foreach (var error in results)
                    {
                        strWithError += error.ErrorMessage;
                    }

                    MessageBox.Show(strWithError + "Неверно введены значения");
                    return false;
                }
                else
                    return true;
            }

            CheckFields();
            var newItem = CollectData();
            if (newItem == null)
                return;

            if (disciplines.Any(item => item.Equals(newItem)))
            {
                MessageBox.Show("Такой элемент уже есть в таблице");
                return;
            }
            if (Check(newItem))
            {
                disciplines.Add(newItem);
            }
            ResetFields();
        }

        private void Change_Button_Click(object sender, EventArgs e)
        {

            if (currentDiscipline == null)
            {
                MessageBox.Show("Ничего не выбрано");
                return;
            }
            CheckFields();
            if (!correct)
            {
                MessageBox.Show("Значения введены неверно");
                return;
            }

            var newItem = CollectData();
            if (currentDiscipline.Equals(newItem))
            {
                MessageBox.Show("Нечего менять");
                return;
            }
            disciplines.Remove(currentDiscipline);
            currentDiscipline = newItem;
            disciplines.Add(currentDiscipline);
        }

        private void Remove_Button_Click(object sender, EventArgs e)
        {
            if (currentDiscipline == null)
            {
                MessageBox.Show("Не выбран элемент для удаления");
                return;
            }

            disciplines.Remove(currentDiscipline);
            currentDiscipline = null;
        }

        private void Preset_Button_Click(object sender, EventArgs e)
        {
            Preset();
        }

        private void Reset_Button_Click(object sender, EventArgs e)
        {
            ResetFields();
        }

        private void Clear_ToolLabel_Click(object sender, EventArgs e)
        {
            Lectures.Clear();
        }

        private void PrintJson_Button_Click(object sender, EventArgs e)
        {
            Json_TextBox.Text = JsonConvert.SerializeObject(disciplines);
        }

        private void Save_Button_Click(object sender, EventArgs e)
        {
            var fileName = "save.json";

            var dialog = new SaveFileDialog
            {
                FileName = fileName
            };

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                using (var sw = new StreamWriter(dialog.FileName))
                {
                    sw.Write(JsonConvert.SerializeObject(disciplines));
                }
            }
        }

        private void Load_Button_Click(object sender, EventArgs e)
        {
            var dialog = new OpenFileDialog();

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    using (var sr = new StreamReader(dialog.FileName))
                    {
                        string sd = sr.ReadToEnd();
                        var items = JsonConvert.DeserializeObject<List<Discipline>>(sd);
                        foreach (var item in items)
                            disciplines.Add(item);
                    }
                }
                catch
                {
                    MessageBox.Show("Данные в файле имеют неверный формат");
                }
            }
        }

        private void Disciplines_ListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            var list = sender as ListView;

            if (list.SelectedItems.Count == 0 ||
                list.SelectedItems[0].Text == "")
            {
                currentDiscipline = null;
                return;
            }

            // keys словарь для listviewItem и Discipline
            currentDiscipline = keys[(sender as ListView).SelectedItems[0]];
            FillFields(currentDiscipline);
            snapshot = CollectData();
        }

        private void AddToTableRange(IEnumerable<Discipline> disciplines)
        {
            foreach (var discipline in disciplines)
                AddToTable(discipline);
        }

        private void AddToTable(Discipline discipline)
        {
            var item = new ListViewItem(discipline.Name);
            item.SubItems.Add(discipline.Course.ToString());
            item.SubItems.Add(discipline.Semester.ToString());
            item.SubItems.Add(discipline.Test);
            item.SubItems.Add(discipline.LecturesAmt.ToString());
            item.SubItems.Add(discipline.LabsAmt.ToString());
            item.SubItems.Add(discipline.Specialty);
            item.SubItems.Add(discipline.Lecturer.FullName);
            item.SubItems.Add(discipline.Lecturer.Chair);
            item.SubItems.Add(discipline.Lecturer.Step);

            keys.Add(item, discipline);
            Disciplines_ListView.Items.Add(item);
        }

        private Discipline CollectData()
        {
            if (!correct)
                return null;

            string name = Name_TextBox.Text;
            int course = Convert.ToInt32(Course_ComboBox.Text);
            string semester = Sem1_CheckBox.Checked ? Sem1_CheckBox.Text : Sem2_CheckBox.Text;
            string test = Test_ListBox.Text;
            int lecturesAmt = Convert.ToInt32(LecturesAmt_TextBox.Text);
            int labsAmt = Convert.ToInt32(LabsAmt_TextBox.Text);
            string specialty = Specialization_ComboBox.Text;
            var rb = RadioButtons.Where(item => item.Checked).First();
            ILecturer lecturer = Lectures.Where(item => item.FullName == rb.Text).First();

            disciplineBuilder.Reset();

            disciplineBuilder.BuildName(name);
            disciplineBuilder.BuildCourse(course);
            disciplineBuilder.BuildSemester(semester);
            disciplineBuilder.BuildTest(test);
            disciplineBuilder.BuildLecturesAmt(lecturesAmt);
            disciplineBuilder.BuildLabsAmt(labsAmt);
            disciplineBuilder.BuildSpeciality(specialty);
            disciplineBuilder.BuildLecturer(lecturer);

            return disciplineBuilder.GetResult();
        }

        private void FillFields(Discipline discipline)
        {
            if (discipline.Semester == "Первый")
            {
                Sem1_CheckBox.Checked = true;
                Sem2_CheckBox.Checked = false;
            }
            else
            {
                Sem1_CheckBox.Checked = false;
                Sem2_CheckBox.Checked = true;
            }
            Course_ComboBox.SelectedIndex = discipline.Course - 1;
            Specialization_ComboBox.SelectedIndex =
                Specialization_ComboBox.Items.Cast<string>().ToList().IndexOf(discipline.Specialty);
            LecturesAmt_TextBox.Text = discipline.LecturesAmt.ToString();
            LabsAmt_TextBox.Text = discipline.LabsAmt.ToString();
            Test_ListBox.SelectedIndex =
                Test_ListBox.Items.Cast<string>().ToList().IndexOf(discipline.Test);
            RadioButtons.Where(item => item.Text == discipline.Lecturer.FullName).First().Checked = true;
            Name_TextBox.Text = discipline.Name;
        }

        private void ResetFields()
        {
            LabsAmt_TextBox.Text = "";
            LecturesAmt_TextBox.Text = "";
            Sem1_CheckBox.Checked = false;
            Sem2_CheckBox.Checked = false;
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
            radioButton4.Checked = false;
            radioButton5.Checked = false;
            Course_ComboBox.Text = "";
            Specialization_ComboBox.Text = "";
            Test_ListBox.SelectedIndex = -1;
            Name_TextBox.Text = "";
        }

        private void Preset()
        {
            Sem1_CheckBox.Checked = true;
            Course_ComboBox.SelectedIndex = 1;
            Specialization_ComboBox.SelectedIndex = 1;
            LecturesAmt_TextBox.Text = "1";
            LabsAmt_TextBox.Text = "1";
            Test_ListBox.SelectedIndex = 1;
            radioButton1.Checked = true;
            Name_TextBox.Text = "Test";
        }


        private void Search_button_Click(object sender, EventArgs e)
        {

            if (radioCourse.Checked)
            {
                var resList = new List<Discipline>();
                Regex Course = new Regex("^[1-4]$");

                try
                {
                    foreach (var item in disciplines)
                    {
                        if (Course.IsMatch(SearchBox.Text))
                        {
                            if (Convert.ToInt32(SearchBox.Text) == item.Course)
                                resList.Add(item);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Поиск по курсу производится числом");
                }
                if (resList.Count() != 0)
                {
                    var form = new Form2(resList);
                    form.ShowDialog();
                }
                else
                    MessageBox.Show("Ничего не найдено");
            }

            else if (radioSemestr.Checked)
            {
                Regex Semester = new Regex("^[A-Я]|[а-я]$");
                Regex SemesterFirst = new Regex("^[П|п]{1}");
                Regex SemesterSecond = new Regex("^[В|в]{1}");

                if (Semester.IsMatch(SearchBox.Text))
                {
                    var resList = new List<Discipline>();
                    if (SemesterFirst.IsMatch(SearchBox.Text))
                    {
                        foreach (var item in disciplines)
                        {
                            if (SemesterFirst.IsMatch(item.Semester))
                                resList.Add(item);
                        }
                    }
                    if (SemesterSecond.IsMatch(SearchBox.Text))
                    {
                        foreach (var item in disciplines)
                        {
                            if (SemesterSecond.IsMatch(item.Semester))
                                resList.Add(item);
                        }
                    }
                    if (resList.Count() != 0)
                    {
                        var form = new Form2(resList);
                        form.ShowDialog();
                    }
                    else
                        MessageBox.Show("Ничего не найдено");
                }
            }
            else if (radioLector.Checked)
            {
                Regex Lector = new Regex("^([А-Я]|[A-Z])[а-я]{1,15} [А-Я][а-я]{1,15} [А-Я][а-я]{1,15}$");
                Regex Sm = new Regex("^[С|с]{1}");
                Regex Gil = new Regex("^[Ж|ж]{1}");
                Regex Pyst = new Regex("^[П|п]{1}");
                Regex Yrb = new Regex("^[У|у]{1}");
                Regex Kol = new Regex("^[К|к]{1}");
                var resList = new List<Discipline>();
                if (Sm.IsMatch(SearchBox.Text))
                {
                    foreach (var item in disciplines)
                    {
                        if (Sm.IsMatch(item.Lecturer.FullName))
                            resList.Add(item);
                    }
                }
                if (Gil.IsMatch(SearchBox.Text))
                {
                    foreach (var item in disciplines)
                    {
                        if (Gil.IsMatch(item.Lecturer.FullName))
                            resList.Add(item);
                    }
                }
                if (Yrb.IsMatch(SearchBox.Text))
                {
                    foreach (var item in disciplines)
                    {
                        if (Yrb.IsMatch(item.Lecturer.FullName))
                            resList.Add(item);
                    }
                }
                if (Pyst.IsMatch(SearchBox.Text))
                {
                    foreach (var item in disciplines)
                    {
                        if (Pyst.IsMatch(item.Lecturer.FullName))
                            resList.Add(item);
                    }
                }
                if (Kol.IsMatch(SearchBox.Text))
                {
                    foreach (var item in disciplines)
                    {
                        if (Kol.IsMatch(item.Lecturer.FullName))
                            resList.Add(item);
                    }
                }
                if (resList.Count() != 0)
                {
                    var form = new Form2(resList);
                    form.ShowDialog();
                }
                else
                    MessageBox.Show("Ничего не найдено");
            }
        }

        private void toolStripLabelSearch_Click(object sender, EventArgs e)
        {
            if (radioCourse.Checked)
            {
                var resList = new List<Discipline>();
                Regex Course = new Regex("^[1-4]$");
                try
                {
                    foreach (var item in disciplines)
                    {
                        if (Course.IsMatch(SearchBox.Text))
                        {
                            if (Convert.ToInt32(SearchBox.Text) == item.Course)
                                resList.Add(item);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Поиск по курсу производится числом");
                }
                if (resList.Count() != 0)
                {
                    var form = new Form2(resList);
                    form.ShowDialog();
                }
                else
                    MessageBox.Show("Ничего не найдено");
            }
            else if (radioSemestr.Checked)
            {
                Regex Semester = new Regex("^[A-Я]|[а-я]$");
                Regex SemesterFirst = new Regex("^[П|п]{1}");
                Regex SemesterSecond = new Regex("^[В|в]{1}");

                if (Semester.IsMatch(SearchBox.Text))
                {
                    var resList = new List<Discipline>();
                    if (SemesterFirst.IsMatch(SearchBox.Text))
                    {
                        foreach (var item in disciplines)
                        {
                            if (SemesterFirst.IsMatch(item.Semester))
                                resList.Add(item);
                        }
                    }
                    if (SemesterSecond.IsMatch(SearchBox.Text))
                    {
                        foreach (var item in disciplines)
                        {
                            if (SemesterSecond.IsMatch(item.Semester))
                                resList.Add(item);
                        }
                    }
                    if (resList.Count() != 0)
                    {
                        var form = new Form2(resList);
                        form.ShowDialog();
                    }
                    else
                        MessageBox.Show("Ничего не найдено");
                }
            }
            else if (radioLector.Checked)
            {
                Regex Lector = new Regex("^([А-Я]|[A-Z])[а-я]{1,15} [А-Я][а-я]{1,15} [А-Я][а-я]{1,15}$");
                Regex Sm = new Regex("^[С|с]{1}");
                Regex Gil = new Regex("^[Ж|ж]{1}");
                Regex Pyst = new Regex("^[П|п]{1}");
                Regex Yrb = new Regex("^[У|у]{1}");
                Regex Kol = new Regex("^[К|к]{1}");
                var resList = new List<Discipline>();
                if (Sm.IsMatch(SearchBox.Text))
                {
                    foreach (var item in disciplines)
                    {
                        if (Sm.IsMatch(item.Lecturer.FullName))
                            resList.Add(item);
                    }
                }
                if (Gil.IsMatch(SearchBox.Text))
                {
                    foreach (var item in disciplines)
                    {
                        if (Gil.IsMatch(item.Lecturer.FullName))
                            resList.Add(item);
                    }
                }
                if (Yrb.IsMatch(SearchBox.Text))
                {
                    foreach (var item in disciplines)
                    {
                        if (Yrb.IsMatch(item.Lecturer.FullName))
                            resList.Add(item);
                    }
                }
                if (Pyst.IsMatch(SearchBox.Text))
                {
                    foreach (var item in disciplines)
                    {
                        if (Pyst.IsMatch(item.Lecturer.FullName))
                            resList.Add(item);
                    }
                }
                if (Kol.IsMatch(SearchBox.Text))
                {
                    foreach (var item in disciplines)
                    {
                        if (Kol.IsMatch(item.Lecturer.FullName))
                            resList.Add(item);
                    }
                }
                if (resList.Count() != 0)
                {
                    var form = new Form2(resList);
                    form.ShowDialog();
                }
                else
                    MessageBox.Show("Ничего не найдено");
            }
        }

        private void toolStripLabelClear_Click(object sender, EventArgs e)
        {
            ResetFields();
        }

        private void toolStripLabelDelete_Click(object sender, EventArgs e)
        {
            if (currentDiscipline == null)
            {
                MessageBox.Show("Не выбран элемент для удаления");
                return;
            }

            disciplines.Remove(currentDiscipline);
            currentDiscipline = null;
        }

        private void toolStripLabelNext_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < (Disciplines_ListView.Items.Count - 1); i++)
            {
                if (Disciplines_ListView.Items[i].Selected == true)
                {
                    Disciplines_ListView.Items[i].Selected = false;
                    Disciplines_ListView.Items[i + 1].Selected = true;
                    break;
                }
            }
        }

        private void toolStripLabelPrevious_Click(object sender, EventArgs e)
        {
            try
            {
                for (int i = 0; i < (Disciplines_ListView.Items.Count); i++)
                {
                    if (Disciplines_ListView.Items[i].Selected == true)
                    {
                        Disciplines_ListView.Items[i].Selected = false;
                        Disciplines_ListView.Items[i - 1].Selected = true;
                        break;
                    }
                }
            }
            catch
            {
                Disciplines_ListView.Items[0].Selected = true;
            }
        }

        private void toolStripLabelAbout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Владислав Симакович \nVisual studio 2019");
        }

        private void buttonSortLc_Click(object sender, EventArgs e)
        {
            var resList = new List<Discipline>();
            foreach (var item in disciplines)
            {
                resList.Add(item);
            }
            Disciplines_ListView.Items.Clear();
            var testSort = from key in resList
                           orderby key.LecturesAmt ascending
                           select key;
            AddToTableRange(testSort);
        }

        private void buttonSortName_Click(object sender, EventArgs e)
        {
            var resList = new List<Discipline>();
            foreach (var item in disciplines)
            {
                resList.Add(item);
            }
            Disciplines_ListView.Items.Clear();
            var testSort = from key in resList
                           orderby key.Test ascending
                           select key;
            AddToTableRange(testSort);
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        public bool Check(object o)
        {
            var results = new List<ValidationResult>();
            var context = new ValidationContext(o);
            if (!Validator.TryValidateObject(o, context, results, true))
            {
                string strWithError = "";
                foreach (var error in results)
                {
                    strWithError += error.ErrorMessage;
                }

                MessageBox.Show(strWithError);
                return false;
            }
            else
                return true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (toolStrip1.Visible)
            {
                toolStrip1.Hide();
                button1.Text = "Отобразить";
            }
            else
            {
                toolStrip1.Show();
                button1.Text = "Скрыть";
            }
        }

        private void Clone_Button_Click(object sender, EventArgs e)
        {
            if (currentDiscipline == null)
            {
                MessageBox.Show("Ничего не выбрано");
                return;
            }

            var newDiscipline = currentDiscipline.Clone();
            disciplines.Add(newDiscipline);
        }
    }

    public class UserValidationAttribute : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            var discipline = value as Discipline;
            if (discipline.LecturesAmt < 0 && discipline.LecturesAmt > 30 && discipline.LabsAmt < 0 && discipline.LabsAmt > 30)
            {
                ErrorMessage = "Неверное число лекций/лабораторных";
                return false;
            }
            return true;
        }
    }

    //public enum LecturerType
    //{
    //    Доцент,
    //    Профессор
    //}
    //public class Lecturer
    //{
    //    public string Chair { get; set; }
    //    public string FullName { get; set; }
    //    public LecturerType Type;

    //    public Lecturer(string chair, string fullname, LecturerType type)
    //    {   
    //        Chair = chair;
    //        FullName = fullname;
    //        Type = type; 
    //    }
    //}

    //public List<Lecturer> ConvertTo(List<ILecturer> list)
    //{
    //    var listt = new List<Lecturer>();
    //    foreach (var item in listt)
    //    {
    //        if (item is AssociateLecturer)
    //            listt.Add(new Lecturer(item.Chair, item.FullName,LecturerType.Доцент));
    //        else
    //            listt.Add(new Lecturer(item.Chair, item.FullName, LecturerType.Профессор));
    //}
    //    return listt;
    //}
    
    //public List<ILecturer> ConvertFrom(List<Lecturer> list)
    //{
    //    var listt = new List<ILecturer>();
    //    foreach (var item in list)
    //    {
    //        if (item.Type == LecturerType.Доцент)
    //            listt.Add(new Доцент(item.Chair,item.FullName,LecturerType.Доцент));
    //        else
    //            listt.Add(new Профессор(item.Chair, item.FullName, LecturerType.Профессор));
    //    }
    //    return listt;
    //}
}
