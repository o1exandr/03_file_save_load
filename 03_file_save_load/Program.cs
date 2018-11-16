/*
 3. Створити клас, який містить методи для запису у текстовий файл та відновлення з файлу екземпляру класу Студент

class FileWorker
{
 public static  void SaveStudent(Student student, string filename)
{......}

public static  void LoadStudent(Student student, string filename)
{......}
}
 */


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace _03_file_save_load
{
    class Program
    {
        class Student
        {
            public string Name { get; set; }
            public int Age { get; set; }

            public Student(string n = "unknown", int a = 17)
            {
                Name = n;
                Age = a;
            }

            public override string ToString()
            {
                return $"Name:\t{Name}\tAge:\t{Age}";
            }

        }

        class FileWorker
        {
            public static void SaveStudent(Student student, string filename = "student.dat")
            {
                /*
                byte[] name = Encoding.UTF8.GetBytes(student.Name);
                byte[] age = Encoding.UTF8.GetBytes(Convert.ToByte(student.Age));

                using (FileStream fs = new FileStream("fileName", FileMode.Create))
                {
                    fs.Write(wname, 0, wname.Length);
                    fs.Write(space, 0, space.Length);
                    fs.Write(wsurname, 0, wsurname.Length);
                }

                using (FileStream fs = new FileStream("fileName", FileMode.Open))
                {
                    byte[] rsname = new byte[fs.Length];
                    fs.Read(rsname, 0, rsname.Length);

                    string str = Encoding.UTF8.GetString(rsname);
                    Console.Write("{0}", str);
                    Console.WriteLine();
                }
                */
            }

            public static void LoadStudent(Student student, string filename)
            {
               
               
            }
        }

        static void Main(string[] args)
        {

            List<Student> list = new List<Student>();
            var result = new List<Student>();
            list.Add(new Student("John", 17));
            list.Add(new Student("Ted", 40));
            list.Add(new Student("Will", 25));
            foreach(var l in list)
                Console.WriteLine(l);
    
            //FileWorker.SaveStudent(s1);

            Console.ReadKey();
        }
    }
}
