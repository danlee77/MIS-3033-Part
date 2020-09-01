﻿using System;
using System.Collections.Generic;

namespace ClassesAndFiles
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();

            Student stud1 = new Student();
            stud1.name = "Daniel";
            stud1.id = 2;
            students.Add(stud1);

            Student stud2 = new Student("Adam", 1);
            students.Add(stud2);

            foreach (var stud in students)
            {

                Console.WriteLine(stud);
            }


            DateTime current = DateTime.Now;
            DateTime past = Convert.ToDateTime("1/1/2020");

            var result = current - past;
            Console.WriteLine($"It has been {result.TotalDays} days since the New Year");

            TimeSpan difference = current - stud1.enrollDate;
            Console.WriteLine($"It has been {difference.TotalMilliseconds}ms since {stud1.name} has enrolled.");


            Console.WriteLine($"There are currently {Student.totalStudents} enrolled");

            //Console.WriteLine($"{stud1.name} has an id of {stud1.id}");
            //Console.WriteLine($"{stud2.name} has an id of {stud2.id}");
        }
    }
}
