using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.IO;

namespace @Class2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Human> listHuman = new List<Human>();
            Adress add1 = new Adress("Ukraine", "Kherson", "Perekopskaya", 3);
            Human one = new Human("Alesia", "Tantsiurenko", 19, 1.84, 60, false, Nation.Ukranian, add1);
            Human two = new Human("Alex", "Ker", 18, 1.84, 100, true, Nation.Polish, new Adress("Polish", "Jahj", "Thgg", 5));
            Human tree = new Human("Fernando", "Forg", 25, 1.70, 70, true, Nation.French, new Adress("France", "Niol", "Suf", 9));
            Human four = new Human("Marta", "Nanti", 15, 1.60, 38, false, Nation.German, new Adress("Germany", "Natf", "Rolt", 52));

            listHuman list = new listHuman();
            list.add(one);
            list.add(two);
            list.add(tree);
            list.add(four);

            listTeacher listTeacher = new listTeacher();
            Student st_one = new Student("Rita", "Ora", 20, 1.83, 63, false, Nation.French, new Adress("France", "Paris", "Brovera", 7), 241, 5000);
            Student st_two = new Student("Franc", "Antua", 18, 1.83, 63, false, Nation.German, new Adress("Germany", "Nolt", "Brovera", 7), 241, 5000);
            Student st_three = new Student("Rinata", "Jane", 17, 1.83, 63, false, Nation.French, new Adress("France", "Paris", "Brovera", 7), 241, 5000);
            Teacher one_th = new Teacher("Antua", "Jarjo", 21, 1.83, 63, false, Nation.French, new Adress("France", "Paris", "Brovera", 7), 30000, "FKNFM");
            one_th.add(st_one);
            one_th.add(st_two);
            one_th.add(st_three);
            one_th.show();
            Teacher two_th = new Teacher("Jack", "Li", 16, 1.83, 63, false, Nation.French, new Adress("France", "Paris", "Brovera", 7), 30000, "FKNFM");
            listTeacher.add(one_th);
            listTeacher.add(two_th);
            listTeacher.show();
            listTeacher.save_list();

            list.save_txt("C:\\Test.txt");
            /*
            
            Console.WriteLine("Выберите действие ");
            Console.WriteLine("1 - распечатать все объекты");
            Console.WriteLine("2 - найти объект по имени");
            Console.WriteLine("3 - средний возраст");
            Console.WriteLine("4 - сортировка по возрасту");
            int i = int.Parse(Console.ReadLine());
            switch (i)
            {
                case 1:
                    list.show();
                    break;
                case 2:
                    Console.WriteLine("Введите имя ");
                    string name = Console.ReadLine();
                    list.findName(name);
                    break;
                case 3:
                    list.average_age();
                    break;
                case 4:
                    list.sort_age();
                    break;
                default:
                    Console.WriteLine("Вы ввели неверный номер!");
                    break;
            */

        }
    }

}
