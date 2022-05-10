using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnClassAndObjects
{
    class Student
    {
        //variable
        public int studentId;
        public string studentName;
        public int studentAge;
        //method
        public void Details()
        {
            Console.WriteLine($"ID:{studentId} Name:{studentName} Age:{studentAge}");
        }

    }
}
