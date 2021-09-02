using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassRoom
{
    class ClassRoom
    {
        //Task 2
        public string className { get; set; }
        public List<Student> classList { get; set; }
        public DateTime semesterStart { get; set; }

        public ClassRoom ()
        {
            classList = new List<Student>(); 
        }
    }
}
