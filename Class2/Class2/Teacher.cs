using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace @Class2
{
    public enum KeyWords { csharp, python, java, JS }
    class Teacher : Human
    {
        private int salary;
        private string department;
        private int numofseats;
        private KeyWords keywords;
        private List<Student> list;

        public Teacher() : base()
        {
            list = new List<Student>();
        }
        public Teacher(string name, string surname, int age, double height,
            double weight, bool habbits, Nation nation, Adress adress, string email, int salary, string department, int numofseats, KeyWords keywords) : base(name, surname,
                age, height, weight, habbits, nation, adress, email)
        {
            this.salary = salary;
            this.department = department;
            this.numofseats = numofseats;
            this.keywords = keywords;
            this.list = new List<Student>();
        }
        public void add(Student student)
        {
            if (check_numofset(student.Key.ToString()))
                list.Add(student);
            else
            {
                Console.WriteLine("Мест нет либо интересы не совпадают!");
            }
        }
        public void show()
        {
            for (int n = 0; n < list.Count(); n++)
                list[n].printInfo();
        }
        public override void printInfo()
        {
            string data = base.toStr() + "\n" +
               "Salary: " + this.salary.ToString() + "\n" +
               "Department: " + this.department + "\n" +
               "Number of set: " + this.numofseats.ToString() + "\n" +
                "Key: " + this.keywords.ToString() + "\n";
            Console.WriteLine(data);

        }
        public override string toStr()
        {
            string str;
            str = base.toStr();
            str += "Salary: " + this.salary.ToString() + "\n" +
               "Department: " + this.department + "\n" +
               "Number of set: " + this.numofseats.ToString() + "\n" +
                "Key: " + this.keywords.ToString() + "\n";
            return str;
        }
        
        public int Salary
        {
            get { return salary; }
            set { salary = value; }
        }
        public string Department
        {
            get { return department; }
            set { department = value; }
        }
        public List<Student> List
        {
            get { return list; }
            set { list = value; }
        }
        public int NumOfSeats
        {
            get { return numofseats; }
            set { numofseats = value; }
        }
        public KeyWords KeyWords
        {
            get { return keywords; }
            set { keywords = value; }
        }
        /*
        public void save_list()
        {
            string fileName = "Student.json";
            string jsonString = JsonSerializer.Serialize(this.list);
            File.WriteAllText(fileName, jsonString);

            Console.WriteLine(File.ReadAllText(fileName));
        }*/
        public string save_txt()
        {
            string res = "";
            for (int n = 0; n < list.Count; n++)
            {
                res += list[n].toStr();
                res += "\n";
            }
            return res;
        }
        public void TextsWriter(string url)
        {
            StreamWriter sw = new StreamWriter(url);
            sw.WriteLine(save_txt());
            sw.Close();
        }
        public bool check_numofset(string key)
        {
            bool flag = false;
            if ((list.Count < numofseats) && (key == keywords.ToString()))
                flag = true;
            else
            {
                flag = false;
            }
            return flag;
        }
    }
    
}

