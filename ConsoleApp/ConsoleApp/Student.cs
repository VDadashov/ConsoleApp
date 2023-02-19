using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp
{
    internal class Student
    {

        public Student()
        {
            Count++;
            _no = Count;
        }

        int _no;
        string _fullName;
        string _groupNo;
        double _point;
        public DateTime StartDate;

        static int Count;

        #region EncapsulationforStudentFields

        public int No => _no;

        public string FullName
        {
            get => _fullName;

            set
            {
                if (CheckFullName(value))
                {
                    _fullName = value;
                }
            }
        }

        public string GroupNo
        {
            get => _groupNo;

            set
            {
                if (CheckGroupNo(value))
                {
                    _groupNo = value;
                }
            }
        }

        public double Point
        {
            get => _point;
            set
            {
                if (value >= 0 && value <= 100)
                {
                    _point = value;
                } 
            }
        }
        #endregion

        #region CheckMethod

        public static bool CheckFullName(string fullName)
        {
            if (string.IsNullOrWhiteSpace(fullName)) return false;

            var words = fullName.Split(' ');

            if (words.Length != 2) return false;

            if (!char.IsUpper(words[0][0]) || !char.IsUpper(words[1][0]) || words[0].Length < 3 || words[1].Length < 3) return false;

            for (int i = 1; i < words[0].Length; i++)
            {
                if (!char.IsLower(words[0][i]))
                    return false;
            }

            for (int i = 1; i < words[1].Length; i++)
            {
                if (!char.IsLower(words[1][i]))
                    return false;
            }

            return true;
        }

        public static bool CheckGroupNo(string groupNo)
        {
            if (string.IsNullOrEmpty(groupNo))
                return false;

            if (!char.IsLetter(groupNo[0]) || !char.IsUpper(groupNo[0]))
                return false;

            if (groupNo.Length != 4)
                return false;

            for (int i = 1; i < groupNo.Length; i++)
            {
                if (!char.IsDigit(groupNo[i]))
                {
                    return false;
                }
            }



            return true;
        }

        #endregion

    }
}
