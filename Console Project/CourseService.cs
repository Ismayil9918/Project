using Console_Project.Enum;
using Console_Project.InterFace;
using Console_Project.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Console_Project
{
    class CourseService: ICourseService
    {
        private List<Group> _groups = new List<Group>();
        public List<Group> Groups 
        { 
            get
            {
                return _groups;
            } 
        }

        public void AllStudentList(string fullname, string no, bool isonline)
        {
            throw new NotImplementedException();
        }

        public void CreatStudent(string fullname, string groupno, bool type)
        {
            throw new NotImplementedException();
        }

        public void EditGroup(string no, string newno)
        {
            throw new NotImplementedException();
        }

        public void GroupList(string no, Categories Category, int limit)
        {
            throw new NotImplementedException();
        }

        public void GroupListStudents(string no)
        {
            throw new NotImplementedException();
        }

        public void NewGroup( Categories Category)
        {
            bool isonline = Convert();
            Categories category = ConvertCategory();
            Group group = new Group(category,isonline);
            Groups.Add(group);
        }
        public bool Convert()
        {
            Console.WriteLine("Group is online ?");
            Console.WriteLine("1.Yes");
            Console.WriteLine("2.No");
            string answer=Console.ReadLine();
            bool isonline = false;
            if (answer=="1")
            {
                isonline = true;
            }
            else if (answer == "2")
            {
                isonline=false;
            }
            return isonline;
        }
        public Categories ConvertCategory()
        {
            Console.WriteLine("Group is online ?");
            Console.WriteLine("1.Programming");
            Console.WriteLine("2 Design");
            Console.WriteLine("3 SystemAdministration");
            string answer = Console.ReadLine();
            Categories category = Categories.Programming;
            if (answer == "1")
            {
                category = Categories.Programming;
            }
            else if (answer == "2")
            {
                category = Categories.Desing;
            }
            else if (answer == "3")
            {
                category = Categories.SystemAdministration;
            }
            return category;
            
        }
    }
}
