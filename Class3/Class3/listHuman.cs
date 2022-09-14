using System;
using System.Collections.Generic;
using System.Linq;

namespace @Class3
{
    class listHuman
    {
        private List<Human> listHumans;

        public listHuman()
        {
            listHumans = new List<Human>();
        }
        public void add(Human human)
        {
            listHumans.Add(human);
        }
        public void show()
        {
            for (int n = 0; n < listHumans.Count(); n++)
            {
                // Первый способ удаления (создательсам выберает индех)
                // int indexToRemove = 0;
                // listHumans.RemoveAt(indexToRemove);
                // Console.WriteLine(String.Join(", ", listHumans));
                listHumans[n].printInfo();

            }
                
        }
        public void delete()
        {   // Второй способ удаления (пользователь вводит индех того кого хочет удалить)
            Console.WriteLine("\nУ Вас " + listHumans.Count() + " человек(а) \nВведите от 1 до " + listHumans.Count());
            int i = int.Parse(Console.ReadLine());
            listHumans.RemoveAt(i-1);
            this.show();
        }

    }

}

