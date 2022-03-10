using System;

namespace Console_Project
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Course_service course = new Course_service();
            Console.WriteLine("Course Application\n");
            int selection;
            do
            {
                Console.WriteLine("1.NewGroup");
                Console.WriteLine("2.GroupList");
                Console.WriteLine("3.EditGroup");
                Console.WriteLine("4.GroupListStudents");
                Console.WriteLine("5.AllStudentList");
                Console.WriteLine("6.CreateStudent");
                Console.WriteLine("0.Exit");
                string strSelection = Console.ReadLine();
                bool result = int.TryParse(strSelection, out selection);

                if (result)
                {
                    switch (selection)
                    {
                        case 1:
                            Console.WriteLine("Choose Category:");
                            Console.WriteLine("1.Programming" +
                                "2.Design" +
                                "3.SystemAdministration");

                            string str = Console.ReadLine();
                            Categories Category = .Programing;
                            if (str == "1")
                            {
                                categories = Categories.Programing;
                            }
                            else if (str == "2")
                            {
                                categories = Categories.; Design
                            }
                            else if (str == "3")
                            {
                                categories = Categories.SystemAdminstration;
                            }
                            course.NewGroup(categories);
                            break;
                        case 2:
                            course.GroupList();
                            break;
                        case 3:
                            Console.WriteLine("Please enter group no");
                            Console.WriteLine("Please enter new group no");
                            course.EditGroup();
                            break;
                        case 4:
                            course.GroupListStudents();
                            break;
                        case 5:
                            course.AllStudentList();
                            break;
                        case 6:
                            course.CreateStudent();
                            break;

                    }
                }

            } while (selection != 0);
        }
    }
}
