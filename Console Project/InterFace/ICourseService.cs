using Console_Project.Enum;
using Console_Project.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Console_Project.InterFace
{
    interface ICourseService
    {
        

        public void NewGroup( Categories Category);
        public void GroupList();
        public void EditGroup(string no,string newno);
        public void GroupListStudents(string no);
        public void AllStudentList(string fullname, string no,bool isonline);
        public void CreateStudent(string fullname,string groupno,bool type);
    }
}
