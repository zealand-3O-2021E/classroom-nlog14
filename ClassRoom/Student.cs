using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassRoom
{
    class Student
    {
        private int _birthMonth;

        //Task 1
        public string name { get; private set; }
        public int birthMonth
        {
            get { return _birthMonth; }
           private set
            { //Task 7
                if (value >= 1 && value <= 12)
                {
                    _birthMonth = value;
                }
                else
                    throw new ArgumentException("Birth Month should be between 1 and 12.");
            }
        }
        
        
        public int birthDay { get; private set; }

        public Student (string Name, int BirthMonth, int BirthDay)
        {
            name = Name;
            birthMonth = BirthMonth;
            birthDay = BirthDay;
        }

        //Task 5
        public static string Season(int month)
        {
            if (month > 2 && month < 6) return "Spring";
            if (month > 5 && month < 9) return "Summer";
            if (month > 8 && month < 12) return "Autumn";
            return "Winter";

        }


    }
}
