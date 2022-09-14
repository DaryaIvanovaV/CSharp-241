using System;

namespace @Class3
{
	public class Human
    {
		private string name;
		private string surname;
		private Adress adress;

        public Human()
        {
            Console.WriteLine("Создание объекта Person");
            this.name = "Dasha";
            this.surname = "Ivanova";
        }
        public Human(string name, string surname, Adress adress)
	    {
            this.name = name;
            this.surname = surname;
            this.adress = adress;
	    }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Surname
        {
            get { return surname; }
            set { surname = value; }
        }
        public virtual void printInfo()
        {
            string data =
                "Name: " + this.name + "\n" +
                "Surname: " + this.surname + "\n" +
                "Adress: " + this.adress.toString();
            Console.WriteLine(data);
        }
        public virtual string toStr()
        {
            string str;
            str = "Name: " + this.name + "\n" +
                "Surname: " + this.surname;
            return str;
        }
    }

}

