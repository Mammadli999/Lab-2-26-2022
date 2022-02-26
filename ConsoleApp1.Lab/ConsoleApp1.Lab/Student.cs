using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Lab
{
    internal class Student
    {
        public int Id;

        public string Name;

        public string SurName;

        public int Age;

        public static int counter = 0;

        public Student()
        {
            counter++;
            Id = counter;
        }
    }
}
