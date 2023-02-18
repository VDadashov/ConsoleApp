using System;
using System.Linq;

namespace ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student std1 = new Student { FullName = "Vusal Dadashov",StartDate= DateTime.Now,GroupNo = "P123",Point = 75.6 };
            Student std2 = new Student { FullName = "std2", StartDate = DateTime.Now, GroupNo = "P123", Point = 75.6 };
            Student std3 = new Student { FullName = "std3", StartDate = DateTime.Now, GroupNo = "P122", Point = 75.6 };
            Student std4 = new Student { FullName = "Vusal Dadashov", StartDate = DateTime.Now, GroupNo = "P123", Point = 75.6 };


            Course CodeAcademy = new Course();

            CodeAcademy.AddStudent(std1);
            CodeAcademy.AddStudent(std2);
            CodeAcademy.AddStudent(std3);
            CodeAcademy.AddStudent(std4);

            CodeAcademy.RemoveStudent(2);

            var arr = CodeAcademy.Students;

            foreach (var item in arr)
            {
                Console.WriteLine($"{item.FullName} - {item.GroupNo} - {item.Point} - {item.StartDate}");
            }

            //Console.WriteLine(std1.FullName);

            //var item = CodeAcademy.FindStudentByNo(1);

            //Console.WriteLine($"{item.FullName} - {item.GroupNo} - {item.Point} - {item.StartDate}");


            //var item1 = CodeAcademy.GetAllStudents();

            //foreach (var student in item1)
            //{
            //    Console.WriteLine($"{student.FullName} - {student.GroupNo} - {student.Point} - {student.StartDate}");
            //}

            //Console.WriteLine("===========================");

            //Console.WriteLine(CodeAcademy.GetAvgPoint("P123") );

            //var arr = CodeAcademy.GetStudentsByGroupNo("P123");

            //foreach (var item in arr)
            //{
            //    Console.WriteLine($"{item.FullName} - {item.GroupNo} - {item.Point} - {item.StartDate}");
            //}

            
        }
    }
}
