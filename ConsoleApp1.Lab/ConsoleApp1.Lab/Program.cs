using System;

namespace ConsoleApp1.Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            Group[] groups = new Group[0];
            Console.WriteLine("----Welcome----");
            Console.WriteLine("----1 AddStudent ---- 2 AddGroup----3 SearchStudent---- 4 SearchGroup----");
            bool succes = int.TryParse(Console.ReadLine(), out int menunumber);
            if (succes)
            {
                switch (menunumber)
                {
                    case (int)Menu.AddStudent:
                        if (groups.Length == 0)
                        {
                            Console.WriteLine("There Is No Group... You must creat Group");
                            Group group1 = new Group();
                            Console.WriteLine("Group Name: ");
                            string GroupName = Console.ReadLine();
                            group1.Name = GroupName;
                            Console.WriteLine("You Can Create Student Now...");
                            Student[] students = new Student[0];
                            l2:
                            Student newStudent = new Student();
                            Console.WriteLine("Name Of Student: ");
                            string studentName = Console.ReadLine();
                            newStudent.Name = studentName;
                            Console.WriteLine("Surname: ");
                            newStudent.SurName = Console.ReadLine();
                            l1:
                            Console.WriteLine("Age: ");
                            bool succesAge = int.TryParse(Console.ReadLine(), out int age);
                            if (succesAge && age>0 && age<165)
                            {
                                newStudent.Age = age;
                            }
                            else
                            {
                                Console.WriteLine("Yash Duzgun Deyil....!");
                                goto l1;
                            }
                            Array.Resize(ref students, students.Length + 1);
                            students[students.Length - 1] = newStudent;
                            Console.WriteLine("Yeni Telebe Elave Etmek Isteyirsiniz Qrupa : Yes=>1 ---- No=>2");
                            bool successNewStudent = int.TryParse(Console.ReadLine(), out int newReqemSubMenu);
                            if (successNewStudent && newReqemSubMenu == 1)
                            {
                                goto l2;
                            }

                            group1.Students = students;
                            Array.Resize(ref groups, groups.Length + 1);
                            groups[groups.Length - 1] = group1;
                        }
                        else
                        {
                            foreach (var item in groups)
                            {

                            }
                        }
                        break;
                    case (int)Menu.AddGroup:
                        break;
                    case (int)Menu.SearchStudent:
                        break;
                    case (int)Menu.SearchGroup:
                        break;
                    default:
                        break;
                }
            }
            
        }
    }
}
