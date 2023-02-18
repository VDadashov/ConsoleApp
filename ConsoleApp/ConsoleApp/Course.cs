using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace ConsoleApp
{
    internal class Course : ICourseManagerService
    {

        Student[] _students = new Student[0];
        public int StudentsGroupLimit = 18;

        public Student[] Students
        {
            get=> _students; 
            set => _students = value;

        }

        public int StudentsGroupCount
        {
            get
            {
                int count = 0;

                foreach (Student student in _students)
                {
                    
                }
                return count;
            }
        }



        public void AddStudent(Student std)
        {
            if (StudentsGroupCount == StudentsGroupLimit)
                return;

            Array.Resize(ref _students, _students.Length+1);
            _students[_students.Length-1] = std;
            
        }

        public void ChangeStudentGroup(int no, string groupNo)
        {
            bool isExist = false;
            foreach (var item in Students)
            {
                if (item.No == no)
                {
                    item.GroupNo = groupNo;
                    isExist = true;
                    break;
                }
            }
            if (isExist == false)
            {
                Console.WriteLine("Bele telebe yoxdur...");
            }
            
        }

        public Student FindStudentByNo(int no)
        {
            foreach (var item in Students)
            {
                if (item.No == no)
                {
                    return item;
                }
            }
            return null;
        }

        public Student[] GetAllStudents()
        {
            Student[] wantedArr = new Student[0];
            foreach (var item in Students)
            {
                Array.Resize(ref wantedArr,wantedArr.Length+1);
                wantedArr[wantedArr.Length - 1] = item;
            }
            return wantedArr;
        }

        public double GetAvgPoint(string groupNo)
        {
            double sum = 0;
            int count = 0;
            foreach (var item in Students)
            {
                if (item.GroupNo == groupNo)
                {
                    sum += item.Point;
                    count++;
                }
            }
            return sum / count;
        }

        public Student[] GetStudentsByDateRange(DateTime startDate, DateTime endDate)
        {
            Student[] wantedArr = new Student[0];

            foreach (var item in Students)
            {
                if (item.StartDate >= startDate && item.StartDate <= endDate)
                {
                    Array.Resize(ref wantedArr,wantedArr.Length+1);
                    wantedArr[wantedArr.Length - 1] = item;
                }
            }
            return wantedArr;
        }

        public Student[] GetStudentsByGroupNo(string groupNo)
        {
            var wantedArr = new Student[0];
            foreach (var item in Students)
            {
                if (item.GroupNo == groupNo)
                {
                    Array.Resize(ref wantedArr,wantedArr.Length+1);
                    wantedArr[wantedArr.Length - 1] = item;
                }
            }
            return wantedArr;
        }

        public void RemoveStudent(int no) // {12,15,18,21,24}
        {
            int index = -1;

            Student[] wantedArr = new Student[0];

            for (int i = 0; i < Students.Length; i++)
            {
                if (Students[i].No == no)
                {
                    index = i;
                    
                }
            }

            if (index != -1)
            {

                for (int i = 0; i < Students.Length; i++)
                {
                    if (i == index)
                    {
                        continue;
                    }

                    Array.Resize(ref wantedArr,wantedArr.Length+1);
                    wantedArr[wantedArr.Length-1] = Students[i];
                }

                Students = wantedArr;
            }
            else
            {
                Console.WriteLine("Bele telebe yoxdur...");
            }

        }

        public Student[] Search(string value)
        {
            Student[] wantedArr = new Student[0];

            foreach (var item in Students)
            {
                if (item.FullName.Contains(value) || item.GroupNo.Contains(value))
                {
                    Array.Resize(ref wantedArr,wantedArr.Length+1);
                    wantedArr[wantedArr.Length - 1] = item;
                }
            }
            
            return wantedArr;
        }
    }
}
