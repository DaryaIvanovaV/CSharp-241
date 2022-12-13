using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace University
{
    public enum Key { csharp, python, java, JS }
    class Student : Human
    {
        private int group;
        private int money;
        private Key key;

        public Student() : base()
        {

        }
        public Student(string name, string surname, int age, bool habbits,Gender gender, Nation nation, Adress adress, string email, int group, int money, Key key) : base (name, surname,
                age, habbits, gender, nation, adress, email)
        {
            this.group = group;
            this.money = money;
            this.key = key;
        }
        public override  void printInfo()
        {
            string data = base.toStr() + "\n" +
               "Group: " + this.group.ToString() + "\n" +
               "Money: " + this.money.ToString() + "\n" +
               "Key: " + this.key.ToString() + "\n";
            Console.WriteLine(data);

        }
        public override string toStr()
        {
            string str;
            str = base.toStr();
            str += "Group: " + this.group.ToString() + "\n" +
               "Money: " + this.money.ToString() + "\n" +
               "Key: " + this.key.ToString() + "\n";
            return str;
        }
        public int Group
        {
            get { return group; }
            set { group = value; }
        }
        public int Money
        {
            get { return money; }
            set { money = value; }
        }
        public Key Key
        {
            get { return key; }
            set { key = value; }

        }
    }
}
