using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Midterm
{
    class SportsTeam
    {
        private int _id;

        public int Id
        {
            set { _id = value; }
            get { return _id; }
        }

        private int _personId;

        public int PersonId
        {
            set { _personId = value; }
            get { return _personId; }
        }

        private string _sportsTeam;

        public string Sportsteam
        {
            set { _sportsTeam = value; }
            get { return _sportsTeam; }
        }

        private string _city;

        public string City
        {
            set { _city = value; }
            get { return _city; }
        }

        public SportsTeam(int id, int personId,string sportsTeam, string city)
        {
            Id = id;
            PersonId = personId;
            Sportsteam = sportsTeam;
            City = city;
        }





    }
}
