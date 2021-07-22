using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Midterm
{
    class Education
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

        private string _courseName;

        public string CourseName
        {
            set { _courseName = value; }
            get { return _courseName; }
        }

        private double _courseGrade;

        public double CourseGrade
        {
            set { _courseGrade = value; }
            get { return _courseGrade; }
        }

        private string _comments;

        public string Comments
        {
            set { _comments = value; }
            get { return _comments; }
        }

        public Education(int id, int personId,string courseName,double courseGrade,string comments)
        {
            Id = id;
            PersonId = personId;
            CourseName = courseName;
            CourseGrade = courseGrade;
            Comments = comments;
        }

    }
}
