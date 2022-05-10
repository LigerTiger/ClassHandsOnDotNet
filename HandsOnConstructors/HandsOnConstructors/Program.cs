using System;

namespace HandsOnConstructors
{
    class Student
    {
        public int studentId;
        public string studentName;
        public string schollName;
        //default constructor
        public Student()
        {
            schollName = "DPS";
        }
        public Student(int sid,string sname,string scname) //Parametarized constructor
        {
            this.studentId = sid;
            this.studentName = sname;
            this.schollName = scname;
        }
        public void Details()
        {
            Console.WriteLine($"ID:${studentId} Name:{studentName} SchoolName:{schollName}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student() { studentId = 323, studentName = "Rohan" };
            Student s2 = new Student() { studentId = 43344, studentName = "Gopi" };
            s1.Details();
            s2.Details();
            Student s3 = new Student(32324, "Swathi", "HPS");
            Student s4 = new Student(32342, "Amith", "GKS");
            s3.Details();
            s4.Details();
        }
    }
}
