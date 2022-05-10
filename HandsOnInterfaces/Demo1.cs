using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnInterfaces
{
    //Entity class
   class Student
    {
        public int Sid { get; set; }
        public string Sname { get; set; }
    }
    interface IStudentRepository
    {
        void AddStudent(Student student);
        Student GetStudent(int id);
        Student[] GetStudents();
        int Count { get; set; }
    }
    class StudentRepository : IStudentRepository
    {
        public Student[] students = new Student[4]; //in memory array
        int count = 0;
        public void AddStudent(Student student)
        {
            if (count < students.Length)
            {
                students[count] = student;
                count++;
            }
        }

        public Student GetStudent(int id)
        {
            foreach (Student student in students)
            {
                if(student.Sid==id)
                {
                    return student;
                }
            }
            return null;
        }

        public Student[] GetStudents()
        {
            return students;
        }
        public int Count
        {
            get { return count; }
            set { count = value; }
        }
    }
    class Demo1
    {
        //write menu driven code to test all the student repository functions
    }
}
