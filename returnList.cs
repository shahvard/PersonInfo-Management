using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Midterm
{
    static class returnList
    {
        static List<Person> personList;
        static List<SportsTeam> sportsList;
        static List<Personality> personalityList;
        static List<Education> educationList;

        public static List<Person> PersonList
        {
            set { personList = value; }
            get { return personList; }
        }

        public static List<SportsTeam> SportsList
        {
            set { sportsList = value; }
            get { return sportsList; }
        }

        public static List<Personality> PersonalityList
        {
            set { personalityList = value; }
            get { return personalityList; }
        }

        public static List<Education> EducationList
        {
            set { educationList = value; }
            get { return educationList; }
        }




    }



}
