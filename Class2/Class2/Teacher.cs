using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace @Class2
{
    class Teacher : Human
    {
        private int salary;
        private string department;
        private List<Student> list;

        public Teacher() : base()
        {
            list = new List<Student>();
        }
        public Teacher(string name, string surname, int age, double height,
            double weight, bool habbits, Nation nation, Adress adress, int salary, string department) : base(name, surname,
                age, height, weight, habbits, nation, adress)
        {
            this.salary = salary;
            this.department = department;
            this.list = new List<Student>();
        }
        public void add(Student human)
        {
            list.Add(human);
        }
        public void show()
        {
            for (int n = 0; n < list.Count(); n++)
                list[n].printInfo();
        }
        public override void printInfo()
        {
            string data =
               "Name: " + this._name + "\n" +
               "Surname: " + this._surname + "\n" +
               "Age: " + this._age.ToString() + "\n" +
               "Height: " + this._height.ToString() + "\n" +
               "Weight: " + this._weight.ToString() + "\n" +
               "Is Habbits: " + this._habbits.ToString() + "\n" +
               "Salary: " + this.salary.ToString() + "\n" +
               "Department: " + this.department + "\n";
            Console.WriteLine(data);

        }
        public override string toStr()
        {
            string str;
            str = base.toStr();
            str += "Salary: " + this.salary.ToString() + "\n" +
               "Department: " + this.department + "\n";
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
        public void save_txt(string url)
        {
                try
                {
                    
                    StreamWriter sw = new StreamWriter(url);
                    
                    //Write a line of text
                    sw.WriteLine("Hello World!!");
                    //Write a second line of text
                    sw.WriteLine("From the StreamWriter class");
                    //Close the file
                    sw.Close();
                }
                catch(Exception e)
                {
                    Console.WriteLine("Exception: " + e.Message);
                }
                finally
                {
                    Console.WriteLine("Executing finally block.");
                }

        }
    }
    
}

