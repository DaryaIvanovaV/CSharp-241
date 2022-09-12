using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace @Class2
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
                listHumans[n].printInfo();
        }
        public string show(int a)
        {
            string data = "";
            for (int n = 0; n < listHumans.Count(); n++)
                data += listHumans[n].toStr();
            return data;
        }
        public void findCountry_Nation(string str)
        {
            for (int n = 0; n < listHumans.Count(); n++)
                if (listHumans[n].Adress.Country == str &&
                    listHumans[n].Nation.ToString() == "Ukranian")
                    listHumans[n].printInfo();
        }
        public void findName(string str)
        {
            for (int n = 0; n < listHumans.Count(); n++)
            {
                if (listHumans[n].Name == str)
                    listHumans[n].printInfo();
            }

        }
        public void sort_age()
        {
            int len_hum = listHumans.Count();
            double[] sort = new double[len_hum];
            int[] count_hum = new int[len_hum];
            for (int i = 0; i < len_hum; i++)
            {
                count_hum[i] = i;
                sort[i] = listHumans[i].Age;
            }
            int j = len_hum - 1;
            for (int b = 0; b < j; b++)
            {
                for (int n = j; n != 0; n--)
                {
                    if (sort[n] < sort[n - 1])
                    {
                        double temp = sort[n];
                        sort[n] = sort[n - 1];
                        sort[n - 1] = temp;
                        int temp_count = count_hum[n];
                        count_hum[n] = count_hum[n - 1];
                        count_hum[n - 1] = temp_count;
                    }
                }
            }
            if (listHumans.Count() != 0)
            {
                Console.WriteLine("Список отсортирован");
                for (int k = listHumans.Count() - 1; k >= 0; k--)
                {
                    listHumans[count_hum[k]].printInfo();
                }
            }
            else
            {
                Console.WriteLine("Список пустой");
            }
        }
        public void average_age()
        {
            int age = 0;
            for (int n = 0; n < listHumans.Count(); n++)
                age += listHumans[n].Age;
            if (listHumans.Count() != 0)
            {
                float result = age / listHumans.Count();
                Console.WriteLine(result);
            }
            else
            {
                Console.WriteLine("Список пустой");
            }

        }
        public void show(bool b)
        {
            foreach (Human obj in listHumans)
                obj.printInfo();
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
