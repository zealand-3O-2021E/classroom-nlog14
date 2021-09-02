using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassRoom
{
    class Program
    {
        static void Main(string[] args)
        {
            //Task 3
            ClassRoom classRoom = new ClassRoom()
            {
                className = "3Q",
                semesterStart = new DateTime(2021, 08, 30)
            };
            classRoom.classList.Add(new Student("Nohely", 07, 14));
            classRoom.classList.Add(new Student("Niko", 12, 21));
            classRoom.classList.Add(new Student("Adriana", 09, 08));

            //Task 4
            Console.WriteLine($"{classRoom.className}, {classRoom.semesterStart}");
            foreach (var item in classRoom.classList)
            {
                Console.WriteLine($"{item.name}, {item.birthDay}, {item.birthMonth}");

            }


           

            


        }
    }
}
