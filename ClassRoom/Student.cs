using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassRoom
{
    public class Student
    {
        public Student(string name, int birthMonth, int birthDay)
        {
            Name = name;
            BirthMonth = birthMonth;
            BirthDay = birthDay;
        }

        public string Name { get; private set; }
        public int BirthMonth { get; private set; }
        public int BirthDay { get; private set; }

        public string BirthSeason()
        {

            if (BirthMonth == 12 || BirthMonth == 1 || BirthMonth == 2)
                return "Winter";
            if (BirthMonth == 3 || BirthMonth == 4 || BirthMonth == 5)
                return "Spring";
            if (BirthMonth == 6 || BirthMonth == 7 || BirthMonth == 8)
                return "Summer";
            if (BirthMonth == 9 || BirthMonth == 10 || BirthMonth == 11)
                return "Autumn";
            return "";
        }

    }
}
