﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Console_Project.Model
{
    class Student
    {
        public string Fullname;
        public string  GroupNo;
        public bool Type;
        public Student(string fullname, string groupno) 
        {
            Fullname=fullname;
            GroupNo=groupno;
            Type = false;
        }
    }
}
