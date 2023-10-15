using System;
using System.Collections.Generic;
using System.Text;

namespace App6
{
    public class Student
    {
        public string Name { get; set; }
        public string LastName {  get; set; }
        public int Age { get; set; }
        public string Section { get; set; }
    }

    public class StudentGroup : List<Student>
    {
        public string SectionName { get; set; }

        public StudentGroup(string sectionName, List<Student> students)
        {
            SectionName = sectionName;
            AddRange(students);
        }
    }
}
