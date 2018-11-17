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
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace _03_file_save_load
{
    [Serializable]
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
        public static void SaveStudent(Student student, string filename = "student.txt")
        {

            BinaryFormatter formatter = new BinaryFormatter();
            using (FileStream fs = new FileStream(filename, FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, student);
                Console.WriteLine($"Record:\n{student}\nSave to file {filename}\n");
            }
        }

        public static void LoadStudent(Student student, string filename = "student.txt")
        {
            BinaryFormatter formatter = new BinaryFormatter();
            using (FileStream fs = new FileStream(filename, FileMode.OpenOrCreate))
            {
                student = (Student)formatter.Deserialize(fs);
                Console.WriteLine($"Record:\n{student}\nLoad from file {filename}\n");
            }

        }
    }
    class Program
    {
      
        static void Main(string[] args)
        {

            Student student = new Student("John", 17);
            FileWorker.SaveStudent(student);
            Student st = new Student();
            FileWorker.LoadStudent(st);

            Console.ReadKey();
        }
    }
}
