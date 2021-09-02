using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassRoom
{
    class Student
    {
        public string name { get; set; }
        public int birthMonth { get; set; }
        public int birthDay { get; set; }

        public Student (string Name, int BirthMonth, int BirthDay)
        {
            name = Name;
            birthMonth = BirthMonth;
            birthDay = BirthDay;
        }


    }
}
