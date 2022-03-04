using System;
using System.Collections.Generic;
using System.Text;

namespace Console_Project
{
    interface ICourseService
    {
        public List<Group> Groups { get; }
        public void NewGroup();
        public void GroupList();
        public void EditGroup();
        public void GroupListStudents();
        public void AllStudentList();
        public void CreatedStudent();
    }
}
