using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class2
{
    struct UDC
    {
        private int id;
        private string udc;

        public UDC(int id, string udc)
        {
            this.id = id;
            this.udc = udc;
        }
        public int ID
        {
            get { return id; }
            set { id = value; }
        }
        public string Udc
        {
            get { return udc; }
            set { udc = value; }
        }
        public string printInfo()
        {
            return "Id: " + this.id.ToString() + "\n" + "Name: " + this.udc;
        }
            
    }
    class CourseWorks
    {
        private string description;
        private string name;
        private DateTime date;
        private UDC udc;
        public CourseWorks(string description, string name, DateTime date, UDC udc)
        {
            this.description = description;
            this.name = name;
            this.date = date;
            this.udc = udc;
        }

        public void printinfo()
        {
            string text = "Description: " + description + "\n" +
                 "Name: " + name + "\n" +
                 "Date: " + date + "\n" +
                 "UDC: " + udc + "\n";
            Console.WriteLine(text);
        }
        public string strinfo()
        {
            return "Description: " + description + "\n" +
                 "Name: " + name + "\n" +
                 "Date: " + date + "\n" +
                 "UDC: " + udc + "\n";
        }

        public string Description
        {
            get { return description; }
            set { description = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public DateTime Date
        {
            get { return date; }
            set { date = value; }
        }
        public UDC Udc
        {
            get { return udc; }
            set { udc = value; }
        }
    }
}
