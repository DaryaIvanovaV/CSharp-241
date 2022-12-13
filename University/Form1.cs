using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace University
{
    public partial class Form1 : Form
    {
        private int i = 0;
        private Dictionary<int, Human> HumanDict = new Dictionary<int, Human>();
        private listHuman listHuman = new listHuman();
        private Dictionary<int, Student> StudentDict = new Dictionary<int, Student>();
        private listStudent listStudent = new listStudent();
        private Dictionary<int, Teacher> TeacherDict = new Dictionary<int, Teacher>();
        private listTeacher listTeacher = new listTeacher();
        public Form1()
        {
            InitializeComponent();
        }
        private Gender GenderChoice()
        {
            RadioButton male = (RadioButton)MaleradioButton;
            RadioButton female = (RadioButton)FemaleradioButton;
            if (male.Checked) { return Gender.Male; }
            if (female.Checked) { return Gender.Female; }
            return 0;
        }
        private Nation NationChoice()
        {
            if (NationcomboBox.SelectedIndex == 0) { return Nation.Ukranian; }
            if (NationcomboBox.SelectedIndex == 1) { return Nation.French; }
            if (NationcomboBox.SelectedIndex == 2) { return Nation.Polish; }
            if (NationcomboBox.SelectedIndex == 3) { return Nation.German; }
            return 0;
        }
        private Gender GenderChoiceS()
        {
            RadioButton male = (RadioButton)MaleSradioButton;
            RadioButton female = (RadioButton)FamelSradioButton;
            if (male.Checked) { return Gender.Male; }
            if (female.Checked) { return Gender.Female; }
            return 0;
        }
        private Nation NationChoiceS()
        {
            if (NationStudentscomboBox.SelectedIndex == 0) { return Nation.Ukranian; }
            if (NationStudentscomboBox.SelectedIndex == 1) { return Nation.French; }
            if (NationStudentscomboBox.SelectedIndex == 2) { return Nation.Polish; }
            if (NationStudentscomboBox.SelectedIndex == 3) { return Nation.German; }
            return 0;
        }
        private Key KeyChoice()
        {
            if (KeycomboBox.SelectedIndex == 0) { return Key.csharp; }
            if (KeycomboBox.SelectedIndex == 1) { return Key.python; }
            if (KeycomboBox.SelectedIndex == 2) { return Key.java; }
            if (KeycomboBox.SelectedIndex == 3) { return Key.JS; }
            return 0;
        }
        private Gender GenderChoiceT()
        {
            RadioButton male = (RadioButton)MaleTradioButton;
            RadioButton female = (RadioButton)FamaleTradioButton;
            if (male.Checked) { return Gender.Male; }
            if (female.Checked) { return Gender.Female; }
            return 0;
        }
        private Nation NationChoiceT()
        {
            if (NationTeacherscomboBox.SelectedIndex == 0) { return Nation.Ukranian; }
            if (NationTeacherscomboBox.SelectedIndex == 1) { return Nation.French; }
            if (NationTeacherscomboBox.SelectedIndex == 2) { return Nation.Polish; }
            if (NationTeacherscomboBox.SelectedIndex == 3) { return Nation.German; }
            return 0;
        }
        private KeyWords KeyWordsChoice()
        {
            if (KeycomboBox.SelectedIndex == 0) { return KeyWords.csharp; }
            if (KeycomboBox.SelectedIndex == 1) { return KeyWords.python; }
            if (KeycomboBox.SelectedIndex == 2) { return KeyWords.java; }
            if (KeycomboBox.SelectedIndex == 3) { return KeyWords.JS; }
            return 0;
        }
        private void AddHumansbutton_Click(object sender, EventArgs e)
        {
            HumanDict.Add(i, new Human(NameHumanstextBox.Text, SurnameHumanstextBox.Text, int.Parse(AgeHumanstextBox.Text),
                    HabbitsHumanscheckBox.Checked, GenderChoice(), NationChoice(), new Adress(CountryHumanstextBox.Text, 
                    CityHumanstextBox.Text, StreetHumanstextBox.Text, int.Parse(HouseHumanstextBox.Text)), 
                    EmailHumanstextBox.Text));
            listHuman.add(HumanDict[i]);
            listHuman.TextsWriter("Humans.txt");
            i++;
        }

        private void AddStudentsbutton_Click(object sender, EventArgs e)
        {
            StudentDict.Add(i, new Student(NameStudentstextBox.Text, SurnameStudentstextBox.Text, 
                    int.Parse(AgeStudentstextBox.Text), HabbitsStudentscheckBox.Checked, GenderChoiceS(), 
                    NationChoiceS(), new Adress(CountryStudentstextBox.Text, CityStudentstextBox.Text, 
                    StreetStudentstextBox.Text, int.Parse(HouseStudentstextBox.Text)), EmailStudentstextBox.Text, 
                    int.Parse(GroupStudentstextBox.Text), int.Parse(MoneyStudentstextBox.Text), KeyChoice()));
            listStudent.add(StudentDict[i]);
            listStudent.TextsWriter("Students.txt");
            i++;

        }
        private void AddTeachersbutton_Click(object sender, EventArgs e)
        {
            TeacherDict.Add(i, new Teacher(NameTeacherstextBox.Text, SurnameTeacherstextBox.Text,
                    int.Parse(AgeTeacherstextBox.Text), HabbitsTeacherscheckBox.Checked, GenderChoiceT(),
                    NationChoiceT(), new Adress(CountryTeacherstextBox.Text, CityTeacherstextBox.Text,
                    StreetTeacherstextBox.Text, int.Parse(HouseTeacherstextBox.Text)), EmailTeacherstextBox.Text,
                    int.Parse(SalaryTeacherstextBox.Text), DepartmentTeacherstextBox.Text, 
                    int.Parse(NumberOfSeatsTeacherstextBox.Text), KeyWordsChoice()));
            listTeacher.add(TeacherDict[i]);
            listTeacher.TextsWriter("Teachers.txt");
            i++;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            //this.tabPage1.Text = "student"

        }


    }
}