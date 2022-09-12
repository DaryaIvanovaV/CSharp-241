using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.IO;

namespace @Class2
{
    class listTeacher
    {
        private List<Teacher> list;
        public listTeacher()
        {
            list = new List<Teacher>();
        }

        public void add(Teacher human)
        {
            list.Add(human);
        }
        public void show()
        {
            for (int n = 0; n < list.Count(); n++)
                list[n].printInfo();
        }
        public List<Teacher> List
        {
            get { return list; }
            set { list = value; }
        }
        public void save_list()
        {
            string fileName = "Student.json";
            string jsonString = JsonSerializer.Serialize(this.list);
            File.WriteAllText(fileName, jsonString);

            Console.WriteLine(File.ReadAllText(fileName));
        }
        public string t_txt()
        {
            string res = "";
            for(int n = 0; n < list.Count(); n++)
                res += list[n].toStr();
            return res;
        }
    }
}

