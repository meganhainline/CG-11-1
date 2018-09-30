using System;
using System.IO;
using System.Collections.Generic;

namespace CG_11_1
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader file = new StreamReader("C:\\Users\\megha\\source\\repos\\CG 11-1\\CG 11-1\\StudentData.txt");

            List<Student> students = new List<Student>();

            string line;

            while ((line = file.ReadLine()) != null)
            {
                string[] items = line.Split(" ");
                Student student = new Student(items[0]);

                for (int i = 1; i < items.Length; i++)
                {
                    student.AddScore(Int32.Parse(items[i]));
                }

                students.Add(student);
            }
            
            foreach (Student item in students)
            {
                if (item.SixOrGreater())
                    Console.WriteLine(item.Name);
            }
            Console.ReadLine();
        }
    }
}
