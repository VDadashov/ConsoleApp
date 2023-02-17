using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace ConsoleApp
{
    internal interface ICourseManagerService
    {
        public Student[] Students { get; set; }
        public void AddStudent(Student student);
        public void ChangeStudentGroup(int no, string groupNo);
        public Student[] GetStudentsByGroupNo(string groupNo);
        public Student[] GetAllStudents();
        public Student FindStudentByNo(int no);
        public Student[] Search(string value);
        public Student[] GetStudentsByDateRange(DateTime startDate, DateTime endDate);
        public void RemoveStudent(int no);
        public double GetAvgPoint(string groupNo);



    }
}
