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
            Dictionary<string, int> birthSeasonCount = new Dictionary<string, int>();

            birthSeasonCount.Add("Winter", Students.Where(s => s.BirthSeason() == "Winter").ToList().Count());
            birthSeasonCount.Add("Spring", Students.Where(s => s.BirthSeason() == "Spring").ToList().Count());
            birthSeasonCount.Add("Summer", Students.Where(s => s.BirthSeason() == "Summer").ToList().Count());
            birthSeasonCount.Add("Autumn", Students.Where(s => s.BirthSeason() == "Autumn").ToList().Count());

            foreach (KeyValuePair<string, int> pair in birthSeasonCount)
            {
                Console.WriteLine($"> Students born in {pair.Key}: {pair.Value}");
            }


        }

    }
}
