using System;
using System.Linq;

namespace ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args) 
        { 
            Course CodeAcademy = new Course();


            string opt;

            do
            {
                Console.WriteLine("\n1. Qrupdaki telebelerin siyahisini goster");
                Console.WriteLine("2. Butun telebelerin siyahi'ni goster");
                Console.WriteLine("3. Telebe elave et");
                Console.WriteLine("4. Tarix araligina gore telebelere bax");
                Console.WriteLine("5. Umumi axtarish");
                Console.WriteLine("6. Telebenin qrupunu deyish");
                Console.WriteLine("7. Secilmish telebeni sil");
                Console.WriteLine("8. Secilmis qrupun ortalama balina bax");
                Console.WriteLine("--- Prosesi bitirmek ucun 0'a basin ---\n");

                Console.WriteLine("Secim: ");
                opt = Console.ReadLine();

                switch (opt)
                {
                    case "1":

                        string groupNo;
                        do
                        {
                            Console.Write("GroupNo: ");
                            groupNo = Console.ReadLine();
                        }
                        while (!Student.CheckGroupNo(groupNo));

                        var arr = CodeAcademy.GetStudentsByGroupNo(groupNo);

                        if (arr.Length != 0)
                        {
                            foreach (var item in arr)
                            {
                                Console.WriteLine($"FullName: {item.FullName} - GroupNo: {item.GroupNo} - Point: {item.Point} - StartDate: {item.StartDate}");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Bele Group yoxdur");
                        }

                        break;
                    case "2":
                        arr = CodeAcademy.GetAllStudents();

                        foreach (var item in arr)
                        {
                            Console.WriteLine($"FullName: {item.FullName} - GroupNo: {item.GroupNo} - Point: {item.Point} - StartDate: {item.StartDate}");
                        }
                        break;
                    case "3":

                        string fullName;
                        do
                        {
                            Console.Write("FullName: ");
                            fullName= Console.ReadLine();
                        } while (!Student.CheckFullName(fullName));

                        do
                        {
                            Console.Write("GroupNo: ");
                            groupNo= Console.ReadLine();

                        } while (!Student.CheckGroupNo(groupNo));

                        int point;
                        string pointStr;
                        do
                        {
                            Console.Write("Point: ");
                            pointStr= Console.ReadLine();
                        } while (!int.TryParse(pointStr,out point));

                        DateTime date;
                        string dateStr;
                        do
                        {
                            Console.Write("Date(Ay/Gun/il): ");
                            dateStr = Console.ReadLine();

                        } while (!DateTime.TryParse(dateStr,out date));

                        Student student = new Student { FullName = fullName, GroupNo = groupNo , Point = point , StartDate = date};

                        CodeAcademy.AddStudent(student);

                        break;
                    case "4":

                        DateTime startDate;
                        string startDateStr;
                        do
                        {
                            Console.Write("StartDate(Ay/Gun/il): ");
                            startDateStr = Console.ReadLine();
                        } while (!DateTime.TryParse(startDateStr,out startDate));

                        DateTime endDate;
                        string endDateStr;
                        do
                        {
                            Console.Write("EndDate(Ay/Gun/il): ");
                            endDateStr = Console.ReadLine();
                        } while (!DateTime.TryParse(endDateStr, out endDate));

                        arr = CodeAcademy.GetStudentsByDateRange(startDate, endDate);

                        Console.WriteLine("");

                        if (arr.Length != 0)
                        {
                            foreach (var item in arr)
                            {
                                Console.WriteLine($"FullName: {item.FullName} - GroupNo: {item.GroupNo} - Point: {item.Point} - StartDate: {item.StartDate}");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Bu date intervalinda telebe yoxdur.");
                        }
                        break;

                    case "5":
                        Console.Write("Axtaris deyeri: ");
                        string value = Console.ReadLine();

                        arr = CodeAcademy.Search(value);

                        if (arr.Length != 0)
                        {
                            foreach (var item in arr)
                            {
                                Console.WriteLine($"FullName: {item.FullName} - GroupNo: {item.GroupNo} - Point: {item.Point} - StartDate: {item.StartDate}");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Nothing found");
                        }
                        break;
                    case "6":

                        int no;
                        string noStr;
                        do
                        {
                            Console.Write("No: ");
                            noStr= Console.ReadLine();

                        } while (!int.TryParse(noStr,out no));

                        do
                        {
                            Console.Write("GroupNo: ");
                            groupNo= Console.ReadLine();
                        } while (!Student.CheckGroupNo(groupNo));

                        CodeAcademy.ChangeStudentGroup(no, groupNo);

                        break;
                    case "7":
                        do
                        {
                            Console.Write("No: ");
                            noStr = Console.ReadLine();
                        } while (!int.TryParse(noStr, out no));

                        CodeAcademy.RemoveStudent(no);

                        break;

                    case "8":
                        do
                        {
                            Console.Write("GroupNo: ");
                            groupNo = Console.ReadLine();
                        }
                        while (!Student.CheckGroupNo(groupNo));

                        double result = CodeAcademy.GetAvgPoint(groupNo);

                        if (result != -1)
                        {
                            Console.WriteLine($"AvgPoint: {result}");
                        }
                        else
                        {
                            Console.WriteLine("Bele Group yoxdur");
                        }
                        
                        break;
                    case "0":
                        break;

                    default:
                        break;
                }
            } while (opt != "0");

        }
    }
}
