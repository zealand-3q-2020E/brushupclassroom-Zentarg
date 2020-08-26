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
            ClassRoom classRoom = new ClassRoom();
            classRoom.Name = "3Q";
            classRoom.SemesterStart = new DateTime(2019, 8, 26);
            classRoom.Students.AddRange(new List<Student>(){new Student("Andreas", 2, 7), new Student("Dom", 11, 9), new Student("Justin", 12, 31)});

            Console.WriteLine($"Information regarding classroom {classRoom.Name}:");
            Console.WriteLine($"> Semester Start Date: {classRoom.SemesterStart.Date}");
            Console.WriteLine("> Students attending:");
            foreach (Student student in classRoom.Students)
            {
                Console.WriteLine($"  > Name: {student.Name} | Birthday: {student.BirthDay}/{student.BirthMonth}");
            }

            classRoom.CountStudentBirthSeasons();

            Console.ReadKey();
        }
    }
}
