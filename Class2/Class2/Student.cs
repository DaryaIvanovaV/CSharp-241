using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace @Class2
{
    class Student : Human
    {
        private int group;
        private int money;

        public Student() : base()
        {

        }
        public Student(string name, string surname, int age, double height, 
            double weight, bool habbits, Nation nation, Adress adress, int group, int money) : base (name, surname,
                age, height, weight, habbits, nation, adress)
        {
            this.group = group;
            this.money = money;
        }
        public override  void printInfo()
        {
            string data =
               "Name: " + this._name + "\n" +
               "Surname: " + this._surname + "\n" +
               "Age: " + this._age.ToString() + "\n" +
               "Height: " + this._height.ToString() + "\n" +
               "Weight: " + this._weight.ToString() + "\n" +
               "Is Habbits: " + this._habbits.ToString() + "\n" +
               "Group: " + this.group.ToString() + "\n" +
               "Money: " + this.money.ToString() + "\n";
            Console.WriteLine(data);

        }
        public override string toStr()
        {
            string str;
            str = base.toStr();
            str += "Group: " + this.group.ToString() + "\n" +
               "Money: " + this.money.ToString() + "\n";
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
    }
}
