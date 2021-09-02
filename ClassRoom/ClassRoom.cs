using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassRoom
{
    class ClassRoom
    {
        public string className { get; set; }
        public List<Student> ClassList { get; set; }
        public DateTime semesterStart { get; set; }

        public ClassRoom ()
        { }
    }
}
