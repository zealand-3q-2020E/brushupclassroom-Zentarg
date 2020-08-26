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

    
}
