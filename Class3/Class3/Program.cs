using System;
using System.Collections.Generic;
using System.Runtime.Serialization.Formatters;

namespace @Class3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Human> listHuman = new List<Human>();
            Human one = new Human("Dasha", "Ivanova", new Adress("Ukraine", "Kherson"));
            Human two = new Human("Alex", "Ker", new Adress("Ukraine", "Kherson"));
            Human three = new Human("Din", "Vin", new Adress("Ukraine", "Kherson"));
            Human four = new Human("Inna", "Valuan", new Adress("Ukraine", "Kherson"));

            
            listHuman list = new listHuman();
            list.add(one);
            list.add(two);
            list.add(three);
            list.add(four);
            list.show();
            list.delete();
        }
    }
}
