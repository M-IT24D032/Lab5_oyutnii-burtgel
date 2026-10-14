using System;
using System.Collections.Generic;
using System.Drawing;

namespace Lab05_Burtgel
{
    public class Student
    {
        public string StudentCode { get; set; }
        public string Phone { get; set; }
        public int Age { get; set; }
        public DateTime BirthDate { get; set; }
        public bool IsDayStudy { get; set; }
        public string Department { get; set; }
        public bool HasScholarship { get; set; }
        public List<string> Courses { get; set; } = new List<string>();
        public string Language { get; set; }
        public Image Photo { get; set; }
    }
}