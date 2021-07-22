using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Midterm
{
    class Personality
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

        private int _shoeSize;

        public int ShoeSize
        {
            set { _shoeSize = value; }
            get { return _shoeSize; }
        }

        private string _favouriteMovie;

        public string FavouriteMovie
        {
            set { _favouriteMovie = value; }
            get { return _favouriteMovie; }
        }

        private string _favouriteActor;

        public string FavouriteActor
        {
            set { _favouriteActor = value; }
            get { return _favouriteActor; }
        }

        public Personality(int id, int personId,int shoeSize,string favouriteMovie, string favouriteActor)
        {
            Id = id;
            PersonId = personId;
            ShoeSize = shoeSize;
            FavouriteMovie = favouriteMovie;
            FavouriteActor = favouriteActor;

        }

    }
}
