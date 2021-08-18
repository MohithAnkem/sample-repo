using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnClasses
{
    class Student
    {
        public int studentid;
        public string studentname;
        public int studentage;
        public static string schoolname;
        public static string classname;
    }
    class StudentDetails
    {
        static void Main(string[] args)
        {
            Student.schoolname = "DPS";
            Student.classname = "II";
            Student s1 = new Student();
            s1.studentid = 2345;
            s1.studentage = 10;
            s1.studentname = "Rohan";
            Console.WriteLine("{0} {1} {2} {3} {4}", s1.studentid, s1.studentname, s1.studentage, Student.schoolname, Student.classname);

            Student s2 = new Student();
            s2.studentid = 7898;
            s2.studentname = "Cherry";
            s2.studentage = 20;
            Console.WriteLine("{0} {1} {2} {3} {4}", s2.studentid, s2.studentname, s2.studentage, Student.schoolname, Student.classname);

            Student.schoolname = "HPS";
            Student.classname = "III";
            Student s3 = new Student();
            s3.studentid = 7348;
            s3.studentname = "mohith";
            s3.studentage = 11;
            Console.WriteLine("{0} {1} {2} {3} {4}", s3.studentid, s3.studentname, s3.studentage, Student.schoolname, Student.classname);

        }
    }

}
