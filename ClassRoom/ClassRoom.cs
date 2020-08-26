using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassRoom
{
    public class ClassRoom
    {
        public ClassRoom()
        {
            Name = "";
            Students = new List<Student>();
            SemesterStart = new DateTime();
        }

        public string Name { get; set; }
        public List<Student> Students { get; set; }
        public DateTime SemesterStart { get; set; }

        public void CountStudentBirthSeasons()
        {
            int winter, spring, summer, autumn = 0;

            winter = Students.Where(s => s.BirthSeason() == "Winter").ToList().Count();
            spring = Students.Where(s => s.BirthSeason() == "Spring").ToList().Count();
            summer = Students.Where(s => s.BirthSeason() == "Summer").ToList().Count();
            autumn = Students.Where(s => s.BirthSeason() == "Autumn").ToList().Count();

            Console.WriteLine($"Classroom {Name} has {winter} students born during winter, {spring} students born during spring, {summer} students born during summer, {autumn} students born during autumn.");

        }

    }
}
