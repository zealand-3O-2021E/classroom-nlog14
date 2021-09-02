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

        

        //Task 6
        public void birthdaysBySeasons()
        {
            var birthdaysGrouped = classList.GroupBy(s => Student.Season(s.birthMonth)).Select(group => new
            { season = group.Key, 
              numberOfBirthdays = group.Count()});

            foreach(var item in birthdaysGrouped)
            {
                Console.WriteLine($"Season: {item.season}, birthdays in this season {item.numberOfBirthdays}");
            }

        }
    }
}
