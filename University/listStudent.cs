using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University
{
    internal class listStudent
    {
        private List<Student> listStudents;

        public listStudent()
        {
            listStudents = new List<Student>();
        }
        public void add(Student student)
        {
            listStudents.Add(student);
        }
        public void show()
        {
            for (int n = 0; n < listStudents.Count(); n++)
                listStudents[n].printInfo();
        }
        public string show(int a)
        {
            string data = "";
            for (int n = 0; n < listStudents.Count(); n++)
                data += listStudents[n].toStr();
            return data;
        }
        public string save_txt()
        {
            string res = "";
            for (int n = 0; n < listStudents.Count; n++)
            {
                res += listStudents[n].toStr();
                res += "\n";
            }
            return res;
        }
        public void TextsWriter(string url)
        {
            StreamWriter sw = new StreamWriter(url);
            sw.WriteLine(save_txt());
            sw.Close();
        }

    }
}
