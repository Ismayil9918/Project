using Console_Project.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace Console_Project.Model
{
    class Group
    {
        public static int count = 1;
        public string No;
        public bool IsOnline;
        public int Limit;       
        public Categories Category;
        public Student[] Students;
        public Group(Categories category, bool isonline) 
        {

            switch (category)
            {
                case Categories.Programming:
                    No = $"P-{count}";
                    break;
                case Categories.Desing:
                    No = $"D-{count}";
                    break;
                case Categories.SystemAdministration:
                    No = $"SA-{count}";
                    break;
                default:
                    break;
            }
            Category = category;
            IsOnline=isonline;
            if (IsOnline)
            {
                Limit = 10;
            }
            else
            {
                Limit = 15;
            }            
        }
    }
}
