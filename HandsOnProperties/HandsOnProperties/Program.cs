using System;

namespace HandsOnProperties
{
    class Student
    {
        private int studentId;
        private string studentName;
        //Property for StudentId
        public int StudentId
        {
            get { return studentId; } //return studentId values
            set { studentId = value; } //set value to studentId
        }
        //Property for StudentName
        public string StudentName
        {
            get { return studentName; }
            set { studentName = value; }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student();
            s1.StudentId = 308932;
            s1.StudentName = "Prateik";
            Console.WriteLine($"ID:{s1.StudentId} Name:{s1.StudentName}");
            
        }
    }
}
